using CLAParser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CLAParser;

namespace TESharedComponentsTests
{
    
    
    /// <summary>
    ///This is a test class for CLAParserTest and is intended
    ///to contain all CLAParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CLAParserTest
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
        ///A test for Parse
        ///</summary>
        [TestMethod()]
        public void ParseTest()
        {
            string NamespaceOfResX = string.Empty; // TODO: Initialize to an appropriate value
            CLAParser.CLAParser target = new CLAParser.CLAParser(NamespaceOfResX); // TODO: Initialize to an appropriate value
            string[] Arguments = null; // TODO: Initialize to an appropriate value
            target.Parse(Arguments);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
