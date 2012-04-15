using TikzEdt.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TikzEdt;
using System.IO;
using System.Threading;
using System.Windows.Threading;
using TESharedComponents;
using System.Diagnostics;

namespace TEApplicationLogicUnitTests
{
    
    
    /// <summary>
    ///This is a test class for TEDocumentVMTest and is intended
    ///to contain all TEDocumentVMTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TEDocumentVMTest  : DispatcherObject
    {


        private TestContext testContextInstance;

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
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            MyBackgroundWorker.IsSynchronous = true;
            GlobalUI.UI = GlobUI = new GlobalUIMock();
            GlobalUI.UI.OnGlobalStatus += (s, e) => Debug.WriteLine("*** " + e.StatusLine);
        }

        static GlobalUIMock GlobUI;
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
        ///A test for SavePdf
        ///</summary>
        [Ignore]
        [TestMethod()]
        public void SavePdfTest()
        {
            TexCompiler tc = new TexCompiler();
            //MainWindowVM parent = new MainWindowVM(tc); // TODO: Initialize to an appropriate value
            string cFile = string.Empty; // TODO: Initialize to an appropriate value
            TEDocumentVM<AvalonDocumentWrapper> target = new TEDocumentVM<AvalonDocumentWrapper>(null, tc); 
            string filename = GlobUI.MockFileDialogFileName = Directory.GetCurrentDirectory() + "\\" + "temp2.tex";
            GlobUI.MockFileDialogResult = true;
            target.SaveCurFile();
            
            Thread.Sleep(1000);

            target.SavePdf(false);

            Assert.IsTrue(File.Exists(Helper.RemoveFileExtension(filename)+".pdf"));
            
        }


        /// <summary>
        ///A test for ExportFile
        ///</summary>
        [Ignore]
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void ExportFileTest()
        {
            //PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            //TEDocumentVM_Accessor target = new TEDocumentVM_Accessor(param0); // TODO: Initialize to an appropriate value
            //target.ExportFile();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

    }
}
