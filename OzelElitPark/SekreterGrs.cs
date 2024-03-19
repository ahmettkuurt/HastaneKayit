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
    public partial class SekreterGrs : Form
    {
        public SekreterGrs()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("select*from Sekreterler where SekreterKadi=@kadi and SekreterSifre=@sifre", SqlBaglantisi.connection);
            komut.Parameters.AddWithValue("@kadi", txtkadi.Text);
            komut.Parameters.AddWithValue("@sifre", txtsifre.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Hoş Geldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SekreterEkran ye = new SekreterEkran();
                ye.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlBaglantisi.connection.Close();
        }
    }
}
