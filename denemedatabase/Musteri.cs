using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace denemedatabase
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dburunler; user ID=postgres; password=123Hassin456");
        private void btn_MusteriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into musteriler(musteriadsoyad,musteritelefon,musterieposta,musteriadres) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p2", int.Parse(txt_Telefon.Text));
            komut.Parameters.AddWithValue("@p1", txt_AdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txt_Eposta.Text);
            komut.Parameters.AddWithValue("@p4", rtxt_Adres.Text);
         
            komut.ExecuteNonQuery();
            MessageBox.Show("Musteri Kaydı Basarılı ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update musteriler set musteriadsoyad=@p1 where musteritelefon=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", txt_AdSoyadGuncelle.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(txt_TelefonGuncelle.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Urun Guncelleme İslemi Gerceklesti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mislem Musteri = new mislem();
            Musteri.ShowDialog();
        }
    }
}




