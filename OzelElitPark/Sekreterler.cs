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
    public partial class Sekreterler : Form
    {
        public Sekreterler()
        {
            InitializeComponent();
        }

        private void Sekreterler_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from Sekreterler", SqlBaglantisi.connection);

            DataSet ds = new DataSet();

            SqlBaglantisi.CheckConnection();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            SqlBaglantisi.connection.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SekreterEkle se = new SekreterEkle();
            se.Show();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SekreterSil ss= new SekreterSil();
            ss.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ss.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ss.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SekreterGuncelle sg = new SekreterGuncelle();
            sg.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            sg.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sg.c = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sg.d = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sg.h = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            sg.i = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            sg.j = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            sg.Show();
        }
    }
}
