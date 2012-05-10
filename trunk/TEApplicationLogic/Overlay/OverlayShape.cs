using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TikzEdt.Parser;

namespace TikzEdt.Overlay
{
    /// <summary>
    /// The viewmodel for shapes used in the overlay control.
    /// 
    /// Note: All coordinate are in bottom left centered coordinates!
    ///       We use bottom centric coordinates, because (i) it is what Tikz does and 
    ///       (ii) WPF can use them by setting Bottom.
    ///       Winforms/GTK views have to use PDFOverlayModel.Height (e.g.) to convert them to topleft centric coords.
    /// </summary>
    public abstract class OverlayShapeVM : ViewModels.ViewModelBase
    {
        //public IOverlayShapeView View;

        /// <summary>
        /// The position of the center of the object
        /// </summary>
        public Point Center
        {
            get
            {
                return BB.Center();
            }
            set
            {
                BB = new Rect(value.X-BB.Width/2, value.Y-BB.Height/2, BB.Width, BB.Height  );
            }
        }

        private Rect _BB = new Rect(0,0,10,10) ;

        /// <summary>
        /// The bounding box in bottom left centric pixel coordinates.
        /// </summary>
        public Rect BB
        {
            get { return _BB; }
            protected set
            {
                if (_BB != value)
                {
                    _BB = value;
                    NotifyPropertyChanged("BB");
                }
            }
        }

        public bool _IsSelected = false;
        /// <summary>
        /// The view should change its color according to whether it is selected.
        /// </summary>
        public bool IsSelected
        {
            get { return _IsSelected; }
            set
            {
                if (_IsSelected != value)
                {
                    _IsSelected = value;
                    NotifyPropertyChanged("IsSelected");
                }
            }
        }

        /// <summary>
        /// The tooltip to be displayed when hovering over the overlay shape.
        /// </summary>
        public string ToolTip
        {
            get { return _ToolTip; }
            set
            {
                if (_ToolTip != value)
                {
                    _ToolTip = value;
                    NotifyPropertyChanged("ToolTip");
                }
            }
        }
        string _ToolTip = null;

        //public PdfOverlayModel pol;
        /// <summary>
        /// Sets the position of the Overlay Shape (and its children) according to the position of the underlying parseitem
        /// </summary>
        /// <param name="tikzToScreen"> </param>
        /// <returns></returns>
        public abstract bool AdjustPosition(Func<Point, Point> TikzToScreen);
        /// <summary>
        /// Shifts the underlying parseitem by the indicated amount, by changing the parse tree.
        /// Does not affect BB directly, only after AdjustPosition()
        /// </summary>
        /// <param name="RelShift">The shift, in Tikz units.</param>
        public abstract void ShiftItemRelative(Vector RelShift);

        /// <summary>
        /// The underlying ParseItem
        /// </summary>
        public abstract TikzParseItem item { get; }

        

        //public virtual void SetSelectedColor() { View.SetSelColor(); }
        //public virtual void SetStdColor() { View.SetStdColor(); }
    }

    public class OverlayScope : OverlayShapeVM
    {
        //public IOverlayScopeView ScopeView;
        public List<OverlayShapeVM> children = new List<OverlayShapeVM>();
        public Tikz_Scope tikzitem;
        public override TikzParseItem item { get { return tikzitem; } }

        /// <summary>
        /// Sets the item's position according to its tikzitem's value
        /// </summary>
        public override bool AdjustPosition(Func<Point, Point> TikzToScreen)
        {
            Rect r = new Rect(0, 0, 0, 0);
            bool hasone = false;
            foreach (OverlayShapeVM o in children)
            {
                o.AdjustPosition(TikzToScreen);
                Rect rr = o.BB;
                if (hasone)
                    r.Union(rr);
                else
                {
                    r = rr;
                    hasone = true;
                }
            }
            if (hasone)
            {
                r.Inflate(20, 20);
                //r = new Rect(10, 10, 100, 100);
                //ScopeView.SetSize(r.Width, r.Height);
                //ScopeView.SetPosition(r.X, r.Y);
                BB = r;
                return true;
            }
            else return false;
        }

        public override void ShiftItemRelative(Vector RelShift)
        {
            if (RelShift.X != 0 || RelShift.Y != 0)
            {
                if (tikzitem.options == null)
                {
                    tikzitem.options = new Tikz_Options();
                    tikzitem.options.starttag = "[";
                    tikzitem.options.endtag = "]";
                    tikzitem.AddChild(tikzitem.options, true);
                }
                //Tikz_Options.SetShiftRel(ts, xs, ys);
                tikzitem.options.SetShiftRel(RelShift.X, RelShift.Y);
                tikzitem.UpdateText();  // todo: don't update text of ll children
            }
        }

        /// <summary>
        /// Determines whether the scope is selected for editing.
        /// The View should in this case display an adorner around the scope to notify the user.
        /// </summary>
        public bool IsCurEditing
        {
            get { return _IsCurEditing; }
            set
            {
                if (_IsCurEditing != value)
                {
                    _IsCurEditing = value;
                    NotifyPropertyChanged("IsCurEditing");
                }
            }
        }
        bool _IsCurEditing = false;

        public OverlayScope()
        {
            //this.View = this.ScopeView= View;
            //View.TheUnderlyingShape = this;
        }
    }

    public class OverlayNode : OverlayShapeVM
    {        
        public Tikz_XYItem tikzitem;
        public override TikzParseItem item { get { return tikzitem; } }

        public delegate void PositionChangedHandler(OverlayNode sender);
        /// <summary>
        /// This event is called whenever the position changes.
        /// </summary>
        //public event PositionChangedHandler PositionChanged;

        /// <summary>
        /// Sets the item's position according to its tikzitem's value
        /// </summary>
        public override bool AdjustPosition(Func<Point, Point> TikzToScreen)
        {

            Point p;
            if (tikzitem.GetAbsPos(out p))
            {
                Point pp = TikzToScreen(p);
                //View.SetPosition(pp.X, pp.Y);
                Center = pp;
       //         if (PositionChanged != null)
       //             PositionChanged(this);
                return true;
            }
            else
            {
                //return false;
                throw new Exception("Encountered drawn item without valid coordinates.");
            }
        }

        public override void ShiftItemRelative(Vector RelShift)
        {
            Point p;
            if (tikzitem.GetAbsPos(out p))
            {
                tikzitem.SetAbsPos(new Point(p.X + RelShift.X, p.Y + RelShift.Y));
                tikzitem.UpdateText();
            }
            else
                throw new Exception("Noneditable overlay node found");
        }

        public OverlayNode()
        {
            //this.View = View;
            //View.TheUnderlyingShape = this;
        }

    }

    /// <summary>
    /// Viewmodel for overlay control point, for Bezier segments.
    /// Note that a control point needs to know about one or two other points, namely one
    /// or two other endpoints of the Bezier segment.
    /// 
    /// Lines should be drawn between the control point and the endpoint(s).
    /// 
    /// The links to the corresponding VMs are stored in Origin1, Origin2 and set with BindToOrigin().
    /// </summary>
    public class OverlayControlPoint : OverlayNode
    {
        //public new IOverlayCPView View;


        OverlayNode _Origin1 = null;
        public OverlayNode Origin1
        {
            get { return _Origin1; }
            private set
            {
                if (_Origin1 != value)
                {
                    _Origin1 = value;
                    NotifyPropertyChanged("Origin1");
                }
            }
        }
        OverlayNode _Origin2 = null;
        public OverlayNode Origin2
        {
            get { return _Origin2; }
            private set
            {
                if (_Origin2 != value)
                {
                    _Origin2 = value;
                    NotifyPropertyChanged("Origin2");
                }
            }
        }

        /// <summary>
        /// Finds the correct VMs that correspond to the endpoints of the Bezier segment in the 
        /// provided List of known OverlayShapes.
        /// 
        /// </summary>
        /// <param name="AllOverlayShapes"></param>
        public void BindToOrigin(IEnumerable<OverlayShapeVM> AllOverlayShapes)
        {

            // find the correct node (s)
            OverlayNode on1 = null, on2 = null;
            if (tikzitem.parent is Tikz_Controls) //lineToOrigin1 == null && lineToOrigin2 == null &&
            {
                Tikz_Controls pa = tikzitem.parent as Tikz_Controls;
                foreach (var o in AllOverlayShapes.OfType < OverlayNode>())
                {
                    if (o.tikzitem == pa.CoordBefore)
                        on1 = o;
                    else if (o.tikzitem == pa.CoordAfter)
                        on2 = o;
                }

                if (pa.FirstCP == tikzitem && on1 != null)    // bind to first
                {
                    //lineToOrigin1 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };
                    //Canvas.SetZIndex(lineToOrigin1, -1);
                    Origin1 = on1;
                    //on_PositionChanged(on1);
                    //pol.canvas.Children.Add(lineToOrigin1);
                    //lineToOrigin1.Visibility = Visibility.Visible;
                    //on1.PositionChanged += new PositionChangedHandler(on_PositionChanged);
                }
                if (pa.LastCP == tikzitem && on2 != null)    // bind to second                
                {
                    //lineToOrigin2 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };
                    //Canvas.SetZIndex(lineToOrigin2, -1);
                    Origin2 = on2;
                    //on_PositionChanged(on2);
                    //pol.canvas.Children.Add(lineToOrigin2);
                    //lineToOrigin2.Visibility = Visibility.Visible;
                    //on2.PositionChanged += new PositionChangedHandler(on_PositionChanged);
                }
            }
        }

  /*      void on_PositionChanged(OverlayNode sender)
        {
            if (Origin1 != null)
                View.SetOrigin1(Origin1.Center.GetLeft(), pol.Height - Origin1.View.GetBottom(), pol.Height);

            if (Origin2 != null)
                View.SetOrigin2(Origin2.View.GetLeft(), pol.Height - Origin2.View.GetBottom(), pol.Height);        
        }*/

        public OverlayControlPoint() : base()
        {
            //this.View = View;
            //View.TheUnderlyingShape = this;
            //PositionChanged += on_PositionChanged;
        }
    }
}
