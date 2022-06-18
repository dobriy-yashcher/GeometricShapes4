//Turushkin Sergey, 220P "GeometricShapes3" 01.06.22

using System;

namespace FiguresCore
{
    [Serializable]
    public class Line : FilledFigure
    {
        protected Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        protected Point B;
        protected StrokeData Stroke;
        
        public Line(Point a, Point b) : base(a)
        {
            B = b;
        }

        public Line(decimal x1, decimal y1, decimal x2, decimal y2) : base(x1, y1)
        {
            B = new Point(x2, y2);
        }

        public override string ToString()
        {
            return ($"Line: A {A} - B {B}, Stroke width: {Stroke.Width}, Stroke color: {Stroke.Color}");
        }

        public override void Draw()
        {
            drawer.DrawLine(A.X, A.Y, B.X, B.Y);
        }
    }
}