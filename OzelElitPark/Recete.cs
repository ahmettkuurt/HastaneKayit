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
    public partial class Recete : Form
    {
        public Recete()
        {
            InitializeComponent();
        }
        public string a, b, c, d, h, i;
        private void Recete_Load(object sender, EventArgs e)
        {
            txtadi.Text = a;
            txtsoyadi.Text = b;
            txttc.Text = c;
            txtcinsiyet.Text = d;
            txtsikayet.Text = h;
            lblid.Text = i;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlBaglantisi.CheckConnection();
            SqlCommand komut = new SqlCommand("update  Hastalar set HastaTedavi=@tedavi  where HastaID=@id", SqlBaglantisi.connection);

            komut.Parameters.AddWithValue("@tedavi", txtrecete.Text);
            komut.Parameters.AddWithValue("@id", lblid.Text);

            komut.ExecuteNonQuery();
            SqlBaglantisi.connection.Close();

            Doktorlar k = new Doktorlar();
            MessageBox.Show("Doktor Bilgileri Başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            k.Show();
            this.Hide();
        }
    }
}
