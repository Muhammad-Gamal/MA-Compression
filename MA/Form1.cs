using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MA
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );
        public Form1()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnRLC.Height;
            pnlNav.Top = btnRLC.Top;
            pnlNav.Left = btnRLC.Left;
            //btnRLC.BackColor = Color.FromArgb(25,25,25);

            this.pnlLoader.Controls.Clear();
            rlc rlc_vrb = new rlc() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            rlc_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(rlc_vrb);
            rlc_vrb.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = btnRLC.Height;
            pnlNav.Top = btnRLC.Top;
            pnlNav.Left = btnRLC.Left;
            //btnRLC.BackColor = Color.FromArgb(25,25,25);

            this.pnlLoader.Controls.Clear();
            rlc rlc_vrb = new rlc() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            rlc_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(rlc_vrb);
            rlc_vrb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnVLC.Height;
            pnlNav.Top = btnVLC.Top;
            pnlNav.Left = btnVLC.Left;
            //btnVLC.BackColor = Color.FromArgb(25, 25, 25);

            this.pnlLoader.Controls.Clear();
            vlc vlc_vrb = new vlc() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            vlc_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(vlc_vrb);
            vlc_vrb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLZW_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLZW.Height;
            pnlNav.Top = btnLZW.Top;
            pnlNav.Left = btnLZW.Left;
            //btnLZW.BackColor = Color.FromArgb(25, 25, 25);

            this.pnlLoader.Controls.Clear();
            lzw lzw_vrb = new lzw() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            lzw_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(lzw_vrb);
            lzw_vrb.Show();
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAD.Height;
            pnlNav.Top = btnAD.Top;
            pnlNav.Left = btnAD.Left;
            //btnAD.BackColor = Color.FromArgb(25, 25, 25);

            this.pnlLoader.Controls.Clear();
            ad ad_vrb = new ad() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ad_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(ad_vrb);
            ad_vrb.Show();
        }

        private void btnHF_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHF.Height;
            pnlNav.Top = btnHF.Top;
            pnlNav.Left = btnHF.Left;
            //btnHF.BackColor = Color.FromArgb(25, 25, 25);

            this.pnlLoader.Controls.Clear();
            hf hf_vrb = new hf() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            hf_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoader.Controls.Add(hf_vrb);
            hf_vrb.Show();
        }

        private void btnRLC_Leave(object sender, EventArgs e)
        {
            btnRLC.BackColor = Color.FromArgb(0,0,0);
        }

        private void btnVLC_Leave(object sender, EventArgs e)
        {
            btnVLC.BackColor = Color.FromArgb(0,0,0);
        }

        private void btnLZW_Leave(object sender, EventArgs e)
        {
            btnLZW.BackColor = Color.FromArgb(0,0,0);
        }

        private void btnAD_Leave(object sender, EventArgs e)
        {
            btnAD.BackColor = Color.FromArgb(0,0,0);
        }

        private void btnHF_Leave(object sender, EventArgs e)
        {
            btnHF.BackColor = Color.FromArgb(0,0,0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
