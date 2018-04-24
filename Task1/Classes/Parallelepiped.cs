using System;

namespace Task1.Classes
{
    public class Parallelepiped: Rectangle
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
                if(value < 0)
                {
                    throw new ArgumentException("Inappropriate parallelepiped height");
                }
                height = value;
            }
        }

        public Parallelepiped(Color _outlineColor = Color.black, Color _pouringColor = Color.blue, double _outlineWidth = 0.0,
                              double _width = 0.0, double _length = 0.0, double _height = 0.0): base(_outlineColor, _pouringColor, _outlineWidth,
                                  _width, _length)
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
