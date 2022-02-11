using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MA
{
    public partial class landpage : Form
    {
        public landpage()
        {
            InitializeComponent();
            picGIF.ImageLocation = "C:\\Users\\Muhammad Gamal\\OneDrive\\Desktop\\ba.gif";
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
