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
    public partial class mislem : Form
    {
        public mislem()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dburunler; user ID=postgres; password=123Hassin456");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgv_MusteriListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string sorgu = "select*from musteriler";
            //NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
