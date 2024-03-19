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
    public partial class DoktorEkran : Form
    {
        public DoktorEkran()
        {
            InitializeComponent();
        }

        private void btnhasta_Click(object sender, EventArgs e)
        {
            DoktorHasta dh = new DoktorHasta();
            dh.Show();
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            DoktorDuyuru dd = new DoktorDuyuru();
            dd.Show();
        }
    }
}
