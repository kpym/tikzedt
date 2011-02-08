using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using System.IO;
using System.Windows;


namespace TikzEdt.Editor
{
    class CodeCompleter
    {
        public string CompletionTriggers = "[.";

        public CodeCompleter()
        {

        }
        /// <summary>
        /// Loads the completion definitions from an xml file
        /// </summary>
        /// <param name="cFile"></param>
        public void LoadCompletions(string cFile)
        {
            Data.CompletionDS ds = new Data.CompletionDS();            
            if (File.Exists(cFile))
            {
                try
                {
                    ds.ReadXml(cFile);
                    envs.Clear();
                    CompletionTriggers = "";

                    foreach (Data.CompletionDS.TriggersRow tr in ds.Triggers.Rows)
                    {
                        CompletionTriggers = CompletionTriggers + tr.Trigger;
                    }

                    foreach (Data.CompletionDS.EnvironmentsRow r in ds.Environments.Rows)
                    {
                        envs.Add(new CodeEnvironment(r));
                    }
                    //ds.WriteXml(cFile);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error reading Completion data... is the file (" + cFile + ") corrupt?\r\n" + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Completion data not found (File: " + cFile +")");
            }
        }
    
  
        List<CodeEnvironment> envs = new List<CodeEnvironment>();


        public void GetCompletions(TextDocument doc, int Offset, IList<ICompletionData> data)
        {    
  
            // match only last N chars
            int N = Math.Min(Offset, 200);
            string s = doc.GetText(Offset - N, N);

            foreach (CodeEnvironment ee in envs)
            {
                if ( ee.MatchEnv(s) )
                {
                    foreach (MyCompletionData snipp in ee.snippets)
                    {
                        data.Add(snipp);
                    }
                }
            }
    

            //data.Add(new MyCompletionData("draw"));
            //data.Add(new MyCompletionData("fill"));
            //data.Add(new MyCompletionData("minimum size"));
        }

        public class CodeEnvironment
        {
            string starttag, endtag;
            Regex restart, reend;
            public List<MyCompletionData> snippets = new List<MyCompletionData>();
            public CodeEnvironment(Data.CompletionDS.EnvironmentsRow r)
            {
                starttag = r.StartTag;
                endtag = r.EndTag;

                RegexOptions o = RegexOptions.RightToLeft | RegexOptions.Compiled;
                reend = new Regex(endtag, o);
                restart = new Regex(starttag, o);

                foreach (Data.CompletionDS.SnippetsRow sr in r.GetSnippetsRows())
                {
                    string descr = "";
                    if (!sr.IsDescriptionNull())
                        descr = sr.Description;                    
                    snippets.Add(new MyCompletionData(sr.Text, descr));
                }
            }

            public bool MatchEnv(string pre)
            {
                Match mstart = restart.Match(pre);
                Match mend = reend.Match(pre);

                if (mstart.Success)
                {
                    if (mend.Success)
                    {
                        return mstart.Index > mend.Index;
                    }
                    else
                        return true;
                }

                return false;
            }            
        } 


}
}
