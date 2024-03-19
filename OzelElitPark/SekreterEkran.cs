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
    public partial class SekreterEkran : Form
    {
        public SekreterEkran()
        {
            InitializeComponent();
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            Duyurular d= new Duyurular();
            d.Show();
        }

        private void btnhasta_Click(object sender, EventArgs e)
        {
            Hastalar h = new Hastalar();
            h.Show();
        }
    }
}
