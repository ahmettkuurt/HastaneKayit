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
    public partial class YonetiEkran : Form
    {
        public YonetiEkran()
        {
            InitializeComponent();
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            Doktorlar d = new Doktorlar();
            d.Show();

        }

        private void BtnSekreter_Click(object sender, EventArgs e)
        {
            Sekreterler s = new Sekreterler();  
            s.Show();
        }
    }
}
