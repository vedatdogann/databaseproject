using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace denemedatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dburunler; user ID=postgres; password=123Hassin456");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("insert into kategori(kategoriid,kategoriad) values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtKategoriid.Text));
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
           
            komut.ExecuteNonQuery();

            MessageBox.Show("Kateori Kaydý Basarýlý ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update kategori set kategoriad=@p1 where kategoriid=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(TxtKategoriid.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Urun Guncelleme Ýslemi Gerceklesti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From kategori where kategoriid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtKategoriid.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Silme Ýslemi Gerceklesti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from kategori";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}