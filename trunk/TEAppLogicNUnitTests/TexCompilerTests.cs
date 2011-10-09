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
\end{tikzpicture
";

        string JunkCode =
@"sdfsdlfj sfdlj klsdf lsdjf ksdfj l";

        TexCompiler tc;
        TexCompiler.Job LastReceivedJob;

        [TestFixtureSetUp]
        public static void MyClassInitialize()
        {

        }

        [SetUp]
        public void TestSetup()
        {
            tc = new TexCompiler();
            tc.JobSucceeded += (s, e) => LastReceivedJob = e.job;
        }

        [Test]
        public void PrecompiedHeaderJobTest()
        {


        }

        [Test]
        public void AddJobTest_PCHCreation()
        {
            
            // Delete the precompiled header and check that it is re-created
            string pchPath = Helper.GetPrecompiledHeaderPath() + Helper.GetPrecompiledHeaderFilename();
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
            Assert.AreNotEqual(LastReceivedJob, null);
            Assert.AreEqual(LastReceivedJob.DocumentID, 111);
            Assert.That(LastReceivedJob.BB.Width, Is.EqualTo(3).Within(0.1));
            Assert.That(LastReceivedJob.BB.Height, Is.EqualTo(3).Within(0.1));


        }

    }
}
