using TikzEdt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Windows;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using TESharedComponents;

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


        string StandAloneCode =
@"\documentclass{article}
\usepackage{tikz}
\begin{document}
\begin{tikzpicture}

\end{tikzpicture
\end{document}
";
        string NonStandAloneCode =
 @"\begin{tikzpicture}
\draw (0,0)--(3,3);
\end{tikzpicture}
";

        string JunkCode =
@"sdfsdlfj \sfdlj \klsdf [lsdjf  }ksdfj l";

        TexCompiler tc;
        TexCompiler.Job LastReceivedJob;
        TexCompiler.JobEventArgs LastReceivedEA;
        bool JobFailed_Reported = false;

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
            tc = new TexCompiler();
            tc.JobDone += (s, e) => { LastReceivedJob = e.job; LastReceivedEA = e; JobFailed_Reported = e.ExitCode != 0; };       

            LastReceivedJob = null;
            LastReceivedEA = null;
            JobFailed_Reported = false;
        }
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
            //TexCompiler_Accessor target = new TexCompiler_Accessor(); // TODO: Initialize to an appropriate value
           // TexCompiler.Job job = new TexCompiler.Job(); // TODO: Initialize to an appropriate value
           // job.code = "\\begin{tikzpicture} %!TE% \\end{tikzpicture}";
           // target.PreprocessJob(job);
           // Assert.AreEqual("\\begin{tikzpicture}  \\end{tikzpicture}", job.code.Trim());
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

        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void AddJobTest_PCHCreation()
        {

            // Delete the precompiled header and check that it is re-created
            string pchPath = Helper.GetPrecompiledHeaderFMTFilePath();
            if (File.Exists(pchPath))
                File.Delete(pchPath);

            tc.AddJobExclusive(NonStandAloneCode, null, true, 111);

            Assert.IsTrue(File.Exists(pchPath));
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
            target.texprocess_Exited(StdOutput, ErrOutput, null);
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

        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void AddJobTest_BBreadout()
        {
            // Check that the bounding box is read out and is approximately correct
            LastReceivedJob = null;
            tc.AddJobExclusive(NonStandAloneCode, null, true, 111);
            tc.AddJobExclusive(NonStandAloneCode, null, true, 111);

            Assert.AreNotEqual(LastReceivedJob, null);
            Assert.AreEqual(LastReceivedJob.DocumentID, 111);
            Assert.IsTrue( Math.Abs( LastReceivedJob.BB.Width -3) < .5);
            Assert.IsTrue( Math.Abs( LastReceivedJob.BB.Height - 3) < .5);

        }

        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void ErrorHandlingTest()
        {
            // Check that the bounding box is read out and is approximately correct        
            tc.AddJobExclusive(JunkCode, null, true, 112);

            Assert.AreNotEqual(LastReceivedJob, null);
            Assert.AreEqual(112, LastReceivedJob.DocumentID);
            Assert.IsTrue(LastReceivedEA.OutputParseResult.Errors.Count() > 0);
            Assert.IsTrue(JobFailed_Reported);
        }

        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void LocksUpOnPdfInUseTest()
        {
            // lock the pdf, and check that still the compiler returns, and not produces deadlock
            LastReceivedJob = null;
            // compile, now pdf should be in place
            tc.AddJobExclusive(NonStandAloneCode, "temp3.tex", true, 113);
            // lock the pdf and recompile
            using (FileStream fs = new FileStream("temp3.pdf", FileMode.OpenOrCreate))
            {
                // tc.timeout = 6000;
                tc.AddJobExclusive(NonStandAloneCode, "temp3.tex", true, 113);
            }
            Assert.AreNotEqual(LastReceivedJob, null);
            Assert.AreEqual(113, LastReceivedJob.DocumentID);
            Assert.IsTrue(LastReceivedEA.OutputParseResult.Errors.Count() > 0);
            Assert.IsTrue(JobFailed_Reported);
        }

    }
}
