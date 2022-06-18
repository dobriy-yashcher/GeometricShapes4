//Turushkin Sergey, 220P "GeometricShapes4" 01.06.22

using System;

namespace FiguresCore
{
    [Serializable]
    public class Circle : FilledFigure
    {
        protected decimal Radius;
        public Circle(Point point, decimal radius) : base(point)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return ($"Circle: at {basePoint}, Radius: {Radius}");
        }

        public override void Draw()
        {
            drawer.DrawCircle(basePoint.X, basePoint.Y, Radius);
        }
    }
}