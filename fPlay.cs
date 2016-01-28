using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class fPlay : Form
    {
        Random rnd = new Random();

        public fPlay()
        {
            InitializeComponent();
        }
        void next()
        {
            if (data.files.Count == 0)
            {
                endGame();
            }
            else
            {
                int n = rnd.Next(0, data.files.Count);
                mp.URL = data.files[n];
                data.song = data.files[n];
                mp.Ctlcontrols.play();
                data.files.RemoveAt(n);
            }
            lblCount.Text = Convert.ToString(data.files.Count);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            progressBar2.Value = 0;
            timer1.Start();
            next();
        }

        private void fPlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            pause();
        }

        private void fPlay_Load(object sender, EventArgs e)
        {
            lblCount.Text = Convert.ToString(data.files.Count);
            progressBar1.Maximum = data.gDur;
            progressBar2.Maximum = data.mDur;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            mp.Refresh();
            data.loadList();
            mp.Height = 46;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            progressBar2.Value++;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                endGame();
            }
            if (progressBar2.Value == progressBar2.Maximum)
            {
                progressBar2.Value = 0;
                pause();
                next();
                continuer();
            }
        }

        void pause()
        {
            timer1.Stop();
            mp.Ctlcontrols.pause();
        }

        void continuer()
        {
            timer1.Start();
            mp.Ctlcontrols.play();
        }

        void endGame()
        {
            pause();
            int p1 = Convert.ToInt32(lblP1.Text);
            int p2 = Convert.ToInt32(lblP2.Text);
            MessageBox.Show((p1 == p2) ? "Ничья" : (p2 > p1) ? "Игрок 2 выиграл" : "Игрок 1 выиграл", "Результат");
            Close();
        }

        private void fPlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled) return;
            if (e.KeyData == Keys.A)
            {
                pause();
                fDialog fd = new fDialog();
                fd.lblPlayer.Text = "1";
                fd.ShowDialog();
                if (fd.DialogResult == DialogResult.Yes)
                {
                    lblP1.Text = Convert.ToString(Convert.ToInt32(lblP1.Text) + 1);
                }
                next();
                continuer();
                progressBar2.Value = 0;
            }
            if (e.KeyData == Keys.L)
            {
                pause();
                fDialog fd = new fDialog();
                fd.lblPlayer.Text = "2";
                fd.ShowDialog();
                if (fd.DialogResult == DialogResult.Yes)
                {
                    lblP2.Text = Convert.ToString(Convert.ToInt32(lblP2.Text) + 1);
                }
                next();
                continuer();
                progressBar2.Value = 0;
            }
        }

        private void mp_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (data.randStart)
            {
                if (mp.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                {
                    mp.Ctlcontrols.currentPosition = rnd.Next(0, Convert.ToInt32(mp.currentMedia.duration) - data.mDur);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{Tab}");
            SendKeys.Send("{Enter}");
        }

        private void mp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3) continuer();
            if (e.newState == 2) pause();
            if (e.newState == 1) next();
        }

        private void lblP1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            if (e.Button == MouseButtons.Right) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
        }
    }
}
