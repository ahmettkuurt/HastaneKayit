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
using System.Data.SqlClient;

namespace OzelElitPark
{
    public partial class DoktorSİl : Form
    {
        public DoktorSİl()
        {
            InitializeComponent();
        }
        public string a, b;

        private void sil_Click(object sender, EventArgs e)
        {
            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("delete from Doktorlar where DoktorID=@id", SqlBaglantisi.connection);

            komut.Parameters.AddWithValue("@id", lblid.Text);

            komut.ExecuteNonQuery();
            komut.Dispose();
            SqlBaglantisi.connection.Close();
            Doktorlar syf = new Doktorlar();
            MessageBox.Show("Doktorun Kaydı Başarıyla Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            Doktorlar syf = new Doktorlar();
            MessageBox.Show("Kayıt Silme İşlemi İptal Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            syf.Show();
            this.Hide();
        }

        private void DoktorSİl_Load(object sender, EventArgs e)
        {
            lblid.Text = a;
            lblad.Text = b;
        }
    }
}
