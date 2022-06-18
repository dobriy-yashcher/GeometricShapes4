//Turushkin Sergey, 220P "GeometricShapes4" 01.06.22

using System;

namespace FiguresCore
{
    [Serializable]
    public class Triangle : FilledFigure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;
        public Point C;

        public Triangle(Point a, Point b, Point c) : base(a)
        {
            B = b;
            C = c;
        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
        {
            B = new Point(x2, y2);
            C = new Point(x3, y3);
        }

        public override string ToString()
        {
            return ($"Triangle: A {A} - B {B} - C {C}");
        }

        public override void Draw()
        {
            drawer.DrawTriangle(A.X, A.Y, B.X, B.Y, C.X, C.Y);
        }
    }
}
