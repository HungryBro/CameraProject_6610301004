﻿namespace CameraProject_6610301004
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Face = new System.Windows.Forms.Label();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFlipVer = new System.Windows.Forms.Button();
            this.buttonFlipHor = new System.Windows.Forms.Button();
            this.buttonStsrt = new System.Windows.Forms.Button();
            this.tbCarmera = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.statusLabalDate = new System.Windows.Forms.Label();
            this.statusLabelClock = new System.Windows.Forms.Label();
            this.textBoxShowim = new System.Windows.Forms.TextBox();
            this.Log = new System.Windows.Forms.Label();
            this.groupBoxRecognizer = new System.Windows.Forms.GroupBox();
            this.UpDownChoosetime = new System.Windows.Forms.NumericUpDown();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.checkBoxRecognizer = new System.Windows.Forms.CheckBox();
            this.textBoxImageFolder = new System.Windows.Forms.TextBox();
            this.checkBoxSnpshot = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxRecognizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownChoosetime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Face);
            this.groupBox1.Controls.Add(this.imageBox2);
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(828, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Live";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "========================";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "========================";
            // 
            // Face
            // 
            this.Face.AutoSize = true;
            this.Face.Location = new System.Drawing.Point(582, 26);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(45, 20);
            this.Face.TabIndex = 3;
            this.Face.Text = "Face";
            this.Face.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.BackgroundImage = global::CameraProject_6610301004.Properties.Resources.istockphoto_1500807425_612x612;
            this.imageBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox2.Location = new System.Drawing.Point(582, 71);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(213, 222);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            this.imageBox2.Click += new System.EventHandler(this.imageBox2_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.Window;
            this.imageBox1.BackgroundImage = global::CameraProject_6610301004.Properties.Resources._8406;
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageBox1.ErrorImage")));
            this.imageBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageBox1.InitialImage")));
            this.imageBox1.Location = new System.Drawing.Point(18, 26);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(540, 289);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConnect.Location = new System.Drawing.Point(57, 29);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(147, 109);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.buttonFlipVer);
            this.groupBox2.Controls.Add(this.buttonFlipHor);
            this.groupBox2.Controls.Add(this.buttonStsrt);
            this.groupBox2.Controls.Add(this.buttonConnect);
            this.groupBox2.Location = new System.Drawing.Point(8, 360);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(834, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tool";
            // 
            // buttonFlipVer
            // 
            this.buttonFlipVer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFlipVer.Location = new System.Drawing.Point(640, 29);
            this.buttonFlipVer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonFlipVer.Name = "buttonFlipVer";
            this.buttonFlipVer.Size = new System.Drawing.Size(141, 109);
            this.buttonFlipVer.TabIndex = 5;
            this.buttonFlipVer.Text = "FlipVer";
            this.buttonFlipVer.UseVisualStyleBackColor = true;
            this.buttonFlipVer.Click += new System.EventHandler(this.buttonFlipVer_Click);
            // 
            // buttonFlipHor
            // 
            this.buttonFlipHor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFlipHor.Location = new System.Drawing.Point(450, 29);
            this.buttonFlipHor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonFlipHor.Name = "buttonFlipHor";
            this.buttonFlipHor.Size = new System.Drawing.Size(146, 109);
            this.buttonFlipHor.TabIndex = 4;
            this.buttonFlipHor.Text = "FlipHor";
            this.buttonFlipHor.UseVisualStyleBackColor = true;
            this.buttonFlipHor.Click += new System.EventHandler(this.buttonFlipHor_Click);
            // 
            // buttonStsrt
            // 
            this.buttonStsrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonStsrt.Location = new System.Drawing.Point(250, 29);
            this.buttonStsrt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonStsrt.Name = "buttonStsrt";
            this.buttonStsrt.Size = new System.Drawing.Size(156, 109);
            this.buttonStsrt.TabIndex = 6;
            this.buttonStsrt.Text = "Stsrt";
            this.buttonStsrt.UseVisualStyleBackColor = true;
            this.buttonStsrt.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbCarmera
            // 
            this.tbCarmera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCarmera.Location = new System.Drawing.Point(14, 520);
            this.tbCarmera.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbCarmera.Name = "tbCarmera";
            this.tbCarmera.Size = new System.Drawing.Size(151, 26);
            this.tbCarmera.TabIndex = 4;
            this.tbCarmera.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 36);
            this.contextMenuStrip1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(192, 520);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // statusLabalDate
            // 
            this.statusLabalDate.AutoSize = true;
            this.statusLabalDate.Location = new System.Drawing.Point(1131, 526);
            this.statusLabalDate.Name = "statusLabalDate";
            this.statusLabalDate.Size = new System.Drawing.Size(37, 20);
            this.statusLabalDate.TabIndex = 8;
            this.statusLabalDate.Text = "Day";
            this.statusLabalDate.Click += new System.EventHandler(this.statusLabalDate_Click);
            // 
            // statusLabelClock
            // 
            this.statusLabelClock.AutoSize = true;
            this.statusLabelClock.Location = new System.Drawing.Point(1051, 526);
            this.statusLabelClock.Name = "statusLabelClock";
            this.statusLabelClock.Size = new System.Drawing.Size(43, 20);
            this.statusLabelClock.TabIndex = 9;
            this.statusLabelClock.Text = "Time";
            this.statusLabelClock.Click += new System.EventHandler(this.statusLabelClock_Click);
            // 
            // textBoxShowim
            // 
            this.textBoxShowim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShowim.Location = new System.Drawing.Point(862, 244);
            this.textBoxShowim.Multiline = true;
            this.textBoxShowim.Name = "textBoxShowim";
            this.textBoxShowim.ReadOnly = true;
            this.textBoxShowim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxShowim.Size = new System.Drawing.Size(369, 268);
            this.textBoxShowim.TabIndex = 10;
            this.textBoxShowim.TextChanged += new System.EventHandler(this.textbox_log_TextChanged);
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(858, 216);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(36, 20);
            this.Log.TabIndex = 11;
            this.Log.Text = "Log";
            // 
            // groupBoxRecognizer
            // 
            this.groupBoxRecognizer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRecognizer.Controls.Add(this.UpDownChoosetime);
            this.groupBoxRecognizer.Controls.Add(this.buttonBrowse);
            this.groupBoxRecognizer.Controls.Add(this.checkBoxRecognizer);
            this.groupBoxRecognizer.Controls.Add(this.textBoxImageFolder);
            this.groupBoxRecognizer.Controls.Add(this.checkBoxSnpshot);
            this.groupBoxRecognizer.Controls.Add(this.label4);
            this.groupBoxRecognizer.Location = new System.Drawing.Point(862, 13);
            this.groupBoxRecognizer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxRecognizer.Name = "groupBoxRecognizer";
            this.groupBoxRecognizer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxRecognizer.Size = new System.Drawing.Size(378, 195);
            this.groupBoxRecognizer.TabIndex = 12;
            this.groupBoxRecognizer.TabStop = false;
            this.groupBoxRecognizer.Text = "Recognizer";
            // 
            // UpDownChoosetime
            // 
            this.UpDownChoosetime.Location = new System.Drawing.Point(178, 60);
            this.UpDownChoosetime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpDownChoosetime.Name = "UpDownChoosetime";
            this.UpDownChoosetime.Size = new System.Drawing.Size(54, 26);
            this.UpDownChoosetime.TabIndex = 20;
            this.UpDownChoosetime.ValueChanged += new System.EventHandler(this.UpDownChoosetime_ValueChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(273, 142);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(84, 29);
            this.buttonBrowse.TabIndex = 19;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // checkBoxRecognizer
            // 
            this.checkBoxRecognizer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRecognizer.AutoSize = true;
            this.checkBoxRecognizer.Location = new System.Drawing.Point(24, 28);
            this.checkBoxRecognizer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxRecognizer.Name = "checkBoxRecognizer";
            this.checkBoxRecognizer.Size = new System.Drawing.Size(172, 24);
            this.checkBoxRecognizer.TabIndex = 16;
            this.checkBoxRecognizer.Text = "On / off Recognizer";
            this.checkBoxRecognizer.UseVisualStyleBackColor = true;
            this.checkBoxRecognizer.CheckedChanged += new System.EventHandler(this.checkBoxRecognizer_CheckedChanged);
            // 
            // textBoxImageFolder
            // 
            this.textBoxImageFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageFolder.Location = new System.Drawing.Point(24, 142);
            this.textBoxImageFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxImageFolder.Name = "textBoxImageFolder";
            this.textBoxImageFolder.Size = new System.Drawing.Size(229, 26);
            this.textBoxImageFolder.TabIndex = 14;
            // 
            // checkBoxSnpshot
            // 
            this.checkBoxSnpshot.AutoSize = true;
            this.checkBoxSnpshot.Location = new System.Drawing.Point(24, 60);
            this.checkBoxSnpshot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSnpshot.Name = "checkBoxSnpshot";
            this.checkBoxSnpshot.Size = new System.Drawing.Size(148, 24);
            this.checkBoxSnpshot.TabIndex = 17;
            this.checkBoxSnpshot.Text = "on / off Snpshot";
            this.checkBoxSnpshot.UseVisualStyleBackColor = true;
            this.checkBoxSnpshot.CheckedChanged += new System.EventHandler(this.checkBoxSnpshot_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Training lmage(s) Folder";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1267, 562);
            this.Controls.Add(this.groupBoxRecognizer);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.textBoxShowim);
            this.Controls.Add(this.statusLabelClock);
            this.Controls.Add(this.statusLabalDate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbCarmera);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxRecognizer.ResumeLayout(false);
            this.groupBoxRecognizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownChoosetime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFlipHor;
        private System.Windows.Forms.Button buttonFlipVer;
        private System.Windows.Forms.TextBox tbCarmera;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonStsrt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label statusLabalDate;
        private System.Windows.Forms.Label statusLabelClock;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Label Face;
        private System.Windows.Forms.TextBox textBoxShowim;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRecognizer;
        private System.Windows.Forms.NumericUpDown UpDownChoosetime;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.CheckBox checkBoxRecognizer;
        private System.Windows.Forms.TextBox textBoxImageFolder;
        private System.Windows.Forms.CheckBox checkBoxSnpshot;
        private System.Windows.Forms.Label label4;
    }
}

