//Turushkin Sergey, 220P "GeometricShapes3" 01.06.22

using System;

namespace FiguresCore
{
    [Serializable]
    public class Rectangle : FilledFigure
    {
        protected decimal Height;
        protected decimal Width;

        public Rectangle(Point point, decimal height, decimal width) : base(point)
        {
            Height = height;
            Width = width;
        }

        public override string ToString()
        {
            return ($"Rectangle: at {basePoint}, Height: {Height}, Width: {Width}");
        }

        public override void Draw()
        {
            drawer.DrawRectangle(basePoint.X, basePoint.Y, Height, Width);
        }
    }
}