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

        [TestMethod()]
        public void ParseTest2()
        {
            string code =
@"\begin{tikzpicture}
\draw (1,2) -- (3,3);
\end{tikzpicture}
";
            Tikz_ParseTree actual = TikzParser.Parse(code);

            Tikz_Picture tp = actual.GetTikzPicture();
            Assert.AreEqual(0, tp.StartPosition());
            Tikz_Path tpa = tp.Children.Find(tpi => tpi is Tikz_Path) as Tikz_Path;

            Assert.AreEqual(21, tpa.StartPosition());
            Tikz_Coord tc = tpa.Children.Find(tpi => tpi is Tikz_Coord) as Tikz_Coord;

            Assert.AreEqual(1, tc.uX.number);
            Assert.AreEqual(2, tc.uY.number);

            Assert.AreEqual(27, tc.StartPosition());

        }

        [TestMethod()]
        public void ParseTest3()
        {
            string code =
@"%some text
\begin{tikzpicture}
\draw (1,2) -- (3,3);
\end{tikzpicture}
";
            Tikz_ParseTree actual = TikzParser.Parse(code);

            Tikz_Picture tp = actual.GetTikzPicture();
            Assert.AreEqual(12, tp.StartPosition());
            Tikz_Path tpa = tp.Children.Find(tpi => tpi is Tikz_Path) as Tikz_Path;

            Assert.AreEqual(33, tpa.StartPosition());
            Tikz_Coord tc = tpa.Children.Find(tpi => tpi is Tikz_Coord) as Tikz_Coord;

            Assert.AreEqual(1, tc.uX.number);
            Assert.AreEqual(2, tc.uY.number);

            Assert.AreEqual(39, tc.StartPosition());

        }

        [TestMethod()]
        public void ParseTest4()
        {
            string code =
@"%some text
\begin{tikzpicture}[scale=2]
\draw (1,2) node (v) {bla} -- (3,3);
\end{tikzpicture}
";
            Tikz_ParseTree actual = TikzParser.Parse(code);

            Tikz_Picture tp = actual.GetTikzPicture();
            Tikz_Node n = tp.GetNodeByName("v");
            System.Windows.Point p;
            bool ret = n.GetAbsPos(out p);
            Assert.IsTrue(ret);
            Assert.AreEqual(2, p.X);
            Assert.AreEqual(4, p.Y);
            Assert.AreEqual("bla", n.label);
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
