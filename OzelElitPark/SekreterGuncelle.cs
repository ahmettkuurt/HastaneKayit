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
    public partial class SekreterGuncelle : Form
    {
        public SekreterGuncelle()
        {
            InitializeComponent();
        }
        public string a, b, c, d, h, i, j;

        private void SekreterGuncelle_Load(object sender, EventArgs e)
        {
            txttc.Enabled = false;

            lblid.Text = a;
            txtadi.Text = b;
            txtsoyadi.Text = c;
            txtkadi.Text = d;
            txtsifre.Text = h;
            txttc.Text = i;
            txttelefon.Text = j;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("update  Sekreterler set SekreterAdi=@adi,SekreterSoyadi=@soyadi,SekreterKadi=@kadi,SekreterSifre=@sifre,SekreterTc=@tc,SekreterTelefon=@tel where SekreterID=@id", SqlBaglantisi.connection);

            komut.Parameters.AddWithValue("@adi", txtadi.Text);
            komut.Parameters.AddWithValue("@soyadi", txtsoyadi.Text);
            komut.Parameters.AddWithValue("@kadi", txtkadi.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@tel", txttelefon.Text);
            komut.Parameters.AddWithValue("@id", lblid.Text);

            komut.ExecuteNonQuery();
            SqlBaglantisi.connection.Close();

            Sekreterler k = new Sekreterler();
            MessageBox.Show("Doktor Bilgileri Başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            k.Show();
            this.Hide();
           
        }
    }
}
