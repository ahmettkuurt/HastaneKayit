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
    public partial class DuyuruBak : Form
    {
        public DuyuruBak()
        {
            InitializeComponent();
        }
        public string a, b;
        private void DuyuruBak_Load(object sender, EventArgs e)
        {
            txtbaslik.Text=a;
            txticerik.Text=b;
        }
    }
}
