using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblRed.Text = "128";
            hsbRed.Value = 128;
            lblGreen.Text = "128";
            hsbGreen.Value = 128;
            lblBlue.Text = "128";
            hsbBlue.Value = 128;
            DisplayColor();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblRed.Text = hsbRed.Value.ToString();
            DisplayColor();
        }

        private void hsbGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblGreen.Text = hsbGreen.Value.ToString();
            DisplayColor();
        }

        private void hsbBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblBlue.Text = hsbBlue.Value.ToString();
            DisplayColor();
        }
        private void DisplayColor()
        {
            pnlColor.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
        }
    }
}
