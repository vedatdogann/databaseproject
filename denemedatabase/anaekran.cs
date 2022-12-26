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
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmurun frurn = new frmurun();
            frurn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frmkatalog = new Form1();
            frmkatalog.ShowDialog();
        }

        private void btn_MusteriListesi_Click(object sender, EventArgs e)
        {
            Musteri frm = new Musteri();
            frm.ShowDialog();
        }
    }
}
