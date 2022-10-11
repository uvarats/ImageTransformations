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
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.beforeScaleInfoBox = new System.Windows.Forms.GroupBox();
            this.afterScaleInfoBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.algoSelectComboBox = new System.Windows.Forms.ComboBox();
            this.imgSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.dimensionBefore = new System.Windows.Forms.Label();
            this.dimensionAfter = new System.Windows.Forms.Label();
            this.filesizeBefore = new System.Windows.Forms.Label();
            this.filesizeAfter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xScaleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yScaleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.algoSelectComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.xScaleValue);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.bilinearResizeButton);
            this.splitContainer1.Panel2.Controls.Add(this.yScaleValue);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(405, 38);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 29);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 178);
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
            this.splitContainer2.Size = new System.Drawing.Size(524, 152);
            this.splitContainer2.SplitterDistance = 264;
            this.splitContainer2.TabIndex = 0;
            // 
            // beforeScaleInfoBox
            // 
            this.beforeScaleInfoBox.Controls.Add(this.filesizeBefore);
            this.beforeScaleInfoBox.Controls.Add(this.dimensionBefore);
            this.beforeScaleInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beforeScaleInfoBox.Location = new System.Drawing.Point(0, 0);
            this.beforeScaleInfoBox.Name = "beforeScaleInfoBox";
            this.beforeScaleInfoBox.Size = new System.Drawing.Size(264, 152);
            this.beforeScaleInfoBox.TabIndex = 0;
            this.beforeScaleInfoBox.TabStop = false;
            this.beforeScaleInfoBox.Text = "До интерполяциии";
            // 
            // afterScaleInfoBox
            // 
            this.afterScaleInfoBox.Controls.Add(this.filesizeAfter);
            this.afterScaleInfoBox.Controls.Add(this.dimensionAfter);
            this.afterScaleInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afterScaleInfoBox.Location = new System.Drawing.Point(0, 0);
            this.afterScaleInfoBox.Name = "afterScaleInfoBox";
            this.afterScaleInfoBox.Size = new System.Drawing.Size(256, 152);
            this.afterScaleInfoBox.TabIndex = 1;
            this.afterScaleInfoBox.TabStop = false;
            this.afterScaleInfoBox.Text = "После интерполяции";
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
            // dimensionBefore
            // 
            this.dimensionBefore.AutoSize = true;
            this.dimensionBefore.Location = new System.Drawing.Point(6, 23);
            this.dimensionBefore.Name = "dimensionBefore";
            this.dimensionBefore.Size = new System.Drawing.Size(122, 20);
            this.dimensionBefore.TabIndex = 0;
            this.dimensionBefore.Text = "dimensionBefore";
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
            // filesizeBefore
            // 
            this.filesizeBefore.AutoSize = true;
            this.filesizeBefore.Location = new System.Drawing.Point(6, 43);
            this.filesizeBefore.Name = "filesizeBefore";
            this.filesizeBefore.Size = new System.Drawing.Size(99, 20);
            this.filesizeBefore.TabIndex = 1;
            this.filesizeBefore.Text = "filesizeBefore";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}