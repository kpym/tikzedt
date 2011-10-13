using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt;
using TikzEdt.ViewModels;
using NUnit.Framework;
using System.Threading;
using System.IO;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Permissions;
using System.Windows.Threading;
namespace TEAppLogicNUnitTests
{
    [TestFixture, RequiresSTA]
    class TexCompilerTests
    {

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

        [TestFixtureSetUp]
        public static void MyClassInitialize()
        {

        }

        [SetUp]
        public void TestSetup()
        {
            tc = new TexCompiler();
            tc.JobDone += (s, e) => { LastReceivedJob = e.job; LastReceivedEA = e; JobFailed_Reported = e.ExitCode != 0; };                  

            LastReceivedJob = null;
            LastReceivedEA = null;
            JobFailed_Reported = false;
        }

        [Test]
        public void PrecompiledHeaderJobTest()
        {


        }

        [Test]
        public void AddJobTest_PCHCreation()
        {
            
            // Delete the precompiled header and check that it is re-created
            string pchPath = Helper.GetPrecompiledHeaderFMTFilePath();
            if (File.Exists(pchPath))
                File.Delete(pchPath);

            tc.AddJobExclusive(NonStandAloneCode, null, true, 111);

            Assert.IsTrue(File.Exists(pchPath));            
        }

        [Test]
        public void AddJobTest_BBreadout()
        {
            // Check that the bounding box is read out and is approximately correct
            LastReceivedJob = null;
            tc.AddJobExclusive(NonStandAloneCode, null, true, 111);
            tc.AddJobExclusive(NonStandAloneCode, null, true, 111);

            Assert.AreNotEqual(LastReceivedJob, null);
            Assert.AreEqual(LastReceivedJob.DocumentID, 111);
            Assert.That(LastReceivedJob.BB.Width, Is.EqualTo(3).Within(0.5));
            Assert.That(LastReceivedJob.BB.Height, Is.EqualTo(3).Within(0.5));


        }

        [Test]
        public void ErrorHandlingTest()
        {            
            tc.AddJobExclusive(JunkCode, null, true, 112);

            Assert.AreNotEqual(LastReceivedJob, null);
            Assert.AreEqual(LastReceivedJob.DocumentID, 112);
            Assert.IsTrue(LastReceivedEA.OutputParseResult.Errors.Count() > 0);
            Assert.IsTrue(LastReceivedEA.OutputParseResult.Errors.Any(err => err.severity == Severity.ERROR) );
            Assert.IsTrue(JobFailed_Reported);
        }

        [Test]
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
            Assert.AreEqual(LastReceivedJob.DocumentID, 113);
            Assert.IsTrue(LastReceivedEA.OutputParseResult.Errors.Count() > 0);
            Assert.IsTrue(JobFailed_Reported);
        }

    }
}
