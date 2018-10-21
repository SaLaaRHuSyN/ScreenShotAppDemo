using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ScreenShotAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            System.Threading.Thread.Sleep(1000);
            SendKeys.Send("{PRTSC}");
            Image myImage = Clipboard.GetImage();
            pictureBox1.Image = myImage;
            
            myImage.Save("E:\\abc.jpg");
            this.Show();
        }
    }
}
