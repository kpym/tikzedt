using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TikzEdt.Parser;

namespace TikzEdt.Overlay
{
    public abstract class OverlayShape 
    {
        public IOverlayShapeView View;

        public Rect getBB() { return View.GetBB(); }

        public PdfOverlayModel pol;
        /// <summary>
        /// Sets the position of the Overlay Shape (and its children) according to the position of the underlying parseitem
        /// </summary>
        /// <param name="Resolution"></param>
        /// <returns></returns>
        public abstract bool AdjustPosition(double Resolution);
        /// <summary>
        /// Shifts the underlying parseitem by the indicated amount.
        /// </summary>
        /// <param name="RelShift"></param>
        public abstract void ShiftItemRelative(Point RelShift);
        /// <summary>
        /// The underlying ParseItem
        /// </summary>
        public abstract TikzParseItem item { get; }

        public virtual void SetSelectedColor() { View.SetSelColor(); }
        public virtual void SetStdColor() { View.SetStdColor(); }
    }

    public class OverlayScope : OverlayShape
    {
        public new IOverlayScopeView View;
        public List<OverlayShape> children = new List<OverlayShape>();
        public Tikz_Scope tikzitem;
        public override TikzParseItem item { get { return tikzitem; } }

        /// <summary>
        /// Sets the item's position according to its tikzitem's value
        /// </summary>
        public override bool AdjustPosition(double Resolution)
        {
            Rect r = new Rect(0, 0, 0, 0);
            bool hasone = false;
            foreach (OverlayShape o in children)
            {
                o.AdjustPosition(Resolution);
                Rect rr = o.View.GetBB();
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
                View.SetSize( r.Width, r.Height);
                View.SetPosition(r.X, r.Y);
                return true;
            }
            else return false;
        }

        public override void ShiftItemRelative(Point RelShift)
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

        public OverlayScope(IOverlayScopeView View)
        {
            this.View = View;
            View.TheUnderlyingShape = this;
        }
    }

    public class OverlayNode : OverlayShape
    {        
        public Tikz_XYItem tikzitem;
        public override TikzParseItem item { get { return tikzitem; } }

        public delegate void PositionChangedHandler(OverlayNode sender);
        /// <summary>
        /// This event is called whenever the position changes.
        /// </summary>
        public event PositionChangedHandler PositionChanged;

        /// <summary>
        /// Sets the item's position according to its tikzitem's value
        /// </summary>
        public override bool AdjustPosition(double Resolution)
        {

            Point p;
            if (tikzitem.GetAbsPos(out p))
            {
                Point pp = pol.TikzToScreen(p);
                View.SetPosition(pp.X, pp.Y);
                if (PositionChanged != null)
                    PositionChanged(this);
                return true;
            }
            else
            {
                //return false;
                throw new Exception("Encountered drawn item without valid coordinates.");
            }
        }

        public override void ShiftItemRelative(Point RelShift)
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

        public OverlayNode(IOverlayShapeView View)
        {
            this.View = View;
            View.TheUnderlyingShape = this;
        }

    }


    public class OverlayControlPoint : OverlayNode
    {
        public new IOverlayCPView View;

        public void BindToOrigin()
        {
            // find the correct node (s)
            OverlayNode on1 = null, on2 = null;
            if (tikzitem.parent is Tikz_Controls) //lineToOrigin1 == null && lineToOrigin2 == null &&
            {
                Tikz_Controls pa = tikzitem.parent as Tikz_Controls;
                foreach (OverlayShape o in pol.GetAllDescendants(null))
                    if (o is OverlayNode)
                    {
                        if ((o as OverlayNode).tikzitem == pa.CoordBefore)
                            on1 = o as OverlayNode;
                        else if ((o as OverlayNode).tikzitem == pa.CoordAfter)
                            on2 = o as OverlayNode;
                    }

                if (pa.FirstCP == tikzitem && on1 != null)    // bind to first
                {
                    //lineToOrigin1 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };
                    //Canvas.SetZIndex(lineToOrigin1, -1);
                    Origin1 = on1;
                    on_PositionChanged(on1);
                    //pol.canvas.Children.Add(lineToOrigin1);
                    //lineToOrigin1.Visibility = Visibility.Visible;
                    on1.PositionChanged += new PositionChangedHandler(on_PositionChanged);
                }
                if (pa.LastCP == tikzitem && on2 != null)    // bind to second                
                {
                    //lineToOrigin2 = new Line() { Stroke = Brushes.Gray, StrokeDashArray = new DoubleCollection(new double[] { 4, 4 }) };
                    //Canvas.SetZIndex(lineToOrigin2, -1);
                    Origin2 = on2;
                    on_PositionChanged(on2);
                    //pol.canvas.Children.Add(lineToOrigin2);
                    //lineToOrigin2.Visibility = Visibility.Visible;
                    on2.PositionChanged += new PositionChangedHandler(on_PositionChanged);
                }
            }
        }
        
        OverlayNode Origin1, Origin2 = null;

        void on_PositionChanged(OverlayNode sender)
        {
            if (Origin1 != null)
                View.SetOrigin1(Origin1.View.GetLeft(), pol.Height - Origin1.View.GetBottom(), pol.Height);

            if (Origin2 != null)
                View.SetOrigin2(Origin2.View.GetLeft(), pol.Height - Origin2.View.GetBottom(), pol.Height);        
        }

        public OverlayControlPoint(IOverlayCPView View) : base(View)
        {
            this.View = View;
            View.TheUnderlyingShape = this;
            PositionChanged += on_PositionChanged;
        }
    }
}
