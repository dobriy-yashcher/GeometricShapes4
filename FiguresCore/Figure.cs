//Turushkin Sergey, 220P "GeometricShapes4" 01.06.22

using System;

namespace FiguresCore
{
    [Serializable]
    public struct Point
    {
        public decimal X;
        public decimal Y;

        public Point(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }
    }

    [Serializable]
    public class Figure
    {
        public Point basePoint;
        public Drawer drawer;

        public Figure(Point point)
        {
            basePoint = point;
        }

        public Figure(decimal x = 0, decimal y = 0)
        {
            basePoint = new Point(x, y);
        }

        public override string ToString()
        {
            return ($"Figure: at {basePoint}");
        }

        public virtual void Draw()
        { }
    }
}
