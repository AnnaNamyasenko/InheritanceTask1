using System;

namespace Task1
{
    public class Circle: Figure
    {
        protected double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Inappropriate circle radius");
                }
                radius = value;
            }
        }

        public Circle(Color _outlineColor = Color.black, Color _pouringColor = Color.blue, double _outlineWidth = 0.0, double _radius = 0.0)
                      :base(_outlineColor, _pouringColor, _outlineWidth)
        {
            Radius = _radius;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Radius:{0}", Radius);
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

    }
}
