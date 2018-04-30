using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Globalization.CultureInfo;
using System.Collections.Generic;
using Task1;
using Task1.Classes;

namespace Task1_UnitTest
{
    [TestClass]
    public class RectangleUnitTest
    {
        public void AreaTestMethod()
        {
            Rectangle figure = new Rectangle(Color.green, Color.pink, 0.1, 1.5, 2);
            double expected = 6;
            double actual = figure.Area();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PerimeterTestMethod()
        {
            Rectangle figure = new Rectangle(Color.green, Color.pink, 0.1, 1.5, 2);
            double expected = 7;
            double actual = figure.Perimeter();
            Assert.AreEqual(expected, actual);
        }
    }
}