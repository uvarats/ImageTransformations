namespace ImageResize
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.xScaleValue = new System.Windows.Forms.NumericUpDown();
            this.bilinearResizeButton = new System.Windows.Forms.Button();
            this.yScaleValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMedian = new System.Windows.Forms.Label();
            this.medianMatrixSize = new System.Windows.Forms.NumericUpDown();
            this.medianFilterButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.k22 = new System.Windows.Forms.NumericUpDown();
            this.k21 = new System.Windows.Forms.NumericUpDown();
            this.k20 = new System.Windows.Forms.NumericUpDown();
            this.k12 = new System.Windows.Forms.NumericUpDown();
            this.k11 = new System.Windows.Forms.NumericUpDown();
            this.k10 = new System.Windows.Forms.NumericUpDown();
            this.k02 = new System.Windows.Forms.NumericUpDown();
            this.k01 = new System.Windows.Forms.NumericUpDown();
            this.k00 = new System.Windows.Forms.NumericUpDown();
            this.kernelsComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.openImageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.angleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.beforeScaleInfoBox = new System.Windows.Forms.GroupBox();
            this.filesizeBefore = new System.Windows.Forms.Label();
            this.dimensionBefore = new System.Windows.Forms.Label();
            this.afterScaleInfoBox = new System.Windows.Forms.GroupBox();
            this.timeElapsed = new System.Windows.Forms.Label();
            this.filesizeAfter = new System.Windows.Forms.Label();
            this.dimensionAfter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.algoSelectComboBox = new System.Windows.Forms.ComboBox();
            this.imgSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.cleanMatrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xScaleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yScaleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianMatrixSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.beforeScaleInfoBox.SuspendLayout();
            this.afterScaleInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // xScaleValue
            // 
            this.xScaleValue.DecimalPlaces = 1;
            this.xScaleValue.Location = new System.Drawing.Point(134, 79);
            this.xScaleValue.Name = "xScaleValue";
            this.xScaleValue.Size = new System.Drawing.Size(150, 27);
            this.xScaleValue.TabIndex = 3;
            // 
            // bilinearResizeButton
            // 
            this.bilinearResizeButton.Location = new System.Drawing.Point(134, 145);
            this.bilinearResizeButton.Name = "bilinearResizeButton";
            this.bilinearResizeButton.Size = new System.Drawing.Size(154, 29);
            this.bilinearResizeButton.TabIndex = 5;
            this.bilinearResizeButton.Text = "Изменить размер";
            this.bilinearResizeButton.UseVisualStyleBackColor = true;
            this.bilinearResizeButton.Click += new System.EventHandler(this.bilinearResizeButton_Click);
            // 
            // yScaleValue
            // 
            this.yScaleValue.DecimalPlaces = 1;
            this.yScaleValue.Location = new System.Drawing.Point(134, 112);
            this.yScaleValue.Name = "yScaleValue";
            this.yScaleValue.Size = new System.Drawing.Size(150, 27);
            this.yScaleValue.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "y";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cleanMatrix);
            this.splitContainer1.Panel2.Controls.Add(this.labelMedian);
            this.splitContainer1.Panel2.Controls.Add(this.medianMatrixSize);
            this.splitContainer1.Panel2.Controls.Add(this.medianFilterButton);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.k22);
            this.splitContainer1.Panel2.Controls.Add(this.k21);
            this.splitContainer1.Panel2.Controls.Add(this.k20);
            this.splitContainer1.Panel2.Controls.Add(this.k12);
            this.splitContainer1.Panel2.Controls.Add(this.k11);
            this.splitContainer1.Panel2.Controls.Add(this.k10);
            this.splitContainer1.Panel2.Controls.Add(this.k02);
            this.splitContainer1.Panel2.Controls.Add(this.k01);
            this.splitContainer1.Panel2.Controls.Add(this.k00);
            this.splitContainer1.Panel2.Controls.Add(this.kernelsComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.filterButton);
            this.splitContainer1.Panel2.Controls.Add(this.openImageButton);
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Panel2.Controls.Add(this.rotateButton);
            this.splitContainer1.Panel2.Controls.Add(this.angleUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.algoSelectComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.xScaleValue);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.bilinearResizeButton);
            this.splitContainer1.Panel2.Controls.Add(this.yScaleValue);
            this.splitContainer1.Size = new System.Drawing.Size(1243, 626);
            this.splitContainer1.SplitterDistance = 412;
            this.splitContainer1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 626);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelMedian
            // 
            this.labelMedian.AutoSize = true;
            this.labelMedian.Location = new System.Drawing.Point(613, 284);
            this.labelMedian.Name = "labelMedian";
            this.labelMedian.Size = new System.Drawing.Size(166, 20);
            this.labelMedian.TabIndex = 32;
            this.labelMedian.Text = "Размерность матрицы";
            // 
            // medianMatrixSize
            // 
            this.medianMatrixSize.Location = new System.Drawing.Point(613, 312);
            this.medianMatrixSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.medianMatrixSize.Name = "medianMatrixSize";
            this.medianMatrixSize.Size = new System.Drawing.Size(182, 27);
            this.medianMatrixSize.TabIndex = 31;
            // 
            // medianFilterButton
            // 
            this.medianFilterButton.Location = new System.Drawing.Point(613, 345);
            this.medianFilterButton.Name = "medianFilterButton";
            this.medianFilterButton.Size = new System.Drawing.Size(182, 29);
            this.medianFilterButton.TabIndex = 30;
            this.medianFilterButton.Text = "Медианный фильтр";
            this.medianFilterButton.UseVisualStyleBackColor = true;
            this.medianFilterButton.Click += new System.EventHandler(this.medianFilterButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Предопределенные матрицы";
            // 
            // k22
            // 
            this.k22.DecimalPlaces = 2;
            this.k22.Location = new System.Drawing.Point(196, 315);
            this.k22.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.k22.Name = "k22";
            this.k22.Size = new System.Drawing.Size(64, 27);
            this.k22.TabIndex = 26;
            // 
            // k21
            // 
            this.k21.DecimalPlaces = 2;
            this.k21.Location = new System.Drawing.Point(126, 315);
            this.k21.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.k21.Name = "k21";
            this.k21.Size = new System.Drawing.Size(64, 27);
            this.k21.TabIndex = 25;
            // 
            // k20
            // 
            this.k20.DecimalPlaces = 2;
            this.k20.Location = new System.Drawing.Point(56, 315);
            this.k20.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.k20.Name = "k20";
            this.k20.Size = new System.Drawing.Size(64, 27);
            this.k20.TabIndex = 24;
            // 
            // k12
            // 
            this.k12.DecimalPlaces = 2;
            this.k12.Location = new System.Drawing.Point(196, 282);
            this.k12.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.k12.Name = "k12";
            this.k12.Size = new System.Drawing.Size(64, 27);
            this.k12.TabIndex = 23;
            // 
            // k11
            // 
            this.k11.DecimalPlaces = 2;
            this.k11.Location = new System.Drawing.Point(126, 282);
            this.k11.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.k11.Name = "k11";
            this.k11.Size = new System.Drawing.Size(64, 27);
            this.k11.TabIndex = 22;
            // 
            // k10
            // 
            this.k10.DecimalPlaces = 2;
            this.k10.Location = new System.Drawing.Point(56, 282);
            this.k10.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.k10.Name = "k10";
            this.k10.Size = new System.Drawing.Size(64, 27);
            this.k10.TabIndex = 21;
            // 
            // k02
            // 
            this.k02.DecimalPlaces = 2;
            this.k02.Location = new System.Drawing.Point(196, 249);
            this.k02.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.k02.Name = "k02";
            this.k02.Size = new System.Drawing.Size(64, 27);
            this.k02.TabIndex = 20;
            // 
            // k01
            // 
            this.k01.DecimalPlaces = 2;
            this.k01.Location = new System.Drawing.Point(126, 249);
            this.k01.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.k01.Name = "k01";
            this.k01.Size = new System.Drawing.Size(64, 27);
            this.k01.TabIndex = 19;
            // 
            // k00
            // 
            this.k00.DecimalPlaces = 2;
            this.k00.Location = new System.Drawing.Point(56, 249);
            this.k00.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.k00.Name = "k00";
            this.k00.Size = new System.Drawing.Size(64, 27);
            this.k00.TabIndex = 18;
            // 
            // kernelsComboBox
            // 
            this.kernelsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kernelsComboBox.FormattingEnabled = true;
            this.kernelsComboBox.Location = new System.Drawing.Point(266, 272);
            this.kernelsComboBox.Name = "kernelsComboBox";
            this.kernelsComboBox.Size = new System.Drawing.Size(212, 28);
            this.kernelsComboBox.TabIndex = 17;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(266, 315);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(114, 29);
            this.filterButton.TabIndex = 16;
            this.filterButton.Text = "Фильтрация";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(468, 114);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(113, 29);
            this.openImageButton.TabIndex = 15;
            this.openImageButton.Text = "Открыть";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(468, 149);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 29);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(328, 72);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(94, 29);
            this.rotateButton.TabIndex = 14;
            this.rotateButton.Text = "Повернуть";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // angleUpDown
            // 
            this.angleUpDown.Location = new System.Drawing.Point(328, 40);
            this.angleUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleUpDown.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.angleUpDown.Name = "angleUpDown";
            this.angleUpDown.Size = new System.Drawing.Size(150, 27);
            this.angleUpDown.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Поворот (в градусах)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 178);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация об изображении";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 23);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.beforeScaleInfoBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.afterScaleInfoBox);
            this.splitContainer2.Size = new System.Drawing.Size(821, 152);
            this.splitContainer2.SplitterDistance = 412;
            this.splitContainer2.TabIndex = 0;
            // 
            // beforeScaleInfoBox
            // 
            this.beforeScaleInfoBox.Controls.Add(this.filesizeBefore);
            this.beforeScaleInfoBox.Controls.Add(this.dimensionBefore);
            this.beforeScaleInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beforeScaleInfoBox.Location = new System.Drawing.Point(0, 0);
            this.beforeScaleInfoBox.Name = "beforeScaleInfoBox";
            this.beforeScaleInfoBox.Size = new System.Drawing.Size(412, 152);
            this.beforeScaleInfoBox.TabIndex = 0;
            this.beforeScaleInfoBox.TabStop = false;
            this.beforeScaleInfoBox.Text = "До интерполяциии";
            // 
            // filesizeBefore
            // 
            this.filesizeBefore.AutoSize = true;
            this.filesizeBefore.Location = new System.Drawing.Point(6, 43);
            this.filesizeBefore.Name = "filesizeBefore";
            this.filesizeBefore.Size = new System.Drawing.Size(99, 20);
            this.filesizeBefore.TabIndex = 1;
            this.filesizeBefore.Text = "filesizeBefore";
            // 
            // dimensionBefore
            // 
            this.dimensionBefore.AutoSize = true;
            this.dimensionBefore.Location = new System.Drawing.Point(6, 23);
            this.dimensionBefore.Name = "dimensionBefore";
            this.dimensionBefore.Size = new System.Drawing.Size(122, 20);
            this.dimensionBefore.TabIndex = 0;
            this.dimensionBefore.Text = "dimensionBefore";
            // 
            // afterScaleInfoBox
            // 
            this.afterScaleInfoBox.Controls.Add(this.timeElapsed);
            this.afterScaleInfoBox.Controls.Add(this.filesizeAfter);
            this.afterScaleInfoBox.Controls.Add(this.dimensionAfter);
            this.afterScaleInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afterScaleInfoBox.Location = new System.Drawing.Point(0, 0);
            this.afterScaleInfoBox.Name = "afterScaleInfoBox";
            this.afterScaleInfoBox.Size = new System.Drawing.Size(405, 152);
            this.afterScaleInfoBox.TabIndex = 1;
            this.afterScaleInfoBox.TabStop = false;
            this.afterScaleInfoBox.Text = "После интерполяции";
            // 
            // timeElapsed
            // 
            this.timeElapsed.AutoSize = true;
            this.timeElapsed.Location = new System.Drawing.Point(6, 63);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.Size = new System.Drawing.Size(91, 20);
            this.timeElapsed.TabIndex = 3;
            this.timeElapsed.Text = "timeElapsed";
            // 
            // filesizeAfter
            // 
            this.filesizeAfter.AutoSize = true;
            this.filesizeAfter.Location = new System.Drawing.Point(6, 43);
            this.filesizeAfter.Name = "filesizeAfter";
            this.filesizeAfter.Size = new System.Drawing.Size(88, 20);
            this.filesizeAfter.TabIndex = 2;
            this.filesizeAfter.Text = "filesizeAfter";
            // 
            // dimensionAfter
            // 
            this.dimensionAfter.AutoSize = true;
            this.dimensionAfter.Location = new System.Drawing.Point(6, 23);
            this.dimensionAfter.Name = "dimensionAfter";
            this.dimensionAfter.Size = new System.Drawing.Size(111, 20);
            this.dimensionAfter.TabIndex = 1;
            this.dimensionAfter.Text = "dimensionAfter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Алгоритм";
            // 
            // algoSelectComboBox
            // 
            this.algoSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algoSelectComboBox.FormattingEnabled = true;
            this.algoSelectComboBox.Location = new System.Drawing.Point(34, 39);
            this.algoSelectComboBox.Name = "algoSelectComboBox";
            this.algoSelectComboBox.Size = new System.Drawing.Size(250, 28);
            this.algoSelectComboBox.TabIndex = 9;
            // 
            // cleanMatrix
            // 
            this.cleanMatrix.Location = new System.Drawing.Point(56, 348);
            this.cleanMatrix.Name = "cleanMatrix";
            this.cleanMatrix.Size = new System.Drawing.Size(156, 29);
            this.cleanMatrix.TabIndex = 33;
            this.cleanMatrix.Text = "Очистить матрицу";
            this.cleanMatrix.UseVisualStyleBackColor = true;
            this.cleanMatrix.Click += new System.EventHandler(this.cleanMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 626);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xScaleValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yScaleValue)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianMatrixSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.beforeScaleInfoBox.ResumeLayout(false);
            this.beforeScaleInfoBox.PerformLayout();
            this.afterScaleInfoBox.ResumeLayout(false);
            this.afterScaleInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private NumericUpDown xScaleValue;
        private Button bilinearResizeButton;
        private NumericUpDown yScaleValue;
        private Label label2;
        private Label label3;
        private OpenFileDialog imgOpenDialog;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private ComboBox algoSelectComboBox;
        private Label label1;
        private GroupBox groupBox1;
        private SplitContainer splitContainer2;
        private GroupBox beforeScaleInfoBox;
        private GroupBox afterScaleInfoBox;
        private Button saveButton;
        private SaveFileDialog imgSaveDialog;
        private Label filesizeBefore;
        private Label dimensionBefore;
        private Label filesizeAfter;
        private Label dimensionAfter;
        private NumericUpDown angleUpDown;
        private Label label4;
        private Button rotateButton;
        private Button openImageButton;
        private Label timeElapsed;
        private Button filterButton;
        private ComboBox kernelsComboBox;
        private Label label5;
        private NumericUpDown k22;
        private NumericUpDown k21;
        private NumericUpDown k20;
        private NumericUpDown k12;
        private NumericUpDown k11;
        private NumericUpDown k10;
        private NumericUpDown k02;
        private NumericUpDown k01;
        private NumericUpDown k00;
        private Button medianFilterButton;
        private Label labelMedian;
        private NumericUpDown medianMatrixSize;
        private Button cleanMatrix;
    }
}