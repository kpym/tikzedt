/* Legal note:
 * This code interfaces the AvalonEdit TextEditor library,
 * which is provided under the terms of the GNU Lesser General Public license (LGPL),
 * available here: http://www.gnu.org/copyleft/lesser.html.
 * If you use this code in your project you might be subject to restrictions
 * imposed by the LGPL.
*/

using FindReplace;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ICSharpCode.AvalonEdit;
using System.Collections.Generic;

namespace FindReplaceUnitTests
{
    
    
    /// <summary>
    ///This is a test class for FindReplaceVMTest and is intended
    ///to contain all FindReplaceVMTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FindReplaceVMTest
    {

        string DefSampleText =
            @"Hallo 1 bla bla Hallo2 Hallo 3. Testen testen test tesssst";

        private TestContext testContextInstance;
        List<TextEditor> Editors = new List<TextEditor>();
        private FindReplaceMgr MakeSample(string SampleText)
        {
            Editors.Clear();
            Editors.Add(new TextEditor() { Text=SampleText });
            Editors.Add(new TextEditor() { Text = SampleText });
            Editors.Add(new TextEditor() { Text = SampleText });
            Editors.Add(new TextEditor() { Text = SampleText });

            FindReplaceMgr ret = new FindReplaceMgr() { Editors=Editors, InterfaceConverter=new IEditorConverter(), CurrentEditor=Editors[0] };
            return ret;
        }
        private FindReplaceMgr_Accessor MakeSampleA(string SampleText)
        {
            Editors.Clear();
            Editors.Add(new TextEditor() { Text = SampleText });
            Editors.Add(new TextEditor() { Text = SampleText });
            Editors.Add(new TextEditor() { Text = SampleText });
            Editors.Add(new TextEditor() { Text = SampleText });

            FindReplaceMgr_Accessor ret = new FindReplaceMgr_Accessor() { Editors = Editors, InterfaceConverter = new IEditorConverter(), CurrentEditor = Editors[0] };
            return ret;
        }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetNextEditor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("FindReplace.dll")]
        public void GetNextEditorTest()
        {
            FindReplaceMgr_Accessor target = MakeSampleA(DefSampleText);
            for (int i=0;i<4;i++) 
                Editors[i].Text = "Edt:"+i +" "+ Editors[i].Text; 
            bool previous = false;                        
            IEditor actual;

            actual = target.GetNextEditor(previous);
            actual = target.GetNextEditor(previous);
            Assert.AreEqual(target.CurrentEditor, Editors[0]);
            actual = target.GetNextEditor(true);
            Assert.AreEqual(target.CurrentEditor, Editors[0]);

            target.SearchIn = FindReplaceMgr.SearchScope.AllDocuments;
            actual = target.GetNextEditor(previous);
            Assert.AreEqual(target.CurrentEditor, Editors[1]);
            actual = target.GetNextEditor(previous);
            Assert.AreEqual(target.CurrentEditor, Editors[2]);
            actual = target.GetNextEditor(previous);
            actual = target.GetNextEditor(previous);
            actual = target.GetNextEditor(previous);
            Assert.AreEqual(target.CurrentEditor, Editors[1]);

            previous = true;
            actual = target.GetNextEditor(previous);
            Assert.AreEqual(target.CurrentEditor, Editors[0]);
            actual = target.GetNextEditor(previous);
            Assert.AreEqual(target.CurrentEditor, Editors[3]);
            actual = target.GetNextEditor(previous);
            Assert.AreEqual(target.CurrentEditor, Editors[2]);


            // if currenteditor is not in list, the same editor has to be returned
            target.Editors = null;
            target.GetNextEditor(previous);
            Assert.AreEqual(target.CurrentEditor, Editors[2]);
        }

        /// <summary>
        ///A test for Replace
        ///</summary>
        [TestMethod()]
        public void ReplaceTest()
        {
            FindReplaceMgr target = MakeSample(@"Hallo 1 bla bla Hallo2 Hallo 3. Testen testen test tesssst");
            target.TextToFind = "bla";
            target.ReplacementText = "blu";

            target.Replace();
            target.Replace();

            Assert.AreEqual<string>(Editors[0].Text, @"Hallo 1 blu bla Hallo2 Hallo 3. Testen testen test tesssst");

            target.SearchIn = FindReplaceMgr.SearchScope.AllDocuments;
            target.FindNext();
            target.Replace();
            target.Replace();

            Assert.AreEqual<string>(Editors[1].Text, @"Hallo 1 blu blu Hallo2 Hallo 3. Testen testen test tesssst");
        }


        /// <summary>
        ///A test for ReplaceAll
        ///</summary>
        [TestMethod()]
        public void ReplaceAllTest()
        {
            FindReplaceMgr target = MakeSample(@"Hallo 1 bla bla Hallo2 Hallo 3. Testen testen test tesssst");
            target.TextToFind = "testen testen";
            target.ReplacementText = "xxx";
            target.CaseSensitive = false;
            bool AskBefore = false;

            // test basic replacement
            target.ReplaceAll(AskBefore);           
            Assert.AreEqual<string>(Editors[0].Text, @"Hallo 1 bla bla Hallo2 Hallo 3. xxx test tesssst");

            // test wrapping through all open files
            target.SearchIn = FindReplaceMgr.SearchScope.AllDocuments;
            target.TextToFind = "bla";
            target.ReplaceAll(AskBefore);            
            Assert.AreEqual<string>(Editors[2].Text, @"Hallo 1 xxx xxx Hallo2 Hallo 3. Testen testen test tesssst");
            Assert.AreEqual<string>(Editors[1].Text, @"Hallo 1 xxx xxx Hallo2 Hallo 3. Testen testen test tesssst");
            Assert.AreEqual<string>(Editors[0].Text, @"Hallo 1 xxx xxx Hallo2 Hallo 3. xxx test tesssst");

            // variable length
            target.UseWildcards = true;
            target.CaseSensitive = true;
            target.TextToFind = "tes*st";
            target.ReplaceAll(AskBefore);
            Assert.AreEqual<string>(Editors[2].Text, @"Hallo 1 xxx xxx Hallo2 Hallo 3. Testen xxx");
            Assert.AreEqual<string>(Editors[1].Text, @"Hallo 1 xxx xxx Hallo2 Hallo 3. Testen xxx");
            Assert.AreEqual<string>(Editors[0].Text, @"Hallo 1 xxx xxx Hallo2 Hallo 3. xxx xxx");

        }

        /// <summary>
        ///A test for FindPrevious
        ///</summary>
        [TestMethod()]
        public void FindPreviousTest()
        {

            FindReplaceMgr target = MakeSample(@"Hallo 1 bla bla Hallo2 Hallo 3. Testen testen test tesssst");

            // basic Find
            target.CaseSensitive = true;
            target.TextToFind = "Hallo";
            Editors[0].SelectionStart = 27;
            target.FindPrevious();
            Assert.AreEqual<int>(16, Editors[0].SelectionStart);
            Editors[0].SelectionStart = 28;
            target.FindPrevious();
            Assert.AreEqual<int>(23, Editors[0].SelectionStart);
            target.FindPrevious();
            Assert.AreEqual<int>(16, Editors[0].SelectionStart);

            //Assert.AreEqual<string>(Editors[0].SelectedText, "bla Hallo2");

            // wildcards
            //Editors[0].CaretOffset = 0;
            //target.UseWildcards = true;
            //target.TextToFind = "ha*o2";
        }

        /// <summary>
        ///A test for FindNext
        ///</summary>
        [TestMethod()]
        public void FindNextTest()
        {
            FindReplaceMgr target = MakeSample(@"Hallo 1 bla bla Hallo2 Hallo 3. Testen testen test tesssst");

            // basic Find
            target.CaseSensitive = false;
            target.TextToFind = "bla hallo2";
            target.FindNext();
            Assert.AreEqual<int>(12+target.TextToFind.Length, Editors[0].CaretOffset);
            Assert.AreEqual<string>("bla Hallo2", Editors[0].SelectedText);

            // wildcards
            Editors[0].CaretOffset = 0;
            target.UseWildcards = true;
            target.TextToFind = " ha*o2";
            target.FindNext();
            Assert.AreEqual<int>(22, Editors[0].CaretOffset);
            Assert.AreEqual<string>(" Hallo2", Editors[0].SelectedText);
            Editors[0].CaretOffset = 0;
            target.TextToFind = " ha?o2";
            target.FindNext();
            Assert.AreEqual<int>(0, Editors[0].CaretOffset);
            Editors[0].CaretOffset = 0;
            target.TextToFind = " ha??o2";
            target.FindNext();
            Assert.AreEqual<int>(22, Editors[0].CaretOffset);
            target.CaseSensitive = true;
            Editors[0].CaretOffset = 0;
            target.TextToFind = " ha??o2";
            target.FindNext();
            Assert.AreEqual<int>(0, Editors[0].CaretOffset);

            // regex
            Editors[0].CaretOffset = 0;
            Editors[0].Text = @"Hallo1bla Hallo2   bla. Testen testen test tesssst";
            target.UseWildcards = false;
            target.UseRegEx = true;
            target.CaseSensitive = true;
            target.TextToFind = @"hallo\d\s+bla";            
            target.FindNext();
            Assert.AreEqual<int>(0, Editors[0].CaretOffset);

            target.CaseSensitive = false;
            target.FindNext();
            Assert.AreEqual<int>(22, Editors[0].CaretOffset);
            Assert.AreEqual<string>("Hallo2   bla", Editors[0].SelectedText);

            // jump over several editors            
            Editors[0].Text = Editors[1].Text = @"Hallo1bla Hallo2   bla. Testen testen test tesssst";
            Editors[2].Text = Editors[3].Text = @"foo";
            target.CurrentEditor = Editors[1];
            Editors[1].CaretOffset = 0;
            target.UseWildcards = false;
            target.UseRegEx = false;
            target.TextToFind = "hallo1";
            target.SearchIn = FindReplaceMgr.SearchScope.AllDocuments;
            target.FindNext(); target.FindNext();
            Assert.AreEqual(Editors[0], target.CurrentEditor);
            Assert.AreEqual("Hallo1", Editors[0].SelectedText);

            // no match to be found...
            target.TextToFind = "sdfsgsgsfgsfgsf";
            target.FindNext();
            Assert.AreEqual(Editors[0], target.CurrentEditor);

        }

        /// <summary>
        ///A second test for FindNext
        ///</summary>
        [TestMethod()]
        public void FindNextTest2()
        {
            FindReplaceMgr target = MakeSample(@"aaaaaaaaaaaaaaa");

            // basic Find
            target.CaseSensitive = false;
            target.TextToFind = "a";
            target.FindNext();
            Assert.AreEqual<int>(1, Editors[0].CaretOffset);
            target.FindNext();
            Assert.AreEqual<int>(2, Editors[0].CaretOffset);
            target.FindNext();
            Assert.AreEqual<int>(3, Editors[0].CaretOffset);
            target.FindNext();
            Assert.AreEqual<int>(4, Editors[0].CaretOffset);
            target.FindNext();
            Assert.AreEqual<int>(5, Editors[0].CaretOffset);
        }
    }
}
