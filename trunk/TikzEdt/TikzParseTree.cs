using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;

using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace TikzEdt
{
   
    public class TikzMatrix
    {
        double[,] m = new double[2, 3];

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
        public double Det() { return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]; }
        public TikzMatrix Inverse()
        {
            TikzMatrix mi = new TikzMatrix();
            double d = Det();
            mi.m[0,0] = m[1, 1] / d;
            mi.m[1, 0] = -m[1, 0] / d;
            mi.m[0, 1] = -m[0, 1] / d;
            mi.m[1, 1] = m[0, 0] / d;

            mi.m[0, 2] = - mi.m[0,0] * mi.m[0,2] - mi.m[0,1]*mi.m[1,2];
            mi.m[1, 2] = - mi.m[1,0] * mi.m[0, 2] - mi.m[1, 1] * mi.m[1, 2];

            return mi;
        }
    }

    public class TikzParseItem
    {
        public TikzContainerParseItem parent;
        public string text = "";
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
        /// 
        /// </summary>
        /// <returns>Returns false if the item does not have a bounding box</returns>
        public virtual bool GetBB(out Rect r)
        {
            r = new Rect(0, 0, 0, 0);
            return false;
        }
        public virtual void RegisterNodeRefs()
        {
            if (this is Tikz_Node && parent != null)
                parent.AddNodeRef(this as Tikz_Node);
        }

        /// <summary>
        /// causes the object to update its text according to its contents
        /// </summary>
        public virtual void UpdateText() { }

        /// <summary>
        /// For testing
        /// </summary>
        public virtual string ToStringEx()
        {
            return (GetType().ToString() + ":   " + text + "\r\n");
        }

    }
    /// <summary>
    /// This item represents parts of the code that the parser does not understand
    /// or not care about, e. g., whitespace.
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
    /// <summary>
    /// Parse Item having an x and y coordinate
    /// </summary>
    public abstract class Tikz_XYItem : TikzParseItem
    {
        public double x, y;
        public abstract void SetPosition(Point p);
        public abstract Point GetAbsPos();
        public abstract void SetAbsPos(Point p);

        public override bool GetBB(out Rect r)
        {
            Point p = GetAbsPos();
            r = new Rect(p,p);
            return true;
        }
    }
    public class Tikz_Node : Tikz_XYItem
    {
        public static Tikz_Node FromCommonTree(CommonTree t)
        {
            // IM_NODE OPTIONS? nodename? coord? STRING
            Tikz_Node n = new Tikz_Node();
            int i = 0;
            if (t.GetChild(i).Type == simpletikzParser.OPTIONS)
            {
                n.options = t.GetChild(i++).Text;
            }
            if (t.GetChild(i).Type == simpletikzParser.IM_NODENAME)
            {
                n.name = t.GetChild(i++).GetChild(0).Text;
            }
            if (t.GetChild(i).Type == simpletikzParser.IM_COORD)
            {
                n.coord = Tikz_Coord.FromCommonTree(t.GetChild(i++));
                n.x = n.coord.uX.number; //hack
                n.y = n.coord.uY.number;
            }

            n.label = t.GetChild(i).Text.Trim();
            // remove leading and trailing {} TODO: to it in parser
            n.label = n.label.Substring(1, n.label.Length - 2);


            return n;
        }
        public void SetName(string tname)
        {
            name = tname;
            RegisterNodeRefs();
        }
        public override void SetPosition(Point p)
        {
            coord.SetPosition(p);
        }
        public override Point GetAbsPos()
        {
            if (coord == null)
            {
                return (parent as Tikz_Path).GetAbsOffset(this);
                //return new Point(0, 0);
            }
            else
            {
                return coord.GetAbsPos(this);
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
        public Tikz_Node(double tx, double ty)
        {
            x = tx; y = ty;
        }
        public override void UpdateText()
        {
            text = "node ";
            // if parent is a node, and this item is the first, do not print node again
            if (parent is Tikz_Path)
            {
                if (parent.starttag.Trim() == @"\node")
                {
                    // todo: check for first....
                    text = "";
                }
            }

            
            if (name != "")
                text = text + "(" + name + ") ";
            if (coord != null)
            {
                coord.UpdateText();
                text = text + "at " + coord.ToString() + " ";
            }
            text = text + "{" + label + "}";
        }
    }
    public enum Tikz_CoordType { Cartesian, Polar, Named }
    //public enum Tikz_CoordDeco { none, p, pp }
    public class Tikz_Coord : Tikz_XYItem
    {
        public static Tikz_Coord FromCommonTree(ITree t)
        {
            Tikz_Coord tc = new Tikz_Coord();
            if (t.ChildCount == 1 && t.GetChild(0).Type == simpletikzParser.IM_NODENAME) // named node 
            {
                tc.type = Tikz_CoordType.Named;
                tc.nameref = t.GetChild(0).GetChild(0).Text;
                return tc;
            }
            else if (t.ChildCount >= 2)
            {
                int i = 0;
                if (t.ChildCount == 3)
                {
                    tc.deco = t.GetChild(0).Text;
                    i = 1;
                }
                tc.uX = new Tikz_NumberUnit(t.GetChild(i));
                tc.uY = new Tikz_NumberUnit(t.GetChild(i + 1));

                tc.x = tc.uX.number; // hack
                tc.y = tc.uY.number;

                return tc;
            }

            return null;
        }
        public override void SetAbsPos(Point p)
        {
            SetAbsPos(p, this);
        }
        public void SetAbsPos(Point p, TikzParseItem relto)
        {
            if (type == Tikz_CoordType.Named)
            {
                // cannot change coord
            }
            else
            {
                Point relp; // will hold the new coordinates, in the current coordinate system
                if (deco == "+" || deco == "++")
                {
                    Point offset = (relto.parent as Tikz_Path).GetAbsOffset(relto);
                    relp = new Point(p.X - offset.X, p.Y - offset.Y);
                    relp = relto.parent.GetCurrentTransform().Inverse().Transform(relp, false);
                }
                else
                {
                    relp = relto.parent.GetCurrentTransform().Inverse().Transform(new Point(p.X, p.Y), true);
                }
                uX.SetInCM(relp.X);
                uY.SetInCM(relp.Y);
            }
        }

        public override Point GetAbsPos()
        {
            return GetAbsPos(this);
        }
        public Point GetAbsPos(TikzParseItem relto)
        {
            if (type == Tikz_CoordType.Named)
            {
                if (relto.parent == null)
                    return new Point(0, 0);
                Tikz_Node t = relto.parent.GetNodeByName(nameref);
                if (t == null)
                    return new Point(0, 0);
                else return t.GetAbsPos();
            }

            Point offset = new Point(0, 0);
            if (deco == "+" || deco == "++")
            {
                // determine offset
                if (relto.parent is Tikz_Path)
                    offset = (relto.parent as Tikz_Path).GetAbsOffset(relto);

                Point relpos = new Point(uX.GetInCM(), uY.GetInCM());
                if (relto.parent != null)
                    relpos = relto.parent.GetCurrentTransform().Transform(relpos, true);

                return new Point(offset.X + relpos.X, offset.Y + relpos.Y);
            }

            // std coordinate
            Point p = new Point(uX.GetInCM(), uY.GetInCM());
            if (relto.parent == null)
                return p;
            else return relto.parent.GetCurrentTransform().Transform(p);
        }
        public override void UpdateText()
        {
            text = deco + "(";
            switch (type)
            {
                case Tikz_CoordType.Named:
                    text = text + nameref;
                    break;
                case Tikz_CoordType.Polar:
                    text = text + uX.ToString() + ";" + uY.ToString();
                    break;
                case Tikz_CoordType.Cartesian:
                    text = text + uX.ToString() + "," + uY.ToString();
                    break;
            }
            text = text + ")";
        }

        public override void SetPosition(Point p)
        {
            uX.number = p.X;
            uY.number = p.Y;
            x = p.X; y = p.Y; //hack
        }

        public Tikz_CoordType type = Tikz_CoordType.Cartesian;
        public string deco = "";
        public Tikz_NumberUnit uX=new Tikz_NumberUnit(), uY=new Tikz_NumberUnit();
        public string nameref = ""; // name of vertex if coordinate is such a reference
        public Tikz_Coord() { }
        public Tikz_Coord(double tx, double ty)
        {
            x = tx; y = ty;
        }
    }
    public class Tikz_NumberUnit
    {
        public Tikz_NumberUnit(ITree t)
        {
            number = Double.Parse(t.GetChild(0).Text);
            if (t.ChildCount > 1)
                unit = t.GetChild(1).Text.Trim();
            else unit = "";
        }
        public Tikz_NumberUnit()
        {
        }
        public double number=0;
        public string unit="";
        public override string ToString()
        {
            return number.ToString() + unit;
        }
        public double GetInCM()
        {
            switch (unit)
            {
                case "":
                case "cm":
                    return number;
                case "in":
                    return number * Consts.cmperin;
                case "mm":
                    return 10 * number;
                default:
                    //error 
                    return 0;
            }

        }
        public void SetInCM(double val)
        {
            switch (unit)
            {
                case "":
                case "cm":
                    number = val;
                    break;
                case "in":
                    number = val / Consts.cmperin;
                    break;
                case "mm":
                    number = val / 10;
                    break;
                default:
                    //error 
                    number = val;
                    break;
            }
        }
    }
    public class TikzContainerParseItem : TikzParseItem
    {
        public string starttag = "", endtag = "";
        public List<TikzParseItem> Children = new List<TikzParseItem>();
        public Tikz_Options options;

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

        public virtual void AddNodeRef(Tikz_Node tn)
        {
            if (parent != null)
                parent.AddNodeRef(tn);
        }
        public override void RegisterNodeRefs()
        {
            foreach (TikzParseItem tpi in Children)
                tpi.RegisterNodeRefs();
        }

        public void AddChild(TikzParseItem tpi)
        {
            tpi.parent = this;
            Children.Add(tpi);
        }

        public virtual Tikz_Node GetNodeByName(string tname)
        {
            if (parent != null)
                return parent.GetNodeByName(tname);
            else return null;
        }

        public TikzMatrix GetCurrentTransform()
        {
            TikzMatrix M;
            if (options != null)
                M = options.GetTransform();
            else
                M = new TikzMatrix();
            if (parent != null)
                M = parent.GetCurrentTransform() * M;
            return M;
        }

        public override string ToString()
        {
            string s = starttag;
            foreach (TikzParseItem t in Children)
            {
                s = s + t.ToString();
            }
            return s + endtag;
        }
        public override void UpdateText()
        {
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
    // the root of the parse tree
    public class Tikz_ParseTree : TikzContainerParseItem
    {
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
    public class Tikz_Draw : TikzContainerParseItem
    {

    }
    public class Tikz_Picture : TikzContainerParseItem
    {
        public Dictionary<string, Tikz_Node> nodelist = new Dictionary<string, Tikz_Node>();
        public override Tikz_Node GetNodeByName(string tname)
        {
            return nodelist[tname];
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
    public class Tikz_Path : TikzContainerParseItem
    {
        public Point GetAbsOffset(TikzParseItem tpi)
        {
            int ind = Children.IndexOf(tpi);
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
                return GetCurrentTransform().Transform(new Point(0,0));
            else 
                return previous.GetAbsPos();
        }
    }
    public class Tikz_Scope : TikzContainerParseItem
    {

    }

    public class Tikz_Options : TikzParseItem
    {
        public List<string> options = new List<string>();

        public TikzMatrix GetTransform()
        {
            TikzMatrix ret = new TikzMatrix();
            return ret;
        }

        public override void UpdateText()
        {
            text = "[" + String.Join(", ", options.ToArray()) + "]";
        }
    }
}
