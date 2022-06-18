using FiguresCore;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace GeometricShapes3
{
    [Serializable]
    public class WFDrawer : Drawer
    {
        [NonSerialized]
        private Pen pen;
        [NonSerialized]
        private Graphics paper;
        [NonSerialized]
        private SolidBrush brush = new SolidBrush(Color.White);

        public WFDrawer(Graphics newPaper, FilledFigure fig)
        {
            pen = new Pen(fig.Stroke.Color, (int)fig.Stroke.Width);
            try
            {
                brush = new SolidBrush(fig.Fill.Color);
            }
            catch (Exception) { }
            paper = newPaper;
        }

        public WFDrawer(Graphics newPaper)
        {
            paper = newPaper;
        }

        public override void DrawLine(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            paper.DrawLine(pen, (int)x1, (int)y1, (int)x2, (int)y2);
        }

        public override void DrawCircle(decimal x, decimal y, decimal r)
        {
            paper.FillEllipse(brush, (int)x, (int)y, (int)r, (int)r);
            paper.DrawEllipse(pen, (int)x, (int)y, (int)r, (int)r);
        }

        public override void DrawRectangle(decimal x, decimal y, decimal height, decimal width)
        {
            paper.FillRectangle(brush, (int)x, (int)y, (int)width, (int)height);
            paper.DrawRectangle(pen, (int)x, (int)y, (int)width, (int)height);
        }

        public override void DrawTriangle(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3)
        {
            var points = new PointF[] {
                         new PointF((int)x1, (int)y1),
                         new PointF((int)x2, (int)y2),
                         new PointF((int)x3, (int)y3) };

            paper.FillPolygon(brush, points);
            paper.DrawPolygon(pen, points);
        }

        public override void DrawFigires(List<FilledFigure> page)
        {
           foreach (var fig in page)
           {
                fig.drawer = new WFDrawer(paper, fig);

                try
                {
                    fig.Draw();
                }
                catch (Exception)
                {
                    fig.Draw();
                }
           }
        }
    }
}
