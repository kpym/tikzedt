using TikzEdt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows;
using Rhino.Mocks;
using System.Collections.Generic;

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
            IRasterControlView View = MockRepository.GenerateStub<IRasterControlView>();
            View.Resolution = 100;
            View.RasterWidth = 1;
            View.IsCartesian = true;
            View.BB = new Rect(0, 0, 10, 10);
            View.CoordinateTransform = new TikzEdt.Parser.TikzMatrix();

            RasterControlModel target = new RasterControlModel(View);
            List<Point> lstpts = new List<Point>();
            List<double> lstrads = new List<double>();
            Action<Point, Point> LineDrawMethod = (p1,p2)=>lstpts.Add(p1);
            Action<double, double> EllipseDrawMethod = (r1,r2)=>lstrads.Add(r1); 
            target.DrawRaster(LineDrawMethod, EllipseDrawMethod);
            Assert.IsTrue( lstpts.TrueForAll(p=> p.X == Math.Round(p.X) &&   p.Y == Math.Round(p.Y)));
            Assert.AreEqual(0, lstrads.Count);
        }

        /// <summary>
        ///A test for RasterizePixelToTikz
        ///</summary>
        [TestMethod()]
        public void RasterizePixelToTikzTest()
        {
            IRasterControlView View = MockRepository.GenerateStub<IRasterControlView>();
            View.Resolution = 100;
            View.RasterWidth = 1;
            View.IsCartesian = true;
            View.BB = new Rect(0, 0, 10, 10);
            View.CoordinateTransform = new TikzEdt.Parser.TikzMatrix();

            RasterControlModel target = new RasterControlModel(View);
            Point p = new Point(30, 70);
            Point expected = new Point(0, 1);
            Point actual;
            actual = target.RasterizePixelToTikz(p);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for RasterizePixelRelative
        ///</summary>
        [TestMethod()]
        public void RasterizePixelRelativeTest()
        {
            IRasterControlView View = MockRepository.GenerateStub<IRasterControlView>();
            View.Resolution = 100;
            View.RasterWidth = 1;
            View.IsCartesian = true;
            View.BB = new Rect(0, 0, 10, 10);
            View.CoordinateTransform = new TikzEdt.Parser.TikzMatrix();

            RasterControlModel target = new RasterControlModel(View);
            Point p = new Point(30, 70);
            Point expected = new Point(0, 100);
            Point actual;
            actual = target.RasterizePixelRelative(p);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for EstimateRasterSteps
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TEApplicationLogic.dll")]
        public void EstimateRasterStepsTest()
        {
            IRasterControlView View = MockRepository.GenerateStub<IRasterControlView>();
            View.Resolution = 100;
            View.RasterWidth = 1;
            View.IsCartesian = true;
            View.BB = new Rect(0, 0, 10, 10);
            View.CoordinateTransform = new TikzEdt.Parser.TikzMatrix();

            RasterControlModel_Accessor target = new RasterControlModel_Accessor(View);             
            int actual;
            actual = target.EstimateRasterSteps();
            Assert.IsTrue(actual >= 10);
            Assert.IsTrue(actual <= 20);
        }

        /// <summary>
        ///A test for RasterizePixel
        ///</summary>
        [TestMethod()]
        public void RasterizePixelTest()
        {
            IRasterControlView View = MockRepository.GenerateStub<IRasterControlView>();
            View.Resolution = 100;
            View.RasterWidth = 1;
            View.IsCartesian = true;
            View.BB = new Rect(0, 0, 10, 10);
            View.CoordinateTransform = new TikzEdt.Parser.TikzMatrix();

            RasterControlModel target = new RasterControlModel(View);
            Point p = new Point(30, 70); 
            Point expected = new Point(0, 100); 
            Point actual;
            actual = target.RasterizePixel(p);
            Assert.AreEqual(expected, actual);
           

        }

        /// <summary>
        ///A test for Rasterize
        ///</summary>
        [TestMethod()]
        public void RasterizeTest()
        {
            IRasterControlView View = MockRepository.GenerateStub<IRasterControlView>();
            View.Resolution = 100;
            View.RasterWidth = 1;
            View.IsCartesian = true;
            View.BB = new Rect(0.5, 0.5, 10, 10);
            View.CoordinateTransform = new TikzEdt.Parser.TikzMatrix();

            RasterControlModel target = new RasterControlModel(View);
            Point p = new Point(3, 3); // TODO: Initialize to an appropriate value
            Point expected = new Point(3, 3); // TODO: Initialize to an appropriate value
            Point actual;
            actual = target.Rasterize(p);
            Assert.AreEqual(expected, actual);

            p = new Point(3.2, 3.7);
            expected = new Point(3, 4);
            actual = target.Rasterize(p);
            Assert.AreEqual(expected, actual);

            p = new Point(3.2, 3.5);
            expected = new Point(3, 4);
            actual = target.Rasterize(p);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
