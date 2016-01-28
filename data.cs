using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace WindowsFormsApplication3
{
    static class data
    {
        static public List<string> files = new List<string>();
        static public int gDur = 60;
        static public int mDur = 10;
        static public bool randStart = false;
        static public string lastFold = "";
        static public bool subDir = true;
        static public string song = "";


        static public void loadList()
        {
            try
            {
                string[] ml = Directory.GetFiles(lastFold, "*.mp3", subDir ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                files.Clear();
                files.AddRange(ml);
            } catch
            {

            }
        }

        static string regKey = "SoftWare\\GuessMelody";

        static public void saveReg()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKey);
                if (rk == null) return;
                rk.SetValue("gDur", gDur);
                rk.SetValue("mDur", mDur);
                rk.SetValue("lastFold", lastFold);
                rk.SetValue("randStart", randStart);
                rk.SetValue("subDir", subDir);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        static public void openReg()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKey);
                if (rk != null)
                {
                    gDur = (int)rk.GetValue("gDur");
                    mDur = (int)rk.GetValue("mDur");
                    lastFold = (string)rk.GetValue("lastFold");
                    randStart = Convert.ToBoolean(rk.GetValue("randStart"));
                    subDir = Convert.ToBoolean(rk.GetValue("subDir"));
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
