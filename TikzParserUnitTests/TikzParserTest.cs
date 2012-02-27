using TikzEdt.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TikzParserUnitTests
{
    
    
    /// <summary>
    ///This is a test class for TikzParserTest and is intended
    ///to contain all TikzParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TikzParserTest
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
        ///A test for ParseInputFile
        ///</summary>
        [TestMethod()]
        public void ParseInputFileTest()
        {
            /*
            string code = string.Empty; // TODO: Initialize to an appropriate value
            Tikz_ParseTree expected = null; // TODO: Initialize to an appropriate value
            Tikz_ParseTree actual;
            actual = TikzParser.ParseInputFile(code);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
             */
        }

        /// <summary>
        /// A test for Parse.
        /// Loads one by one all files in testcases folder and tries to compile.
        /// Compilation should go through without error.
        ///</summary>
        [TestMethod()]
        public void ParseTest()
        {
            foreach (string file in Directory.EnumerateFiles("..\\..\\..\\TikzParserUnitTests\\testcases", "*.tex"))
            {

                string code = File.ReadAllText(file);
                
                Tikz_ParseTree actual;

                try
                {
                    actual = TikzParser.Parse(code);
                }
                catch (Exception ex)
                {
                    Assert.Fail("Exception in file: " + file + Environment.NewLine + ex.Message);
                }
            }            
        }

        /// <summary>
        /// A test for Parse.
        /// Loads one by one all files in testcases folder and tries to compile.
        /// Compilation should go through without error.
        ///</summary>
        [TestMethod()]
        public void ParseTestStyleDetection()
        {
            string code =
                @"
\tikzstyle{test 1}=[draw]
%!TE% \tikzset{ test   2 /.style={draw}}
\begin{tikzpicture}[test   3/.style={draw}]
\tikzstyle{test 4}=[draw]
\tikzset{   test   5/.style={draw}}

\end{tikzpicture}
";
            Tikz_ParseTree T = TikzParser.Parse(code);
            Assert.AreEqual<int>(5, T.styles.Count);            

            // check whether style names are stored with whitespace removed
            for (int i=1;i<=5;i++)
                Assert.IsTrue(T.styles.ContainsKey( "test "+i));
        }





    }
}
