using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Globalization.CultureInfo;
using System.Collections.Generic;
using Task1;
using Task1.Classes;

namespace Task1_UnitTest
{
    [TestClass]
    public class ParallelepipedUnitTest
    {
        public void AreaTestMethod()
        {
            Parallelepiped figure = new Parallelepiped(Color.white, Color.yellow, 0.1, 1, 1, 1);
            double expected = 6;
            double actual = figure.Area();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VolumeTestMethod()
        {
            Parallelepiped figure = new Parallelepiped(Color.white, Color.yellow, 0.1, 1.1, 1.6, 1.2);
            double expected = 2.112;
            double actual = figure.Volume();
            Assert.AreEqual(expected, actual);
        }
    }
}