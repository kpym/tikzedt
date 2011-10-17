using TESharedComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TESharedComponentsTests
{
    
    
    /// <summary>
    ///This is a test class for UpdateCheckerTest and is intended
    ///to contain all UpdateCheckerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UpdateCheckerTest
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
        }
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            target = new UpdateChecker();
            target.Status += (s, e) => statusargs = e;
            target.Success += (s, e) => successargs = e;
            successargs = null;
            statusargs = null;

        
        }
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        UpdateChecker.SuccessEventArgs successargs = null;
        UpdateChecker.StatusEventArgs statusargs = null;
        UpdateChecker target;

        /// <summary>
        ///A test for CheckForUpdatesAsync
        ///</summary>
        [TestMethod()]
        public void CheckForUpdatesAsyncTest()
        {
            target.VersionInfoURL = @"https://tikzedt.googlecode.com/svn/trunk/VersionInfo.xml";

            bool expected = true;
            bool actual;
            actual = target.CheckForUpdatesAsync();
            Assert.AreEqual(expected, actual);

            Assert.IsNotNull(successargs);
            Assert.IsNotNull(statusargs);

            Assert.IsFalse(statusargs.HasFailed);            
            Assert.IsTrue(Uri.IsWellFormedUriString(successargs.DownloadURL, UriKind.Absolute));
            Assert.IsTrue(Uri.IsWellFormedUriString(successargs.WebpageURL, UriKind.Absolute));

        }

        [TestMethod()]
        public void CheckForUpdatesAsync_Fail_Test()
        {
            target.VersionInfoURL = @"https://tikzedt.googlecode.com/svn/trunk/junk.junk";

            bool expected = true;
            bool actual;
            actual = target.CheckForUpdatesAsync();
            Assert.AreEqual(expected, actual);

            Assert.IsNull(successargs);
            Assert.IsNotNull(statusargs);

            Assert.IsTrue(statusargs.HasFailed);            
        }
    }
}
