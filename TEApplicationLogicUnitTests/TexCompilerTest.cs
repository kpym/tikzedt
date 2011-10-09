using TikzEdt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;
using System.ComponentModel;
using System.Diagnostics;

namespace TEApplicationLogicUnitTests
{
    
    
    /// <summary>
    ///This is a test class for TexCompilerTest and is intended
    ///to contain all TexCompilerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TexCompilerTest
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
        ///A test for IsStandalone
        ///</summary>
        [Ignore]
        [TestMethod()]
        public void IsStandaloneTest()
        {
            string code = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = TexCompiler.IsStandalone(code);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PreprocessJob
        ///</summary>
        [Ignore]
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void PreprocessJobTest()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            TexCompiler.Job job = new TexCompiler.Job(); // TODO: Initialize to an appropriate value
            job.code = "\\begin{tikzpicture} %!TE% \\end{tikzpicture}";
            target.PreprocessJob(job);
            Assert.AreEqual("\\begin{tikzpicture}  \\end{tikzpicture}", job.code.Trim());
        }

        /// <summary>
        ///A test for ReadBBFromFile
        ///</summary>
        [Ignore]
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void ReadBBFromFileTest()
        {
            //TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            //TexCompiler.Job job = null; // TODO: Initialize to an appropriate value
            //target.ReadBBFromFile(job);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }



        /// <summary>
        ///A test for texprocess_Exited
        ///</summary>
        [Ignore]
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void texprocess_ExitedTest()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            string StdOutput = string.Empty; // TODO: Initialize to an appropriate value
            string ErrOutput = string.Empty; // TODO: Initialize to an appropriate value
            target.texprocess_Exited(StdOutput, ErrOutput);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }



        /// <summary>
        ///A test for writeBBWritertoTikz
        ///</summary>
        [Ignore]
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void writeBBWritertoTikzTest()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            string code = string.Empty; // TODO: Initialize to an appropriate value
            bool succeeded = false; // TODO: Initialize to an appropriate value
            bool succeededExpected = false; // TODO: Initialize to an appropriate value
            int PositionOfAddedLine = 0; // TODO: Initialize to an appropriate value
            int PositionOfAddedLineExpected = 0; // TODO: Initialize to an appropriate value
            int NumberOfAddedLines = 0; // TODO: Initialize to an appropriate value
            int NumberOfAddedLinesExpected = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.writeBBWritertoTikz(code, out succeeded, out PositionOfAddedLine, out NumberOfAddedLines);
            Assert.AreEqual(succeededExpected, succeeded);
            Assert.AreEqual(PositionOfAddedLineExpected, PositionOfAddedLine);
            Assert.AreEqual(NumberOfAddedLinesExpected, NumberOfAddedLines);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

 
    }
}
