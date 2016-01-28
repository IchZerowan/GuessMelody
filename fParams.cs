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
    public partial class fParams : Form
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public fParams()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            data.gDur = Convert.ToInt32(nudCount.Value);
            data.mDur = Convert.ToInt32(nudDur.Value);
            data.randStart = cbPos.Checked;
            data.subDir = cbSubFolders.Checked;
            data.saveReg();
            Hide();
        }

        private void setDefault()
        {
            nudCount.Value = data.gDur;
            nudDur.Value = data.mDur;
            cbPos.Checked = data.randStart;
            cbSubFolders.Checked = data.subDir;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setDefault();
            Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] ml = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cbSubFolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                data.lastFold = fbd.SelectedPath;
                listBox1.Items.Clear();
                data.files.Clear();
                listBox1.Items.AddRange(ml);
                data.files.AddRange(ml);
            }
        }

        private void fParams_Load(object sender, EventArgs e)
        {
            setDefault();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(data.files.ToArray());
        }
    }
}
