using System;
using System.Collections.Generic;
using System.Windows;
using TikzEdt.Parser;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TikzEdt.Overlay
{

    /// <summary>
    /// A request for some text change from the overlay control to the UI.
    /// (UI shall in response modify the text in the editor control).
    /// </summary>
    public class ReplaceTextEventArgs : EventArgs
    {
        public struct ReplaceData
        {
            public int StartPosition;
            public int Length;
            public string ReplacementText;
        }
        public IEnumerable<ReplaceData> Replacements;

        public ReplaceTextEventArgs() { }
        public ReplaceTextEventArgs( int tStartPosition, int tLength, string tReplacementText) 
        {
            var l = new List<ReplaceData>();
            l.Add(new ReplaceData() { StartPosition = tStartPosition, Length=tLength, ReplacementText=tReplacementText });
            Replacements = l;
        } 
    }


    /// <summary>
    /// The control model for the overlay control.
    /// 
    /// The overlay control is the central part of TikzEdt. It displays the overlay on top of the pdf
    /// and is responsible for all WYSIWYG editing.
    /// 
    /// It has the following duties:
    ///     1) It takes the current ParseTree, extracts the elements to be shown in the overlay (nodes and scopes essentially) 
    ///        and builds a display tree consisting of OverlayShapes.
    ///        
    ///     2) It provides methods to update the display tree once the parsetree is modified (note: currently there is no automatic update)
    ///     
    ///     3) It keeps a list of tools, which must be subclasses of the abstract class OverlayTool. In case events relevant for tools fire,
    ///        (mouse, keyboard etc.) these events are forwarded to the active tool.
    /// 
    ///     4) To the overlay tools, PdfOverlayModel provides UI framework independent access to the overlay drawing area and to the ParseTree.
    ///        The overlay tools may modify the ParseTree and display something (previewshapes etc.) on the overlay control.
    ///        The tools see PdfOverlayModel through the IOverlayInterface.
    /// 
    /// </summary>
    public class PdfOverlayModel : ViewModels.ViewModelBase, IOverlayInterface
    {
        IPdfOverlayView View { get; set; }
        public IOverlayShapeFactory ShapeFactory { get; set; }

        readonly TikzDisplayTree _DisplayTree;
        public TikzDisplayTree DisplayTree { get { return _DisplayTree; } }

        OverlayScope _CurEditing = null;
        /// <summary>
        /// This is a link to the scope currently selected for editing.
        /// New nodes/paths are added to this scope.
        /// The scope can be selected for editing by double-clicking or context menu command.
        /// It then becomes highlighted, i.e., a hatched thick additional border is drawn.
        /// </summary>
        public OverlayScope CurEditing
        {
            get { return _CurEditing; }
            set
            {
                if (_CurEditing != null)
                {
                    // remove adorner
                    _CurEditing.IsCurEditing = false;
                }
                _CurEditing = value;
                if (_CurEditing != null)
                {
                    _CurEditing.IsCurEditing = true;
                }

                SetCorrectRaster(CurEditing); // todo: correct? ,true
            }
        }

        /// <summary>
        /// The currently active WYSIWYG tool
        /// </summary>
        public OverlayTool CurrentTool
        {
            get
            {
                return ToolList[(int)View.Tool];
            }
        }

        // Member variables for the tools
        public SelectionTool selectionTool; // todo: make private
        /*EdgeTool edgeTool = new EdgeTool();
        PathTool pathTool = new PathTool();
        NodeTool nodeTool = new NodeTool();
        SmoothCurveTool smoothCurveTool = new SmoothCurveTool();
        BezierTool bezierTool = new BezierTool();
        GridTool gridTool = new GridTool();
        RectangleTool rectangleTool = new RectangleTool();
        EllipseTool ellipseTool = new EllipseTool();
        ArcTool arcTool = new ArcTool();
        ArcEditTool arcEditTool = new ArcEditTool(); */

        public OverlayTool[] ToolList; // is filled in the constructor


        public PdfOverlayModel(IPdfOverlayView View, IOverlayShapeFactory ShapeFactory)
        {
            this.View = View;
            this.ShapeFactory = ShapeFactory;
            _DisplayTree = new TikzDisplayTree( p => TikzToScreen(p, false) );

            // initialize tools
            selectionTool = new SelectionTool(this);

            // must be in the same order as the ToolType enum
            ToolList = new OverlayTool[] { selectionTool, new NodeTool(this), new EdgeTool(this), new PathTool(this), new SmoothCurveTool(this),
                                           new BezierTool(this), new RectangleTool(this), new EllipseTool(this), new GridTool(this), new ArcTool(this), new ArcEditTool(this) };
        }       

        public enum AssignStyleType { AssignNewStyle, ChangeToNewStyle, AssignCurrentNodeStyle, ChangeToCurrentNodeStyle }
        /// <summary>
        /// Assigns some style to the current selection.
        /// </summary>
        /// <param name="type">Determines how to assign the style.</param>
        public void AssignStyle(AssignStyleType type)
        {
            string cStyle = NodeStyle;
            Tikz_Picture tp = ParseTree.GetTikzPicture();
            if (tp == null)
                return;
            if (View.Tool != OverlayToolType.move)
                return;     // context menu should actually only open with move tool,... but to be safe against later changes...

            if (type == AssignStyleType.AssignNewStyle || type == AssignStyleType.ChangeToNewStyle)
            {

                if (GlobalUI.UI.ShowInputDialog("New style...", "Please enter a unique style name", out cStyle) != DialogResult.OK)
                    return;
                cStyle = cStyle.Trim();
                // check if style name is valid and unique
                if (ParseTree == null || cStyle == "")
                    return;
                if (ParseTree.styles.ContainsKey(cStyle))
                {
                    GlobalUI.UI.ShowMessageBox("Error: Style name '" + cStyle + "' already exists.", "Style exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // add new style, immediately before \begin{tikzpicture}[...]
                BeginUpdate();
                Tikz_Option to = new Tikz_Option();
                to.type = Tikz_OptionType.style;
                to.key = cStyle;
                to.val = "";
                to.text = "\\tikzstyle{" + cStyle + "}=[];";

                int index = ParseTree.Children.IndexOf(tp);
                if (index >= 0)
                {
                    ParseTree.InsertChildAt(to, index);
                    to.RegisterNodeAndStyleRefs();
                    ParseTree.InsertChildAt(new Tikz_Something(Environment.NewLine), index + 1);
                }
            }
            else
            {

                if (cStyle.Trim() == "")
                    return;


                BeginUpdate();
            }

            // loop through selected items and set styles
            foreach (OverlayShapeVM ols in selectionTool.SelItems)
            {
                // currently only node styles can be set
                if (ols.item is Tikz_Node)
                {
                    Tikz_Node tn = ols.item as Tikz_Node;
                    if (tn.options == "" || type  == AssignStyleType.ChangeToCurrentNodeStyle || type == AssignStyleType.ChangeToNewStyle)
                    {
                        tn.options = "[" + cStyle + "]";
                    }
                    else // just add option
                    {
                        string o = tn.options.Trim();
                        if (o.EndsWith("]"))
                        {
                            o = o.Substring(0, o.Length - 1);
                            o = o + ", " + cStyle + "]";
                        } // otherwise, do nothing (error)
                        tn.options = o;
                    }
                    tn.UpdateText();
                }
            }

            EndUpdate();        // Make sure EndUpdate() is always called (..if Beginupdate() was)!
        }


        public enum CodeBlockAction { Copy, CopyEnscoped, Cut, CutEnscoped, Delete, Collect, CollectEnscoped }
        /// <summary>
        /// Performs some action on the currently selected items.
        /// 
        /// If necessary, raises the ReplaceText event (via calling RaiseRelaceText) to request text changes.
        /// This is necessary since the Parsetree currently does not support deletions.
        /// Ideally, we would directly do the changes to the Parsetree instead of firing the ReplaceText event.
        /// </summary>
        public void PerformCodeBlockOperation(CodeBlockAction action)
        {
            // The operations are only valid when the select tool is active
            if (View.Tool != OverlayToolType.move)
                return;

            List<TikzParseItem> FullSelection = TikzParseTreeHelper.GetFullSelection(selectionTool.SelItems.Select(ols => ols.item));

            if (!FullSelection.Any())
                return;

            // get codeblock text
            string cbtext = "", cbtextE = "";
            foreach (var tpi in FullSelection)
                cbtext += tpi.ToString() + Environment.NewLine;

            // if the selected items are within a path, enscope by adding { }. If they are within another scope or the tikzpicture, enscope by \begin{scope} \end{scope}
            TikzContainerParseItem tc = FullSelection.First().parent;
            if (tc is Tikz_Picture || tc is Tikz_Scope)
                cbtextE = "\\begin{scope}[]" + Environment.NewLine + cbtext + Environment.NewLine + "\\end{scope}" + Environment.NewLine;
            else
                cbtextE = " { " + cbtext + " } ";


            var ReplacementList = new List<ReplaceTextEventArgs.ReplaceData>();

            if (action == CodeBlockAction.Copy)
            {
                Clipboard.SetText(cbtext);
            }
            else if (action == CodeBlockAction.CopyEnscoped)
            {
                Clipboard.SetText(cbtextE);
            }
            else if (action == CodeBlockAction.Delete || action == CodeBlockAction.Cut || action == CodeBlockAction.CutEnscoped)
            {
                foreach (var tpi in FullSelection)
                    ReplacementList.Insert(0, new ReplaceTextEventArgs.ReplaceData() { StartPosition = tpi.StartPosition(), Length = tpi.Length, ReplacementText = "" });

                if (action == CodeBlockAction.Cut)
                    Clipboard.SetText(cbtext);
                else if (action == CodeBlockAction.CutEnscoped)
                    Clipboard.SetText(cbtextE);

                View.RaiseReplaceText(new ReplaceTextEventArgs() { Replacements = ReplacementList });

            }
            else if (action == CodeBlockAction.Collect || action == CodeBlockAction.CollectEnscoped)
            {
                // Text to delete ... mind the order
                foreach (var tpi in FullSelection)
                    ReplacementList.Insert(0, new ReplaceTextEventArgs.ReplaceData() { StartPosition = tpi.StartPosition(), Length = tpi.Length, ReplacementText = "" });

                // text to insert (text of selected nodes, gathered together, optionally enscoped
                if (action == CodeBlockAction.Collect)
                {
                    ReplacementList.Add(new ReplaceTextEventArgs.ReplaceData()
                    {
                        StartPosition = FullSelection.First().StartPosition(),
                        Length = 0,
                        ReplacementText = cbtext
                    });
                }
                else
                {
                    ReplacementList.Add(new ReplaceTextEventArgs.ReplaceData()
                    {
                        StartPosition = FullSelection.First().StartPosition(),
                        Length = 0,
                        ReplacementText = cbtextE
                    });
                }

                View.RaiseReplaceText(new ReplaceTextEventArgs() { Replacements = ReplacementList });

            }
        }

        /// <summary>
        /// Clears all items from the canvas.
        /// </summary>
        public void Clear()
        {
            View.Clear();
            CurEditing = null;
            ParseTree = null;
            View.Tool = View.Tool;    // this deactivates + reactivates the current tool to reset its status... e.g., it might contain links to some selected objects etc.
            //DisplayTree.Clear();
            Rasterizer.ResetRaster();
        }

        public void RedrawObjects()
        {
            View.Clear();
            //curSel = null;
            CurEditing = null;
            View.Tool = View.Tool;    // this deactivates + reactivates the current tool to reset its status... TODO: does this really work?
            //TopLevelItems = new List<OverlayShapeVM>();
            DisplayTree.ParseTree = ParseTree;
            //DisplayTree.RecreateDisplayTree();

            if (ParseTree == null)
            {
                Rasterizer.ResetRaster();
                return; // nothing to display
            }

            try
            {
                SetCorrectRaster((TikzParseItem)null);
            }
            catch (Exception e)
            {
                // we should really not come here.... but there are conceivable tex files with cyclic references that might 
                // produce errors.
                Clear();
                View.AllowEditing = false;
                GlobalUI.UI.AddStatusLine(this, "Error in Overlay rendering: '" + e.Message + "' Overlay disabled for now.", true);
            }
        }

        public Point CursorPosition { get { return View.CursorPosition; } }
        public OverlayShapeVM ObjectAtCursor { get { return View.ObjectAtCursor; } }
        public TEModifierKeys KeyboardModifiers { get { return View.KeyboardModifiers; } }

        /// <summary>
        /// The displayed raster changes depending on the currently selected object.
        /// This method sets the raster, so as to fit the coordinate transformation at o.
        /// There are two cases:    (i)  (IsParent=false) o is the object being modified, so the relevant coordinate trsf. is that at o
        ///                         (ii) (IsParent=true)  o is a parent object to which items are added. 
        ///                              In this case the relevant transf. is that at the end of o, since new items are inserted at the end.
        /// </summary>
        /// <param name="o">The object. If null, it is taken to be the tikzpicture.</param>
        /// <param name="IsParent">Indicates whether object is to be moved itself, or children added.</param>        
        public void SetCorrectRaster(OverlayShapeVM o, bool IsParent = false)
        {
            SetCorrectRaster(o == null ? null : o.item, IsParent);
        }
        public void SetCorrectRaster(TikzParseItem tpi, bool IsParent = false)
        {
            if (ParseTree == null)
                return;
            if (tpi == null)
            {
                Tikz_Picture tp = ParseTree.GetTikzPicture();
                if (tp != null)
                {
                    TikzMatrix M;
                    if (!tp.GetCurrentTransformAt(null, out M))
                        Rasterizer.View.CoordinateTransform = new TikzMatrix();   // if the program gets here, the global coord. transformation could not be understood->ovelay should display nothing
                    else
                        Rasterizer.View.CoordinateTransform = M;
                    //rasterizer.RasterOrigin = M.Transform(new Point(0, 0));
                    //rasterizer.RasterScale = M.m[1, 1];
                    Rasterizer.View.IsCartesian = !UsePolarCoordinates;
                }
            }
            else if (tpi is Tikz_Scope)
            {
                Tikz_Scope ts = tpi as Tikz_Scope;
                TikzMatrix M;
                if (IsParent)
                {
                    if (!ts.GetCurrentTransformAt(null, out M))  // todo
                        M = new TikzMatrix(); // broken coords-> take unity as backup
                }
                else
                {
                    //if (!ts.parent.GetCurrentTransformAt(ts, out M))
                    //    M = new TikzMatrix();
                    if (!ts.GetRasterTransform(out M))
                        M = new TikzMatrix();
                }
                Rasterizer.View.CoordinateTransform = M;
                //rasterizer.RasterOrigin = M.Transform(new Point(0, 0));
                //rasterizer.RasterScale = M.m[1, 1];
                Rasterizer.View.IsCartesian = !IsParent || !UsePolarCoordinates;
            }
            else if (tpi is Tikz_XYItem)
            {
                Tikz_XYItem t = tpi as Tikz_XYItem;
                Point offset;
                if (t.GetAbsPos(out offset, true))
                {
                    TikzMatrix M;
                    if (!t.parent.GetCurrentTransformAt(t, out M)) //.CloneIt();
                        M = new TikzMatrix();

                    M.m[0, 2] = offset.X;
                    M.m[1, 2] = offset.Y;
                    //rasterizer.RasterScale = M.m[1, 1];
                    Rasterizer.View.CoordinateTransform = M;
                    Rasterizer.View.IsCartesian = !(t.IsPolar());
                }
                else throw new Exception("In PdfOverlay: Encountered drawn item without valid coordinates");
            }
            else if (tpi is Tikz_Path)
            {
                Tikz_Path ts = tpi as Tikz_Path;
                TikzMatrix M;
                if (IsParent)
                {
                    Point curPointAtEnd;
                    if (!ts.GetCurrentTransformAt(null, out M))  // todo
                        M = new TikzMatrix(); // broken coords-> take unity as backup
                    if (ts.GetAbsOffset(out curPointAtEnd, null))
                    {
                        M.m[0, 2] = curPointAtEnd.X;
                        M.m[1, 2] = curPointAtEnd.Y;
                    }
                }
                else
                {
                    if (!ts.parent.GetCurrentTransformAt(ts, out M))
                        M = new TikzMatrix();
                    //if (!ts.GetRasterTransform(out M))
                    //    M = new TikzMatrix();
                }
                Rasterizer.View.CoordinateTransform = M;
                //rasterizer.RasterOrigin = M.Transform(new Point(0, 0));
                //rasterizer.RasterScale = M.m[1, 1];
                Rasterizer.View.IsCartesian = !IsParent || !UsePolarCoordinates;
            }
            else
                Debug.WriteLine("Error in SetCorrectRaster: unsupported type");//Rasterizer.IsCartesian = true;  // should not get here
        }

        

        public Point ScreenToTikz(Point p, bool invY = false)
        {
            if (invY)
                return new Point(p.X / Resolution + View.BB.X, (Height - p.Y) / Resolution + View.BB.Y);
            else return new Point(p.X / Resolution + View.BB.X, p.Y / Resolution + View.BB.Y);
        }
        public Point TikzToScreen(Point p, bool invY = false)
        {
            if (invY)
                return new Point((p.X - View.BB.X) * Resolution, Height - (p.Y - View.BB.Y) * Resolution);
            else return new Point((p.X - View.BB.X) * Resolution, (p.Y - View.BB.Y) * Resolution);
        }


        #region OverlayInterface
        public Parser.Tikz_ParseTree ParseTree
        {
            get { return View.ParseTree; }
            set { View.ParseTree = value; }
        }

        public bool AllowEditing
        {
            get { return View.AllowEditing; }
        }

        public void BeginUpdate()
        {
            if (ParseTree != null)
                ParseTree.BeginModify();
        }

        public void EndUpdate()
        {
            if (ParseTree != null)
                ParseTree.EndModify();
        }

        public void ActivateDefaultTool()
        {
            View.Tool = OverlayToolType.move;
        }

        public RasterControlModel Rasterizer
        {
            get { return View.Rasterizer; }
        }

        public double Resolution
        {
            get { return View.Resolution; }
        }

        public string NodeStyle
        {
            get { return View.NodeStyle; }
        }

        public string EdgeStyle
        {
            get { return View.EdgeStyle; }
        }

        public double Height
        {
            get { return View.BB.Height * View.Resolution; }
        }

        public double Width
        {
            get { return View.BB.Width * View.Resolution; }
        }

        public string NewNodeModifier
        {
            get { return View.NewNodeModifier; }
        }

        public bool UsePolarCoordinates
        {
            get { return View.UsePolarCoordinates; }
        }

        public void JumpToSourceDoIt(OverlayShapeVM o)
        {
            View.JumpToSourceDoIt(o);
        }

        #endregion


        /// <summary>
        /// Tries to display a ring around the object at text position
        /// offset.
        /// </summary>
        /// <param name="offset">The text position.</param>
        public void MarkObjectAt(int offset)
        {
            OverlayShapeVM ols = DisplayTree.ObjectFromOffset(offset);
            if (ols != null)
            {
                View.MarkObject(ols);
            }
        }



        public void SetCursor(System.Windows.Forms.Cursor cursor)
        {
            View.SetCursor(cursor);
        }


        public bool MouseCaptured
        {
            set { View.MouseCaptured = value; }
        }
    }

}
