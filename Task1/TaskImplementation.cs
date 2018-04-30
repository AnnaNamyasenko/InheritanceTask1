using System;
using System.Collections.Generic;
using Task1.Classes;

namespace Task1
{
    public class TaskImplementation
    {
        public List<Figure> GetFigures()
        {
            List<Figure> figures = new List<Figure>
            {
                new Circle(Color.red, Color.green, 2.5, 5),
                new Rectangle(Color.blue, Color.white, 3, 4, 5),
                new Parallelepiped(Color.yellow, Color.black, 1.3, 2, 3, 4),
                new Cylinder(Color.blue, Color.brown, 1, 4, 2)
            };
            return figures;
        }

        public void Output(List<Figure> figures)
        {
            Console.WriteLine("Our figures");
            Console.WriteLine("-----------");
            for (int i = 0; i < figures.Count; i++)
            {
                Console.WriteLine(figures[i].GetType());
                figures[i].Output();
                Console.WriteLine();
            }
        }

        public static double FindSummaryPerimeter(List<Figure> figures)
        {
            double summaryPerimeter = 0;
            for (int i = 0; i < figures.Count; i++)
            {
                summaryPerimeter += figures[i].Perimeter();
            }
            return summaryPerimeter;
        }

        public static double FindSummaryArea(List<Figure> figures)
        {
            double summaryArea = 0;
            for (int i = 0; i < figures.Count; i++)
            {
                summaryArea += figures[i].Area();
            }
            return summaryArea;
        }

        public void Execute()
        {
            List<Figure> figures = GetFigures();
            Output(figures);

            Console.WriteLine("Summary perimeter:");
            Console.WriteLine(FindSummaryPerimeter(figures));
            Console.WriteLine("Summary area: ");
            Console.WriteLine(FindSummaryArea(figures));
        }
    }
}

