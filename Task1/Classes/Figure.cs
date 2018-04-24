using System;

namespace Task1
{
    public enum Color { red, blue, yellow, green, white, black, brown, pink };


    public abstract class Figure
    {
        protected double outlineWidth;
        public Color OutlineColor { get; set; }
        public Color PouringColor { get; set; }
        public double OutlineWidth
        {
            get
            {
                return outlineWidth;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Inappropriate outline width");
                }
                outlineWidth = value;
            }
        }


        public Figure(Color _outlineColor = Color.black, Color _pouringColor = Color.blue, double _outlineWidth = 0.0)
        {
            OutlineColor = _outlineColor;
            PouringColor = _pouringColor;
            OutlineWidth = _outlineWidth;
        }
    
        public virtual void Output()
        {
            Console.WriteLine("Outline color: {0}", OutlineColor);
            Console.WriteLine("Outline width: {0}", OutlineWidth);
            Console.WriteLine("Pouring color: {0}", PouringColor);
        }
        public abstract double Area();
        public abstract double Perimeter();
    }
        
}
