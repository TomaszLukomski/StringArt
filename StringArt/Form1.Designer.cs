namespace StringArt
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonClearChart = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.trackBarReduction = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.trackBarSaturation = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
            this.labelTimeDone = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownIncrease = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLines = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPoints = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.openFileDialogOrigin = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogResult = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogOrigin = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogResult = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.artToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxOrigin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxResult, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1217, 810);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartHistogram);
            this.groupBox2.Controls.Add(this.buttonClearChart);
            this.groupBox2.Controls.Add(this.buttonTest);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.trackBarReduction);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.buttonReset);
            this.groupBox2.Controls.Add(this.trackBarSaturation);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.trackBarContrast);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.trackBarBrightness);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 529);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 278);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edycja obrazu";
            // 
            // chartHistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Enabled = false;
            legend1.IsDockedInsideChartArea = false;
            legend1.MaximumAutoSize = 10F;
            legend1.Name = "111";
            this.chartHistogram.Legends.Add(legend1);
            this.chartHistogram.Location = new System.Drawing.Point(310, 21);
            this.chartHistogram.Name = "chartHistogram";
            this.chartHistogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "111";
            series1.Name = "Histogram";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "111";
            series2.Name = "Series2";
            this.chartHistogram.Series.Add(series1);
            this.chartHistogram.Series.Add(series2);
            this.chartHistogram.Size = new System.Drawing.Size(286, 248);
            this.chartHistogram.TabIndex = 24;
            this.chartHistogram.Text = "chart1";
            // 
            // buttonClearChart
            // 
            this.buttonClearChart.Location = new System.Drawing.Point(103, 210);
            this.buttonClearChart.Name = "buttonClearChart";
            this.buttonClearChart.Size = new System.Drawing.Size(75, 23);
            this.buttonClearChart.TabIndex = 23;
            this.buttonClearChart.Text = "Clear Chart";
            this.buttonClearChart.UseVisualStyleBackColor = true;
            this.buttonClearChart.Click += new System.EventHandler(this.buttonClearChart_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(9, 210);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 22;
            this.buttonTest.Text = "test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(263, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "label14";
            // 
            // trackBarReduction
            // 
            this.trackBarReduction.AutoSize = false;
            this.trackBarReduction.LargeChange = 1;
            this.trackBarReduction.Location = new System.Drawing.Point(57, 129);
            this.trackBarReduction.Maximum = 32;
            this.trackBarReduction.Minimum = 2;
            this.trackBarReduction.Name = "trackBarReduction";
            this.trackBarReduction.Size = new System.Drawing.Size(200, 30);
            this.trackBarReduction.TabIndex = 1;
            this.trackBarReduction.TickFrequency = 2;
            this.trackBarReduction.Value = 4;
            this.trackBarReduction.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Reduction";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(263, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "label10";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(9, 172);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // trackBarSaturation
            // 
            this.trackBarSaturation.AutoSize = false;
            this.trackBarSaturation.Location = new System.Drawing.Point(57, 88);
            this.trackBarSaturation.Maximum = 100;
            this.trackBarSaturation.Name = "trackBarSaturation";
            this.trackBarSaturation.Size = new System.Drawing.Size(200, 30);
            this.trackBarSaturation.TabIndex = 5;
            this.trackBarSaturation.TickFrequency = 5;
            this.trackBarSaturation.Value = 100;
            this.trackBarSaturation.Scroll += new System.EventHandler(this.trackBarSaturation_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Saturation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Brightness";
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.AutoSize = false;
            this.trackBarContrast.Location = new System.Drawing.Point(57, 52);
            this.trackBarContrast.Maximum = 200;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(200, 30);
            this.trackBarContrast.TabIndex = 1;
            this.trackBarContrast.TickFrequency = 5;
            this.trackBarContrast.Value = 100;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Contrast";
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.AutoSize = false;
            this.trackBarBrightness.Location = new System.Drawing.Point(57, 16);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Minimum = -100;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(200, 30);
            this.trackBarBrightness.TabIndex = 0;
            this.trackBarBrightness.TickFrequency = 5;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownOffset);
            this.groupBox1.Controls.Add(this.labelTimeDone);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownIncrease);
            this.groupBox1.Controls.Add(this.numericUpDownLines);
            this.groupBox1.Controls.Add(this.numericUpDownPoints);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(611, 529);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 278);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDownOffset
            // 
            this.numericUpDownOffset.Location = new System.Drawing.Point(109, 213);
            this.numericUpDownOffset.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownOffset.Name = "numericUpDownOffset";
            this.numericUpDownOffset.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownOffset.TabIndex = 18;
            this.numericUpDownOffset.ValueChanged += new System.EventHandler(this.numericUpDownOffset_ValueChanged);
            // 
            // labelTimeDone
            // 
            this.labelTimeDone.AutoSize = true;
            this.labelTimeDone.Location = new System.Drawing.Point(139, 177);
            this.labelTimeDone.Name = "labelTimeDone";
            this.labelTimeDone.Size = new System.Drawing.Size(0, 13);
            this.labelTimeDone.TabIndex = 16;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 136);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(202, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Increase";
            // 
            // numericUpDownIncrease
            // 
            this.numericUpDownIncrease.Location = new System.Drawing.Point(109, 91);
            this.numericUpDownIncrease.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownIncrease.Name = "numericUpDownIncrease";
            this.numericUpDownIncrease.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIncrease.TabIndex = 7;
            this.numericUpDownIncrease.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownIncrease.ValueChanged += new System.EventHandler(this.numericUpDownIncrease_ValueChanged);
            // 
            // numericUpDownLines
            // 
            this.numericUpDownLines.Location = new System.Drawing.Point(109, 55);
            this.numericUpDownLines.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownLines.Name = "numericUpDownLines";
            this.numericUpDownLines.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLines.TabIndex = 6;
            this.numericUpDownLines.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownLines.ValueChanged += new System.EventHandler(this.numericUpDownLines_ValueChanged);
            // 
            // numericUpDownPoints
            // 
            this.numericUpDownPoints.Location = new System.Drawing.Point(109, 19);
            this.numericUpDownPoints.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericUpDownPoints.Name = "numericUpDownPoints";
            this.numericUpDownPoints.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPoints.TabIndex = 5;
            this.numericUpDownPoints.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPoints.ValueChanged += new System.EventHandler(this.numericUpDownPoints_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lines";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anchor Points";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(27, 172);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxOrigin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOrigin.Image = global::StringArt.Properties.Resources.MM;
            this.pictureBoxOrigin.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.Size = new System.Drawing.Size(602, 520);
            this.pictureBoxOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrigin.TabIndex = 0;
            this.pictureBoxOrigin.TabStop = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxResult.Location = new System.Drawing.Point(611, 3);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(603, 520);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResult.TabIndex = 1;
            this.pictureBoxResult.TabStop = false;
            // 
            // openFileDialogOrigin
            // 
            this.openFileDialogOrigin.AddExtension = false;
            this.openFileDialogOrigin.FileName = "EA.png";
            this.openFileDialogOrigin.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // openFileDialogResult
            // 
            this.openFileDialogResult.FileName = "openFileDialog2";
            // 
            // saveFileDialogOrigin
            // 
            this.saveFileDialogOrigin.Filter = "Images|*.png;*.bmp;*.jpg";
            // 
            // saveFileDialogResult
            // 
            this.saveFileDialogResult.DefaultExt = "png";
            this.saveFileDialogResult.Filter = "Images|*.png;*.bmp;*.jpg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.otwórzToolStripMenuItem1,
            this.zapiszToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1217, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrazToolStripMenuItem,
            this.artToolStripMenuItem});
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            // 
            // obrazToolStripMenuItem
            // 
            this.obrazToolStripMenuItem.Name = "obrazToolStripMenuItem";
            this.obrazToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.obrazToolStripMenuItem.Text = "Obraz";
            this.obrazToolStripMenuItem.Click += new System.EventHandler(this.obrazToolStripMenuItem_Click);
            // 
            // artToolStripMenuItem
            // 
            this.artToolStripMenuItem.Name = "artToolStripMenuItem";
            this.artToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.artToolStripMenuItem.Text = "Art";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrazToolStripMenuItem1,
            this.artToolStripMenuItem1});
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // obrazToolStripMenuItem1
            // 
            this.obrazToolStripMenuItem1.Name = "obrazToolStripMenuItem1";
            this.obrazToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.obrazToolStripMenuItem1.Text = "Obraz";
            this.obrazToolStripMenuItem1.Click += new System.EventHandler(this.obrazToolStripMenuItem1_Click);
            // 
            // artToolStripMenuItem1
            // 
            this.artToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrazToolStripMenuItem2,
            this.tekstToolStripMenuItem});
            this.artToolStripMenuItem1.Name = "artToolStripMenuItem1";
            this.artToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.artToolStripMenuItem1.Text = "Art";
            // 
            // obrazToolStripMenuItem2
            // 
            this.obrazToolStripMenuItem2.Name = "obrazToolStripMenuItem2";
            this.obrazToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.obrazToolStripMenuItem2.Text = "Obraz";
            this.obrazToolStripMenuItem2.Click += new System.EventHandler(this.obrazToolStripMenuItem2_Click);
            // 
            // tekstToolStripMenuItem
            // 
            this.tekstToolStripMenuItem.Name = "tekstToolStripMenuItem";
            this.tekstToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.tekstToolStripMenuItem.Text = "Tekst";
            // 
            // otwórzToolStripMenuItem1
            // 
            this.otwórzToolStripMenuItem1.Name = "otwórzToolStripMenuItem1";
            this.otwórzToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.otwórzToolStripMenuItem1.Text = "Otwórz";
            this.otwórzToolStripMenuItem1.Click += new System.EventHandler(this.otwórzToolStripMenuItem1_Click);
            // 
            // zapiszToolStripMenuItem1
            // 
            this.zapiszToolStripMenuItem1.Name = "zapiszToolStripMenuItem1";
            this.zapiszToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.zapiszToolStripMenuItem1.Text = "Zapisz";
            this.zapiszToolStripMenuItem1.Click += new System.EventHandler(this.zapiszToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 834);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Art";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxOrigin;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.OpenFileDialog openFileDialogOrigin;
        private System.Windows.Forms.OpenFileDialog openFileDialogResult;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOrigin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrazToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem artToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem obrazToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tekstToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownLines;
        private System.Windows.Forms.NumericUpDown numericUpDownPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownIncrease;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SaveFileDialog saveFileDialogResult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackBarReduction;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelTimeDone;
        private System.Windows.Forms.NumericUpDown numericUpDownOffset;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonClearChart;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
    }
}

