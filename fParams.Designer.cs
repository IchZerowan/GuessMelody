namespace WindowsFormsApplication3
{
    partial class fParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fParams));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbSubFolders = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.nudDur = new System.Windows.Forms.NumericUpDown();
            this.cbPos = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDur)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(332, 173);
            this.listBox1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 191);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 33);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(121, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 33);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cbSubFolders
            // 
            this.cbSubFolders.AutoSize = true;
            this.cbSubFolders.Checked = true;
            this.cbSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSubFolders.Location = new System.Drawing.Point(230, 200);
            this.cbSubFolders.Name = "cbSubFolders";
            this.cbSubFolders.Size = new System.Drawing.Size(118, 17);
            this.cbSubFolders.TabIndex = 3;
            this.cbSubFolders.Text = "Вложенные папки";
            this.cbSubFolders.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(273, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(196, 386);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(71, 28);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 252);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(87, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Сколько играть";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 288);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(86, 13);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Время на ответ";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(105, 250);
            this.nudCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(56, 20);
            this.nudCount.TabIndex = 8;
            this.nudCount.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // nudDur
            // 
            this.nudDur.Location = new System.Drawing.Point(105, 286);
            this.nudDur.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDur.Name = "nudDur";
            this.nudDur.Size = new System.Drawing.Size(56, 20);
            this.nudDur.TabIndex = 9;
            this.nudDur.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbPos
            // 
            this.cbPos.AutoSize = true;
            this.cbPos.Location = new System.Drawing.Point(15, 321);
            this.cbPos.Name = "cbPos";
            this.cbPos.Size = new System.Drawing.Size(133, 17);
            this.cbPos.TabIndex = 10;
            this.cbPos.Text = "Со случайного места";
            this.cbPos.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "A";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(243, 288);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(47, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "L";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Игрок1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Игрок2";
            // 
            // fParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 426);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbPos);
            this.Controls.Add(this.nudDur);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbSubFolders);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fParams";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fParams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbSubFolders;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.NumericUpDown nudDur;
        private System.Windows.Forms.CheckBox cbPos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}