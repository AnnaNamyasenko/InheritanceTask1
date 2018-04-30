using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Globalization.CultureInfo;
using System.Collections.Generic;
using Task1;

namespace Task1_UnitTest
{
    [TestClass]
    public class CircleUnitTest
    {
        [TestMethod]
        public void AreaTestMethod()
        {
            Circle figure = new Circle(Color.blue, Color.green, 1, 3);
            double expected = 28.27;
            double actual = figure.Area();
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }
        [TestMethod]
        public void PerimeterTestMethod()
        {
            Circle figure = new Circle(Color.blue, Color.green, 1, 3);
            double expected = 18.85;
            double actual = figure.Perimeter();
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }
    }
}