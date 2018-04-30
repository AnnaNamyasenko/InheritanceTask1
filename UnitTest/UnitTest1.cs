using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Globalization.CultureInfo;
using System.Collections.Generic;
using Task1;

namespace Task1_UnitTest
{
    [TestClass]
    public class TaskUnitTest
    {
        [TestMethod]
        public void TotalAreaTestMethod()
        {
            List<Figure> figures = new List<Figure>();

            figures.Add(new Circle(Color.blue, Color.green, 1, 3));
            figures.Add(new Rectangle(Color.pink, Color.red, 0.1, 1.5, 1.4));

            double expected = 30.37;
            double actual = TaskImplementation.FindSummaryArea(figures);
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }
        [TestMethod]
        public void TotalPerimeterTestMethod()
        {
            List<Figure> figures = new List<Figure>();

            figures.Add(new Circle(Color.blue, Color.green, 1, 3));
            figures.Add(new Task1.Classes.Cylinder(Color.black, Color.blue, 0.1, 1.3, 1.4));
            figures.Add(new Rectangle(Color.green, Color.pink, 0.1, 1.5, 1.7));

            double expected = 33.42;
            double actual = TaskImplementation.FindSummaryPerimeter(figures);
            Assert.AreEqual(expected, Math.Round(actual, 2));
        }
    }
}