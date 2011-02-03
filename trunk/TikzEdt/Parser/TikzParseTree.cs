using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.Windows.Media;

namespace TikzEdt.Parser
{

    /// <summary>
    /// This class represents a 3x2 Matrix used for Tikz coordinate transformations
    /// </summary>
    public class TikzMatrix : ICloneable
    {
        public double[,] m = new double[2, 3];

        public TikzMatrix()
        {
            m[0, 0] = 1; m[1, 1] = 1;
        }
        public static TikzMatrix ZeroMatrix()
        {
            TikzMatrix ret = new TikzMatrix();
            ret.m[0, 0] = 0; ret.m[1, 1] = 0;
            return ret;
        }
        
        public static TikzMatrix operator *(TikzMatrix M1, TikzMatrix M2)
        {
            TikzMatrix ret = TikzMatrix.ZeroMatrix();
            ret.m[0, 2] = M1.m[0, 2];
            ret.m[1, 2] = M1.m[1, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    ret.m[i, 2] += M1.m[i, j] * M2.m[j, 2];
                    for (int k = 0; k < 2; k++)
                    {
                        ret.m[i, j] += M1.m[i, k] * M2.m[k, j];
                    }
                }
            return ret;
        }
        public Point Transform(Point p, bool noshift = false)
        {
            Point pp = new Point();
            pp.X = m[0, 0] * p.X + m[0, 1] * p.Y;
            pp.Y = m[1, 0] * p.X + m[1, 1] * p.Y;

            if (!noshift)
            {
                pp.X += m[0, 2];
                pp.Y += m[1, 2];
            }

            return pp;
        }
        public Vector Transform(Vector v)
        {
            Point p = Transform(new Point(v.X, v.Y), true);
            return new Vector(p.X, p.Y);
        }
        public double Det() { return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]; }
        public TikzMatrix Inverse()
        {
            TikzMatrix mi = new TikzMatrix();
            double d = Det();
            mi.m[0,0] = m[1, 1] / d;
            mi.m[1, 0] = -m[1, 0] / d;
            mi.m[0, 1] = -m[0, 1] / d;
            mi.m[1, 1] = m[0, 0] / d;

            mi.m[0, 2] = - mi.m[0,0] * m[0,2] - mi.m[0,1]*m[1,2];
            mi.m[1, 2] = - mi.m[1,0] * m[0, 2] - mi.m[1, 1] * m[1, 2];

            return mi;
        }

        public object Clone()
        {
            return CloneIt();
        }

        public TikzMatrix CloneIt()
        {
            TikzMatrix M = (TikzMatrix)this.MemberwiseClone();
            M.m = new double[2, 3];
            for (int i = 0; i < 2; i++) for (int j = 0; j < 3; j++)
                    M.m[i, j] = m[i, j];
            return M;
        }

        public Matrix ToWpfMatrix()
        {
            // Which is correct? I think the first
            return new Matrix(m[0, 0], m[1, 0], m[0, 1], m[1, 1], m[0, 2], m[1, 2]);
            //return new Matrix(m[0, 0], m[0, 1], m[1, 0], m[1, 1], m[0, 2], m[1, 2]);
        }
    }


    /// <summary>
    /// This class is the base class of all nodes in the Parsetree.
    /// Every node in the parsetree stores the block of text in the code it represents.
    /// This text, ehich can be obtained through <code>ToString()</code>, may differ from the internal state of the node. 
    /// To synchronize this text with the internal state, call <code>UpdateText()</code>.
    /// For example, in the code, there might occur the phrase
    ///   <code>node  (hello    world    )    at (1,2){}</code>
    /// The parser will write this string into the text property of the node. 
    /// After <code>UpdateText()</code>, the text will be
    ///   <code>node (hello world) at (1,2) {}</code>
    /// </summary>
    public class TikzParseItem
    {
        /// <summary>
        /// The parent node in the parse tree, or null if the current node is the root
        /// </summary>
        public TikzContainerParseItem parent;
        
        private string _text = "";
        public virtual int Length { get { return _text.Length; } }
        /// <summary>
        /// This property holds the displayed Text of the node in the parse tree
        /// </summary>
        public string text
        {
            get { return _text; }
            set
            {
                string old = text;
                _text = value;
                RaiseTextChanged(this, old);
            }
        }
        public TikzParseItem(string txt)
        {
            text = txt;
        }
        public TikzParseItem()
        {
        }
        public override string ToString()
        {
            return text;
        }

        /// <summary>
        /// Gets the position, in the document, of the current node.
        /// (Position= index of the first character in the string produced by tikzdocument.ToString(), that belongs to this node)
        /// </summary>
        /// <returns></returns>
        public virtual int StartPosition()
        {
            if (parent != null)
                return parent.GetLengthBefore(this);
            else
                return 0;
        }
        //public virtual int GetLengthBefore(TikzParseItem tpi)
        //{
        //    return ToString().Length; //
        //}
        /// <summary>
        /// This method triggers a TextChanged event in the root of the parse tree.
        /// </summary>
        /// <param name="sender">The node whose text was changed.</param>
        /// <param name="oldtext">the text of the node before the change.</param>
        public virtual void RaiseTextChanged(TikzParseItem sender, string oldtext)
        {
            if (parent != null)
                parent.RaiseTextChanged(sender, oldtext);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns false if the item does not have a bounding box</returns>
        public virtual bool GetBB(out Rect r)
        {
            r = new Rect(0, 0, 0, 0);
            return false;
        }

        /// <summary>
        /// Call this to make the ParseItem register itself at the picture or document root node
        /// </summary>
        public virtual void RegisterNodeAndStyleRefs()
        {
            if (parent != null)
            {
                if (this is Tikz_Node)
                    parent.AddNodeRef(this as Tikz_Node);
                else if (this is Tikz_Option && (this as Tikz_Option).type == Tikz_OptionType.style)
                    parent.AddStyleRef(this as Tikz_Option);
            }
        }

        /// <summary>
        /// causes the object to update its text according to its contents
        /// </summary>
        public virtual void UpdateText() { }

        /// <summary>
        /// For testing only, don't use.
        /// </summary>
        public virtual string ToStringEx()
        {
            return (GetType().ToString() + ":   " + text + "\r\n");
        }

    }
    /// <summary>
    /// This item represents parts of the code that the parser does not understand
    /// or not care about, e. g., whitespace, or commands that have no internal 
    /// representation in the parse tree.
    /// </summary>
    public class Tikz_Something : TikzParseItem
    {
        public Tikz_Something(string txt)
        {
            text = txt;
        }
        public Tikz_Something()
        {
        }
    }
    public class Tikz_EdtCommand : TikzParseItem
    {
        public Tikz_EdtCommand(string txt)
        {
            text = txt;
        }
        public Tikz_EdtCommand()
        {
        }
    }
    /// <summary>
    /// Parse Item having an x and y coordinate.
    /// </summary>
    public abstract class Tikz_XYItem : TikzParseItem
    {
        //public double x, y;
        //public abstract void SetPosition(Point p);
        /// <summary>
        /// Returns the absolute position of this node within the Tikzpicture (in cm).
        /// Note that sometimes this is not possible, for example if the coordinates involve math expressions,
        /// or node names that are not found in the global node name list.
        /// </summary>
        /// <param name="ret">The point, if it was possible to determine coordinates, and something otherwise.</param>
        /// <param name="OnlyOffset"></param>
        /// <returns>True if coordinate could be determined, false otherwise.</returns>
        public abstract bool GetAbsPos(out Point ret, bool OnlyOffset = false);
        /// <summary>
        /// Sets the absolute position of this node within the Tikzpicture (in cm).
        /// If it is not possible to set the coordinates, the function just does nothing and doesn't complain.
        /// </summary>
        /// <param name="p"></param>
        public abstract void SetAbsPos(Point p);

        /// <summary>
        /// Indicates whether the item's coordinate can be edited.
        /// It cannot be edited, e.g., if the items position is relative to some unknown node, or 
        /// if the coord is given through a math expression etc.
        /// </summary>
        /// <returns></returns>
        public abstract bool HasEditableCoordinate();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //public abstract Point GetAbsCoordOffset();

        public override bool GetBB(out Rect r)
        {
            Point p;
            if (!GetAbsPos(out p))
            {
                r = new Rect(0, 0, 0, 0);
                return false;
            }
            else
            {
                r = new Rect(p, p);
                return true;
            }
        }
        public abstract bool IsPolar();
        
    }
    public class Tikz_Node : Tikz_XYItem
    {
        /// <summary>
        /// The parse calls this static method to construct a Tikz_Node from 
        /// a node in the abstract syntax tree produced by antlr
        /// </summary>
        /// <param name="t">The node in the abstract syntax tree. Must be of type IM_NODE</param>
        /// <param name="tokens">A reference to the Antlr tokenstream. This is used to extract e.g. the node label.</param>
        /// <returns></returns>
        public static Tikz_Node FromCommonTree(CommonTree t, CommonTokenStream tokens)
        {
            // IM_NODE (OPTIONS | nodename | coord)* STRING
            Tikz_Node n = new Tikz_Node();
            n.options = "";
            foreach (CommonTree childt in t.Children)
            {
                switch (childt.Type)
                {
                    case simpletikzParser.IM_OPTIONS:
                        n.options = n.options + TikzParser.getTokensString(tokens, childt);
                        break;
                    case simpletikzParser.IM_COORD:
                        n.coord = Tikz_Coord.FromCommonTree(childt, tokens);
                        break;
                    case simpletikzParser.IM_NODENAME:
                        n.name = TikzParser.getTokensString(tokens, childt.GetChild(0));
                        n.name = Helper.RemoveMultipleWhitespace(n.name);
                        break;
                    case simpletikzParser.IM_STRING:
                        n.label = TikzParser.getTokensString(tokens, childt);
                        // remove leading and trailing {} TODO: do it in parser
                        n.label = n.label.Substring(1, n.label.Length - 2);
                        break;
                }
            }
/*            int i = 0;
            if (t.GetChild(i).Type == simpletikzParser.IM_OPTIONS)
            {
                //i++;
                n.options = TikzParser.getTokensString(tokens, t.GetChild(i++));
            }
            if (t.GetChild(i).Type == simpletikzParser.IM_NODENAME)
            {
                n.name = TikzParser.getTokensString(tokens, t.GetChild(i++).GetChild(0)); //t.GetChild(i++).GetChild(0).Text;
            }
            if (t.GetChild(i).Type == simpletikzParser.IM_COORD)
            {
                n.coord = Tikz_Coord.FromCommonTree(t.GetChild(i++), tokens);
                //n.x = n.coord.uX.number; //hack
                //n.y = n.coord.uY.number;
            }

            // the text of the node
            n.label = TikzParser.getTokensString(tokens, t.GetChild(i));  //t.GetChild(i).Text.Trim();
            // remove leading and trailing {} TODO: do it in parser
            n.label = n.label.Substring(1, n.label.Length - 2);
            */
            return n;
        }
        public void SetName(string tname)
        {
            name = tname;
            RegisterNodeAndStyleRefs();
        }

        public override bool HasEditableCoordinate()
        {
            if (coord == null) 
                return false;
            else
            {
                if (coord.type == Tikz_CoordType.Named)
                    return false;
                Point pdummy;
                return coord.GetAbsPos(out pdummy, this);  
            }
//            if  (tpi is Tikz_Coord && (tpi as Tikz_Coord).type == Tikz_CoordType.Named)
//                    && !(tpi is Tikz_Node && (tpi as Tikz_Node).coord == null) // TODO: yet to decide whether to draw such things
        }
        //public override void SetPosition(Point p)
       // {
        //    coord.SetPosition(p);
        //}

        public override bool IsPolar()
        {
            if (coord != null)
                return coord.IsPolar();
            else return false;
        }


        public override bool GetAbsPos(out Point ret, bool OnlyOffset = false) 
        {
            if (coord == null)// later possibly: todo: return correct value if OnlyOffset 
            {
                return (parent as Tikz_Path).GetAbsOffset(out ret, this);
                //return new Point(0, 0);
            }
            else
            {
                return coord.GetAbsPos(out ret, this, OnlyOffset);
            }
        }
        public override void SetAbsPos(Point p)
        {
            if (coord != null)
                coord.SetAbsPos(p, this);
        }

        public Tikz_Coord coord;
        public string name = "";
        public string options = "";
        public string label = "";
        public Tikz_Node() { }
        //public Tikz_Node(double tx, double ty)
        //{
        //    x = tx; y = ty;
        //}
        public override void UpdateText()
        {
            string newtext = "node ";
            // if parent is a node or coordinate, and this item is the first, do not print node again
            if (parent is Tikz_Path)
            {
                if (parent.starttag.Trim() == @"\node" || parent.starttag.Trim() == @"\coordinate")
                {
                    // todo: check for first.... 
                    //int i = parent.Children.IndexOf(this);
                    //bool found
                    //for (int j=i-1; j
                    newtext = "";
                }
            }

            if (options != "")
                newtext = newtext + options + " ";
            
            if (name != "")
                newtext = newtext + "(" + name + ") ";
            if (coord != null)
            {
                coord.UpdateText();
                newtext = newtext + "at " + coord.ToString() + " ";
            }
            newtext = newtext + "{" + label + "}";
            text = newtext;
        }
    }
    public class Tikz_Size : TikzParseItem
    {
        public static Tikz_Size FromCommonTree(ITree t, CommonTokenStream tokens)
        {
            Tikz_Size to = new Tikz_Size();
            switch (t.Type)
            {
                case simpletikzParser.IM_SIZE:
                    if (t.ChildCount == 1)
                    {
                        to.text = "(" + t.GetChild(0).GetChild(0) + ")";
                        return to;
                    }
                    break;
                default:
                    throw new Exception("bad.");

            }
            return to;
        }
    }
    public enum Tikz_CoordType { Cartesian, Polar, Named, Invalid } // Invaid means ununderstandable for TikzEdt, not necessarily incorrect in Tikz
    //public enum Tikz_CoordDeco { none, p, pp }
    public class Tikz_Coord : Tikz_XYItem
    {
        /// <summary>
        /// TikzEdt cannot understand some coordinates (e.g., with math expressions or macros).
        /// For those cases, the coordinate will be marked as broken.
        /// All attempts to get the position of the coordinate will fail.
        /// </summary>
        public bool IsBroken { get { return type == Tikz_CoordType.Invalid; } }

        public override bool HasEditableCoordinate()
        {
            if (type == Tikz_CoordType.Named)
                return false;

            Point pdummy;
            return GetAbsPos(out pdummy);  
        }

        /// <summary>
        /// The Parser calls this method to create a Tikz_Coord from a node of the 
        /// abstract syntax tree produced by antlr.
        /// </summary>
        /// <param name="t">The node of the AST.</param>
        /// <returns></returns>
        public static Tikz_Coord FromCommonTree(ITree t, CommonTokenStream tokens)
        {
            Tikz_Coord tc = new Tikz_Coord();
            if (t.ChildCount == 1 && t.GetChild(0).Type == simpletikzParser.IM_NODENAME) // named node 
            {
                tc.type = Tikz_CoordType.Named;
                tc.nameref = TikzParser.getTokensString(tokens, t.GetChild(0).GetChild(0)); //t.GetChild(0).GetChild(0).Text;
                return tc;
            }
            else if (t.ChildCount >= 2)
            {
                int i = 0;
                if (t.ChildCount == 4)
                {
                    tc.deco = t.GetChild(0).Text;
                    i = 1;
                }

                if (t.GetChild(i).Type == simpletikzParser.IM_NUMBERUNIT && t.GetChild(i).Type == simpletikzParser.IM_NUMBERUNIT)
                {
                    tc.uX = new Tikz_NumberUnit(t.GetChild(i));
                    tc.uY = new Tikz_NumberUnit(t.GetChild(i + 1));
                    if (t.GetChild(i + 2).Text == ":")
                    {
                        tc.type = Tikz_CoordType.Polar;
                    }
                }
                else
                {
                    tc.type = Tikz_CoordType.Invalid;
                }
                //tc.x = tc.uX.number; // hack
                //tc.y = tc.uY.number;

                return tc;
            }

            return null;    // coming here is an error... this should not happen.
        }
        public override void SetAbsPos(Point p)
        {
            SetAbsPos(p, this);
        }

        public override bool IsPolar()
        {
            return (type == Tikz_CoordType.Polar);
        }

        /// <summary>
        /// Adjusts the current coordinates (seen as coordinates of relto)
        /// such that relto sits at p in absolute coordinates.
        /// The extra parameter is needed since this method is called by Tikz_Node, which
        /// contains a Tikz_Coord object. (In that case relto will be the Tikz_Node)
        /// </summary>
        /// <param name="p">The new absolute (cartesian) coordinates, in cm</param>
        /// <param name="relto">Object with respect to which the coordinate transformation is determined</param>
        public void SetAbsPos(Point p, TikzParseItem relto)
        {
            if (IsBroken && type == Tikz_CoordType.Named)
            {
                // cannot change coord
            }
            else
            {
                Point relp; // will hold the new coordinates, in the current coordinate system
                TikzMatrix MM;
                if (!relto.parent.GetCurrentTransformAt(relto, out MM))
                    return; // broken coord trafo -> do nothing
                MM = MM.Inverse();

                if (deco == "+" || deco == "++")
                {
                    Point offset;
                    if (relto.parent is Tikz_Controls)
                    {
                        Tikz_Controls par = relto.parent as Tikz_Controls;
                        Tikz_Coord offc = null;
                        if (relto == par.FirstCP)
                            offc = par.CoordBefore;
                        else if (relto == par.LastCP)
                            offc = par.CoordAfter;
                        if (offc == null || !offc.GetAbsPos(out offset))
                            return;
                        relp = new Point(p.X - offset.X, p.Y - offset.Y);   // the desired shift, in absolute coordinates
                        relp = MM.Transform(relp, true);
                    }
                    else if ((relto.parent as Tikz_Path).GetAbsOffset(out offset, relto))
                    {
                        relp = new Point(p.X - offset.X, p.Y - offset.Y);   // the desired shift, in absolute coordinates
                        relp = MM.Transform(relp, true);
                    }
                    else
                    {
                        // error in determining offset -> cannot set coordinate
                        return;
                    }
                }
                else
                {
                    relp = MM.Transform(new Point(p.X, p.Y));   // this is the target point in current coordinate system
                }

                if (type == Tikz_CoordType.Polar)
                {
                    relp = RasterControl.CartToPolTC(relp);

                }
                uX.SetInCM(relp.X);
                uY.SetInCM(relp.Y);
            }
        }

        public override bool GetAbsPos(out Point ret, bool OnlyOffset = false)
        {
            return GetAbsPos(out ret, this, OnlyOffset);
        }
        /// <summary>
        /// Gets the absolute position. For the significance of relto, see SetAbsPos()
        /// </summary>
        /// <param name="relto"></param>
        /// <param name="OnlyOffset">Only the coordinate offset is returned. (This is used to determine the raster offset.)</param>
        /// <returns>The position in the coordinates of the ancestral Tikz_Picture, or (0,0) in case of failure.</returns>
        public bool GetAbsPos(out Point ret, TikzParseItem relto, bool OnlyOffset=false)
        {
            if (IsBroken)   // cannot determine coordinates
            {
                ret = new Point(0,0);
                return false;
            }

            if (type == Tikz_CoordType.Named)
            {
                if (relto.parent == null)
                {
                    // node name not find in node list (either error or not parsed)
                    ret = new Point(0, 0);
                    return false;
                }
                Tikz_Node t = relto.parent.GetNodeByName(nameref);
                if (t == null)
                {
                    ret = new Point(0, 0);
                    return false;
                }
                else
                {
                    return t.GetAbsPos(out ret);
                }
            }

            Point offset = new Point(0, 0);
            if (deco == "+" || deco == "++")
            {
                // determine offset
                if (relto.parent is Tikz_Path)
                {
                    if (!(relto.parent as Tikz_Path).GetAbsOffset(out offset, relto))
                    {
                        // error in determining offset -> cannot determine coordinates
                        ret = new Point(0, 0);
                        return false;
                    }
                }
                else if (relto.parent is Tikz_Controls)
                {
                    Tikz_Controls par = relto.parent as Tikz_Controls;
                    Tikz_Coord offc = null;
                    if (relto == par.FirstCP)
                        offc = par.CoordBefore;
                    else if (relto == par.LastCP)
                        offc = par.CoordAfter;
                    if (offc == null || !offc.GetAbsPos(out offset))
                    {
                        ret = new Point(0, 0);
                        return false;
                    }
                } else
                {
                    // not supported

                }

                Point relpos = new Point(uX.GetInCM(), uY.GetInCM());
                if (type == Tikz_CoordType.Polar)
                    relpos = RasterControl.PolToCartTC(relpos);

                if (relto.parent != null)
                {
                    TikzMatrix M;
                    if (!relto.parent.GetCurrentTransformAt(relto, out M))
                    {
                        ret = new Point(0, 0);
                        return false;
                    }
                    relpos = M.Transform(relpos, true);
                }
                if (OnlyOffset)
                {
                    ret = offset;
                    return true;
                }
                else
                {
                    ret = new Point(offset.X + relpos.X, offset.Y + relpos.Y);
                    return true;
                }
            }

            // standard coordinate (not relative etc.)
            Point p = new Point(uX.GetInCM(), uY.GetInCM());
            if (type == Tikz_CoordType.Polar)
                p = RasterControl.PolToCartTC(p);
            if (relto.parent == null)
            {
                if (OnlyOffset)
                {
                    ret = new Point(0, 0);
                }
                else
                {
                    ret = p;
                }
                return true;
            }
            else
            {
                TikzMatrix M;
                if (!relto.parent.GetCurrentTransformAt(relto, out M))
                {
                    ret = new Point(0, 0);
                    return false;
                }
                //Point pret;
                if (OnlyOffset)
                {
                    ret = M.Transform(new Point(0, 0));
                }
                else
                {
                    ret = M.Transform(p);                    
                }
                return true;
            }
                
        }
        public override void UpdateText()
        {
            if (IsBroken)   // if coordinate could not be determined-> do not change the text
                return;

            string newtext = deco + "(";
            switch (type)
            {
                case Tikz_CoordType.Named:
                    newtext = newtext + nameref;
                    break;
                case Tikz_CoordType.Polar:
                    newtext = newtext + uX.ToString() + ":" + uY.ToString();
                    break;
                case Tikz_CoordType.Cartesian:
                    newtext = newtext + uX.ToString() + "," + uY.ToString();
                    break;
            }
            newtext = newtext + ")";
            text = newtext;
        }

        //public override void SetPosition(Point p)
        //{
        //    uX.number = p.X;
        //    uY.number = p.Y;
        //    x = p.X; y = p.Y; //hack
        //}

        /// <summary>
        /// Coordinates can be either polar, cartesian, or a reference to some node
        /// </summary>
        public Tikz_CoordType type = Tikz_CoordType.Cartesian;
        /// <summary>
        /// This is '+' for relative coordinates w/o update of the current point in a path
        /// or '++' for relative coordinates w/ update of the current point in a path
        /// (or '' for absolute coordinates)
        /// </summary>
        public string deco = "";
        public Tikz_NumberUnit uX=new Tikz_NumberUnit(), uY=new Tikz_NumberUnit();
        public string nameref = ""; // name of vertex if coordinate is such a reference
        public Tikz_Coord() { }
        //public Tikz_Coord(double tx, double ty)
        //{
            //x = tx; y = ty;
        //}

        /// <summary>
        /// returns the Cartesian coordinates, w/o any coordinate transformation applied
        /// </summary>
        /// <returns></returns>
        public Point GetCartesian()
        {
            if (type == Tikz_CoordType.Cartesian)
            {
                return new Point(uX.GetInCM(), uY.GetInCM());
            }
            else if (type == Tikz_CoordType.Polar)
            {
                double angle = uX.GetInCM() * 2 * Math.PI / 360;    // in radians
                return new Point(uY.GetInCM() * Math.Cos(angle), uY.GetInCM() * Math.Sin(angle));
            }
            else
                throw new Exception("Tikz_Coord.GetCartesian should only be called for valid cartesian or polar coordinates");

        }
        public void SetCartesian(double x, double y)
        {
            if (type != Tikz_CoordType.Cartesian)
                throw new Exception("Tikz_Coord.SetCartesian should only be called for valid cartesian coordinates");
            uX.SetInCM(x);
            uY.SetInCM(y);
        }

    }

    /// <summary>
    /// This class represents (guess what) a number and a unit.
    /// </summary>
    public class Tikz_NumberUnit
    {
        public Tikz_NumberUnit(ITree t)
        {
            try
            {
                number = Double.Parse(t.GetChild(0).Text);
            }
            catch (FormatException)
            {
                unit = "";
            }
            
            if (t.ChildCount > 1)
                unit = t.GetChild(1).Text.Trim();
            else unit = "";
        }
        public Tikz_NumberUnit()
        {
        }
        private double _number=0;
        public double number
        {
            get { return _number; }
            set
            {
                _number = Math.Round(value, (int)Properties.Settings.Default.RoundToDecimals);
            }
        }
        public string unit="";
        public override string ToString()
        {
            return number.ToString() + unit;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="defaultunit">Tells how a missing unit is interpreted.</param>
        /// <returns></returns>
        public double GetInCM(string defaultunit="cm")
        {
            string cunit = unit;
            if (cunit == "")
                cunit = defaultunit;
            switch (cunit)
            {
                //case "":
                case "cm":
                    return number;
                case "in":
                    return number * Consts.cmperin;
                case "mm":
                    return number /10;
                case "pt":
                    return number / Consts.ptspertikzunit;
                case "em":
                    return number * Consts.cmperem;
                case "ex":
                    return number * Consts.cmperex;
                default:
                    //error
                    throw new Exception("Tikz_Numberunit: unknown unit, value queried.");
                    //return 0;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <param name="defaultunit">The unit to be assumed if no unit specified.</param>
        public void SetInCM(double val, string defaultunit = "cm")
        {
            string cunit = unit;
            if (cunit == "")
                cunit = defaultunit;
            switch (cunit)
            {
                //case "":
                case "cm":
                    number = val;
                    break;
                case "in":
                    number = val / Consts.cmperin;
                    break;
                case "mm":
                    number = val * 10;
                    break;
                case "pt":
                    number = val * Consts.ptspertikzunit;
                    break;
                case "em":
                    number = val / Consts.cmperem;
                    break;
                case "ex":
                    number = val / Consts.cmperex;
                    break;
                default:
                    //error 
                    number = val;
                    break;
            }            
        }
    }

    /// <summary>
    /// This is the base class for all parse tree nodes which may have children.
    /// The important properties are starttag and endtag.
    /// The textblock in the code that such a node represents has the form 
    /// starttag + child1.ToString() + ... + childn.ToString() + endtag = ToString()
    /// </summary>
    public class TikzContainerParseItem : TikzParseItem
    {
        public string starttag = "", endtag = "";
        public List<TikzParseItem> Children = new List<TikzParseItem>();

        /// <summary>
        /// A reference to the options of this element, or null if there are none.
        /// Note that the options additionally appear as a child object of type Tikz_Options
        /// </summary>
        public Tikz_Options options;

        public override int Length 
        {
            get
            {
                int ret = 0;
                foreach (TikzParseItem tpi in Children)
                    ret += tpi.Length;
                return ret;
            }
        }
        /// <summary>
        /// Returns an estimate for the Bounding Box of the container.
        /// In fact, it simply returns the smallest rectangle around all occuring coordinates in children.
        /// </summary>
        /// <param name="r">Will hold the rectangle upon return.</param>
        /// <returns></returns>
        public override bool GetBB(out Rect r)
        {
            bool hasone = false;
            r = new Rect(0, 0, 0, 0);
            foreach (TikzParseItem tpi in Children)
            {
                Rect rr;
                if (tpi.GetBB(out rr))
                {
                    if (!hasone)
                    {
                        r = rr;
                        hasone = true;
                    }
                    else
                        r.Union(rr);
                }
            }
            return hasone;
        }
        /// <summary>
        /// Called in repsonse to RegisterNodeAndStyleRefs by its children
        /// </summary>
        /// <param name="tn"></param>
        public virtual void AddNodeRef(Tikz_Node tn)
        {
            if (parent != null)
                parent.AddNodeRef(tn);
        }
        /// <summary>
        /// Called in repsonse to Registernoderefs by its children
        /// </summary>
        /// <param name="tn"></param>
        public virtual void AddStyleRef(Tikz_Option to)
        {
            if (parent != null)
                parent.AddStyleRef(to);
        }

        /// <summary>
        /// Causes all nodes among the children to register their names at the tikz_picture (so that they can be found when referenced by name somewhere)
        /// </summary>
        public override void RegisterNodeAndStyleRefs()
        {
            foreach (TikzParseItem tpi in Children)
                tpi.RegisterNodeAndStyleRefs();
        }

        /// <summary>
        /// This should be called instead of adding nodes to Children directly
        /// </summary>
        /// <param name="tpi"></param>
        public void AddChild(TikzParseItem tpi, bool InsertAsFirst=false)
        {
            tpi.parent = this;
            if (InsertAsFirst)
                Children.Insert(0, tpi);
            else
                Children.Add(tpi);
            // raise event
            RaiseTextChanged(tpi, "");
        }
        public void InsertChildAt(TikzParseItem tpi, int position)
        {
            tpi.parent = this;
            Children.Insert(position, tpi);
            // raise event
            RaiseTextChanged(tpi, "");
        }

        /// <summary>
        /// This method is used by the children of this parse-node to query for a certain tik-node by name.
        /// This is used concretely by a Tikz_Coord, with a reference to some node as coordinate,
        /// in order to determine its absolute position.
        /// The query is answered by the Tikz_Picture object, which overrides this method
        /// </summary>
        /// <param name="tname">The name of the Tikz-node.</param>
        /// <returns>A reference to the Tikz_Node object representing that Tikz-node, or null if none was found.</returns>
        public virtual Tikz_Node GetNodeByName(string tname)
        {
            if (parent != null)
                return parent.GetNodeByName(tname);
            else return null;
        }

      /*  public TikzMatrix GetCurrentTransform()
        {
            TikzMatrix M;
            //M = Tikz_Options.GetTransform(this);
            if (options != null)
                M = options.GetTransform();
            else
                M = new TikzMatrix();
            if (parent != null)
                M = parent.GetCurrentTransform() * M;
            return M;
        } */
        /// <summary>
        /// Determines the coordinate transformation at object childtpi,
        /// or at the end of the container in case childtpi is null.
        /// </summary>
        /// <param name="childtpi">The object to determine coordinate trsf. at.</param>
        /// <returns>The coordinate transformation.</returns>
        public bool GetCurrentTransformAt(TikzParseItem childtpi, out TikzMatrix M)
        {
            if (parent != null)
            {
                if (!parent.GetCurrentTransformAt(this, out M))
                    return false;
            }
            else
                M = new TikzMatrix(); // identity matrix

            foreach (TikzParseItem tpi in Children)
            {
                if (tpi == childtpi && childtpi != null)
                {
                    break;
                }
                else if (tpi is Tikz_Options)
                {
                    TikzMatrix MM;
                    if ((tpi as Tikz_Options).GetTransform(out MM))
                        M = M * MM;
                    else
                        return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string s = starttag;
            //if (options != null)
            //    s = s + options.ToString();
            foreach (TikzParseItem t in Children)
            {
                s = s + t.ToString();
            }
            return s + endtag;
        }

        public int GetLengthBefore(TikzParseItem tpi)
        {
            int pos = 0;
            if (parent != null)
                pos = parent.GetLengthBefore(this);
            pos += starttag.Length;
            //if (options != null)
            //    pos += options.ToString().Length;
            
            foreach (TikzParseItem t in Children)
            {
                if (t == tpi)
                    break;
                else 
                    pos += t.ToString().Length;
            }
            return pos;
        }

        public override void UpdateText()
        {
            if (options != null)
                options.UpdateText();
            foreach (TikzParseItem t in Children)
            {
                t.UpdateText();
            }
        }

        public override string ToStringEx()
        {
            string s = starttag + "\r\n";
            foreach (TikzParseItem t in Children)
            {
                s = s + "     " + t.ToString();
            }

            return (GetType().ToString() + ":   " + s + endtag + "\r\n");
        }
    }

    /// <summary>
    /// This is a container for the control points used to define bezier curves.
    /// There can be either one or two
    /// </summary>
    public class Tikz_Controls : TikzContainerParseItem
    {
        /// <summary>
        /// The start point of the Bezier curve
        /// </summary>
        public Tikz_Coord CoordBefore
        {
            get
            {
                for (int i = parent.Children.IndexOf(this) - 1; i >= 0; i--)
                {
                    if (parent.Children[i] is Tikz_Coord)
                        return parent.Children[i] as Tikz_Coord;
                    if (!(parent.Children[i] is Tikz_Something))
                        break;
                }
                return null;
            }
        }
        /// <summary>
        /// The endpoint of the Bezier curve
        /// </summary>
        public Tikz_Coord CoordAfter
        {
            get
            {
                for (int i = parent.Children.IndexOf(this) + 1; i < parent.Children.Count; i++)
                {
                    if (parent.Children[i] is Tikz_Coord)
                        return parent.Children[i] as Tikz_Coord;
                    if (!(parent.Children[i] is Tikz_Something))
                        break;
                }
                return null;
            }
        }

        public IEnumerable<Tikz_Coord> ControlPoints
        {
            get 
            {
                return Children.Where(tpi => (tpi is Tikz_Coord)).Cast<Tikz_Coord>();
            }
        }

        public Tikz_Coord FirstCP
        {
            get { return Children.First(tpi => (tpi is Tikz_Coord)) as Tikz_Coord; }
        }
        public Tikz_Coord LastCP
        {
            get { return Children.Last(tpi => (tpi is Tikz_Coord)) as Tikz_Coord; }
        }

    }

    /// <summary>
    /// This class represents the root of the parse tree.
    /// This class raises events when the text of some child obeject changes.
    /// Furthermore, it maintains a list of Tikz-styles.
    /// </summary>
    public class Tikz_ParseTree : TikzContainerParseItem
    {
        public Dictionary<string, Tikz_Option> styles = new Dictionary<string,Tikz_Option>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">The node whose text has changed.</param>
        /// <param name="oldtext">The old text of the node.</param>
        public delegate void TextChangedHandler(TikzParseItem sender, string oldtext);
        /// <summary>
        /// This event is called whenever the text of any node in this parsetree changes.
        /// </summary>
        public event TextChangedHandler TextChanged;

        public override void RaiseTextChanged(TikzParseItem sender, string oldtext)
        {
            if (TextChanged != null)
                TextChanged(sender, oldtext);
            //base.RaiseTextChanged(sender, oldtext);
        }

        /// <summary>
        /// This is called by child-nodes in the parse-tree, in response to a call of RegisterNodeAndStyleRefs().
        /// </summary>
        /// <param name="to">The Tikz_Option representing a style that wants to register itself in the list.</param>
        public override void  AddStyleRef(Tikz_Option to)
        {
 	         if (!styles.ContainsKey(to.key))
                 styles[to.key]= to;
        }

        /// <summary>
        /// Returns a reference to the first Tikz_Picture object in this tree.
        /// (There should be only one, ... but who knows.)
        /// </summary>
        /// <param name="tc"></param>
        /// <returns></returns>
        public Tikz_Picture GetTikzPicture()
        {
            return GetTikzPicture(this);
        }
        Tikz_Picture GetTikzPicture(TikzContainerParseItem tc)
        {            
            foreach (TikzParseItem tpi in tc.Children)
            {
                if (tpi is Tikz_Picture)
                    return (tpi as Tikz_Picture);
                if (tpi is TikzContainerParseItem)
                {
                    Tikz_Picture ret = GetTikzPicture(tpi as TikzContainerParseItem);
                    if (ret != null)
                        return ret;
                }
            }
            return null;
        }
    }

    //public class Tikz_Draw : TikzContainerParseItem
    //{

    //}

    /// <summary>
    /// This class represents the Tikz-Picture.
    /// It maintains a list of node names, with references to the apprpriate Tikz_Node objects.
    /// This list is queried by Tikz_Coordinate objects with coordinates relative to those nodes.
    /// </summary>
    public class Tikz_Picture : TikzContainerParseItem
    {
        public Dictionary<string, Tikz_Node> nodelist = new Dictionary<string, Tikz_Node>();
        public override Tikz_Node GetNodeByName(string tname)
        {
            if (nodelist.ContainsKey(tname))
                return nodelist[tname];
            else
                return null;
        }
        public override void AddNodeRef(Tikz_Node tn)
        {
            nodelist[tn.name] = tn;
        }

        public string GetUniqueName()
        {
            string prefix="v";
            for (int i = 1; i < 1000; i++)
                if (!nodelist.ContainsKey(prefix + i))
                    return prefix + i;
            return "null";
        }
    }

    /// <summary>
    /// This class represents a Tikz path command.
    /// </summary>
    public class Tikz_Path : TikzContainerParseItem
    {
        /// <summary>
        /// Gets the offset, i.e., the current drawing position at some
        /// position along the path. (in absolute Cartesian coordinates)
        /// This is used to determine the absoulte position of nodes specified with relative 
        /// coordinates like +(1,1).
        /// </summary>
        /// <param name="tpi">The node just before which the current drawing position is to be determined.</param>
        /// <returns>True, if offset could be determined, false otherwise.</returns>
        public bool GetAbsOffset(out Point ret, TikzParseItem tpi)
        {
            Tikz_XYItem tcret;
            if (GetLastDrawnItem(tpi, out tcret))
            {
                // last drawn item exists
                TikzMatrix M2, M1;
                if (!GetCurrentTransformAt(tpi, out M2) || !tcret.parent.GetCurrentTransformAt(tcret, out M1))
                {
                    ret = new Point(0, 0);
                    return false;
                }
                Point p1;
                if (tcret.GetAbsPos(out p1))
                {
                    // p1 = M2 * orig point; offset = M1 * orig point (I guess) => offset = M1 * I(M2) * p1
                    ret = (M2 * (M1.Inverse())).Transform(p1);
                    return true;
                }
                else
                {
                    ret = new Point(0, 0);
                    return false;
                }
            }
            else
            {
                // no item was drawn before.... take origin (...after coord transform)
                TikzMatrix M;
                if (!GetCurrentTransformAt(tpi, out M))
                {
                    ret = new Point(0, 0);
                    return false;
                }
                ret = M.Transform(new Point(0, 0));
                return true;
            }
            /*int ind = Children.IndexOf(tpi);
                        Tikz_Coord previous = null;
                        for (int i = ind - 1; i >= 0; i--)
                        {
                            if (Children[i] is Tikz_Coord)
                            {
                                Tikz_Coord tc = Children[i] as Tikz_Coord;

                                if (tc.type == Tikz_CoordType.Named || tc.deco != "+")
                                {
                                    previous = tc;
                                    break;
                                }
                            }
                        }
                        if (previous == null)
                            return GetCurrentTransformAt(tpi).Transform(new Point(0,0));
                        else 
                            return previous.GetAbsPos(); */
        }

        /// <summary>
        /// Get the last item that changes the "current position" in a tikz path.
        /// This implememntation is not yet entirely accurate at present.... for example  ... edge (v) .. does not change the current position.
        /// </summary>
        /// <param name="before">The item before which we should search.</param>
        /// <param name="ret">The last item that changed the current position.</param>
        /// <returns></returns>
        bool GetLastDrawnItem(TikzParseItem before, out Tikz_XYItem ret)
        {
            int ind;
            if (before == null)
                ind = Children.Count;
            else
                ind = Children.IndexOf(before);

            //CoordTrafoInBetween = new TikzMatrix();
            for (int i = ind - 1; i >= 0; i--)
            {
                if (Children[i] is Tikz_Coord)
                {
                    Tikz_Coord tc = Children[i] as Tikz_Coord;

                    if (tc.type == Tikz_CoordType.Named || tc.deco != "+")  
                    {
                        ret = tc;
                        return true;
                    }
                }
                else if (Children[i] is Tikz_Arc)
                {
                    ret = Children[i] as Tikz_Arc;
                    return true;
                }
                //else if (Children[i] is Tikz_Options)
                //{
                //    CoordTrafoInBetween = (Children[i] as Tikz_Options).GetTransform() * CoordTrafoInBetween;
                //}
                else if (Children[i] is Tikz_Path)
                {
                    Tikz_Path tp = (Children[i] as Tikz_Path);
                    Tikz_XYItem tpi;
                    //TikzMatrix M; // not used here
                    bool lret = tp.GetLastDrawnItem(null, out tpi);
                    if (lret)
                    {
                        ret = tpi;
                        return true;
                    }
                }
            }

            // nothing found -> look in parent
            if (this.parent is Tikz_Path)
            {
                Tikz_Path tparent = parent as Tikz_Path;
                Tikz_XYItem tpi;
                if (tparent.GetLastDrawnItem(this, out tpi))
                {
                    ret = tpi;
                    return true;
                }
            }

            // if we come here, nothing has been found...
            ret = null;
            return false;
        }

    }

    public class Tikz_Scope : TikzContainerParseItem
    {
        /// <summary>
        /// This method determines the coord transform that should be used for rasterizing the scope's
        /// shift. Note that this is tricky since a scope per se does not have an anchor point.
        /// We take here as anchor point (i.e., the image of (0,0) under returned coord transformation)
        /// the transformed origin of the coordinate system at the position of the editable option shift=...
        /// that determines the scope's position.
        /// </summary>
        /// <param name="ret"></param>
        /// <returns></returns>
         public bool GetRasterTransform(out TikzMatrix ret)
         {
             if (options != null)
                 return options.GetTransformAtEditableShift(out ret);
             else
                 return parent.GetCurrentTransformAt(this, out ret);
         }
    }

    public enum Tikz_OptionType { keyval, key, style }
    public class Tikz_Option : TikzParseItem
    {
        public Tikz_OptionType type;

        public string key, val;        // for style, key is the style's name, val is the style definition
        public Tikz_Coord coordval;    // this is used for shift={(3,3)} option
        public Tikz_NumberUnit numval; // only one of val, numval, coordval should be not null
       /* public static string GetID(ITree t)
        {
            if (t.ChildCount <= 0)
                return "";
            string s = "";
            for (int i=0;i<t.ChildCount;i++)                
                s = s + " " + t.GetChild(i).Text;
            return s.Remove(0,1); // remove leading space
        } */
        public static Tikz_Option FromCommonTree(ITree t, CommonTokenStream tokens)
        {
            Tikz_Option to = new Tikz_Option();
            switch (t.Type)
            {
                case simpletikzParser.IM_OPTION_KV:
                    if (t.ChildCount == 1)
                    {
                        to.type = Tikz_OptionType.key;
                        to.key = TikzParser.getTokensString(tokens, t.GetChild(0));
                        return to;
                    }
                    else if (t.ChildCount == 2)
                    {
                        to.type = Tikz_OptionType.keyval;
                        to.key = TikzParser.getTokensString(tokens, t.GetChild(0));
                        if (t.GetChild(1).Type == simpletikzParser.IM_NUMBERUNIT)
                            to.numval = new Tikz_NumberUnit(t.GetChild(1));
                        else if (t.GetChild(1).Type == simpletikzParser.IM_COORD)
                            to.coordval = Tikz_Coord.FromCommonTree(t.GetChild(1), tokens);
                        else
                            to.val = TikzParser.getTokensString(tokens, t.GetChild(1));
                        return to;
                    }
                    else
                    {
                        throw new Exception("The parser seems to have returned an invalid parsetree: invalid number of children of IM_OPTION_KV node");
                        //return null;
                    }
                case simpletikzParser.IM_OPTION_STYLE:
                    if (t.ChildCount < 1)
                        return null;
                    else
                    {
                        to.type = Tikz_OptionType.style;
                        to.key = TikzParser.getTokensString(tokens, t.GetChild(0));
                        to.val = "";// GetID(t.GetChild(1)); // hack
                        return to;
                    }
                case simpletikzParser.IM_STYLE:
                    to.type = Tikz_OptionType.style;
                    to.key = TikzParser.getTokensString(tokens, t.GetChild(0));
                    to.val = t.GetChild(1).Text;  // hack,... but irrelevant 
                    return to;
                default:
                    return null; // error
            }
        }

        public override void UpdateText()
        {
            string newtext="";
            switch (type)
            {
                case Tikz_OptionType.key:
                    newtext = key;
                    break;
                case Tikz_OptionType.keyval:
                    newtext = key + "=";
                    if (numval != null)                    
                        newtext = newtext + numval.ToString();
                    else if (coordval != null)
                    {
                        coordval.UpdateText();
                        newtext = newtext + "{" + coordval.text + "}";
                    }
                    else
                        newtext = newtext + val;
                    
                    break;
                case Tikz_OptionType.style:
                    newtext = key + "/.style=" + val;
                    break;
            }
            text = newtext;
        }
    }

    public class Tikz_Options : TikzContainerParseItem
    {
        //public List<Tikz_Option> options = new List<Tikz_Option>();

       // public static Tikz_Options FromCommonTree(CommonTree t)
       // {
            // IM_NODE OPTIONS? nodename? coord? STRING
       //     Tikz_Options opts = new Tikz_Options();
       //     foreach (CommonTree tt in t.Children)
       //     {
       //         Tikz_Option to = Tikz_Option.FromCommonTree(tt);
       //         if (to != null)
       //             opts.options.Add(to);
       //     }

       //     return opts;
       // }
    /*    public static TikzMatrix GetTransform(TikzContainerParseItem tcpi)
        {
            TikzMatrix ret = new TikzMatrix();

            double scale = 1, xshift = 0, yshift = 0;

            Tikz_Option o = GetOption(tcpi, "xshift", Tikz_OptionType.keyval);
            if (o != null)
                if (o.numval != null)
                    xshift = o.numval.GetInCM();
            o = GetOption(tcpi, "yshift", Tikz_OptionType.keyval);
            if (o != null)
                if (o.numval != null)
                    yshift = o.numval.GetInCM();
            o = GetOption(tcpi, "scale", Tikz_OptionType.keyval);
            if (o != null)
                if (o.numval != null)
                    scale = o.numval.GetInCM();
            ret.m[0, 0] = scale;
            ret.m[1, 1] = scale;
            ret.m[0, 2] = xshift;
            ret.m[1, 2] = yshift;
            return ret;
        } */

        /// <summary>
        /// Gets the total coordinate transformation that is encoded in this options block.
        /// How this apparently works in Tikz is as follows: 
        /// (determined by trial and error rather than specification, so hope for the best...)
        ///     - for each relevant option (shift, xshift, yshift, scale, xscale, yscale) a separate transformation is produced
        ///     - all those transformations are multiplied
        /// </summary>
        /// <returns></returns>
        public bool GetTransform(out TikzMatrix ret)
        {
            ret = new TikzMatrix();  // start with unit matrix
            foreach (TikzParseItem tpi in Children)
            {
                if (tpi is Tikz_Option)
                {
                    Tikz_Option to = tpi as Tikz_Option;
                    if (!TransformFromOption(to, ret, out ret))
                        return false;
                }
            }
            return true;
            /*
            double scale=1, xshift=0, yshift=0, xscale=1, yscale=1;

            Tikz_Option o = GetOption("xshift", Tikz_OptionType.keyval);
            if (o != null)
                if (o.numval != null)
                    xshift = o.numval.GetInCM("pt");
            o = GetOption("yshift", Tikz_OptionType.keyval);
            if (o != null)
                if (o.numval != null)
                    yshift = o.numval.GetInCM("pt");
            o = GetOption("scale", Tikz_OptionType.keyval);
            if (o != null)
                if (o.numval != null)
                   scale = o.numval.GetInCM();
            o = GetOption("xscale", Tikz_OptionType.keyval);
            if (o != null)
                if (o.numval != null)
                    xscale = o.numval.GetInCM();
            o = GetOption("yscale", Tikz_OptionType.keyval);
            if (o != null)
                if (o.numval != null)
                    yscale = o.numval.GetInCM();
            ret.m[0, 0] = scale * xscale;
            ret.m[1, 1] = scale * yscale;
            ret.m[0, 2] = xshift;
            ret.m[1, 2] = yshift; */
            //return ret;
        }

        /// <summary>
        /// Returns the coordinate transfor corresponding to an option, if possible.
        /// If the option is not relevant for coordinate tranformation (or not supported), true is returned 
        /// and newTrafo = oldTrafo. If the option is recognized, but the value cannot be determined,
        /// false is returned and newTrafo shouldn't be used.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="oldTrafo"></param>
        /// <param name="newTrafo"></param>
        /// <returns></returns>
        bool TransformFromOption(Tikz_Option to, TikzMatrix oldTrafo, out TikzMatrix newTrafo)
        {
            TikzMatrix ret = new TikzMatrix();
            newTrafo = ret;
            if (to.type == Tikz_OptionType.keyval)
            {
                switch (to.key.Trim())
                {
                    case "xscale":
                        if (to.numval == null)
                            return false;
                        ret.m[0, 0] = to.numval.GetInCM();
                        break;
                    case "yscale":
                        if (to.numval == null)
                            return false;
                        ret.m[1, 1] = to.numval.GetInCM();
                        break;
                    case "scale":
                        if (to.numval == null)
                            return false;
                        ret.m[0, 0] = to.numval.GetInCM();
                        ret.m[1, 1] = ret.m[0, 0];
                        break;
                    case "xshift":
                        if (to.numval == null)
                            return false;
                        ret.m[0, 2] = to.numval.GetInCM("pt");
                        break;
                    case "yshift":
                        if (to.numval == null)
                            return false;
                        ret.m[1, 2] = to.numval.GetInCM("pt");
                        break;
                    case "shift":
                        // shift is complicated.....
                        if (to.coordval == null)
                            return false;
                        if (to.coordval.type == Tikz_CoordType.Named)
                        {
                            // for named coord, shift sets the _absolute_ origin of the coord system
                            // hence we need the absolute coord trafo at the current point!
                            Point neworig;
                            if (!to.coordval.GetAbsPos(out neworig, this))
                                return false;

                            TikzMatrix Mabs;
                            if (!parent.GetCurrentTransformAt(this, out Mabs))
                                return false;

                            Mabs = Mabs * oldTrafo;
                            Point theshift = Mabs.Inverse().Transform(neworig);
                            ret.m[0, 2] = theshift.X;
                            ret.m[1, 2] = theshift.Y;

                        }
                        else if (to.coordval.type == Tikz_CoordType.Cartesian || to.coordval.type == Tikz_CoordType.Polar)
                        {
                            Point p = to.coordval.GetCartesian();
                            ret.m[0, 2] = p.X;
                            ret.m[1, 2] = p.Y;
                        }
                        else
                        {
                            // invalid coordinate value
                            return false;
                        }                        
                        break;
                    case "rotate":
                        if (to.numval == null)
                            return false;
                        double angle = to.numval.GetInCM() * 2* Math.PI / 360;
                        ret.m[0, 0] = Math.Cos(angle);
                        ret.m[1, 0] = Math.Sin(angle);
                        ret.m[0, 1] = -Math.Sin(angle);
                        ret.m[1, 1] = Math.Cos(angle);
                        break;
                    default:
                        // option not relevant for coordinate computation (or not supported) -> ignore
                        newTrafo = oldTrafo;
                        return true;
                }
            }
            // if we get here, the option was recognized as relevant for coordinate transf., and the value could be read
            newTrafo = oldTrafo * ret;
            return true;
        }
        /// <summary>
        /// Adds the specified amounts to the current xshift and yshift.
        /// Note that this might be complicated since the coord transf. can be encoded as, e.g.
        /// [xshift=1cm, scale=2, xshift=-3cm, scale=-1, shift={(45:1)}]
        /// Which shift should we change? Where should we insert a yshift?
        /// 
        /// The policy is as follows:
        ///     (i)  change the first occuring _cartesian_ "shift=..." item if present.
        ///     (ii) if not present, add a shift=... to the end.
        ///     
        /// Keep in mind that we also want to support rotations.... 
        /// Todo: check whether ambient coord transform is taken into account...
        /// </summary>
        /// <param name="xshift"></param>
        /// <param name="yshift"></param>
        public void SetShiftRel(double xshift, double yshift)
        {
            TikzMatrix curTrafo;
            Tikz_Option EditableShift;
            if (!GetTransformAtEditableShift(out curTrafo, out EditableShift))
                return;

            if (EditableShift == null)
            {
                // We need to add a new shift=... option
                Point theshift = curTrafo.Inverse().Transform(new Point(xshift, yshift), true);
                Tikz_Option topt = new Tikz_Option();
                topt.type = Tikz_OptionType.keyval;
                topt.key = "shift";
                topt.coordval = new Tikz_Coord();
                topt.coordval.type = Tikz_CoordType.Cartesian;
                topt.coordval.SetCartesian(theshift.X, theshift.Y);
                AddOption(topt);
            }
            else
            {
                // We already have a suitable shift=... -option, add shift 
                Point oldshift = EditableShift.coordval.GetCartesian();
                Point shifttoadd = curTrafo.Inverse().Transform(new Point(xshift, yshift), true);

                EditableShift.coordval.SetCartesian(oldshift.X + shifttoadd.X, oldshift.Y + shifttoadd.Y);
                EditableShift.UpdateText();
                return;
            }

            /*= new TikzMatrix();     // stores the coord trsf. at current position
            if (!parent.GetCurrentTransformAt(this, out curTrafo))
                return;
            //bool foundone = false;
            foreach (TikzParseItem tpi in Children)
            {
                if (tpi is Tikz_Option)
                {
                    Tikz_Option to = tpi as Tikz_Option;

                    if (to.type == Tikz_OptionType.keyval && to.key.Trim() == "shift")
                    {
                        if (to.coordval == null)
                            return;
                        if (to.coordval.type == Tikz_CoordType.Cartesian)
                        {
                            // we found one (yoohoo), set the shift accordingly and exit
                            Point oldshift = to.coordval.GetCartesian();
                            Point shifttoadd = curTrafo.Inverse().Transform(new Point(xshift, yshift), true);

                            to.coordval.SetCartesian(oldshift.X + shifttoadd.X, oldshift.Y + shifttoadd.Y);
                            to.UpdateText();
                            return;
                        }
                    }

                    if (!TransformFromOption(to, curTrafo, out curTrafo))
                        return; // invalid coord trafo encountered -> do nothing
                }
            }
             */

            // When we get here, nothing was found -> add new shift=... at the end

            
            
            //if (!foundone)
            //{

            //}
            
            /*if (xshift != 0)
            {

                Tikz_Option o = GetOption("xshift", Tikz_OptionType.keyval);
                if (o == null)
                {
                    o = new Tikz_Option();
                    o.type = Tikz_OptionType.keyval;
                    o.key = "xshift";
                    o.numval = new Tikz_NumberUnit();
                    o.numval.unit = "cm";
                    o.numval.SetInCM(xshift);
                    AddOption(o);
                }
                else
                {
                    o.numval.SetInCM(o.numval.GetInCM() + xshift, "pt");
                    o.UpdateText();
                }
            }
            if (yshift != 0)
            {
                Tikz_Option o = GetOption("yshift", Tikz_OptionType.keyval);
                if (o == null)
                {
                    o = new Tikz_Option();
                    o.type = Tikz_OptionType.keyval;
                    o.key = "yshift";
                    o.numval = new Tikz_NumberUnit();
                    o.numval.unit = "cm";
                    o.numval.SetInCM(yshift);
                    AddOption(o);
                }
                else
                {
                    o.numval.SetInCM(o.numval.GetInCM() + yshift, "pt");
                    o.UpdateText();
                }
            } */
        }

        /// <summary>
        /// It returns, if possible, the coordinate transformation at the shift=... option that will
        /// be editted by SetShiftRel(). This method is in particular used by PdfOverlay to draw the raster associated 
        /// to a scope object. 
        /// </summary>
        /// <param name="ret"></param>
        /// <returns>true on success, false if coord trafo could not be determined</returns>
        public bool GetTransformAtEditableShift(out TikzMatrix ret)
        {
            Tikz_Option dummy;
            return GetTransformAtEditableShift(out ret, out dummy);
        }
        /// <summary>
        /// Same as above, but additionally the editable shift is returned.
        /// (or null if a new one needs to be created)
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="EditableShift"></param>
        /// <returns></returns>
        bool GetTransformAtEditableShift(out TikzMatrix ret, out Tikz_Option EditableShift)
        {
            ret = new TikzMatrix();     // stores the coord trsf. at current position
            EditableShift = null;
            if (!parent.GetCurrentTransformAt(this, out ret))
                return false;
            //bool foundone = false;
            foreach (TikzParseItem tpi in Children)
            {
                if (tpi is Tikz_Option)
                {
                    Tikz_Option to = tpi as Tikz_Option;

                    if (to.type == Tikz_OptionType.keyval && to.key.Trim() == "shift")
                    {
                        if (to.coordval == null)
                            return false;
                        if (to.coordval.type == Tikz_CoordType.Cartesian)
                        {
                            // we found one (yoohoo)
                            EditableShift = to;
                            return true;
                        }
                    }

                    if (!TransformFromOption(to, ret, out ret))
                        return false; // invalid coord trafo encountered -> report failure
                }
            }

            EditableShift = null;   // nothing found -> return null
            return true;
        }

   /*     public static void SetShiftRel(TikzContainerParseItem tcpi, double xshift, double yshift)
        {
            if (xshift != 0)
            {
                Tikz_Option o = GetOption(tcpi, "xshift", Tikz_OptionType.keyval);
                if (o == null)
                {
                    o = new Tikz_Option();
                    o.type = Tikz_OptionType.keyval;
                    o.key = "xshift";
                    o.numval = new Tikz_NumberUnit();
                    o.numval.unit = "cm";
                    o.numval.SetInCM(xshift);
                    AddOption(tcpi, o);
                }
                else
                {
                    o.numval.SetInCM(o.numval.GetInCM() + xshift);
                    o.UpdateText();
                }
            }
            if (yshift != 0)
            {
                Tikz_Option o = GetOption(tcpi, "yshift", Tikz_OptionType.keyval);
                if (o == null)
                {
                    o = new Tikz_Option();
                    o.type = Tikz_OptionType.keyval;
                    o.key = "yshift";
                    o.numval = new Tikz_NumberUnit();
                    o.numval.unit = "cm";
                    o.numval.SetInCM(yshift);
                    AddOption(tcpi, o);
                }
                else
                {
                    o.numval.SetInCM(o.numval.GetInCM() + yshift);
                    o.UpdateText();
                }
            }
        } */

        public static Tikz_Option GetOption(TikzContainerParseItem tcpi, string optionname, Tikz_OptionType type)
        {
            Tikz_Option to = null;
            foreach (TikzParseItem tpi in tcpi.Children)
            {
                if (tpi is Tikz_Options)
                {
                    Tikz_Option o = (tpi as Tikz_Options).GetOption(optionname, type);
                    if (o != null)
                        to = o;
                }
            }
            return to;
        }

        public Tikz_Option GetOption(string optionname, Tikz_OptionType type)
        {
            foreach (TikzParseItem tpi in Children)
            {
                if (tpi is Tikz_Option)
                {
                    Tikz_Option s = tpi as Tikz_Option;
                    if (s.type == type && s.key.Trim() == optionname)
                        return s;
                }
            }
           // foreach (Tikz_Option s in options)
           //     if (s.type == type && s.key.Trim() == optionname)
           //         return s;

            return null;
        }

        public int OptionsCount()
        {
            int ret = 0;
            foreach (TikzParseItem tpi in Children)            
                if (tpi is Tikz_Option)
                    ret++;
             
            return ret;
        }

        public Tikz_Option AddOption(string key)
        {
            Tikz_Option to = new Tikz_Option();
            to.type = Tikz_OptionType.key;
            to.key = key;
            AddOption(to);
            return to;
        }
        public Tikz_Option AddOption(string key, string value)
        {
            Tikz_Option to = new Tikz_Option();
            to.type = Tikz_OptionType.keyval;
            to.key = key;
            to.val = value;
            AddOption(to);
            return to;
        }

        public void AddOption(Tikz_Option o)
        {
            if (OptionsCount() > 0)
            {
                Tikz_Something komma = new Tikz_Something(", ");                
                AddChild(komma);
            }
            o.UpdateText();
            AddChild(o);
        }

        public static void AddOption(TikzContainerParseItem tcpi, Tikz_Option o)
        {
            if (tcpi.options == null)
            {
                Tikz_Options topts = new Tikz_Options();
                tcpi.AddChild(topts, true);
                tcpi.options = topts;
            }

            tcpi.options.AddOption(o);
        }
        //public override void UpdateText()
        //{
        //    string[] opts = new string[options.Count];
        //    for (int i = 0; i < options.Count; i++)
        //    {
        //        options[i].UpdateText();
        //        opts[i] = options[i].text;
        //    }
        //    text = "[" + String.Join(", ", opts) + "]";
        //}
    }

    /// <summary>
    /// The class for path elements of the form "arc (30:60:2)" or arc "arc (30:60:2 and 4)"
    /// </summary>
    class Tikz_Arc : Tikz_XYItem
    {
        Tikz_NumberUnit phi1 = null, phi2=null, r1 = null, r2 = null;

        /// <summary>
        /// This flag will be set when the coordinates cannot be determined, either because
        /// of erroneous Tikz code or unsupported operations (math expressions, macros etc.)
        /// </summary>
        bool IsBroken = false;

        /// <summary>
        /// The Treenode t must have either 3 or four children
        /// </summary>
        /// <param name="t"></param>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public static Tikz_Arc FromCommonTree(ITree t, CommonTokenStream tokens)
        {
            Tikz_Arc ta = new Tikz_Arc();
            if (t.ChildCount != 3 && t.ChildCount != 4)
            {
                throw new Exception("Parser returned invalid IM_ARC node.");
            }

            // if one of the children is not of type numberunit (i.e., math expression etc.), then the present arc will be marked invalid
            for (int i = 0; i < t.ChildCount; i++)
                if (t.GetChild(i).Type != simpletikzParser.IM_NUMBERUNIT)
                    ta.IsBroken = true;

            if (!ta.IsBroken)
            {
                ta.phi1 = new Tikz_NumberUnit(t.GetChild(0));
                ta.phi2 = new Tikz_NumberUnit(t.GetChild(1));
                ta.r1 = new Tikz_NumberUnit(t.GetChild(2));
                if (t.ChildCount == 4)
                {
                    ta.r2 = new Tikz_NumberUnit(t.GetChild(3));
                }
            }
            return ta;
        }

        public override bool GetAbsPos(out Point ret, bool OnlyOffset = false)
        {
            ret = new Point(0, 0);
            if (IsBroken)                       
                return false;
            
            // get the offset (=starting point of arc)
            Point offset;
            if (!(parent as Tikz_Path).GetAbsOffset(out offset, this))
                return false;

            if (OnlyOffset)
            {
                ret = offset;
                return true;
            }

            // compute relative distance
            double R1 = r1.GetInCM(), R2=R1;
            double a1 = phi1.GetInCM()*2*Math.PI/360, a2 = phi2.GetInCM()*2*Math.PI/360;  // angles in radians
            if (r2 != null) // ellipse case
            {
                R2 = r2.GetInCM();
            }
            Point relp = new Point((Math.Cos(a2) - Math.Cos(a1)) * R1, (Math.Sin(a2) - Math.Sin(a1)) * R2);

            // Transform
            TikzMatrix M;
            if (!parent.GetCurrentTransformAt(this, out M))
                return false;
            relp = M.Transform(relp, true);

            ret = new Point(offset.X + relp.X, offset.Y + relp.Y);
            return true;
        }
        public override bool HasEditableCoordinate()
        {
            Point pdummy;
            return GetAbsPos(out pdummy);
        }
        public override void SetAbsPos(Point p)
        {
            if (IsBroken)
                return;
            if (r2 != null)
                return;     // currently unsupported

            // compute the starting point and desired shift
            Point offset;
            if (!(parent as Tikz_Path).GetAbsOffset(out offset, this))
                return;
            //Point relp = new Point(p.X-offset.X, p.Y-offset.Y);
            Vector relp = p - offset;
            // transform
            TikzMatrix M;
            if (!parent.GetCurrentTransformAt(this, out M))
                return;
            relp = M.Inverse().Transform(relp);
            
            // compute the new parameters
            // Note that there is some ambiguity since one would could change both radii and both angles
            // We keep the difference of angles the same, and change the radius
            // still there is a twofold ambiguity ...            
            double a1 = phi1.GetInCM() * 2 * Math.PI / 360, a2 = phi2.GetInCM() * 2 * Math.PI / 360, a=a2-a1;  // angles in radians

            double R = Math.Abs( .5 * relp.Length / Math.Sin(a / 2) );
            if (! (R < 50))
                return;

            Vector mid = relp / 2;
            Vector normal = new Vector(relp.Y, -relp.X);
            normal.Normalize();

            Vector c = mid + normal * Math.Cos(a/2) * R; // the new center

            // new angles
            double b1 = Math.Atan2((-c).Y, (-c).X), b2 = Math.Atan2((relp-c).Y, (relp-c).X);
            if (b2 - b1 > Math.PI)
                b2 = b2 - 2 * Math.PI;
            r1.SetInCM(R);
            phi1.SetInCM(b1 * 180 / Math.PI);
            phi2.SetInCM(b2 * 180 / Math.PI);
        }

        public override void UpdateText()
        {
            if (!IsBroken)
            {
                string newtext = "arc (" + phi1.GetInCM() + ":" + phi2.GetInCM() + ":" + r1.GetInCM();
                if (r2 != null)
                    newtext += " and " + r2.GetInCM();
                text = newtext + ")";   // there should only be one update to newtext since updates generate events
            }
        }

        public override bool IsPolar()
        {
            return false; // true;
        }
    }

}
