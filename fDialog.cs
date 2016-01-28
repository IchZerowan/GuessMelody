using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class fDialog : Form
    {
        public fDialog()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("Resources\\s.wav");
            lblPlayer.Text = "";
            lbl1.Text = "Время вышло!!!";
            sp.PlaySync();
            btnYes.DialogResult = DialogResult.No;
            timer1.Stop();
        }

        private void fDialog_Load(object sender, EventArgs e)
        {
            timer1.Start();
            btnYes.DialogResult = DialogResult.Yes;
            textBox1.Visible = false;
        }

        private void fDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            lbl1.Text = "Игрок";
        }

        private void btnShowAns_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            var mp3 = TagLib.File.Create(data.song);
            textBox1.Text = mp3.Tag.Title;
            if (textBox1.Text == "")
            {
                textBox1.Text = Path.GetFileNameWithoutExtension(data.song);
            }
            timer1.Stop();
        }
    }
}
