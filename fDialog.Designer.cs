namespace WindowsFormsApplication3
{
    partial class fDialog
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
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnShowAns = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYes.Location = new System.Drawing.Point(8, 114);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(104, 39);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Да";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNo.Location = new System.Drawing.Point(118, 114);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(94, 39);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "Нет";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(47, 16);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Игрок";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer.Location = new System.Drawing.Point(65, 5);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(18, 20);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Text = "1";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnShowAns
            // 
            this.btnShowAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAns.Location = new System.Drawing.Point(8, 28);
            this.btnShowAns.Name = "btnShowAns";
            this.btnShowAns.Size = new System.Drawing.Size(161, 30);
            this.btnShowAns.TabIndex = 4;
            this.btnShowAns.Text = "Показать ответ";
            this.btnShowAns.UseVisualStyleBackColor = true;
            this.btnShowAns.Click += new System.EventHandler(this.btnShowAns_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 44);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            // 
            // fDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 165);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnShowAns);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fDialog";
            this.Text = "Ответ правильный?";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fDialog_FormClosed);
            this.Load += new System.EventHandler(this.fDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnShowAns;
        private System.Windows.Forms.TextBox textBox1;
    }
}