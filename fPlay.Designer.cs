namespace WindowsFormsApplication3
{
    partial class fPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPlay));
            this.mp = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.mp)).BeginInit();
            this.SuspendLayout();
            // 
            // mp
            // 
            this.mp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mp.Enabled = true;
            this.mp.Location = new System.Drawing.Point(0, 305);
            this.mp.Name = "mp";
            this.mp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mp.OcxState")));
            this.mp.Size = new System.Drawing.Size(267, 46);
            this.mp.TabIndex = 0;
            this.mp.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.mp_OpenStateChange);
            this.mp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mp_PlayStateChange);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(20, 234);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(222, 53);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(12, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(110, 33);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Игрок1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(145, 31);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(110, 33);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Игрок2";
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(12, 89);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(43, 43);
            this.lblP1.TabIndex = 6;
            this.lblP1.Text = "0";
            this.lblP1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblP1_MouseClick);
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(212, 89);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(43, 43);
            this.lblP2.TabIndex = 7;
            this.lblP2.Text = "0";
            this.lblP2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblP1_MouseClick);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl3.Location = new System.Drawing.Point(16, 152);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(135, 20);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "Осталось песен:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(148, 152);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 20);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 175);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(243, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 204);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(243, 23);
            this.progressBar2.TabIndex = 11;
            // 
            // fPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources._8484201;
            this.ClientSize = new System.Drawing.Size(267, 351);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.mp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fPlay";
            this.Text = "GuessMelody";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fPlay_FormClosed);
            this.Load += new System.EventHandler(this.fPlay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fPlay_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mp;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}