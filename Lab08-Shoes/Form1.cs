using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_Shoes
{
    public partial class frmLab08Shoes : Form
    {
        public frmLab08Shoes()
        {
            InitializeComponent();
            sslPicture.Text = "Floaters";
            
        }
        private void Form1_Load(object sender, EventArgs e)
        { }


        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuShoesBrowse_Click(object sender, EventArgs e)
        {
            ofdImage.Title = "Open a Picture";
            ofdImage.FileName = "";
            ofdImage.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, @"Images");
            ofdImage.Filter = "All Files|*.*|Text Files|*.txt|Image Files|*.jpg;*.gif;*.png";
            ofdImage.FilterIndex = 3;
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                picDisplay.Image = Image.FromFile(ofdImage.FileName);
                
                sslPicture.Text = ofdImage.SafeFileName.Split('.')[0];
            }
        }

        private void conMnuBrowser_Click(object sender, EventArgs e)
        {
            mnuShoesBrowse.PerformClick();
        }
    }
}
