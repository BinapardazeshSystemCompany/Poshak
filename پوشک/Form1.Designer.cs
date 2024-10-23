namespace پوشک
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnmodels = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.hwhalcon = new HalconDotNet.HWindowControl();
            this.lblbrows = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbrows = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearForm1 = new System.Windows.Forms.Button();
            this.lblsensitivity = new System.Windows.Forms.Label();
            this.trasensitivity = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnbrowstrain = new System.Windows.Forms.Button();
            this.txtlocathointrain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hwhalconTrain = new HalconDotNet.HWindowControl();
            this.btnsavemodel = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btntrain = new System.Windows.Forms.Button();
            this.lblmaxtrain = new System.Windows.Forms.Label();
            this.tramaxthertrain = new System.Windows.Forms.TrackBar();
            this.lblmintrain = new System.Windows.Forms.Label();
            this.traminthertrain = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trasensitivity)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.btnsavemodel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tramaxthertrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traminthertrain)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnmodels);
            this.tabPage1.Controls.Add(this.btnstop);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.txtadress);
            this.tabPage1.Controls.Add(this.hwhalcon);
            this.tabPage1.Controls.Add(this.lblbrows);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(964, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnmodels
            // 
            this.btnmodels.Location = new System.Drawing.Point(478, 418);
            this.btnmodels.Name = "btnmodels";
            this.btnmodels.Size = new System.Drawing.Size(180, 37);
            this.btnmodels.TabIndex = 27;
            this.btnmodels.Text = "Choose your model";
            this.btnmodels.UseVisualStyleBackColor = true;
            this.btnmodels.Click += new System.EventHandler(this.btnmodels_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Red;
            this.btnstop.Enabled = false;
            this.btnstop.Location = new System.Drawing.Point(100, 418);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(89, 37);
            this.btnstop.TabIndex = 26;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Location = new System.Drawing.Point(8, 418);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 37);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtadress
            // 
            this.txtadress.Enabled = false;
            this.txtadress.Location = new System.Drawing.Point(51, 382);
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(523, 20);
            this.txtadress.TabIndex = 23;
            // 
            // hwhalcon
            // 
            this.hwhalcon.BackColor = System.Drawing.Color.Black;
            this.hwhalcon.BorderColor = System.Drawing.Color.Black;
            this.hwhalcon.ImagePart = new System.Drawing.Rectangle(0, 0, 1300, 700);
            this.hwhalcon.Location = new System.Drawing.Point(8, 6);
            this.hwhalcon.Name = "hwhalcon";
            this.hwhalcon.Size = new System.Drawing.Size(650, 350);
            this.hwhalcon.TabIndex = 0;
            this.hwhalcon.WindowSize = new System.Drawing.Size(650, 350);
            // 
            // lblbrows
            // 
            this.lblbrows.AutoSize = true;
            this.lblbrows.Location = new System.Drawing.Point(14, 385);
            this.lblbrows.Name = "lblbrows";
            this.lblbrows.Size = new System.Drawing.Size(42, 13);
            this.lblbrows.TabIndex = 21;
            this.lblbrows.Text = "Brows: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbrows);
            this.groupBox2.Location = new System.Drawing.Point(8, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 50);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location File";
            // 
            // btnbrows
            // 
            this.btnbrows.Location = new System.Drawing.Point(569, 20);
            this.btnbrows.Name = "btnbrows";
            this.btnbrows.Size = new System.Drawing.Size(74, 20);
            this.btnbrows.TabIndex = 22;
            this.btnbrows.Text = "Brows";
            this.btnbrows.UseVisualStyleBackColor = true;
            this.btnbrows.Click += new System.EventHandler(this.btnbrows_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearForm1);
            this.groupBox1.Controls.Add(this.lblsensitivity);
            this.groupBox1.Controls.Add(this.trasensitivity);
            this.groupBox1.Location = new System.Drawing.Point(665, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 454);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // btnClearForm1
            // 
            this.btnClearForm1.Enabled = false;
            this.btnClearForm1.Location = new System.Drawing.Point(6, 417);
            this.btnClearForm1.Name = "btnClearForm1";
            this.btnClearForm1.Size = new System.Drawing.Size(278, 37);
            this.btnClearForm1.TabIndex = 3;
            this.btnClearForm1.Text = "Clear";
            this.btnClearForm1.UseVisualStyleBackColor = true;
            this.btnClearForm1.Click += new System.EventHandler(this.btnClearForm1_Click);
            // 
            // lblsensitivity
            // 
            this.lblsensitivity.AutoSize = true;
            this.lblsensitivity.Location = new System.Drawing.Point(17, 38);
            this.lblsensitivity.Name = "lblsensitivity";
            this.lblsensitivity.Size = new System.Drawing.Size(75, 13);
            this.lblsensitivity.TabIndex = 2;
            this.lblsensitivity.Text = "Sensitivity: 0.9";
            // 
            // trasensitivity
            // 
            this.trasensitivity.Location = new System.Drawing.Point(75, 69);
            this.trasensitivity.Name = "trasensitivity";
            this.trasensitivity.Size = new System.Drawing.Size(200, 45);
            this.trasensitivity.TabIndex = 1;
            this.trasensitivity.Value = 9;
            this.trasensitivity.Scroll += new System.EventHandler(this.trasensitivity_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnbrowstrain);
            this.tabPage2.Controls.Add(this.txtlocathointrain);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.hwhalconTrain);
            this.tabPage2.Controls.Add(this.btnsavemodel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnbrowstrain
            // 
            this.btnbrowstrain.Location = new System.Drawing.Point(580, 360);
            this.btnbrowstrain.Name = "btnbrowstrain";
            this.btnbrowstrain.Size = new System.Drawing.Size(75, 23);
            this.btnbrowstrain.TabIndex = 8;
            this.btnbrowstrain.Text = "Brows...";
            this.btnbrowstrain.UseVisualStyleBackColor = true;
            this.btnbrowstrain.Click += new System.EventHandler(this.btnbrowstrain_Click);
            // 
            // txtlocathointrain
            // 
            this.txtlocathointrain.Enabled = false;
            this.txtlocathointrain.Location = new System.Drawing.Point(92, 362);
            this.txtlocathointrain.Name = "txtlocathointrain";
            this.txtlocathointrain.Size = new System.Drawing.Size(482, 20);
            this.txtlocathointrain.TabIndex = 7;
            this.txtlocathointrain.TextChanged += new System.EventHandler(this.txtlocathointrain_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Image Locathion: ";
            // 
            // hwhalconTrain
            // 
            this.hwhalconTrain.BackColor = System.Drawing.Color.Black;
            this.hwhalconTrain.BorderColor = System.Drawing.Color.Black;
            this.hwhalconTrain.ImagePart = new System.Drawing.Rectangle(0, 0, 1300, 700);
            this.hwhalconTrain.Location = new System.Drawing.Point(4, 2);
            this.hwhalconTrain.Name = "hwhalconTrain";
            this.hwhalconTrain.Size = new System.Drawing.Size(650, 350);
            this.hwhalconTrain.TabIndex = 0;
            this.hwhalconTrain.WindowSize = new System.Drawing.Size(650, 350);
            this.hwhalconTrain.HMouseUp += new HalconDotNet.HMouseEventHandler(this.hwhalconTrain_HMouseUp);
            // 
            // btnsavemodel
            // 
            this.btnsavemodel.Controls.Add(this.btnclear);
            this.btnsavemodel.Controls.Add(this.button1);
            this.btnsavemodel.Controls.Add(this.btntrain);
            this.btnsavemodel.Controls.Add(this.lblmaxtrain);
            this.btnsavemodel.Controls.Add(this.tramaxthertrain);
            this.btnsavemodel.Controls.Add(this.lblmintrain);
            this.btnsavemodel.Controls.Add(this.traminthertrain);
            this.btnsavemodel.Location = new System.Drawing.Point(660, 6);
            this.btnsavemodel.Name = "btnsavemodel";
            this.btnsavemodel.Size = new System.Drawing.Size(296, 453);
            this.btnsavemodel.TabIndex = 3;
            this.btnsavemodel.TabStop = false;
            this.btnsavemodel.Text = "Train setting";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(13, 326);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(271, 48);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save Model";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSaveModel);
            // 
            // btntrain
            // 
            this.btntrain.Enabled = false;
            this.btntrain.Location = new System.Drawing.Point(13, 224);
            this.btntrain.Name = "btntrain";
            this.btntrain.Size = new System.Drawing.Size(271, 48);
            this.btntrain.TabIndex = 1;
            this.btntrain.Text = "Train";
            this.btntrain.UseVisualStyleBackColor = true;
            this.btntrain.Click += new System.EventHandler(this.btntrain_Click);
            // 
            // lblmaxtrain
            // 
            this.lblmaxtrain.AutoSize = true;
            this.lblmaxtrain.Location = new System.Drawing.Point(12, 126);
            this.lblmaxtrain.Name = "lblmaxtrain";
            this.lblmaxtrain.Size = new System.Drawing.Size(95, 13);
            this.lblmaxtrain.TabIndex = 5;
            this.lblmaxtrain.Text = "Max Threshold: 75";
            // 
            // tramaxthertrain
            // 
            this.tramaxthertrain.Enabled = false;
            this.tramaxthertrain.Location = new System.Drawing.Point(68, 152);
            this.tramaxthertrain.Maximum = 255;
            this.tramaxthertrain.Name = "tramaxthertrain";
            this.tramaxthertrain.Size = new System.Drawing.Size(216, 45);
            this.tramaxthertrain.TabIndex = 4;
            this.tramaxthertrain.Value = 75;
            this.tramaxthertrain.Scroll += new System.EventHandler(this.traminthertrain_Scroll);
            // 
            // lblmintrain
            // 
            this.lblmintrain.AutoSize = true;
            this.lblmintrain.Location = new System.Drawing.Point(10, 39);
            this.lblmintrain.Name = "lblmintrain";
            this.lblmintrain.Size = new System.Drawing.Size(92, 13);
            this.lblmintrain.TabIndex = 3;
            this.lblmintrain.Text = "Min Threshold: 55";
            // 
            // traminthertrain
            // 
            this.traminthertrain.Enabled = false;
            this.traminthertrain.Location = new System.Drawing.Point(66, 65);
            this.traminthertrain.Maximum = 255;
            this.traminthertrain.Name = "traminthertrain";
            this.traminthertrain.Size = new System.Drawing.Size(216, 45);
            this.traminthertrain.TabIndex = 2;
            this.traminthertrain.Value = 55;
            this.traminthertrain.Scroll += new System.EventHandler(this.traminthertrain_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 491);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "BinaPardazeshSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trasensitivity)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.btnsavemodel.ResumeLayout(false);
            this.btnsavemodel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tramaxthertrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traminthertrain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private HalconDotNet.HWindowControl hwhalcon;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsensitivity;
        private System.Windows.Forms.TrackBar trasensitivity;
        private System.Windows.Forms.TextBox txtadress;
        private System.Windows.Forms.Label lblbrows;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnbrows;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnStart;
        private HalconDotNet.HWindowControl hwhalconTrain;
        private System.Windows.Forms.Button btntrain;
        private System.Windows.Forms.TrackBar traminthertrain;
        private System.Windows.Forms.GroupBox btnsavemodel;
        private System.Windows.Forms.Label lblmintrain;
        private System.Windows.Forms.Label lblmaxtrain;
        private System.Windows.Forms.TrackBar tramaxthertrain;
        private System.Windows.Forms.TextBox txtlocathointrain;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbrowstrain;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnmodels;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnClearForm1;
    }
}

