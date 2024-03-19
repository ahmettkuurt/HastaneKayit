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
    public partial class DuyuruSil : Form
    {
        public DuyuruSil()
        {
            InitializeComponent();
        }
        public string a, b;
        private void DuyuruSil_Load(object sender, EventArgs e)
        {
            lblid.Text = a;
            lblad.Text = b;
            
        }

        private void sil_Click(object sender, EventArgs e)
        {
            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("delete from Duyurular where DuyuruID=@id", SqlBaglantisi.connection);

            komut.Parameters.AddWithValue("@id", lblid.Text);

            komut.ExecuteNonQuery();
            komut.Dispose();
            SqlBaglantisi.connection.Close();
            Duyurular syf = new Duyurular();
            MessageBox.Show("Duyuru Başarıyla Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            Duyurular syf = new Duyurular();
            MessageBox.Show("Duyuru Silme İşlemi İptal Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
            
        }
    }
}
