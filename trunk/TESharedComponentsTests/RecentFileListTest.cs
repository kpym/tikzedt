using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TESharedComponentsTests
{
    
    
    /// <summary>
    ///This is a test class for RecentFileListTest and is intended
    ///to contain all RecentFileListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RecentFileListTest
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
        ///A test for InsertFile and RemoveFile
        ///</summary>
        [TestMethod()]
        public void InsertFileTest()
        {
            RecentFileList target = new RecentFileList(); // TODO: Initialize to an appropriate value
            while (target.RecentFiles.Count >0)
                target.RemoveFile(target.RecentFiles[0]);
            
            string filepath = "C:\\test.txt", filepath2 = "C:\\TesT.txt", filepath3 = "C:\\hallowelt.txt"; 
            target.InsertFile(filepath);
            Assert.AreEqual(1, target.BindableRecentFiles.Count());
            target.InsertFile(filepath2);
            Assert.AreEqual(1, target.BindableRecentFiles.Count());
            target.InsertFile(filepath3);
            Assert.AreEqual(2, target.BindableRecentFiles.Count());
        }

        /// <summary>
        ///A test for 
        ///</summary>
        [TestMethod()]
        public void RemoveFileTest()
        {
            RecentFileList target = new RecentFileList(); // TODO: Initialize to an appropriate value
            while (target.RecentFiles.Count > 0)
                target.RemoveFile(target.RecentFiles[0]);

            string filepath = "C:\\test.txt", filepath2 = "C:\\TesT.txt", filepath3 = "C:\\hallowelt.txt";
            target.InsertFile(filepath);
            target.InsertFile(filepath3);
            Assert.AreEqual(2, target.BindableRecentFiles.Count());
            target.RemoveFile(filepath2);
            Assert.AreEqual(1, target.RecentFiles.Count());
            Assert.AreEqual(1, target.BindableRecentFiles.Count());
            
        }
    }
}
