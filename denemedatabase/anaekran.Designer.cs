namespace denemedatabase
{
    partial class anaekran
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MusteriListesi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 148);
            this.button1.TabIndex = 0;
            this.button1.Text = "Urun İslemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(729, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 148);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kategori İslemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(428, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(246, 148);
            this.button4.TabIndex = 3;
            this.button4.Text = "Stok";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(729, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(246, 148);
            this.button5.TabIndex = 4;
            this.button5.Text = "Giderler";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(100, 355);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(246, 148);
            this.button6.TabIndex = 5;
            this.button6.Text = "Satis";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 96);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mağaza Stok - Satış";
            // 
            // btn_MusteriListesi
            // 
            this.btn_MusteriListesi.Location = new System.Drawing.Point(428, 140);
            this.btn_MusteriListesi.Name = "btn_MusteriListesi";
            this.btn_MusteriListesi.Size = new System.Drawing.Size(246, 148);
            this.btn_MusteriListesi.TabIndex = 8;
            this.btn_MusteriListesi.Text = "Musteri İslemleri";
            this.btn_MusteriListesi.UseVisualStyleBackColor = true;
            this.btn_MusteriListesi.Click += new System.EventHandler(this.btn_MusteriListesi_Click);
            // 
            // anaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 583);
            this.Controls.Add(this.btn_MusteriListesi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "anaekran";
            this.Text = "anaekran";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel1;
        private Label label1;
        private Button btn_MusteriListesi;
    }
}