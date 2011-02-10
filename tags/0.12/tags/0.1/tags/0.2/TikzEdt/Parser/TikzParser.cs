using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
//using System.ComponentModel;

using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace TikzEdt.Parser
{
    /// <summary>
    /// 
    /// </summary>
    static class TikzParser
    {
        //static public string TIKZEDT_CMD_COMMENT = "";

        public static Tikz_ParseTree Parse(string code)
        {
            //if code is empty to bother ANTLR (it will raise an exception)
            if (code.Trim() == "")
                return null;

            simpletikzLexer lex = new simpletikzLexer(new ANTLRStringStream(code));
            CommonTokenStream tokens = new CommonTokenStream(lex);

            //for (int i = 0; i < tokens.Count; i++)
            //{
            //    string ds = tokens.Get(i).Text;
            //    ds = ds + "eee";
            //}

            simpletikzParser parser = new simpletikzParser(tokens);

            //tikzgrammarParser.expr_return r =            
            simpletikzParser.tikzdocument_return ret = parser.tikzdocument();
            
            //CommonTreeAdaptor adaptor = new CommonTreeAdaptor();
            CommonTree t = (CommonTree)ret.Tree;
            //MessageBox.Show(printTree(t,0));



        

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
            
            
            Tikz_ParseTree root = new Tikz_ParseTree();

            bool success = FillItem(root, t, tokens);


            // mockup 
            //t.Children.Add(new Tikz_Node(0, 0));
            //t.Children.Add(new Tikz_Node(5, 5));
            //t.Children.Add(new Tikz_Node(6, 8));
            //t.Children.Add(new Tikz_Node(8, 8));
            if (success)
            {
                root.RegisterNodeAndStyleRefs(); // make a list with all node names for later reference
                return root;
            }
            else
                return null;
        }

        static bool FillItem(TikzContainerParseItem item, CommonTree t, CommonTokenStream tokens)
        {
            int curToken = t.TokenStartIndex;
            if (item is Tikz_ParseTree)
                curToken = 0;   // for root, start at the beginning

            if (t.Children == null)
                return false;

            foreach (CommonTree childt in t.Children)
            {
                addSomething(item, tokens, curToken, childt.TokenStartIndex - 1);
                
                switch (childt.Type)
                {
                    case simpletikzParser.IM_PICTURE:
                        Tikz_Picture tp = new Tikz_Picture();
                        FillItem(tp, childt, tokens);
                        item.AddChild(tp);
                        break;
                    case simpletikzParser.IM_STARTTAG:
                        item.starttag = getTokensString(tokens, childt.TokenStartIndex, childt.TokenStopIndex);
                        break;
                    case simpletikzParser.IM_ENDTAG:
                        item.endtag = getTokensString(tokens, childt.TokenStartIndex, childt.TokenStopIndex);
                        break;
                    case simpletikzParser.IM_PATH:
                        Tikz_Path tpath = new Tikz_Path();
                        FillItem(tpath, childt, tokens);
                        item.AddChild(tpath);
                        break;
                    case simpletikzParser.IM_SCOPE:
                        Tikz_Scope tscope = new Tikz_Scope();
                        FillItem(tscope, childt, tokens);
                        item.AddChild(tscope);
                        break;
                    case simpletikzParser.IM_COORD:
                        Tikz_Coord tc = Tikz_Coord.FromCommonTree(childt, tokens);
                        tc.text = getTokensString(tokens, childt);
                        item.AddChild(tc);
                        break;
                    
                    case simpletikzParser.IM_NODE:
                        Tikz_Node tn = Tikz_Node.FromCommonTree(childt, tokens);
                        tn.text = getTokensString(tokens, childt);
                        item.AddChild(tn);
                        break;                    
                    case simpletikzParser.IM_OPTION_KV:
                    case simpletikzParser.IM_OPTION_STYLE:
                        Tikz_Option topt = Tikz_Option.FromCommonTree(childt, tokens);
                        topt.text = getTokensString(tokens, childt);
                        item.AddChild(topt);
                        break;
                    case simpletikzParser.IM_OPTIONS:
                        //Tikz_Options to = Tikz_Options.FromCommonTree(childt);                        
                        Tikz_Options to = new Tikz_Options();
                        FillItem(to, childt, tokens);
                        item.AddChild(to);
                        //to.text = getTokensString(tokens, childt);
                        //item.AddChild(tn);
                        if (item.options == null)
                            item.options = to;
                        break;
                    case simpletikzParser.IM_TIKZSET:
                        Tikz_Options to2 = new Tikz_Options();
                        FillItem(to2, childt, tokens);
                        item.AddChild(to2);
                        break;
                    case simpletikzParser.IM_STYLE:
                        Tikz_Option topt2 = Tikz_Option.FromCommonTree(childt, tokens);
                        //FillItem(to2, childt, tokens);
                        topt2.text = getTokensString(tokens, childt);
                        item.AddChild(topt2);
                        break;                    
                    case simpletikzParser.IM_SIZE:
                        Tikz_Size tsize = Tikz_Size.FromCommonTree(childt, tokens);
                        tsize.text = getTokensString(tokens, childt);
                        item.AddChild(tsize);
                        //Tikz_Size tsize = new Tikz_Size();
                        //item.AddChild(tsize);
                        break;                 
                    //case simpletikzParser.ID:
                    //case simpletikzParser.IM_STRING:
                    //case simpletikzParser.COMMAND:
                    //case simpletikzParser.T__57:
                    //    break;
                    case simpletikzParser.IM_TIKZEDT_CMD:
                        Tikz_EdtCommand cmd = new Tikz_EdtCommand(getTokensString(tokens, childt));
                        item.AddChild(cmd);
                        break;
                    default:
                        // getting here is an error
                        throw new Exception("childt.Type not handled! " + childt.Type.ToString());
                        //break;

                }

                curToken = childt.TokenStopIndex + 1;               

            }

            if (t.TokenStartIndex >= 0)   // rule out empty code 
                addSomething(item, tokens, curToken, t.TokenStopIndex);

            return true;
        }

        public static string getTokensString(CommonTokenStream tokens, ITree t)
        {
            return getTokensString(tokens, t.TokenStartIndex, t.TokenStopIndex);
        }
        public static string getTokensString(CommonTokenStream tokens, int FirstToken, int LastToken)
        {
            if (LastToken - FirstToken < 0)
                return "";
            string text = "";
            for (int i = FirstToken; i <= LastToken; i++)
            {
                text = text + tokens.Get(i).Text;
            }
            return text;
        }

        static void addSomething(TikzContainerParseItem item, CommonTokenStream tokens, int FirstToken, int LastToken)
        {
            if (LastToken-FirstToken < 0)
                return;

            Tikz_Something t = new Tikz_Something(getTokensString(tokens, FirstToken, LastToken));
            item.AddChild(t);            
        }

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

}
