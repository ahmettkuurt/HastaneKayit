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
    public partial class SekreterEkle : Form
    {
        public SekreterEkle()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("insert into Sekreterler (SekreterAdi,SekreterSoyadi,SekreterKadi,SekreterSifre,SekreterTc,SekreterTelefon) values (@ad,@soyad,@kadi,@sifre,@tc,@tel)", SqlBaglantisi.connection);
            komut.Parameters.AddWithValue("@ad", txtadi.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyadi.Text);
            komut.Parameters.AddWithValue("@kadi", txtkadi.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@tel", txttelefon.Text);

            komut.ExecuteNonQuery();
            SqlBaglantisi.connection.Close();

            MessageBox.Show("Sekreter Kaydı Başarıyla Gerçekleşti .", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtadi.Text = "";
            txtsifre.Text = "";
            txtsoyadi.Text = "";
            txtkadi.Text = "";
            txttc.Text = "";
            txttelefon.Text = "";
        }
    }
}
