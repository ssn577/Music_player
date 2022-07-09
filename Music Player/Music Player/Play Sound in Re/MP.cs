using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Play_Sound_in_Re
{
    public partial class frm_mp : Form
    {
        public frm_mp()
        {
            InitializeComponent();
        }

        string file;
        List<string> path = new List<string>();
        private void btn_add_Click(object sender, EventArgs e)
        {            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.SafeFileName;
                path.Add(openFileDialog1.FileName);
                lst_music.Items.Add(file);
            }
        }

        private void lst_music_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                wmp.URL = path[lst_music.SelectedIndex];
            }
            catch
            {
                MessageBox.Show("No file was selected","Music Player",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.aliplvp.ir");
            Process.Start(sInfo);
        }

        private void frm_mp_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                icon1.Visible = true;
            }
            else
            {
                icon1.Visible = false;
            }
        }

        private void icon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
