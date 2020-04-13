﻿namespace RepaintingUtil
{
    partial class SplitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.RadioButton rbLayersAll;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbSpotsAll = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbSpotsThreshold = new System.Windows.Forms.RadioButton();
            this.numMU = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numLayerPercent = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rbLayersThreshold = new System.Windows.Forms.RadioButton();
            this.numLayerThreshold = new System.Windows.Forms.NumericUpDown();
            this.rbLayersPercent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numEnMinus = new System.Windows.Forms.NumericUpDown();
            this.numEnPlus = new System.Windows.Forms.NumericUpDown();
            this.cbEnDown = new System.Windows.Forms.CheckBox();
            this.cbEnUp = new System.Windows.Forms.CheckBox();
            this.labelline = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStatistic = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            rbLayersAll = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMU)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLayerPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayerThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnPlus)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbLayersAll
            // 
            rbLayersAll.AutoSize = true;
            rbLayersAll.Location = new System.Drawing.Point(18, 3);
            rbLayersAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            rbLayersAll.Name = "rbLayersAll";
            rbLayersAll.Size = new System.Drawing.Size(143, 24);
            rbLayersAll.TabIndex = 24;
            rbLayersAll.Text = "Split ALL layers";
            rbLayersAll.UseVisualStyleBackColor = true;
            rbLayersAll.CheckedChanged += new System.EventHandler(this.rbLayersAll_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numEnMinus);
            this.groupBox1.Controls.Add(this.numEnPlus);
            this.groupBox1.Controls.Add(this.cbEnDown);
            this.groupBox1.Controls.Add(this.cbEnUp);
            this.groupBox1.Controls.Add(this.labelline);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(362, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Split Settings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbSpotsAll);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rbSpotsThreshold);
            this.panel2.Controls.Add(this.numMU);
            this.panel2.Location = new System.Drawing.Point(6, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 100);
            this.panel2.TabIndex = 31;
            // 
            // rbSpotsAll
            // 
            this.rbSpotsAll.AutoSize = true;
            this.rbSpotsAll.Location = new System.Drawing.Point(25, 21);
            this.rbSpotsAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSpotsAll.Name = "rbSpotsAll";
            this.rbSpotsAll.Size = new System.Drawing.Size(141, 24);
            this.rbSpotsAll.TabIndex = 16;
            this.rbSpotsAll.Text = "Split ALL spots";
            this.rbSpotsAll.UseVisualStyleBackColor = true;
            this.rbSpotsAll.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "MU";
            // 
            // rbSpotsThreshold
            // 
            this.rbSpotsThreshold.AutoSize = true;
            this.rbSpotsThreshold.Checked = true;
            this.rbSpotsThreshold.Location = new System.Drawing.Point(25, 54);
            this.rbSpotsThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSpotsThreshold.Name = "rbSpotsThreshold";
            this.rbSpotsThreshold.Size = new System.Drawing.Size(177, 24);
            this.rbSpotsThreshold.TabIndex = 17;
            this.rbSpotsThreshold.TabStop = true;
            this.rbSpotsThreshold.Text = "Split ONLY spots >=";
            this.rbSpotsThreshold.UseVisualStyleBackColor = true;
            this.rbSpotsThreshold.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // numMU
            // 
            this.numMU.DecimalPlaces = 1;
            this.numMU.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMU.Location = new System.Drawing.Point(209, 54);
            this.numMU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMU.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMU.Name = "numMU";
            this.numMU.Size = new System.Drawing.Size(63, 26);
            this.numMU.TabIndex = 21;
            this.numMU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMU.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMU.ValueChanged += new System.EventHandler(this.numMU_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(rbLayersAll);
            this.panel1.Controls.Add(this.numLayerPercent);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rbLayersThreshold);
            this.panel1.Controls.Add(this.numLayerThreshold);
            this.panel1.Controls.Add(this.rbLayersPercent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 105);
            this.panel1.TabIndex = 30;
            // 
            // numLayerPercent
            // 
            this.numLayerPercent.Enabled = false;
            this.numLayerPercent.Location = new System.Drawing.Point(119, 67);
            this.numLayerPercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numLayerPercent.Name = "numLayerPercent";
            this.numLayerPercent.Size = new System.Drawing.Size(63, 26);
            this.numLayerPercent.TabIndex = 29;
            this.numLayerPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLayerPercent.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "% of Layers";
            // 
            // rbLayersThreshold
            // 
            this.rbLayersThreshold.AutoSize = true;
            this.rbLayersThreshold.Checked = true;
            this.rbLayersThreshold.Location = new System.Drawing.Point(18, 35);
            this.rbLayersThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbLayersThreshold.Name = "rbLayersThreshold";
            this.rbLayersThreshold.Size = new System.Drawing.Size(179, 24);
            this.rbLayersThreshold.TabIndex = 25;
            this.rbLayersThreshold.TabStop = true;
            this.rbLayersThreshold.Text = "Split ONLY layers >=";
            this.rbLayersThreshold.UseVisualStyleBackColor = true;
            this.rbLayersThreshold.CheckedChanged += new System.EventHandler(this.rbLayersAll_CheckedChanged);
            // 
            // numLayerThreshold
            // 
            this.numLayerThreshold.Location = new System.Drawing.Point(202, 31);
            this.numLayerThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numLayerThreshold.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numLayerThreshold.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numLayerThreshold.Name = "numLayerThreshold";
            this.numLayerThreshold.Size = new System.Drawing.Size(63, 26);
            this.numLayerThreshold.TabIndex = 26;
            this.numLayerThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numLayerThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // rbLayersPercent
            // 
            this.rbLayersPercent.AutoSize = true;
            this.rbLayersPercent.Location = new System.Drawing.Point(18, 67);
            this.rbLayersPercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbLayersPercent.Name = "rbLayersPercent";
            this.rbLayersPercent.Size = new System.Drawing.Size(95, 24);
            this.rbLayersPercent.TabIndex = 28;
            this.rbLayersPercent.Text = "Split first";
            this.rbLayersPercent.UseVisualStyleBackColor = true;
            this.rbLayersPercent.CheckedChanged += new System.EventHandler(this.rbLayersAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "MeV";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(1, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 2);
            this.label1.TabIndex = 22;
            this.label1.Text = "line";
            // 
            // numEnMinus
            // 
            this.numEnMinus.DecimalPlaces = 1;
            this.numEnMinus.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEnMinus.Location = new System.Drawing.Point(207, 79);
            this.numEnMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numEnMinus.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.numEnMinus.Name = "numEnMinus";
            this.numEnMinus.Size = new System.Drawing.Size(63, 26);
            this.numEnMinus.TabIndex = 20;
            this.numEnMinus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEnMinus.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEnMinus.ValueChanged += new System.EventHandler(this.numEnMinus_ValueChanged);
            // 
            // numEnPlus
            // 
            this.numEnPlus.DecimalPlaces = 1;
            this.numEnPlus.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEnPlus.Location = new System.Drawing.Point(207, 41);
            this.numEnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numEnPlus.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.numEnPlus.Name = "numEnPlus";
            this.numEnPlus.Size = new System.Drawing.Size(63, 26);
            this.numEnPlus.TabIndex = 19;
            this.numEnPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEnPlus.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEnPlus.ValueChanged += new System.EventHandler(this.numEnPlus_ValueChanged);
            // 
            // cbEnDown
            // 
            this.cbEnDown.AutoSize = true;
            this.cbEnDown.Checked = true;
            this.cbEnDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnDown.Location = new System.Drawing.Point(48, 80);
            this.cbEnDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEnDown.Name = "cbEnDown";
            this.cbEnDown.Size = new System.Drawing.Size(147, 24);
            this.cbEnDown.TabIndex = 14;
            this.cbEnDown.Text = "Split to Energy -";
            this.cbEnDown.UseVisualStyleBackColor = true;
            this.cbEnDown.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbEnUp
            // 
            this.cbEnUp.AutoSize = true;
            this.cbEnUp.Checked = true;
            this.cbEnUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnUp.Location = new System.Drawing.Point(48, 42);
            this.cbEnUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEnUp.Name = "cbEnUp";
            this.cbEnUp.Size = new System.Drawing.Size(151, 24);
            this.cbEnUp.TabIndex = 13;
            this.cbEnUp.Text = "Split to Energy +";
            this.cbEnUp.UseVisualStyleBackColor = true;
            this.cbEnUp.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelline
            // 
            this.labelline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelline.Location = new System.Drawing.Point(0, 122);
            this.labelline.Name = "labelline";
            this.labelline.Size = new System.Drawing.Size(351, 2);
            this.labelline.TabIndex = 6;
            this.labelline.Text = "line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "MeV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "MeV";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 547);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 29);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(266, 547);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStatistic);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 160);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // txtStatistic
            // 
            this.txtStatistic.Location = new System.Drawing.Point(13, 26);
            this.txtStatistic.Multiline = true;
            this.txtStatistic.Name = "txtStatistic";
            this.txtStatistic.ReadOnly = true;
            this.txtStatistic.Size = new System.Drawing.Size(327, 117);
            this.txtStatistic.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(362, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 611);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 586);
            this.panel3.TabIndex = 0;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(139, 547);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(84, 29);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // SplitForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(562, 611);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SplitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Split";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMU)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLayerPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLayerThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEnPlus)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSpotsThreshold;
        private System.Windows.Forms.RadioButton rbSpotsAll;
        private System.Windows.Forms.CheckBox cbEnDown;
        private System.Windows.Forms.CheckBox cbEnUp;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numEnPlus;
        private System.Windows.Forms.NumericUpDown numEnMinus;
        private System.Windows.Forms.NumericUpDown numMU;
        private System.Windows.Forms.NumericUpDown numLayerThreshold;
        private System.Windows.Forms.RadioButton rbLayersThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLayerPercent;
        private System.Windows.Forms.RadioButton rbLayersPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStatistic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPreview;
    }
}