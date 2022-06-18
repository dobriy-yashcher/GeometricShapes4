//Turushkin Sergey, 220P "GeometricShapes4" 01.06.22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresCore
{
    [Serializable]
    abstract public class Drawer
    {
        public abstract void DrawLine(decimal x1, decimal y1, decimal x2, decimal y2);
        public abstract void DrawCircle(decimal x, decimal y, decimal r);
        public abstract void DrawRectangle(decimal x, decimal y, decimal height, decimal width);
        public abstract void DrawTriangle(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3);
        public abstract void DrawFigires(List<FilledFigure> page);
    }
}
