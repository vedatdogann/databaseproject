namespace denemedatabase
{
    partial class mislem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_MusteriListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_MusteriGuncelle = new System.Windows.Forms.Button();
            this.rtxt_Adres = new System.Windows.Forms.RichTextBox();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MusteriListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_MusteriListesi
            // 
            this.dgv_MusteriListesi.AllowUserToAddRows = false;
            this.dgv_MusteriListesi.AllowUserToDeleteRows = false;
            this.dgv_MusteriListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MusteriListesi.Location = new System.Drawing.Point(358, 13);
            this.dgv_MusteriListesi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_MusteriListesi.Name = "dgv_MusteriListesi";
            this.dgv_MusteriListesi.RowHeadersWidth = 51;
            this.dgv_MusteriListesi.RowTemplate.Height = 25;
            this.dgv_MusteriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MusteriListesi.Size = new System.Drawing.Size(430, 424);
            this.dgv_MusteriListesi.TabIndex = 38;
            this.dgv_MusteriListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MusteriListesi_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_MusteriGuncelle);
            this.groupBox1.Controls.Add(this.rtxt_Adres);
            this.groupBox1.Controls.Add(this.txt_Eposta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Telefon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_AdSoyad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(1, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(351, 328);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // btn_MusteriGuncelle
            // 
            this.btn_MusteriGuncelle.Location = new System.Drawing.Point(522, 371);
            this.btn_MusteriGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_MusteriGuncelle.Name = "btn_MusteriGuncelle";
            this.btn_MusteriGuncelle.Size = new System.Drawing.Size(104, 161);
            this.btn_MusteriGuncelle.TabIndex = 48;
            this.btn_MusteriGuncelle.Text = "Müşteri Güncelle";
            this.btn_MusteriGuncelle.UseVisualStyleBackColor = true;
            // 
            // rtxt_Adres
            // 
            this.rtxt_Adres.Location = new System.Drawing.Point(119, 175);
            this.rtxt_Adres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxt_Adres.Name = "rtxt_Adres";
            this.rtxt_Adres.Size = new System.Drawing.Size(218, 127);
            this.rtxt_Adres.TabIndex = 21;
            this.rtxt_Adres.Text = "";
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(119, 137);
            this.txt_Eposta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(218, 27);
            this.txt_Eposta.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Adres :";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(119, 96);
            this.txt_Telefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(218, 27);
            this.txt_Telefon.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "E-Posta :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ad Soyad :";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(119, 57);
            this.txt_AdSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(218, 27);
            this.txt_AdSoyad.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Telefon :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 29);
            this.button1.TabIndex = 49;
            this.button1.Text = "Musteri Guncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_MusteriListesi);
            this.Name = "mislem";
            this.Text = "mislem";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MusteriListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_MusteriListesi;
        private GroupBox groupBox1;
        private Button btn_MusteriGuncelle;
        private RichTextBox rtxt_Adres;
        private TextBox txt_Eposta;
        private Label label2;
        private TextBox txt_Telefon;
        private Label label8;
        private Label label9;
        private TextBox txt_AdSoyad;
        private Label label10;
        private Button button1;
    }
}