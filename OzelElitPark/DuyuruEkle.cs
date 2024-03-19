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
    public partial class DuyuruEkle : Form
    {
        public DuyuruEkle()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            //bağlantı kontorlü
            SqlBaglantisi.CheckConnection();
            //sql komudumuz
            SqlCommand komut = new SqlCommand("insert into Duyurular (DuyuruBaslik,Duyuruİcerik) values (@baslik,@icerik)", SqlBaglantisi.connection);
            //veriler parametrelere atanarak daha güvenli bir şekilde veri tabanına aktarırılıyor
            komut.Parameters.AddWithValue("@baslik", txtbaslik.Text);
            komut.Parameters.AddWithValue("@icerik", txticerik.Text);

            komut.ExecuteNonQuery();
            //bağlantı kapatıyoruz
            SqlBaglantisi.connection.Close();

            MessageBox.Show("Duyuru  Başarıyla Yayımlandı .", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtbaslik.Text = "";
            txticerik.Text = "";
        }

        private void DuyuruEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
