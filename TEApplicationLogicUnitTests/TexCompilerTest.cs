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
        ///A test for TexCompiler Constructor
        ///</summary>
        [TestMethod()]
        public void TexCompilerConstructorTest()
        {
            TexCompiler target = new TexCompiler();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AbortCompilation
        ///</summary>
        [TestMethod()]
        public void AbortCompilationTest()
        {
            TexCompiler target = new TexCompiler(); // TODO: Initialize to an appropriate value
            target.AbortCompilation();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddJob
        ///</summary>
        [TestMethod()]
        public void AddJobTest()
        {
            TexCompiler target = new TexCompiler(); // TODO: Initialize to an appropriate value
            TexCompiler.Job job = null; // TODO: Initialize to an appropriate value
            target.AddJob(job);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddJob
        ///</summary>
        [TestMethod()]
        public void AddJobTest1()
        {
            TexCompiler target = new TexCompiler(); // TODO: Initialize to an appropriate value
            string code = string.Empty; // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            Rect BB = new Rect(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool CreateBMP = false; // TODO: Initialize to an appropriate value
            target.AddJob(code, path, BB, name, CreateBMP);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddJobExclusive
        ///</summary>
        [TestMethod()]
        public void AddJobExclusiveTest()
        {
            TexCompiler target = new TexCompiler(); // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            long DocumentID = 0; // TODO: Initialize to an appropriate value
            target.AddJobExclusive(path, DocumentID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddJobExclusive
        ///</summary>
        [TestMethod()]
        public void AddJobExclusiveTest1()
        {
            TexCompiler target = new TexCompiler(); // TODO: Initialize to an appropriate value
            TexCompiler.Job job = null; // TODO: Initialize to an appropriate value
            target.AddJobExclusive(job);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddJobExclusive
        ///</summary>
        [TestMethod()]
        public void AddJobExclusiveTest2()
        {
            TexCompiler target = new TexCompiler(); // TODO: Initialize to an appropriate value
            string code = string.Empty; // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            bool BBShallBeWritten = false; // TODO: Initialize to an appropriate value
            long DocumentID = 0; // TODO: Initialize to an appropriate value
            target.AddJobExclusive(code, path, BBShallBeWritten, DocumentID);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AsyncReaderWorker_DoWork
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void AsyncReaderWorker_DoWorkTest()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DoWorkEventArgs e = null; // TODO: Initialize to an appropriate value
            target.AsyncReaderWorker_DoWork(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AsyncReaderWorker_RunWorkerCompleted
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void AsyncReaderWorker_RunWorkerCompletedTest()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RunWorkerCompletedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.AsyncReaderWorker_RunWorkerCompleted(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ContainsDoNotInsertPreviewEnvironment
        ///</summary>
        [TestMethod()]
        public void ContainsDoNotInsertPreviewEnvironmentTest()
        {
            TexCompiler target = new TexCompiler(); // TODO: Initialize to an appropriate value
            string code = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ContainsDoNotInsertPreviewEnvironment(code);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ContainsPreviewEnvironment
        ///</summary>
        [TestMethod()]
        public void ContainsPreviewEnvironmentTest()
        {
            TexCompiler target = new TexCompiler(); // TODO: Initialize to an appropriate value
            string code = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ContainsPreviewEnvironment(code);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetPrecompiledHeaderJob
        ///</summary>
        [TestMethod()]
        public void GetPrecompiledHeaderJobTest()
        {
            TexCompiler.Job expected = null; // TODO: Initialize to an appropriate value
            TexCompiler.Job actual;
            actual = TexCompiler.GetPrecompiledHeaderJob();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsStandalone
        ///</summary>
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
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void PreprocessJobTest()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            TexCompiler.Job job = null; // TODO: Initialize to an appropriate value
            target.PreprocessJob(job);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ReadBBFromFile
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void ReadBBFromFileTest()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            TexCompiler.Job job = null; // TODO: Initialize to an appropriate value
            target.ReadBBFromFile(job);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for doCompile
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void doCompileTest()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            target.doCompile();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for myPdflatexOutputParser_OnTexError
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void myPdflatexOutputParser_OnTexErrorTest()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            TexOutputParser.TexError e = null; // TODO: Initialize to an appropriate value
            TexCompiler.Job job = null; // TODO: Initialize to an appropriate value
            target.myPdflatexOutputParser_OnTexError(sender, e, job);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for texProcess_OutputDataReceived
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void texProcess_OutputDataReceivedTest()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            string line = string.Empty; // TODO: Initialize to an appropriate value
            target.texProcess_OutputDataReceived(sender, line);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for texProcess_OutputDataReceived
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void texProcess_OutputDataReceivedTest1()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataReceivedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.texProcess_OutputDataReceived(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for texprocess_Exited
        ///</summary>
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
        ///A test for timer_Tick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void timer_TickTest()
        {
            TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.timer_Tick(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for writeBBWritertoTikz
        ///</summary>
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

        /// <summary>
        ///A test for Compiling
        ///</summary>
        [TestMethod()]
        public void CompilingTest()
        {
            TexCompiler target = new TexCompiler(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.Compiling = expected;
            actual = target.Compiling;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for JobsInQueue
        ///</summary>
        [TestMethod()]
        public void JobsInQueueTest()
        {
            TexCompiler target = new TexCompiler(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.JobsInQueue;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
