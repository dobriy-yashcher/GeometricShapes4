//Turushkin Sergey, 220P "GeometricShapes3" 01.06.22

using System;
using FiguresCore;
using System.Drawing;
using System.Windows.Forms;

namespace GeometricShapes3
{
    [Serializable]
    public partial class frmMain : Form
    {
        Graphics paper;
        private static Figires image = new Figires();

        public frmMain()
        {
            InitializeComponent();
            paper = pnlDrawPlace.CreateGraphics();
        }

        private void lstVFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? selectedCountry = null;

            try
            {
                selectedCountry = lstVFigures.FocusedItem.Index;
            }
            catch (Exception) { }

            switch (selectedCountry)
            {
                case 0:
                    HidePanel();
                    pnlLineData.Visible = true;

                    lblFillColor.Visible = false;
                    btnFillColor.Visible = false;
                    break;
                case 1:
                    HidePanel();
                    pnlCircleData.Visible = true;
                    break;
                case 2:
                    HidePanel();
                    pnlRectangleData.Visible = true;
                    break;
                case 3:
                    HidePanel();
                    pnlTriangleData.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void HidePanel()
        {
            pnlLineData.Visible = false;
            pnlCircleData.Visible = false;
            pnlRectangleData.Visible = false;
            pnlTriangleData.Visible = false;

            lblFillColor.Visible = true;
            btnFillColor.Visible = true;
        }

        private void btnLineAdd_Click(object sender, EventArgs e)
        {
            var p1 = new FiguresCore.Point(nmcLinePointAx.Value, nmcLinePointAy.Value);
            var p2 = new FiguresCore.Point(nmcLinePointBx.Value, nmcLinePointBy.Value);
            var line = new Line(p1, p2);
            line.Stroke.Color = image.strokeColor;
            line.Stroke.Width = nmcStrokeWidth.Value;

            line.drawer = new WFDrawer(paper, line);
            line.Draw();

            image.Add(line);
        }

        private void btnCircleAdd_Click(object sender, EventArgs e)
        {
            var p1 = new FiguresCore.Point(nmcCirclePointAx.Value, nmcCirclePointAy.Value);
            var circle = new Circle(p1, nmcCircleRadius.Value);
            circle.Stroke.Color = image.strokeColor;
            circle.Fill.Color = image.fillColor;
            circle.Stroke.Width = nmcStrokeWidth.Value;

            circle.drawer = new WFDrawer(paper, circle);
            circle.Draw();

            image.Add(circle);
        }

        private void btnTriangleAdd_Click(object sender, EventArgs e)
        {
            var p1 = new FiguresCore.Point(nmcTrianglePointAx.Value, nmcTrianglePointAy.Value);
            var p2 = new FiguresCore.Point(nmcTrianglePointBx.Value, nmcTrianglePointBy.Value);
            var p3 = new FiguresCore.Point(nmcTrianglePointCx.Value, nmcTrianglePointCy.Value);
            var triangle = new Triangle(p1, p2, p3);
            triangle.Stroke.Color = image.strokeColor;
            triangle.Fill.Color = image.fillColor;
            triangle.Stroke.Width = nmcStrokeWidth.Value;

            triangle.drawer = new WFDrawer(paper, triangle);
            triangle.Draw();

            image.Add(triangle);
        }

        private void btnRectangleAdd_Click(object sender, EventArgs e)
        {
            var p1 = new FiguresCore.Point(nmcRectanglePointAx.Value, nmcRectanglePointAy.Value);
            var rectandle = new FiguresCore.Rectangle(p1, nmcRectangleHeight.Value, nmcRectangleWidth.Value);
            rectandle.Stroke.Color = image.strokeColor;
            rectandle.Fill.Color = image.fillColor;
            rectandle.Stroke.Width = nmcStrokeWidth.Value;

            rectandle.drawer = new WFDrawer(paper, rectandle);
            rectandle.Draw();

            image.Add(rectandle);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = saveFileDialog.FileName;

            image.Save(filename);

            MessageBox.Show("Файл сохранен");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            paper.Clear(Color.White);
            image.page.Clear();

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog.FileName;

            image.Load(filename);
            image.drawer = new WFDrawer(this.paper);
            image.Draw();

            MessageBox.Show("Файл открыт");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paper.Clear(Color.White);
            image.page.Clear();
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var color = colorDialog.Color;
            btnFillColor.BackColor = color;
            image.fillColor = color;
        }

        private void btnStrokeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var color = colorDialog.Color;
            btnStrokeColor.BackColor = color;
            image.strokeColor = color;
        }
    }
}
