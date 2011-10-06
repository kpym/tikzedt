using TikzEdt.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TEApplicationLogicUnitTests
{
    
    
    /// <summary>
    ///This is a test class for TEDocumentVMTest and is intended
    ///to contain all TEDocumentVMTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TEDocumentVMTest
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
        ///A test for SavePdf
        ///</summary>
        [TestMethod()]
        public void SavePdfTest()
        {
            MainWindowVM parent = null; // TODO: Initialize to an appropriate value
            string cFile = string.Empty; // TODO: Initialize to an appropriate value
            TEDocumentVM target = new TEDocumentVM(parent, cFile); // TODO: Initialize to an appropriate value
            bool SaveAs = false; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.SavePdf(SaveAs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveCurFile
        ///</summary>
        [TestMethod()]
        public void SaveCurFileTest()
        {
            MainWindowVM parent = null; // TODO: Initialize to an appropriate value
            string cFile = string.Empty; // TODO: Initialize to an appropriate value
            TEDocumentVM target = new TEDocumentVM(parent, cFile); // TODO: Initialize to an appropriate value
            bool saveas = false; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.SaveCurFile(saveas);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LoadFile
        ///</summary>
        [TestMethod()]
        public void LoadFileTest()
        {
            MainWindowVM parent = null; // TODO: Initialize to an appropriate value
            string cFile = string.Empty; // TODO: Initialize to an appropriate value
            TEDocumentVM target = new TEDocumentVM(parent, cFile); // TODO: Initialize to an appropriate value
            string cFile1 = string.Empty; // TODO: Initialize to an appropriate value
            target.LoadFile(cFile1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExportFile
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void ExportFileTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            TEDocumentVM_Accessor target = new TEDocumentVM_Accessor(param0); // TODO: Initialize to an appropriate value
            target.ExportFile();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateStyleList
        ///</summary>
        [TestMethod()]
        public void UpdateStyleListTest()
        {
            MainWindowVM parent = null; // TODO: Initialize to an appropriate value
            string cFile = string.Empty; // TODO: Initialize to an appropriate value
            TEDocumentVM target = new TEDocumentVM(parent, cFile); // TODO: Initialize to an appropriate value
            target.UpdateStyleList();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
