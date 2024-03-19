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
    public partial class DoktorHasta : Form
    {
        public DoktorHasta()
        {
            InitializeComponent();
        }

        private void DoktorHasta_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select h.HastaID,h.HastaTc, h.HastaAdi,h.HastaSoyadi,h.HastaCinsiyet,h.HastaSikayet,h.HastaTedavi,k.KlinikAdi,d.DoktorAdi,d.DoktorSoyadi from Doktorlar as d inner join Klinik as k on d.KlinikID=k.KlinikID inner join Hastalar as h on h. KlinikID=k.KlinikID", SqlBaglantisi.connection);

            DataSet ds = new DataSet();

            SqlBaglantisi.CheckConnection();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            SqlBaglantisi.connection.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Recete dg = new Recete();
            dg.a = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dg.b = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dg.c = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dg.d = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dg.h = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dg.i = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dg.Show();
        }
    }
}
