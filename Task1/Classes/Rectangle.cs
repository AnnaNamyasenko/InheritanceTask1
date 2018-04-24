using System;

namespace Task1
{
    public class Rectangle: Figure
    { 
        protected double width;
        protected double length;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if( value < 0)
                {
                    throw new ArgumentException("Inappropriate rectangle width");
                }
                width = value;
            }
        }
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Inappropriate rectangle length");
                }
                length = value;
            }
        }

        public Rectangle(Color _outlineColor = Color.black, Color _pouringColor = Color.blue, double _outlineWidth = 0.0, double _width = 0.0, 
                          double _length = 0.0): base(_outlineColor, _pouringColor, _outlineWidth)
        {
            Width = _width;
            Length = _length;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Width:{0}", Width);
            Console.WriteLine("Length:{0}", Length);
        }
        public override double Area()
        {
            return Width * Length;
        }

        public override double Perimeter()
        {
            return 2 * (Width + Length);
        }

    }
}
