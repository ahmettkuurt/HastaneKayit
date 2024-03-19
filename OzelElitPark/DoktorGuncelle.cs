using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OzelElitPark
{
    public partial class DoktorGuncelle : Form
    {
        public DoktorGuncelle()
        {
            InitializeComponent();
        }
        public string a, b, c, d, h, i, j, k;

        private void txttelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtklinik_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtkadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("update  Doktorlar set DoktorAdi=@adi,DoktorSoyadi=@soyadi,DoktorKadi=@kadi,DoktorSifre=@sifre,DoktorTc=@tc,DoktorTelefon=@tel where DoktorID=@id", SqlBaglantisi.connection);

            komut.Parameters.AddWithValue("@adi", txtadi.Text);
            komut.Parameters.AddWithValue("@soyadi", txtsoyadi.Text);
            komut.Parameters.AddWithValue("@kadi", txtkadi.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@tel", txttelefon.Text);
            komut.Parameters.AddWithValue("@id", lblid.Text);

            komut.ExecuteNonQuery();
            SqlBaglantisi.connection.Close();

            Doktorlar k = new Doktorlar();
            MessageBox.Show("Doktor Bilgileri Başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            k.Show();
            this.Hide();
        }

        private void DoktorGuncelle_Load(object sender, EventArgs e)
        {
            txttc.Enabled = false;

            lblid.Text = a;
            txtadi.Text = b;
            txtsoyadi.Text = c;
            txtkadi.Text = d;
            txtsifre.Text = h;
            txttc.Text = i;
            txttelefon.Text = j;    
            txtklinik.Text = k;

        }
    }
}
