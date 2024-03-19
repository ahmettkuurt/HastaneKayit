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
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            //seçilen kliniğin ıdsini çekmeye yarıyor
            string kliniktür;
            int KlinikID = 0;
            kliniktür = cbklinik.SelectedItem.ToString();
            SqlDataReader oku;
            object sonuc;
            SqlCommand KlinikID_cek = new SqlCommand("SELECT KlinikID FROM Klinik where KlinikAdi='" + kliniktür + "'", SqlBaglantisi.connection);
            SqlBaglantisi.connection.Open();
            sonuc = KlinikID_cek.ExecuteScalar();
            if (sonuc != null)
            {
                oku = KlinikID_cek.ExecuteReader();
                while (oku.Read())
                {
                    KlinikID = int.Parse(oku[0].ToString());
                }
            }

            SqlBaglantisi.connection.Close();





            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("insert into Doktorlar (DoktorAdi,DoktorSoyadi,DoktorKadi,DoktorSifre,DoktorTc,DoktorTelefon,KlinikID) values (@ad,@soyad,@kadi,@sifre,@tc,@tel,@klinik)", SqlBaglantisi.connection);
            komut.Parameters.AddWithValue("@ad", txtadi.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyadi.Text);
            komut.Parameters.AddWithValue("@kadi", txtkadi.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@tel", txttelefon.Text);
            komut.Parameters.AddWithValue("@klinik", KlinikID.ToString());

            komut.ExecuteNonQuery();
            SqlBaglantisi.connection.Close();

            MessageBox.Show("Doktor Kaydı Başarıyla Gerçekleşti .", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtadi.Text = "";
            txtsifre.Text = "";
            txtsoyadi.Text = "";
            txtkadi.Text = "";
            txttc.Text = "";
            txttelefon.Text = "";
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("select*from Klinik", SqlBaglantisi.connection);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cbklinik.Items.Add(dr["KlinikAdi"]);
            }
            SqlBaglantisi.connection.Close ();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
