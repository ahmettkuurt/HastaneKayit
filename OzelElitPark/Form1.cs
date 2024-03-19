using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzelElitPark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnYonetici_Click(object sender, EventArgs e)
        {
            YoneticiGrs yg = new YoneticiGrs();
            yg.Show();
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            DoktorGrs d = new DoktorGrs();
            d.Show();
        }

        private void BtnSekreter_Click(object sender, EventArgs e)
        {
            SekreterGrs sg = new SekreterGrs();
            sg.Show();
        }
    }
}
