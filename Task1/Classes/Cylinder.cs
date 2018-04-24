using System;

namespace Task1.Classes
{
    public class Cylinder: Circle
    {
        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Inappropriate cylinder height");
                }
                height = value;
            }
        }
        public Cylinder (Color _outlineColor = Color.black, Color _pouringColor = Color.blue, double _outlineWidth = 0.0, double _radius = 0.0,
                        double _height = 0.0): base(_outlineColor, _pouringColor, _outlineWidth, _radius)
        {
            Height = _height;
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Height:{0}", Height);
        }
        public double Volume()
        {
            return Area() * Height;
        }
    }
}
