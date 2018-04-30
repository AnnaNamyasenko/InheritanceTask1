using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Globalization.CultureInfo;
using System.Collections.Generic;
using Task1;
using Task1.Classes;

namespace Task1_UnitTest
{
    [TestClass]
    public class СylinderUnitTest
    {
        public void AreaTestMethod()
        {
            Cylinder figure = new Cylinder(Color.black, Color.blue, 0.1, 1, 1);
            double expected = 3.14;
            double actual = figure.Area();
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }
        [TestMethod]
        public void VolumeTestMethod()
        {
            Cylinder figure = new Cylinder(Color.black, Color.blue, 0.1, 1.3, 1.4);
            double expected = 7.43;
            double actual = figure.Volume();
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }
    }
}