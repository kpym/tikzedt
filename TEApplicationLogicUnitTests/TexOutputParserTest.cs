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
        ///A test for TexOutputParser Constructor
        ///</summary>
        [TestMethod()]
        public void TexOutputParserConstructorTest()
        {
            TexOutputParser target = new TexOutputParser();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Clear
        ///</summary>
        [TestMethod()]
        public void ClearTest()
        {
            TexOutputParser target = new TexOutputParser(); // TODO: Initialize to an appropriate value
            target.Clear();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for addLine
        ///</summary>
        [TestMethod()]
        public void addLineTest()
        {
            TexOutputParser target = new TexOutputParser(); // TODO: Initialize to an appropriate value
            string Line = string.Empty; // TODO: Initialize to an appropriate value
            target.addLine(Line);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for addProblemMarker
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void addProblemMarkerTest()
        {
            TexOutputParser_Accessor target = new TexOutputParser_Accessor(); // TODO: Initialize to an appropriate value
            string error = string.Empty; // TODO: Initialize to an appropriate value
            string causingSourceFile = string.Empty; // TODO: Initialize to an appropriate value
            int linenr = 0; // TODO: Initialize to an appropriate value
            Severity severity = new Severity(); // TODO: Initialize to an appropriate value
            TexCompiler.Job job = null; // TODO: Initialize to an appropriate value
            target.addProblemMarker(error, causingSourceFile, linenr, severity, job);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for determineSourceFile
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void determineSourceFileTest()
        {
            TexOutputParser_Accessor target = new TexOutputParser_Accessor(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.determineSourceFile();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for isAllowedinName
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void isAllowedinNameTest()
        {
            TexOutputParser_Accessor target = new TexOutputParser_Accessor(); // TODO: Initialize to an appropriate value
            char c = '\0'; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.isAllowedinName(c);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for isValidName
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void isValidNameTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = TexOutputParser_Accessor.isValidName(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for parseLine
        ///</summary>
        [TestMethod()]
        public void parseLineTest()
        {
            TexOutputParser target = new TexOutputParser(); // TODO: Initialize to an appropriate value
            string line = string.Empty; // TODO: Initialize to an appropriate value
            target.parseLine(line);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for parseNewOutput
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void parseNewOutputTest()
        {
            TexOutputParser_Accessor target = new TexOutputParser_Accessor(); // TODO: Initialize to an appropriate value
            target.parseNewOutput();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for parseOutput
        ///</summary>
        [TestMethod()]
        public void parseOutputTest()
        {
            TexOutputParser target = new TexOutputParser(); // TODO: Initialize to an appropriate value
            TexCompiler.Job job = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.parseOutput(job);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for updateParsedFile
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void updateParsedFileTest()
        {
            TexOutputParser_Accessor target = new TexOutputParser_Accessor(); // TODO: Initialize to an appropriate value
            string logLine = string.Empty; // TODO: Initialize to an appropriate value
            TexCompiler.Job job = null; // TODO: Initialize to an appropriate value
            target.updateParsedFile(logLine, job);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
