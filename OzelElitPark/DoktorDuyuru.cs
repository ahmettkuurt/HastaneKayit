using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzelElitPark
{
    public partial class DoktorDuyuru : Form
    {
        public DoktorDuyuru()
        {
            InitializeComponent();
        }

        private void DoktorDuyuru_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from Duyurular", SqlBaglantisi.connection);

            DataSet ds = new DataSet();

            SqlBaglantisi.CheckConnection();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            SqlBaglantisi.connection.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            DuyuruBak db = new DuyuruBak();
            db.a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            db.b = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            db.Show();
        }
    }
}
