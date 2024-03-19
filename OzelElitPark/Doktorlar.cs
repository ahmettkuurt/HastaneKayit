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
    public partial class Doktorlar : Form
    {
        public Doktorlar()
        {
            InitializeComponent();
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select d.DoktorID, d.DoktorAdi,d.DoktorSoyadi,d.DoktorKadi,d.DoktorSifre,d.DoktorTc,d.DoktorTelefon,k.KlinikAdi from Doktorlar as d \r\ninner join Klinik as k on d.KlinikID=k.KlinikID", SqlBaglantisi.connection);

            DataSet ds = new DataSet();

            SqlBaglantisi.CheckConnection();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            SqlBaglantisi.connection.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            DoktorEkle de = new DoktorEkle();
            de.Show();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DoktorSİl ds = new DoktorSİl();
            ds.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ds.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ds.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            DoktorGuncelle dg = new DoktorGuncelle();
            dg.a= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dg.b= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dg.c= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dg.d= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dg.h= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dg.i= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dg.j= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dg.k= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dg.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
