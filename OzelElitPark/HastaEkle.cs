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
    public partial class HastaEkle : Form
    {
        public HastaEkle()
        {
            InitializeComponent();
        }

        private void HastaEkle_Load(object sender, EventArgs e)
        {
            //klinikadlarını comboboxa yazdırıyo
            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("select KlinikAdi from Klinik", SqlBaglantisi.connection);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbklinik.Items.Add(dr[0].ToString());
            }
            SqlBaglantisi.connection.Close();

            
        }

        private void cbklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen kliniğin idsini çekiyor
            string kliniktür;
            int KlinikID = 0;
            kliniktür = cbklinik.SelectedItem.ToString();
            SqlDataReader oku;
            object sonuc;
            SqlCommand kllncID_cek = new SqlCommand("SELECT KlinikID FROM Klinik where KlinikAdi='" + kliniktür + "'", SqlBaglantisi.connection);
            SqlBaglantisi.connection.Open();
            sonuc = kllncID_cek.ExecuteScalar();
            if (sonuc != null)
            {
                oku = kllncID_cek.ExecuteReader();
                while (oku.Read())
                {
                    KlinikID = int.Parse(oku[0].ToString());
                }
            }

            SqlBaglantisi.connection.Close();

            cbdoktor.Items.Clear();
            // klinik idye göre doktorları comboboxa çekiyor
            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("Select (DoktorAdi+' '+DoktorSoyadi) From Doktorlar where KlinikID=@p1", SqlBaglantisi.connection);
            komut.Parameters.AddWithValue("@p1", KlinikID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbdoktor.Items.Add(dr[0].ToString());
            }
            SqlBaglantisi.connection.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            //seçilen kliniğin idsini çekiyor
            string kliniktür;
            int KlinikID = 0;
            kliniktür = cbklinik.SelectedItem.ToString();
            SqlDataReader oku;
            object sonuc;
            SqlCommand kllncID_cek = new SqlCommand("SELECT KlinikID FROM Klinik where KlinikAdi='" + kliniktür + "'", SqlBaglantisi.connection);
            SqlBaglantisi.connection.Open();
            sonuc = kllncID_cek.ExecuteScalar();
            if (sonuc != null)
            {
                oku = kllncID_cek.ExecuteReader();
                while (oku.Read())
                {
                    KlinikID = int.Parse(oku[0].ToString());
                }
            }

            //seçilen doktoryb idsini çekiyor
            SqlBaglantisi.connection.Close();
            string Doktortür;
            int DoktorID = 0;
            Doktortür = cbdoktor.SelectedItem.ToString();
            SqlDataReader okuu;
            object sonuuc;
            SqlCommand DoktorID_cek = new SqlCommand("SELECT DoktorID FROM Doktorlar where DoktorAdi='" + Doktortür + "'", SqlBaglantisi.connection);
            SqlBaglantisi.connection.Open();
            sonuuc = DoktorID_cek.ExecuteScalar();
            if (sonuuc != null)
            {
                okuu = kllncID_cek.ExecuteReader();
                while (okuu.Read())
                {
                    DoktorID = int.Parse(okuu[0].ToString());
                }
            }

            SqlBaglantisi.connection.Close();


            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("insert into Hastalar (HastaTc,HastaAdi,HastaSoyadi,HastaCinsiyet,HastaTelefon,HastaAdres,HastaSikayet,KlinikID) values (@tc,@ad,@soyad,@cinsiyet,@tel,@adres,@sikayet,@klinik)", SqlBaglantisi.connection);
            komut.Parameters.AddWithValue("@ad", txtadi.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyadi.Text);
            komut.Parameters.AddWithValue("@cinsiyet", txtcinsiyet.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@tel", txttelefon.Text);
            komut.Parameters.AddWithValue("@sikayet", txtsikayet.Text);
            komut.Parameters.AddWithValue("@klinik", KlinikID.ToString());

            komut.ExecuteNonQuery();
            SqlBaglantisi.connection.Close();

            MessageBox.Show("Doktor Kaydı Başarıyla Gerçekleşti .", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtadi.Text = "";
            txtcinsiyet.Text = "";
            txtsoyadi.Text = "";
            txtadres.Text = "";
            txttc.Text = "";
            txttelefon.Text = "";
            txtsikayet.Text = "";
        }
    }
}
