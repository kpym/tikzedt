using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt.Parser;
using System.Diagnostics.Contracts;

namespace TikzEdt.Overlay
{
    /// <summary>
    /// The TikzDisplayTree class creates and maintains the display tree from the ParseTree.
    /// The display tree is a collection of OverlayShapeVM objects that serve as viewmodels for items
    /// shown in the overlay control.
    /// 
    /// Duties:
    ///     1) (Re-)create the display tree when the parsetree is replaced.
    ///     2) Listen for changes on the parsetree and update the display tree accordingly.
    ///     3) Raise an event (DisplayTreeChanged) if the displaytree changes.
    ///        The overlay control will subscribe to this event and change the attached views accordingly. 
    ///     4) Provide some convenience methods for accessing the display tree.
    /// </summary>
    class TikzDisplayTree
    {

        #region events

        public enum DisplayTreeChangedType { Clear, Insert }
        public class DisplayTreeChangedEventArgs : EventArgs
        {
            public DisplayTreeChangedType Type;
            /// <summary>
            /// This is null if Type is Clear.
            /// </summary>
            public IEnumerable<OverlayShapeVM> AffectedItems; 
        }

        public event EventHandler<DisplayTreeChangedEventArgs> DisplayTreeChanged;

        /// <summary>
        /// This is raised if for some reason the display tree could not be created.
        /// 
        /// </summary>
        public event EventHandler<DisplayErrorEventArgs> DisplayError;
        public class DisplayErrorEventArgs : EventArgs
        {
            public string Message;
        }

        #endregion

        #region properties

        Tikz_ParseTree _ParseTree = null;
        public Tikz_ParseTree ParseTree
        {
            get { return _ParseTree; }
            set
            {
                if (_ParseTree != value)
                {
                    if (_ParseTree != null)
                    {
                        _ParseTree.TextChanged -= new EventHandler<ParseTreeTextChangedEventArgs>(_ParseTree_TextChanged);
                        _ParseTree.ParseTreeModified -= new EventHandler<ParseTreeModifiedEventArgs>(_ParseTree_ParseTreeModified);
                    }
                    _ParseTree = value;
                    if (_ParseTree != null)
                    {
                        _ParseTree.TextChanged += new EventHandler<ParseTreeTextChangedEventArgs>(_ParseTree_TextChanged);
                        _ParseTree.ParseTreeModified += new EventHandler<ParseTreeModifiedEventArgs>(_ParseTree_ParseTreeModified);
                    }
                    RecreateDisplayTree();
                }
            }
        }

        double _Resolution = Consts.ptspertikzunit;
        public double Resolution {
            get { return _Resolution; }
            set
            {
                _Resolution = value;
                AdjustPositions();
            }
        }

        void _ParseTree_ParseTreeModified(object sender, ParseTreeModifiedEventArgs e)
        {
            if (e.Type == ParseTreeModifiedType.Insert)
            {
                // see if the added item is displayed at all
                var toadd = CreateOverlayShapesFromItem(e.AffectedItem);

                if (toadd.Count() == 0)
                    return;

                // so we have something to add... find the correct element of the display tree to insert into
                var parent = e.AffectedItem.Ancestors.FirstOrDefault(tcpi => AllItems.OfType<OverlayScope>().Count(os => os.item == tcpi) > 0);
                if (parent == null)
                    TopLevelItems.AddRange(toadd);
                else
                {
                    var scope = AllItems.OfType<OverlayScope>().First(os => os.item == parent);
                    scope.children.AddRange(toadd);
                }

                if (DisplayTreeChanged != null)
                    DisplayTreeChanged(this, new DisplayTreeChangedEventArgs() { Type = DisplayTreeChangedType.Insert, AffectedItems = toadd });
            }
            else if (e.Type == ParseTreeModifiedType.Remove)
            {
                throw new NotSupportedException(); // maybe support that in the future
            }
        }

        /// <summary>
        /// The link to the overlay (display) tree.
        /// </summary>
        public List<OverlayShapeVM> TopLevelItems { get; set; }

        public IEnumerable<OverlayShapeVM> AllItems { get { return GetAllDescendants(); } }

        #endregion

        #region public methods

        /// <summary>
        /// Gets a list of all descendants of the specified parent in the Display tree, including the parent itself.
        /// </summary>
        /// <param name="OfParent">The parent. If null, it is taken to be the root.</param>
        /// <returns></returns>
        public IEnumerable<OverlayShapeVM> GetAllDescendants(OverlayShapeVM OfParent = null)
        {
            IEnumerable<OverlayShapeVM> src = null;
            List<OverlayShapeVM> ret = new List<OverlayShapeVM>();
            if (OfParent != null)
                ret.Add(OfParent);
            else src = TopLevelItems;

            if (OfParent is OverlayScope)
                src = (OfParent as OverlayScope).children;

            if (src != null)
                ret.AddRange(src.SelectMany(os => GetAllDescendants(os)));

            return ret;
        }

        /// <summary>
        /// Creates a display tree from a given parseitem.
        /// The display tree will contain all displayed subitems and the provided item itself (if displayed).
        /// </summary>
        /// <param name="tpi">The parse tree item.</param>
        /// <returns>The top level displayed items. If tpi is displayed, the list has only one element.</returns>
        [Pure]
        IEnumerable<OverlayShapeVM> CreateOverlayShapesFromItem(TikzParseItem tpi)
        {
            var ret = new List<OverlayShapeVM>();
            if (tpi is Tikz_Scope)
            {
                OverlayScope os = new OverlayScope();
                //os.pol = this;
                os.tikzitem = tpi as Tikz_Scope;

                // add child shapes
                os.children.AddRange( (tpi as TikzContainerParseItem).Children.SelectMany( child => CreateOverlayShapesFromItem(child) ) );

                //foreach (TikzParseItem t in (tpi as TikzContainerParseItem).Children)
                //    DrawObject(t, os.children);

                // don't draw scopes with no drawable children
                // (we don't know where to render them)
                if (os.children.Count > 0)
                {
                    ret.Add(os);
                    os.AdjustPosition(Resolution);
                    
                }
            }
            else if (tpi is TikzContainerParseItem)
            {
                ret.AddRange( (tpi as TikzContainerParseItem).Children.SelectMany( child => CreateOverlayShapesFromItem(child) ) );
            }
            else if (tpi is Tikz_XYItem)
            {
                if ((tpi as Tikz_XYItem).HasEditableCoordinate())
                {
                    OverlayNode el;
                    if (tpi.parent is Tikz_Controls)
                        el = new OverlayControlPoint();     // control points for Bezier curves
                    else
                        el = new OverlayNode();
                    //el.pol = this;
                    el.tikzitem = tpi as Tikz_XYItem;

                    el.AdjustPosition(Resolution);

                    // add tooltip
                    Tikz_Node nref = TikzParseTreeHelper.GetReferenceableNode(tpi as Tikz_XYItem, ParseTree.GetTikzPicture());
                    if (nref != null && !String.IsNullOrWhiteSpace(nref.name))
                    {
                        el.ToolTip = nref.name;
                    }

                    ////canvas1.Children.Add(el);
                    ret.Add(el);

                    //bbg.Add(new Rect(Canvas.GetLeft(el), Canvas.GetTop(el), el.Width, el.Height));
                }
            }
            else if (tpi is Tikz_Path)
            {
            }

            return ret;
        }

        /// <summary>
        /// This recomputes the positions of all OverlayItems.
        /// (It does not recreate the displaytree, just adjusts positions.)
        /// </summary>
        public void AdjustPositions()
        {
            if (TopLevelItems != null)
                foreach (OverlayShapeVM o in TopLevelItems)
                    o.AdjustPosition(Resolution);
        }

        /// <summary>
        /// Clears all items from the display tree.
        /// </summary>
        public void Clear()
        {
            TopLevelItems.Clear();
            if (DisplayTreeChanged != null)
                DisplayTreeChanged(this, new DisplayTreeChangedEventArgs() { AffectedItems = null, Type = DisplayTreeChangedType.Clear });
        }

 /*       /// <summary>
        /// Recreates the display tree
        /// </summary>
        public void RedrawObjects()
        {
            Clear();

            try
            {
                DrawObject(ParseTree, TopLevelItems);
                BindControlPointsToOrigins();
            }
            catch (Exception e)
            {
                // we should really not come here.... but there are conceivable tex files with cyclic references that might 
                // produce errors.
                Clear();
        //        View.AllowEditing = false; // todo
                GlobalUI.UI.AddStatusLine(this, "Error in Overlay rendering: '" + e.Message + "' Overlay disabled for now.", true);

                if (DisplayError != null)
                    DisplayError(this, new DisplayErrorEventArgs() { Message = "Error in Overlay rendering: '" + e.Message });
            }
        } */



 /*       /// <summary>
        /// Adds the TikzParseItem tpi, if it is displayed, or its children, if they can are displayed, 
        /// or grandchildren etc..., and adds the drawn items to bag.
        /// </summary>
        /// <param name="tpi"></param>
        /// <param name="bag"></param>
        void DrawObject(TikzParseItem tpi, List<OverlayShapeVM> bag)
        {
            //BBGatherer bbg = new BBGatherer();
            if (bag == null)
                bag = new List<OverlayShapeVM>();  // dummy, it is not used
            if (tpi is Tikz_Scope)
            {
                OverlayScope os = new OverlayScope();
                //os.pol = this;
                os.tikzitem = tpi as Tikz_Scope;
                foreach (TikzParseItem t in (tpi as TikzContainerParseItem).Children)
                    DrawObject(t, os.children);

                // don't draw scopes with no drawable children
                // (we don't know where to render them)
                if (os.children.Count > 0)
                {
                    bag.Add(os);
                    os.AdjustPosition(Resolution);
                    
                }
            }
            else if (tpi is TikzContainerParseItem)
            {
                foreach (TikzParseItem t in (tpi as TikzContainerParseItem).Children)
                    DrawObject(t, bag);
            }
            if (tpi is Tikz_XYItem)
            {
                if ((tpi as Tikz_XYItem).HasEditableCoordinate())
                {
                    OverlayNode el;
                    if (tpi.parent is Tikz_Controls)
                        el = new OverlayControlPoint(ShapeFactory.NewCPView());     // control points for Bezier curves
                    else
                        el = new OverlayNode(ShapeFactory.NewNodeView());
                    el.pol = this;
                    el.tikzitem = tpi as Tikz_XYItem;
                    //Ellipse el = new Ellipse();                                   
                    //el.Stroke = Brushes.Red;

                    el.AdjustPosition(Resolution);

                    // add tooltip
                    Tikz_Node nref = TikzParseTreeHelper.GetReferenceableNode(tpi as Tikz_XYItem, ParseTree.GetTikzPicture());
                    if (nref != null && !String.IsNullOrWhiteSpace(nref.name))
                    {
                        el.View.SetToolTip(nref.name);
                    }

                    ////canvas1.Children.Add(el);
                    bag.Add(el);

                    //bbg.Add(new Rect(Canvas.GetLeft(el), Canvas.GetTop(el), el.Width, el.Height));
                }
            }
            else if (tpi is Tikz_Path)
            {
                //could this be a possibility to show edges and provide backward search?

                //there are many possibility for draw commands. here we 

            }

        } */

   /*     /// <summary>
        /// Adds a single parseitem to the display tree and redraws.
        /// This is called by tools adding something to the parsetree to refresh the overlay
        /// without redrawing it completely.
        /// </summary>
        /// <param name="tpi">The parseitem to add.</param>
        public void AddToDisplayTree(TikzParseItem tpi)
        {
            List<OverlayShapeVM> l = new List<OverlayShapeVM>();
            DrawObject(tpi, l);
            if (CurEditing == null)
            {
                //do not redraw if there is nothing to show.
                if (TopLevelItems == null)
                    RedrawObjects();
                TopLevelItems.AddRange(l);
            }
            else
            {
                CurEditing.children.AddRange(l);
            }
            AdjustPositions();
            BindControlPointsToOrigins();
        }*/

        public void BindControlPointsToOrigins()
        {
            foreach (var ocp in AllItems.OfType<OverlayControlPoint>())
                ocp.BindToOrigin(AllItems);
        }
        
        /// <summary>
        /// This method searches recursively among all items in the displaytree for one whose associated code segment
        /// contains the position offset. In case multiple items match, the deepest (in the tree) one is chosen.
        /// E.g., if a scope contains a node, and the offset matches the node, it also also lies within the scope,
        /// but the node is returned.
        /// </summary>
        /// <param name="offset">The code position.</param>
        /// <param name="bag">Overlayshapes to search in.</param>
        /// <returns></returns>
        public OverlayShapeVM ObjectFromOffset(int offset, List<OverlayShapeVM> bag)
        {
            foreach (OverlayShapeVM ols in bag)
            {
                if (ols.item.StartPosition() <= offset && ols.item.StartPosition() + ols.item.ToString().Length > offset)
                {
                    // check if there is a child that fits better
                    if (ols is OverlayScope)
                    {
                        OverlayShapeVM olsinner = ObjectFromOffset(offset, (ols as OverlayScope).children);
                        if (olsinner != null)
                            return olsinner;
                    }
                    return ols;
                }
            }
            return null;
        }
        public OverlayShapeVM ObjectFromOffset(int offset) { return ObjectFromOffset(offset, TopLevelItems); }
        #endregion


        private void RecreateDisplayTree()
        {
            Clear();

            try
            {
                var allitems = this.CreateOverlayShapesFromItem(ParseTree);
                TopLevelItems.AddRange(allitems);
                BindControlPointsToOrigins();
                //DrawObject(ParseTree, TopLevelItems);
                if (DisplayTreeChanged != null)
                    DisplayTreeChanged(this, new DisplayTreeChangedEventArgs() { AffectedItems = AllItems, Type = DisplayTreeChangedType.Insert });
            }
            catch (Exception e)
            {
                // we should really not come here.... but there are conceivable tex files with cyclic references that might 
                // produce errors.
                Clear();
                //        View.AllowEditing = false; // todo
                GlobalUI.UI.AddStatusLine(this, "Error in Overlay rendering: '" + e.Message + "' Overlay disabled for now.", true);

                if (DisplayError != null)
                    DisplayError(this, new DisplayErrorEventArgs() { Message = "Error in Overlay rendering: '" + e.Message });
            }
        }


        void _ParseTree_TextChanged(object sender, ParseTreeTextChangedEventArgs e)
        {
            foreach (var os in AllItems.Where(os => os.item.IsChildOfOrSelf(e.ChangedItem)))
                os.AdjustPosition(Resolution);
        }
    }
}
