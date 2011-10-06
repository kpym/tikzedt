using TikzEdt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TEApplicationLogicUnitTests
{
    
    
    /// <summary>
    ///This is a test class for TikzToBMPFactoryTest and is intended
    ///to contain all TikzToBMPFactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TikzToBMPFactoryTest
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
        ///A test for OnJobFailed
        ///</summary>
        [TestMethod()]
        public void OnJobFailedTest()
        {
            //object sender = null; // TODO: Initialize to an appropriate value
            //TexCompiler.Job job = null; // TODO: Initialize to an appropriate value
            //TikzToBMPFactory.OnJobFailed(sender, job);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TikzToBMPFactory Constructor
        ///</summary>
        [TestMethod()]
        public void TikzToBMPFactoryConstructorTest()
        {
            TikzToBMPFactory target = new TikzToBMPFactory();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
