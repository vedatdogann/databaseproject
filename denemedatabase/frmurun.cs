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

namespace denemedatabase
{
    public partial class frmurun : Form
    {
       

        public frmurun()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dburunler; user ID=postgres; password=123Hassin456");
         NpgsqlConnection con;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select*from urunler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds =new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from kategori",baglanti);
            DataTable dt=new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember= "kategoriad";
            comboBox1.ValueMember= "kategoriid";
            comboBox1.DataSource= dt;

            baglanti.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
           // TxtAd.Text=comboBox1.SelectedValue.ToString();
           baglanti.Open();
            NpgsqlCommand komut=new NpgsqlCommand("insert into urunler(urunid,urunad,stok,alisfiyat,satisfiyat,kategori) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(TxtID.Text));
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse(numericUpDown1.Value.ToString()));
            komut.Parameters.AddWithValue("@p4", double.Parse(TxtAlisFiyat.Text));
            komut.Parameters.AddWithValue("@p5", double.Parse(TxtSatisFiyat.Text));
            komut.Parameters.AddWithValue("@p6", int.Parse(comboBox1.SelectedValue.ToString()));
        
            komut.ExecuteNonQuery();

            MessageBox.Show("Urun Kaydı Basarılı ", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);

            baglanti.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2=new NpgsqlCommand("Delete From urunler where urunid=@p1",baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Urun Silme İslemi Gerceklesti","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update urunler set urunad=@p1,stok=@p2,alisfiyat=@p3 where urunid=@p4",baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(numericUpDown1.Value.ToString()));
            komut3.Parameters.AddWithValue("@p3", double.Parse(TxtAlisFiyat.Text));
            komut3.Parameters.AddWithValue("@p4", int.Parse(TxtID.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Urun Guncelleme İslemi Gerceklesti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
          
        }
    }
}
