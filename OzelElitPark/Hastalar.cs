using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzelElitPark
{
    public partial class Hastalar : Form
    {
        public Hastalar()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            HastaEkle he =new HastaEkle();
            he.Show();
        }

        private void Hastalar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select h.HastaID,h.HastaTc, h.HastaAdi,h.HastaSoyadi,h.HastaCinsiyet,HastaTelefon,HastaAdres,h.HastaSikayet,h.HastaTedavi,k.KlinikAdi,d.DoktorAdi,d.DoktorSoyadi from Doktorlar as d inner join Klinik as k on d.KlinikID=k.KlinikID inner join Hastalar as h on h. KlinikID=k.KlinikID", SqlBaglantisi.connection);

            DataSet ds = new DataSet();

            SqlBaglantisi.CheckConnection();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            SqlBaglantisi.connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
