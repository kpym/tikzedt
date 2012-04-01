using TikzEdt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;

namespace TEApplicationLogicUnitTests
{
    
    
    /// <summary>
    ///This is a test class for RasterControlModelTest and is intended
    ///to contain all RasterControlModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RasterControlModelTest
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
        ///A test for DrawRaster
        ///</summary>
        [TestMethod()]
        public void DrawRasterTest()
        {
            IRasterControlView View = null; // TODO: Initialize to an appropriate value
            RasterControlModel target = new RasterControlModel(View); // TODO: Initialize to an appropriate value
            Action<Point, Point> LineDrawMethod = null; // TODO: Initialize to an appropriate value
            Action<double, double> EllipseDrawMethod = null; // TODO: Initialize to an appropriate value
            target.DrawRaster(LineDrawMethod, EllipseDrawMethod);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RasterizePixelToTikz
        ///</summary>
        [TestMethod()]
        public void RasterizePixelToTikzTest()
        {
            IRasterControlView View = null; // TODO: Initialize to an appropriate value
            RasterControlModel target = new RasterControlModel(View); // TODO: Initialize to an appropriate value
            Point p = new Point(); // TODO: Initialize to an appropriate value
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            actual = target.RasterizePixelToTikz(p);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RasterizePixelRelative
        ///</summary>
        [TestMethod()]
        public void RasterizePixelRelativeTest()
        {
            IRasterControlView View = null; // TODO: Initialize to an appropriate value
            RasterControlModel target = new RasterControlModel(View); // TODO: Initialize to an appropriate value
            Point p = new Point(); // TODO: Initialize to an appropriate value
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            actual = target.RasterizePixelRelative(p);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EstimateRasterSteps
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void EstimateRasterStepsTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            RasterControlModel_Accessor target = new RasterControlModel_Accessor(param0); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.EstimateRasterSteps();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RasterizePixel
        ///</summary>
        [TestMethod()]
        public void RasterizePixelTest()
        {
            IRasterControlView View = null; // TODO: Initialize to an appropriate value
            RasterControlModel target = new RasterControlModel(View); // TODO: Initialize to an appropriate value
            Point p = new Point(); // TODO: Initialize to an appropriate value
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            actual = target.RasterizePixel(p);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Rasterize
        ///</summary>
        [TestMethod()]
        public void RasterizeTest()
        {
            IRasterControlView View = null; // TODO: Initialize to an appropriate value
            RasterControlModel target = new RasterControlModel(View); // TODO: Initialize to an appropriate value
            Point p = new Point(); // TODO: Initialize to an appropriate value
            bool IsRelative = false; // TODO: Initialize to an appropriate value
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            actual = target.Rasterize(p, IsRelative);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
