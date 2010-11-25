using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace TikzEdt
{
    /// <summary>
    /// 
    /// </summary>
    static class TikzParser
    {
        public static Tikz_ParseTree Parse(string code)
        {
            
            simpletikzLexer lex = new simpletikzLexer(new ANTLRStringStream(code));
            CommonTokenStream tokens = new CommonTokenStream(lex);

            //for (int i = 0; i < tokens.Count; i++)
            //{
            //    string ds = tokens.Get(i).Text;
            //    ds = ds + "eee";
            //}

            simpletikzParser parser = new simpletikzParser(tokens);

            //tikzgrammarParser.expr_return r =
            simpletikzParser.tikzpath_return ret = parser.tikzpath();
            
            //CommonTreeAdaptor adaptor = new CommonTreeAdaptor();
            CommonTree t = (CommonTree)ret.Tree;
            MessageBox.Show(printTree(t,0));

        }

/*
        public string printTree(CommonTree t, int indent)
        {
            string s="";
            if ( t != null ) {
		        for ( int i = 0; i < indent; i++ )
			        s = s+"   ";

                string r = "";// s + t.ToString() + "\r\n";
                
                if (t.ChildCount >0)
		            foreach ( object o in t.Children ) {
			            r=r+s+o.ToString()+"\r\n" + printTree((CommonTree)o, indent+1);
                    }

                return r;
            }  else return "";
		}
    }*/
            
            
            Tikz_ParseTree t = new Tikz_ParseTree();



            string[] comp = code.Split(new string[] { "\\begin{tikzpicture}" }, StringSplitOptions.None);

            StringReader s = new StringReader(code);
            //c = s.ReadLine();


            // mockup 
            t.Children.Add(new Tikz_Node(0, 0));
            t.Children.Add(new Tikz_Node(5, 5));
            t.Children.Add(new Tikz_Node(6, 8));
            t.Children.Add(new Tikz_Node(8, 8));

            return t;
        }

       // private static bool ParseString(StringReader s, string  c)
       // {
       //     return "";
       // }

   /*     static List<string[]> DoubleSplit(string toSplit, string starttag, string endtag)
        {
            string[] startsplit = toSplit.Split(new string[] { starttag }, StringSplitOptions.None);
            List<string[]> l = new List<string[]>();

            int curdepth = 0;
            string curcontent="";
            foreach (string s in startsplit)
            {
                if (curdepth == 0)
                {
                    l.Add(new string[] { s });
                    curdepth++;
                }
                else
                {
                    string[] endsplit = s.Split(new string[] { endtag }, StringSplitOptions.None);
                    foreach (string t in endsplit)
                    {
                        if (curdepth == 0)
                            l.Add(new string[] { starttag, t, endtag });
                        else


                            curdepth--;
                    }
                }
            }
        }
        */
    }

    public class TikzParseItem
    {
        protected string text = "";
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
    }
    /// <summary>
    /// This item represents parts of the code that the parser does not understand
    /// or not care about, e. g., whitespace.
    /// </summary>
    public class Tikz_Something : TikzParseItem
    {

    }
    public class Tikz_Node : TikzParseItem
    {
        public double x, y;
        public Tikz_Node(double tx, double ty)
        {
            x=tx; y=ty;
        }
    }
    public class TikzContainerParseItem : TikzParseItem
    {
        public string starttag="", endtag="";
        public List<TikzParseItem> Children= new List<TikzParseItem>();
        public override string ToString()
        {
            string s = starttag;
            foreach (TikzParseItem t in Children)
            {
                s = s + t.ToString();
            }
            return s+endtag;
        }
    }
    // the root of the parse tree
    public class Tikz_ParseTree : TikzContainerParseItem
    {

    }
    public class Tikz_Draw : TikzContainerParseItem
    {

    }
    public class Tikz_Picture : TikzContainerParseItem
    {

    }

}
