namespace DemirbasTakip
{
    partial class Urun_Ekleme
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.cmKat = new System.Windows.Forms.ComboBox();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.dtpGarBas = new System.Windows.Forms.DateTimePicker();
            this.dtpGarSon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAltKategori = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(166)))), ((int)(((byte)(157)))));
            this.btnEkle.Location = new System.Drawing.Point(433, 228);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(102, 41);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Urun Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(218, 14);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(192, 30);
            this.txtBarkod.TabIndex = 1;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(218, 50);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(192, 30);
            this.txtUrunAd.TabIndex = 2;
            // 
            // cmKat
            // 
            this.cmKat.FormattingEnabled = true;
            this.cmKat.Location = new System.Drawing.Point(218, 86);
            this.cmKat.Name = "cmKat";
            this.cmKat.Size = new System.Drawing.Size(192, 31);
            this.cmKat.TabIndex = 3;
            this.cmKat.SelectedIndexChanged += new System.EventHandler(this.cmKat_SelectedIndexChanged);
            // 
            // dtpGiris
            // 
            this.dtpGiris.Location = new System.Drawing.Point(218, 158);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(192, 30);
            this.dtpGiris.TabIndex = 4;
            // 
            // dtpGarBas
            // 
            this.dtpGarBas.Location = new System.Drawing.Point(218, 194);
            this.dtpGarBas.Name = "dtpGarBas";
            this.dtpGarBas.Size = new System.Drawing.Size(192, 30);
            this.dtpGarBas.TabIndex = 5;
            // 
            // dtpGarSon
            // 
            this.dtpGarSon.Location = new System.Drawing.Point(218, 230);
            this.dtpGarSon.Name = "dtpGarSon";
            this.dtpGarSon.Size = new System.Drawing.Size(192, 30);
            this.dtpGarSon.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Barkod :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ürün Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürün Kategori :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Garanti Son :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Garanti Başlangıç :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giriş Tarih :";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Location = new System.Drawing.Point(12, 290);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(178, 23);
            this.lblUyari.TabIndex = 13;
            this.lblUyari.Text = "Ürün Ekleme İşlemi >>";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.cmbAltKategori);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBarkod);
            this.panel1.Controls.Add(this.lblUyari);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUrunAd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmKat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpGiris);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpGarBas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpGarSon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 332);
            this.panel1.TabIndex = 14;
            // 
            // cmbAltKategori
            // 
            this.cmbAltKategori.FormattingEnabled = true;
            this.cmbAltKategori.Location = new System.Drawing.Point(218, 123);
            this.cmbAltKategori.Name = "cmbAltKategori";
            this.cmbAltKategori.Size = new System.Drawing.Size(192, 31);
            this.cmbAltKategori.TabIndex = 14;
            this.cmbAltKategori.SelectedIndexChanged += new System.EventHandler(this.cmbAltKategori_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ürün Alt Kategori :";
            // 
            // Urun_Ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 332);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Urun_Ekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun_Ekleme";
            this.Load += new System.EventHandler(this.Urun_Ekleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.ComboBox cmKat;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.DateTimePicker dtpGarBas;
        private System.Windows.Forms.DateTimePicker dtpGarSon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbAltKategori;
        private System.Windows.Forms.Label label7;
    }
}