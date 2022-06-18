//Turushkin Sergey, 220P "GeometricShapes4" 01.06.22

using System;
using System.Drawing;

namespace FiguresCore
{
    [Serializable]
    public struct StrokeData
    {
        public decimal Width;
        public Color Color;
    }

    [Serializable]
    public struct FillData
    {
        public Color Color;
    }

    [Serializable]
    public class FilledFigure : Figure
    {
        public FillData Fill;
        public StrokeData Stroke;

        public FilledFigure(Point point) : base(point)
        {
            Fill.Color = Color.Black;
            Stroke.Color = Color.Black;
        }

        public FilledFigure(decimal x, decimal y) : base(x, y)
        {
            Fill.Color = Color.Black;
            Stroke.Color = Color.Black;
        }
    }
}
