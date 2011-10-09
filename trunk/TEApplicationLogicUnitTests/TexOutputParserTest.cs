using TikzEdt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TEApplicationLogicUnitTests
{
    
    
    /// <summary>
    ///This is a test class for TexOutputParserTest and is intended
    ///to contain all TexOutputParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TexOutputParserTest
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
        ///A test for parseOutput
        ///</summary>
        [Ignore]
        [TestMethod()]
        public void parseOutputTest()
        {
            //TexOutputParser target = new TexOutputParser(); // TODO: Initialize to an appropriate value
            //TexCompiler.Job job = new TexCompiler.Job(); // TODO: Initialize to an appropriate value
            
            //bool expected = false; // TODO: Initialize to an appropriate value
            //bool actual;
            //actual = target.parseOutput(job);
            //Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }


    }
}
