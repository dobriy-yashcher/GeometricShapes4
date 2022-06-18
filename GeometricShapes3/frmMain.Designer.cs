//Turushkin Sergey, 220P "GeometricShapes3" 01.06.22

using FiguresCore;
using System;

namespace GeometricShapes3
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //private static Figires image = new Figires();

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Line", "line.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Circle", "circle.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Rectangle", "rectangle.png");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Triangle", "triangle.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlFigures = new System.Windows.Forms.Panel();
            this.pnlDesign = new System.Windows.Forms.Panel();
            this.btnStrokeColor = new System.Windows.Forms.Button();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.lblFillColor = new System.Windows.Forms.Label();
            this.lblStrokeWidth = new System.Windows.Forms.Label();
            this.lblStrokeColor = new System.Windows.Forms.Label();
            this.nmcStrokeWidth = new System.Windows.Forms.NumericUpDown();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstVFigures = new System.Windows.Forms.ListView();
            this.imgLstFigures = new System.Windows.Forms.ImageList(this.components);
            this.pnlLineData = new System.Windows.Forms.Panel();
            this.btnLineAdd = new System.Windows.Forms.Button();
            this.lblLinePointBy = new System.Windows.Forms.Label();
            this.lblLinePointAy = new System.Windows.Forms.Label();
            this.lblLinePointBx = new System.Windows.Forms.Label();
            this.lblLinePointAx = new System.Windows.Forms.Label();
            this.nmcLinePointBx = new System.Windows.Forms.NumericUpDown();
            this.nmcLinePointAx = new System.Windows.Forms.NumericUpDown();
            this.nmcLinePointBy = new System.Windows.Forms.NumericUpDown();
            this.lblLinePointB = new System.Windows.Forms.Label();
            this.nmcLinePointAy = new System.Windows.Forms.NumericUpDown();
            this.lblLinePointA = new System.Windows.Forms.Label();
            this.pnlCircleData = new System.Windows.Forms.Panel();
            this.btnCircleAdd = new System.Windows.Forms.Button();
            this.nmcCircleRadius = new System.Windows.Forms.NumericUpDown();
            this.lblCircleRadius = new System.Windows.Forms.Label();
            this.lblCirclePointAy = new System.Windows.Forms.Label();
            this.lblCirclePointAx = new System.Windows.Forms.Label();
            this.nmcCirclePointAx = new System.Windows.Forms.NumericUpDown();
            this.nmcCirclePointAy = new System.Windows.Forms.NumericUpDown();
            this.lblCirclePointA = new System.Windows.Forms.Label();
            this.pnlTriangleData = new System.Windows.Forms.Panel();
            this.btnTriangleAdd = new System.Windows.Forms.Button();
            this.lblTrianglePointBy = new System.Windows.Forms.Label();
            this.lblTrianglePointCy = new System.Windows.Forms.Label();
            this.lblTrianglePointAy = new System.Windows.Forms.Label();
            this.lblTrianglePointBx = new System.Windows.Forms.Label();
            this.lblTrianglePointCx = new System.Windows.Forms.Label();
            this.lblTrianglePointAx = new System.Windows.Forms.Label();
            this.nmcTrianglePointBx = new System.Windows.Forms.NumericUpDown();
            this.nmcTrianglePointCx = new System.Windows.Forms.NumericUpDown();
            this.nmcTrianglePointAx = new System.Windows.Forms.NumericUpDown();
            this.nmcTrianglePointBy = new System.Windows.Forms.NumericUpDown();
            this.nmcTrianglePointCy = new System.Windows.Forms.NumericUpDown();
            this.lblTrianglePointB = new System.Windows.Forms.Label();
            this.lblTrianglePointC = new System.Windows.Forms.Label();
            this.nmcTrianglePointAy = new System.Windows.Forms.NumericUpDown();
            this.lblTrianglePointA = new System.Windows.Forms.Label();
            this.pnlRectangleData = new System.Windows.Forms.Panel();
            this.btnRectangleAdd = new System.Windows.Forms.Button();
            this.nmcRectangleHeight = new System.Windows.Forms.NumericUpDown();
            this.nmcRectangleWidth = new System.Windows.Forms.NumericUpDown();
            this.lblRectanglePointAy = new System.Windows.Forms.Label();
            this.lblRectanglePointAx = new System.Windows.Forms.Label();
            this.nmcRectanglePointAx = new System.Windows.Forms.NumericUpDown();
            this.nmcRectanglePointAy = new System.Windows.Forms.NumericUpDown();
            this.lblRectanglePointA = new System.Windows.Forms.Label();
            this.lblRectangleHeight = new System.Windows.Forms.Label();
            this.lblRectangleWidth = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlWorkPlace = new System.Windows.Forms.Panel();
            this.pnlToFillDraw = new System.Windows.Forms.Panel();
            this.pnlDrawPlace = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFigures.SuspendLayout();
            this.pnlDesign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcStrokeWidth)).BeginInit();
            this.pnlLineData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcLinePointBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcLinePointAx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcLinePointBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcLinePointAy)).BeginInit();
            this.pnlCircleData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCircleRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCirclePointAx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCirclePointAy)).BeginInit();
            this.pnlTriangleData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointCx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointAx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointCy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointAy)).BeginInit();
            this.pnlRectangleData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcRectangleHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcRectangleWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcRectanglePointAx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcRectanglePointAy)).BeginInit();
            this.pnlWorkPlace.SuspendLayout();
            this.pnlToFillDraw.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFigures
            // 
            this.pnlFigures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFigures.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlFigures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFigures.Controls.Add(this.pnlDesign);
            this.pnlFigures.Controls.Add(this.btnLoad);
            this.pnlFigures.Controls.Add(this.btnSave);
            this.pnlFigures.Controls.Add(this.lstVFigures);
            this.pnlFigures.Controls.Add(this.pnlRectangleData);
            this.pnlFigures.Controls.Add(this.pnlLineData);
            this.pnlFigures.Controls.Add(this.pnlCircleData);
            this.pnlFigures.Controls.Add(this.pnlTriangleData);
            this.pnlFigures.Location = new System.Drawing.Point(12, 45);
            this.pnlFigures.Name = "pnlFigures";
            this.pnlFigures.Size = new System.Drawing.Size(248, 529);
            this.pnlFigures.TabIndex = 2;
            // 
            // pnlDesign
            // 
            this.pnlDesign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDesign.Controls.Add(this.btnStrokeColor);
            this.pnlDesign.Controls.Add(this.btnFillColor);
            this.pnlDesign.Controls.Add(this.lblFillColor);
            this.pnlDesign.Controls.Add(this.lblStrokeWidth);
            this.pnlDesign.Controls.Add(this.lblStrokeColor);
            this.pnlDesign.Controls.Add(this.nmcStrokeWidth);
            this.pnlDesign.Location = new System.Drawing.Point(15, 138);
            this.pnlDesign.Name = "pnlDesign";
            this.pnlDesign.Size = new System.Drawing.Size(211, 171);
            this.pnlDesign.TabIndex = 8;
            // 
            // btnStrokeColor
            // 
            this.btnStrokeColor.BackColor = System.Drawing.Color.Black;
            this.btnStrokeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStrokeColor.Location = new System.Drawing.Point(95, 50);
            this.btnStrokeColor.Name = "btnStrokeColor";
            this.btnStrokeColor.Size = new System.Drawing.Size(112, 26);
            this.btnStrokeColor.TabIndex = 9;
            this.btnStrokeColor.UseVisualStyleBackColor = false;
            this.btnStrokeColor.Click += new System.EventHandler(this.btnStrokeColor_Click);
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackColor = System.Drawing.Color.Black;
            this.btnFillColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFillColor.Location = new System.Drawing.Point(95, 82);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(112, 26);
            this.btnFillColor.TabIndex = 8;
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // lblFillColor
            // 
            this.lblFillColor.AutoSize = true;
            this.lblFillColor.Location = new System.Drawing.Point(-3, 85);
            this.lblFillColor.Name = "lblFillColor";
            this.lblFillColor.Size = new System.Drawing.Size(71, 20);
            this.lblFillColor.TabIndex = 7;
            this.lblFillColor.Text = "Fill Color:";
            this.lblFillColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStrokeWidth
            // 
            this.lblStrokeWidth.AutoSize = true;
            this.lblStrokeWidth.Location = new System.Drawing.Point(-3, 14);
            this.lblStrokeWidth.Name = "lblStrokeWidth";
            this.lblStrokeWidth.Size = new System.Drawing.Size(98, 20);
            this.lblStrokeWidth.TabIndex = 0;
            this.lblStrokeWidth.Text = "Stroke Width:";
            // 
            // lblStrokeColor
            // 
            this.lblStrokeColor.AutoSize = true;
            this.lblStrokeColor.Location = new System.Drawing.Point(-3, 48);
            this.lblStrokeColor.Name = "lblStrokeColor";
            this.lblStrokeColor.Size = new System.Drawing.Size(94, 20);
            this.lblStrokeColor.TabIndex = 0;
            this.lblStrokeColor.Text = "Stroke Color:";
            this.lblStrokeColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nmcStrokeWidth
            // 
            this.nmcStrokeWidth.Location = new System.Drawing.Point(95, 11);
            this.nmcStrokeWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmcStrokeWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcStrokeWidth.Name = "nmcStrokeWidth";
            this.nmcStrokeWidth.Size = new System.Drawing.Size(112, 26);
            this.nmcStrokeWidth.TabIndex = 5;
            this.nmcStrokeWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoad.Location = new System.Drawing.Point(23, 483);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 28);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(134, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstVFigures
            // 
            this.lstVFigures.HideSelection = false;
            listViewItem2.ToolTipText = "Кружочек";
            this.lstVFigures.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lstVFigures.LargeImageList = this.imgLstFigures;
            this.lstVFigures.Location = new System.Drawing.Point(15, 13);
            this.lstVFigures.MultiSelect = false;
            this.lstVFigures.Name = "lstVFigures";
            this.lstVFigures.Size = new System.Drawing.Size(211, 105);
            this.lstVFigures.SmallImageList = this.imgLstFigures;
            this.lstVFigures.TabIndex = 0;
            this.lstVFigures.Tag = "";
            this.lstVFigures.UseCompatibleStateImageBehavior = false;
            this.lstVFigures.View = System.Windows.Forms.View.List;
            this.lstVFigures.SelectedIndexChanged += new System.EventHandler(this.lstVFigures_SelectedIndexChanged);
            // 
            // imgLstFigures
            // 
            this.imgLstFigures.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLstFigures.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstFigures.ImageStream")));
            this.imgLstFigures.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstFigures.Images.SetKeyName(0, "Gargamel.jpg");
            this.imgLstFigures.Images.SetKeyName(1, "circle.png");
            this.imgLstFigures.Images.SetKeyName(2, "triangle.png");
            this.imgLstFigures.Images.SetKeyName(3, "rectangle.png");
            this.imgLstFigures.Images.SetKeyName(4, "line.png");
            // 
            // pnlLineData
            // 
            this.pnlLineData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlLineData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLineData.Controls.Add(this.btnLineAdd);
            this.pnlLineData.Controls.Add(this.lblLinePointBy);
            this.pnlLineData.Controls.Add(this.lblLinePointAy);
            this.pnlLineData.Controls.Add(this.lblLinePointBx);
            this.pnlLineData.Controls.Add(this.lblLinePointAx);
            this.pnlLineData.Controls.Add(this.nmcLinePointBx);
            this.pnlLineData.Controls.Add(this.nmcLinePointAx);
            this.pnlLineData.Controls.Add(this.nmcLinePointBy);
            this.pnlLineData.Controls.Add(this.lblLinePointB);
            this.pnlLineData.Controls.Add(this.nmcLinePointAy);
            this.pnlLineData.Controls.Add(this.lblLinePointA);
            this.pnlLineData.Location = new System.Drawing.Point(15, 328);
            this.pnlLineData.Name = "pnlLineData";
            this.pnlLineData.Size = new System.Drawing.Size(211, 183);
            this.pnlLineData.TabIndex = 1;
            this.pnlLineData.Visible = false;
            // 
            // btnLineAdd
            // 
            this.btnLineAdd.Location = new System.Drawing.Point(61, 138);
            this.btnLineAdd.Name = "btnLineAdd";
            this.btnLineAdd.Size = new System.Drawing.Size(90, 28);
            this.btnLineAdd.TabIndex = 7;
            this.btnLineAdd.Text = "Add";
            this.btnLineAdd.UseVisualStyleBackColor = true;
            this.btnLineAdd.Click += new System.EventHandler(this.btnLineAdd_Click);
            // 
            // lblLinePointBy
            // 
            this.lblLinePointBy.AutoSize = true;
            this.lblLinePointBy.Location = new System.Drawing.Point(139, 44);
            this.lblLinePointBy.Name = "lblLinePointBy";
            this.lblLinePointBy.Size = new System.Drawing.Size(19, 20);
            this.lblLinePointBy.TabIndex = 4;
            this.lblLinePointBy.Text = "y:";
            // 
            // lblLinePointAy
            // 
            this.lblLinePointAy.AutoSize = true;
            this.lblLinePointAy.Location = new System.Drawing.Point(139, 12);
            this.lblLinePointAy.Name = "lblLinePointAy";
            this.lblLinePointAy.Size = new System.Drawing.Size(19, 20);
            this.lblLinePointAy.TabIndex = 4;
            this.lblLinePointAy.Text = "y:";
            // 
            // lblLinePointBx
            // 
            this.lblLinePointBx.AutoSize = true;
            this.lblLinePointBx.Location = new System.Drawing.Point(69, 44);
            this.lblLinePointBx.Name = "lblLinePointBx";
            this.lblLinePointBx.Size = new System.Drawing.Size(19, 20);
            this.lblLinePointBx.TabIndex = 4;
            this.lblLinePointBx.Text = "x:";
            // 
            // lblLinePointAx
            // 
            this.lblLinePointAx.AutoSize = true;
            this.lblLinePointAx.Location = new System.Drawing.Point(69, 12);
            this.lblLinePointAx.Name = "lblLinePointAx";
            this.lblLinePointAx.Size = new System.Drawing.Size(19, 20);
            this.lblLinePointAx.TabIndex = 4;
            this.lblLinePointAx.Text = "x:";
            // 
            // nmcLinePointBx
            // 
            this.nmcLinePointBx.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmcLinePointBx.Location = new System.Drawing.Point(93, 41);
            this.nmcLinePointBx.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcLinePointBx.Name = "nmcLinePointBx";
            this.nmcLinePointBx.Size = new System.Drawing.Size(43, 26);
            this.nmcLinePointBx.TabIndex = 3;
            // 
            // nmcLinePointAx
            // 
            this.nmcLinePointAx.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmcLinePointAx.Location = new System.Drawing.Point(93, 9);
            this.nmcLinePointAx.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcLinePointAx.Name = "nmcLinePointAx";
            this.nmcLinePointAx.Size = new System.Drawing.Size(43, 26);
            this.nmcLinePointAx.TabIndex = 3;
            // 
            // nmcLinePointBy
            // 
            this.nmcLinePointBy.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmcLinePointBy.Location = new System.Drawing.Point(163, 41);
            this.nmcLinePointBy.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcLinePointBy.Name = "nmcLinePointBy";
            this.nmcLinePointBy.Size = new System.Drawing.Size(43, 26);
            this.nmcLinePointBy.TabIndex = 2;
            // 
            // lblLinePointB
            // 
            this.lblLinePointB.AutoSize = true;
            this.lblLinePointB.Location = new System.Drawing.Point(3, 44);
            this.lblLinePointB.Name = "lblLinePointB";
            this.lblLinePointB.Size = new System.Drawing.Size(58, 20);
            this.lblLinePointB.TabIndex = 1;
            this.lblLinePointB.Text = "Point B:";
            // 
            // nmcLinePointAy
            // 
            this.nmcLinePointAy.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmcLinePointAy.Location = new System.Drawing.Point(163, 9);
            this.nmcLinePointAy.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcLinePointAy.Name = "nmcLinePointAy";
            this.nmcLinePointAy.Size = new System.Drawing.Size(43, 26);
            this.nmcLinePointAy.TabIndex = 2;
            // 
            // lblLinePointA
            // 
            this.lblLinePointA.AutoSize = true;
            this.lblLinePointA.Location = new System.Drawing.Point(3, 12);
            this.lblLinePointA.Name = "lblLinePointA";
            this.lblLinePointA.Size = new System.Drawing.Size(59, 20);
            this.lblLinePointA.TabIndex = 1;
            this.lblLinePointA.Text = "Point A:";
            // 
            // pnlCircleData
            // 
            this.pnlCircleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCircleData.Controls.Add(this.btnCircleAdd);
            this.pnlCircleData.Controls.Add(this.nmcCircleRadius);
            this.pnlCircleData.Controls.Add(this.lblCircleRadius);
            this.pnlCircleData.Controls.Add(this.lblCirclePointAy);
            this.pnlCircleData.Controls.Add(this.lblCirclePointAx);
            this.pnlCircleData.Controls.Add(this.nmcCirclePointAx);
            this.pnlCircleData.Controls.Add(this.nmcCirclePointAy);
            this.pnlCircleData.Controls.Add(this.lblCirclePointA);
            this.pnlCircleData.Location = new System.Drawing.Point(15, 328);
            this.pnlCircleData.Name = "pnlCircleData";
            this.pnlCircleData.Size = new System.Drawing.Size(211, 183);
            this.pnlCircleData.TabIndex = 2;
            this.pnlCircleData.Visible = false;
            // 
            // btnCircleAdd
            // 
            this.btnCircleAdd.Location = new System.Drawing.Point(61, 138);
            this.btnCircleAdd.Name = "btnCircleAdd";
            this.btnCircleAdd.Size = new System.Drawing.Size(90, 28);
            this.btnCircleAdd.TabIndex = 12;
            this.btnCircleAdd.Text = "Add";
            this.btnCircleAdd.UseVisualStyleBackColor = true;
            this.btnCircleAdd.Click += new System.EventHandler(this.btnCircleAdd_Click);
            // 
            // nmcCircleRadius
            // 
            this.nmcCircleRadius.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcCircleRadius.Location = new System.Drawing.Point(93, 43);
            this.nmcCircleRadius.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmcCircleRadius.Name = "nmcCircleRadius";
            this.nmcCircleRadius.Size = new System.Drawing.Size(113, 26);
            this.nmcCircleRadius.TabIndex = 11;
            // 
            // lblCircleRadius
            // 
            this.lblCircleRadius.AutoSize = true;
            this.lblCircleRadius.Location = new System.Drawing.Point(10, 45);
            this.lblCircleRadius.Name = "lblCircleRadius";
            this.lblCircleRadius.Size = new System.Drawing.Size(56, 20);
            this.lblCircleRadius.TabIndex = 10;
            this.lblCircleRadius.Text = "Radius:";
            // 
            // lblCirclePointAy
            // 
            this.lblCirclePointAy.AutoSize = true;
            this.lblCirclePointAy.Location = new System.Drawing.Point(139, 12);
            this.lblCirclePointAy.Name = "lblCirclePointAy";
            this.lblCirclePointAy.Size = new System.Drawing.Size(19, 20);
            this.lblCirclePointAy.TabIndex = 8;
            this.lblCirclePointAy.Text = "y:";
            // 
            // lblCirclePointAx
            // 
            this.lblCirclePointAx.AutoSize = true;
            this.lblCirclePointAx.Location = new System.Drawing.Point(69, 12);
            this.lblCirclePointAx.Name = "lblCirclePointAx";
            this.lblCirclePointAx.Size = new System.Drawing.Size(19, 20);
            this.lblCirclePointAx.TabIndex = 9;
            this.lblCirclePointAx.Text = "x:";
            // 
            // nmcCirclePointAx
            // 
            this.nmcCirclePointAx.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcCirclePointAx.Location = new System.Drawing.Point(93, 9);
            this.nmcCirclePointAx.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmcCirclePointAx.Name = "nmcCirclePointAx";
            this.nmcCirclePointAx.Size = new System.Drawing.Size(43, 26);
            this.nmcCirclePointAx.TabIndex = 7;
            // 
            // nmcCirclePointAy
            // 
            this.nmcCirclePointAy.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcCirclePointAy.Location = new System.Drawing.Point(163, 9);
            this.nmcCirclePointAy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmcCirclePointAy.Name = "nmcCirclePointAy";
            this.nmcCirclePointAy.Size = new System.Drawing.Size(43, 26);
            this.nmcCirclePointAy.TabIndex = 6;
            // 
            // lblCirclePointA
            // 
            this.lblCirclePointA.AutoSize = true;
            this.lblCirclePointA.Location = new System.Drawing.Point(3, 12);
            this.lblCirclePointA.Name = "lblCirclePointA";
            this.lblCirclePointA.Size = new System.Drawing.Size(59, 20);
            this.lblCirclePointA.TabIndex = 5;
            this.lblCirclePointA.Text = "Point A:";
            // 
            // pnlTriangleData
            // 
            this.pnlTriangleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTriangleData.Controls.Add(this.btnTriangleAdd);
            this.pnlTriangleData.Controls.Add(this.lblTrianglePointBy);
            this.pnlTriangleData.Controls.Add(this.lblTrianglePointCy);
            this.pnlTriangleData.Controls.Add(this.lblTrianglePointAy);
            this.pnlTriangleData.Controls.Add(this.lblTrianglePointBx);
            this.pnlTriangleData.Controls.Add(this.lblTrianglePointCx);
            this.pnlTriangleData.Controls.Add(this.lblTrianglePointAx);
            this.pnlTriangleData.Controls.Add(this.nmcTrianglePointBx);
            this.pnlTriangleData.Controls.Add(this.nmcTrianglePointCx);
            this.pnlTriangleData.Controls.Add(this.nmcTrianglePointAx);
            this.pnlTriangleData.Controls.Add(this.nmcTrianglePointBy);
            this.pnlTriangleData.Controls.Add(this.nmcTrianglePointCy);
            this.pnlTriangleData.Controls.Add(this.lblTrianglePointB);
            this.pnlTriangleData.Controls.Add(this.lblTrianglePointC);
            this.pnlTriangleData.Controls.Add(this.nmcTrianglePointAy);
            this.pnlTriangleData.Controls.Add(this.lblTrianglePointA);
            this.pnlTriangleData.Location = new System.Drawing.Point(15, 328);
            this.pnlTriangleData.Name = "pnlTriangleData";
            this.pnlTriangleData.Size = new System.Drawing.Size(211, 183);
            this.pnlTriangleData.TabIndex = 3;
            this.pnlTriangleData.Visible = false;
            // 
            // btnTriangleAdd
            // 
            this.btnTriangleAdd.Location = new System.Drawing.Point(61, 135);
            this.btnTriangleAdd.Name = "btnTriangleAdd";
            this.btnTriangleAdd.Size = new System.Drawing.Size(90, 28);
            this.btnTriangleAdd.TabIndex = 32;
            this.btnTriangleAdd.Text = "Add";
            this.btnTriangleAdd.UseVisualStyleBackColor = true;
            this.btnTriangleAdd.Click += new System.EventHandler(this.btnTriangleAdd_Click);
            // 
            // lblTrianglePointBy
            // 
            this.lblTrianglePointBy.AutoSize = true;
            this.lblTrianglePointBy.Location = new System.Drawing.Point(139, 41);
            this.lblTrianglePointBy.Name = "lblTrianglePointBy";
            this.lblTrianglePointBy.Size = new System.Drawing.Size(19, 20);
            this.lblTrianglePointBy.TabIndex = 28;
            this.lblTrianglePointBy.Text = "y:";
            // 
            // lblTrianglePointCy
            // 
            this.lblTrianglePointCy.AutoSize = true;
            this.lblTrianglePointCy.Location = new System.Drawing.Point(139, 72);
            this.lblTrianglePointCy.Name = "lblTrianglePointCy";
            this.lblTrianglePointCy.Size = new System.Drawing.Size(19, 20);
            this.lblTrianglePointCy.TabIndex = 29;
            this.lblTrianglePointCy.Text = "y:";
            // 
            // lblTrianglePointAy
            // 
            this.lblTrianglePointAy.AutoSize = true;
            this.lblTrianglePointAy.Location = new System.Drawing.Point(139, 9);
            this.lblTrianglePointAy.Name = "lblTrianglePointAy";
            this.lblTrianglePointAy.Size = new System.Drawing.Size(19, 20);
            this.lblTrianglePointAy.TabIndex = 29;
            this.lblTrianglePointAy.Text = "y:";
            // 
            // lblTrianglePointBx
            // 
            this.lblTrianglePointBx.AutoSize = true;
            this.lblTrianglePointBx.Location = new System.Drawing.Point(69, 41);
            this.lblTrianglePointBx.Name = "lblTrianglePointBx";
            this.lblTrianglePointBx.Size = new System.Drawing.Size(19, 20);
            this.lblTrianglePointBx.TabIndex = 30;
            this.lblTrianglePointBx.Text = "x:";
            // 
            // lblTrianglePointCx
            // 
            this.lblTrianglePointCx.AutoSize = true;
            this.lblTrianglePointCx.Location = new System.Drawing.Point(69, 72);
            this.lblTrianglePointCx.Name = "lblTrianglePointCx";
            this.lblTrianglePointCx.Size = new System.Drawing.Size(19, 20);
            this.lblTrianglePointCx.TabIndex = 31;
            this.lblTrianglePointCx.Text = "x:";
            // 
            // lblTrianglePointAx
            // 
            this.lblTrianglePointAx.AutoSize = true;
            this.lblTrianglePointAx.Location = new System.Drawing.Point(69, 9);
            this.lblTrianglePointAx.Name = "lblTrianglePointAx";
            this.lblTrianglePointAx.Size = new System.Drawing.Size(19, 20);
            this.lblTrianglePointAx.TabIndex = 31;
            this.lblTrianglePointAx.Text = "x:";
            // 
            // nmcTrianglePointBx
            // 
            this.nmcTrianglePointBx.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcTrianglePointBx.Location = new System.Drawing.Point(93, 38);
            this.nmcTrianglePointBx.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.nmcTrianglePointBx.Name = "nmcTrianglePointBx";
            this.nmcTrianglePointBx.Size = new System.Drawing.Size(43, 26);
            this.nmcTrianglePointBx.TabIndex = 27;
            // 
            // nmcTrianglePointCx
            // 
            this.nmcTrianglePointCx.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcTrianglePointCx.Location = new System.Drawing.Point(93, 69);
            this.nmcTrianglePointCx.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.nmcTrianglePointCx.Name = "nmcTrianglePointCx";
            this.nmcTrianglePointCx.Size = new System.Drawing.Size(43, 26);
            this.nmcTrianglePointCx.TabIndex = 27;
            // 
            // nmcTrianglePointAx
            // 
            this.nmcTrianglePointAx.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcTrianglePointAx.Location = new System.Drawing.Point(93, 6);
            this.nmcTrianglePointAx.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.nmcTrianglePointAx.Name = "nmcTrianglePointAx";
            this.nmcTrianglePointAx.Size = new System.Drawing.Size(43, 26);
            this.nmcTrianglePointAx.TabIndex = 27;
            // 
            // nmcTrianglePointBy
            // 
            this.nmcTrianglePointBy.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcTrianglePointBy.Location = new System.Drawing.Point(163, 38);
            this.nmcTrianglePointBy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmcTrianglePointBy.Name = "nmcTrianglePointBy";
            this.nmcTrianglePointBy.Size = new System.Drawing.Size(43, 26);
            this.nmcTrianglePointBy.TabIndex = 25;
            // 
            // nmcTrianglePointCy
            // 
            this.nmcTrianglePointCy.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcTrianglePointCy.Location = new System.Drawing.Point(163, 69);
            this.nmcTrianglePointCy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmcTrianglePointCy.Name = "nmcTrianglePointCy";
            this.nmcTrianglePointCy.Size = new System.Drawing.Size(43, 26);
            this.nmcTrianglePointCy.TabIndex = 26;
            // 
            // lblTrianglePointB
            // 
            this.lblTrianglePointB.AutoSize = true;
            this.lblTrianglePointB.Location = new System.Drawing.Point(3, 41);
            this.lblTrianglePointB.Name = "lblTrianglePointB";
            this.lblTrianglePointB.Size = new System.Drawing.Size(58, 20);
            this.lblTrianglePointB.TabIndex = 23;
            this.lblTrianglePointB.Text = "Point B:";
            // 
            // lblTrianglePointC
            // 
            this.lblTrianglePointC.AutoSize = true;
            this.lblTrianglePointC.Location = new System.Drawing.Point(3, 72);
            this.lblTrianglePointC.Name = "lblTrianglePointC";
            this.lblTrianglePointC.Size = new System.Drawing.Size(58, 20);
            this.lblTrianglePointC.TabIndex = 24;
            this.lblTrianglePointC.Text = "Point C:";
            // 
            // nmcTrianglePointAy
            // 
            this.nmcTrianglePointAy.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcTrianglePointAy.Location = new System.Drawing.Point(163, 6);
            this.nmcTrianglePointAy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmcTrianglePointAy.Name = "nmcTrianglePointAy";
            this.nmcTrianglePointAy.Size = new System.Drawing.Size(43, 26);
            this.nmcTrianglePointAy.TabIndex = 26;
            // 
            // lblTrianglePointA
            // 
            this.lblTrianglePointA.AutoSize = true;
            this.lblTrianglePointA.Location = new System.Drawing.Point(3, 9);
            this.lblTrianglePointA.Name = "lblTrianglePointA";
            this.lblTrianglePointA.Size = new System.Drawing.Size(59, 20);
            this.lblTrianglePointA.TabIndex = 24;
            this.lblTrianglePointA.Text = "Point A:";
            // 
            // pnlRectangleData
            // 
            this.pnlRectangleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRectangleData.Controls.Add(this.btnRectangleAdd);
            this.pnlRectangleData.Controls.Add(this.nmcRectangleHeight);
            this.pnlRectangleData.Controls.Add(this.nmcRectangleWidth);
            this.pnlRectangleData.Controls.Add(this.lblRectanglePointAy);
            this.pnlRectangleData.Controls.Add(this.lblRectanglePointAx);
            this.pnlRectangleData.Controls.Add(this.nmcRectanglePointAx);
            this.pnlRectangleData.Controls.Add(this.nmcRectanglePointAy);
            this.pnlRectangleData.Controls.Add(this.lblRectanglePointA);
            this.pnlRectangleData.Controls.Add(this.lblRectangleHeight);
            this.pnlRectangleData.Controls.Add(this.lblRectangleWidth);
            this.pnlRectangleData.Location = new System.Drawing.Point(15, 328);
            this.pnlRectangleData.Name = "pnlRectangleData";
            this.pnlRectangleData.Size = new System.Drawing.Size(211, 183);
            this.pnlRectangleData.TabIndex = 3;
            this.pnlRectangleData.Visible = false;
            // 
            // btnRectangleAdd
            // 
            this.btnRectangleAdd.Location = new System.Drawing.Point(63, 135);
            this.btnRectangleAdd.Name = "btnRectangleAdd";
            this.btnRectangleAdd.Size = new System.Drawing.Size(90, 28);
            this.btnRectangleAdd.TabIndex = 22;
            this.btnRectangleAdd.Text = "Add";
            this.btnRectangleAdd.UseVisualStyleBackColor = true;
            this.btnRectangleAdd.Click += new System.EventHandler(this.btnRectangleAdd_Click);
            // 
            // nmcRectangleHeight
            // 
            this.nmcRectangleHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcRectangleHeight.Location = new System.Drawing.Point(95, 69);
            this.nmcRectangleHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmcRectangleHeight.Name = "nmcRectangleHeight";
            this.nmcRectangleHeight.Size = new System.Drawing.Size(113, 26);
            this.nmcRectangleHeight.TabIndex = 20;
            // 
            // nmcRectangleWidth
            // 
            this.nmcRectangleWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcRectangleWidth.Location = new System.Drawing.Point(95, 37);
            this.nmcRectangleWidth.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.nmcRectangleWidth.Name = "nmcRectangleWidth";
            this.nmcRectangleWidth.Size = new System.Drawing.Size(113, 26);
            this.nmcRectangleWidth.TabIndex = 20;
            // 
            // lblRectanglePointAy
            // 
            this.lblRectanglePointAy.AutoSize = true;
            this.lblRectanglePointAy.Location = new System.Drawing.Point(141, 9);
            this.lblRectanglePointAy.Name = "lblRectanglePointAy";
            this.lblRectanglePointAy.Size = new System.Drawing.Size(19, 20);
            this.lblRectanglePointAy.TabIndex = 17;
            this.lblRectanglePointAy.Text = "y:";
            // 
            // lblRectanglePointAx
            // 
            this.lblRectanglePointAx.AutoSize = true;
            this.lblRectanglePointAx.Location = new System.Drawing.Point(71, 9);
            this.lblRectanglePointAx.Name = "lblRectanglePointAx";
            this.lblRectanglePointAx.Size = new System.Drawing.Size(19, 20);
            this.lblRectanglePointAx.TabIndex = 19;
            this.lblRectanglePointAx.Text = "x:";
            // 
            // nmcRectanglePointAx
            // 
            this.nmcRectanglePointAx.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcRectanglePointAx.Location = new System.Drawing.Point(95, 6);
            this.nmcRectanglePointAx.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.nmcRectanglePointAx.Name = "nmcRectanglePointAx";
            this.nmcRectanglePointAx.Size = new System.Drawing.Size(43, 26);
            this.nmcRectanglePointAx.TabIndex = 15;
            // 
            // nmcRectanglePointAy
            // 
            this.nmcRectanglePointAy.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcRectanglePointAy.Location = new System.Drawing.Point(165, 6);
            this.nmcRectanglePointAy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmcRectanglePointAy.Name = "nmcRectanglePointAy";
            this.nmcRectanglePointAy.Size = new System.Drawing.Size(43, 26);
            this.nmcRectanglePointAy.TabIndex = 13;
            // 
            // lblRectanglePointA
            // 
            this.lblRectanglePointA.AutoSize = true;
            this.lblRectanglePointA.Location = new System.Drawing.Point(5, 9);
            this.lblRectanglePointA.Name = "lblRectanglePointA";
            this.lblRectanglePointA.Size = new System.Drawing.Size(59, 20);
            this.lblRectanglePointA.TabIndex = 11;
            this.lblRectanglePointA.Text = "Point A:";
            // 
            // lblRectangleHeight
            // 
            this.lblRectangleHeight.AutoSize = true;
            this.lblRectangleHeight.Location = new System.Drawing.Point(5, 69);
            this.lblRectangleHeight.Name = "lblRectangleHeight";
            this.lblRectangleHeight.Size = new System.Drawing.Size(57, 20);
            this.lblRectangleHeight.TabIndex = 8;
            this.lblRectangleHeight.Text = "Height:";
            // 
            // lblRectangleWidth
            // 
            this.lblRectangleWidth.AutoSize = true;
            this.lblRectangleWidth.Location = new System.Drawing.Point(11, 37);
            this.lblRectangleWidth.Name = "lblRectangleWidth";
            this.lblRectangleWidth.Size = new System.Drawing.Size(52, 20);
            this.lblRectangleWidth.TabIndex = 9;
            this.lblRectangleWidth.Text = "Width:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CheckPathExists = false;
            this.saveFileDialog.DefaultExt = "pic";
            this.saveFileDialog.FileName = "data";
            this.saveFileDialog.InitialDirectory = "C:\\Users\\Admin\\source\\repos\\GeometricShapes3";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "pic";
            this.openFileDialog.InitialDirectory = "C:\\Users\\Admin\\source\\repos\\GeometricShapes3";
            // 
            // pnlWorkPlace
            // 
            this.pnlWorkPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorkPlace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlWorkPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWorkPlace.Controls.Add(this.pnlToFillDraw);
            this.pnlWorkPlace.Location = new System.Drawing.Point(294, 45);
            this.pnlWorkPlace.Name = "pnlWorkPlace";
            this.pnlWorkPlace.Size = new System.Drawing.Size(961, 529);
            this.pnlWorkPlace.TabIndex = 4;
            // 
            // pnlToFillDraw
            // 
            this.pnlToFillDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlToFillDraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlToFillDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToFillDraw.Controls.Add(this.pnlDrawPlace);
            this.pnlToFillDraw.Location = new System.Drawing.Point(16, 14);
            this.pnlToFillDraw.MaximumSize = new System.Drawing.Size(99999, 99999);
            this.pnlToFillDraw.MinimumSize = new System.Drawing.Size(926, 498);
            this.pnlToFillDraw.Name = "pnlToFillDraw";
            this.pnlToFillDraw.Size = new System.Drawing.Size(926, 498);
            this.pnlToFillDraw.TabIndex = 6;
            // 
            // pnlDrawPlace
            // 
            this.pnlDrawPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrawPlace.AutoSize = true;
            this.pnlDrawPlace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDrawPlace.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawPlace.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDrawPlace.MaximumSize = new System.Drawing.Size(99999, 99999);
            this.pnlDrawPlace.MinimumSize = new System.Drawing.Size(924, 496);
            this.pnlDrawPlace.Name = "pnlDrawPlace";
            this.pnlDrawPlace.Size = new System.Drawing.Size(2000, 1000);
            this.pnlDrawPlace.TabIndex = 5;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1267, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuSave,
            this.tsMenuLoad});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsMenuSave
            // 
            this.tsMenuSave.Name = "tsMenuSave";
            this.tsMenuSave.Size = new System.Drawing.Size(124, 26);
            this.tsMenuSave.Text = "Save";
            this.tsMenuSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tsMenuLoad
            // 
            this.tsMenuLoad.Name = "tsMenuLoad";
            this.tsMenuLoad.Size = new System.Drawing.Size(124, 26);
            this.tsMenuLoad.Text = "Load";
            this.tsMenuLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::GeometricShapes3.Properties.Resources.rus;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 586);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlWorkPlace);
            this.Controls.Add(this.pnlFigures);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(100, 0);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geometric Shapes 4";
            this.pnlFigures.ResumeLayout(false);
            this.pnlDesign.ResumeLayout(false);
            this.pnlDesign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcStrokeWidth)).EndInit();
            this.pnlLineData.ResumeLayout(false);
            this.pnlLineData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcLinePointBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcLinePointAx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcLinePointBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcLinePointAy)).EndInit();
            this.pnlCircleData.ResumeLayout(false);
            this.pnlCircleData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCircleRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCirclePointAx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCirclePointAy)).EndInit();
            this.pnlTriangleData.ResumeLayout(false);
            this.pnlTriangleData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointCx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointAx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointCy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcTrianglePointAy)).EndInit();
            this.pnlRectangleData.ResumeLayout(false);
            this.pnlRectangleData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcRectangleHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcRectangleWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcRectanglePointAx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcRectanglePointAy)).EndInit();
            this.pnlWorkPlace.ResumeLayout(false);
            this.pnlToFillDraw.ResumeLayout(false);
            this.pnlToFillDraw.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFigures;
        private System.Windows.Forms.ListView lstVFigures;
        private System.Windows.Forms.ImageList imgLstFigures;
        private System.Windows.Forms.Panel pnlLineData;
        private System.Windows.Forms.Panel pnlCircleData;
        private System.Windows.Forms.Panel pnlTriangleData;
        private System.Windows.Forms.Panel pnlRectangleData;
        private System.Windows.Forms.Label lblStrokeWidth;
        private System.Windows.Forms.Label lblLinePointA;
        private System.Windows.Forms.Label lblLinePointAx;
        private System.Windows.Forms.NumericUpDown nmcLinePointAx;
        private System.Windows.Forms.NumericUpDown nmcLinePointAy;
        private System.Windows.Forms.Label lblLinePointAy;
        private System.Windows.Forms.Label lblLinePointBy;
        private System.Windows.Forms.Label lblLinePointBx;
        private System.Windows.Forms.NumericUpDown nmcLinePointBx;
        private System.Windows.Forms.NumericUpDown nmcLinePointBy;
        private System.Windows.Forms.Label lblLinePointB;
        private System.Windows.Forms.NumericUpDown nmcStrokeWidth;
        private System.Windows.Forms.Label lblStrokeColor;
        private System.Windows.Forms.Button btnLineAdd;
        private System.Windows.Forms.Label lblCirclePointAy;
        private System.Windows.Forms.Label lblCirclePointAx;
        private System.Windows.Forms.NumericUpDown nmcCirclePointAx;
        private System.Windows.Forms.NumericUpDown nmcCirclePointAy;
        private System.Windows.Forms.Label lblCirclePointA;
        private System.Windows.Forms.NumericUpDown nmcCircleRadius;
        private System.Windows.Forms.Label lblCircleRadius;
        private System.Windows.Forms.Button btnCircleAdd;
        private System.Windows.Forms.Button btnRectangleAdd;
        private System.Windows.Forms.NumericUpDown nmcRectangleWidth;
        private System.Windows.Forms.Label lblRectanglePointAy;
        private System.Windows.Forms.Label lblRectanglePointAx;
        private System.Windows.Forms.NumericUpDown nmcRectanglePointAx;
        private System.Windows.Forms.NumericUpDown nmcRectanglePointAy;
        private System.Windows.Forms.Label lblRectanglePointA;
        private System.Windows.Forms.Label lblRectangleHeight;
        private System.Windows.Forms.Label lblRectangleWidth;
        private System.Windows.Forms.NumericUpDown nmcRectangleHeight;
        private System.Windows.Forms.Button btnTriangleAdd;
        private System.Windows.Forms.Label lblTrianglePointBy;
        private System.Windows.Forms.Label lblTrianglePointAy;
        private System.Windows.Forms.Label lblTrianglePointBx;
        private System.Windows.Forms.Label lblTrianglePointAx;
        private System.Windows.Forms.NumericUpDown nmcTrianglePointBx;
        private System.Windows.Forms.NumericUpDown nmcTrianglePointAx;
        private System.Windows.Forms.NumericUpDown nmcTrianglePointBy;
        private System.Windows.Forms.Label lblTrianglePointB;
        private System.Windows.Forms.NumericUpDown nmcTrianglePointAy;
        private System.Windows.Forms.Label lblTrianglePointA;
        private System.Windows.Forms.Label lblTrianglePointCy;
        private System.Windows.Forms.Label lblTrianglePointCx;
        private System.Windows.Forms.NumericUpDown nmcTrianglePointCx;
        private System.Windows.Forms.NumericUpDown nmcTrianglePointCy;
        private System.Windows.Forms.Label lblTrianglePointC;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel pnlWorkPlace;
        private System.Windows.Forms.Panel pnlDrawPlace;
        private System.Windows.Forms.Panel pnlDesign;
        private System.Windows.Forms.Label lblFillColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Button btnStrokeColor;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSave;
        private System.Windows.Forms.ToolStripMenuItem tsMenuLoad;
        private System.Windows.Forms.Panel pnlToFillDraw;
    }
}
