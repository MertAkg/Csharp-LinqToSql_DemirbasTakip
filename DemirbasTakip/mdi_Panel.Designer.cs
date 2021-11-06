namespace DemirbasTakip
{
    partial class mdi_Panel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdi_Panel));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.msKullanicilar = new System.Windows.Forms.ToolStripMenuItem();
            this.msCalisanlar = new System.Windows.Forms.ToolStripMenuItem();
            this.msUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgAna = new System.Windows.Forms.DataGridView();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmZimmetle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUrunGun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUrunSil = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnAltKategori = new System.Windows.Forms.Button();
            this.btnCalisan = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnKulEkle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gpArama = new System.Windows.Forms.GroupBox();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnSilinenler = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tum = new System.Windows.Forms.TabPage();
            this.Zimmet = new System.Windows.Forms.TabPage();
            this.dgZimmetli = new System.Windows.Forms.DataGridView();
            this.cmsZimmetle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmGeriAl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmServisKaydi = new System.Windows.Forms.ToolStripMenuItem();
            this.Bosta = new System.Windows.Forms.TabPage();
            this.dgBosta = new System.Windows.Forms.DataGridView();
            this.Servis = new System.Windows.Forms.TabPage();
            this.dgServis = new System.Windows.Forms.DataGridView();
            this.Calisanlar = new System.Windows.Forms.TabPage();
            this.dgCalisanlar = new System.Windows.Forms.DataGridView();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.tsmUrunServis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.kullaniciAyrinti = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tspKullaniciGecmis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAna)).BeginInit();
            this.cms.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.gpArama.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Tum.SuspendLayout();
            this.Zimmet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZimmetli)).BeginInit();
            this.cmsZimmetle.SuspendLayout();
            this.Bosta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBosta)).BeginInit();
            this.Servis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgServis)).BeginInit();
            this.Calisanlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCalisanlar)).BeginInit();
            this.kullaniciAyrinti.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msKullanicilar,
            this.msCalisanlar,
            this.msUrunler});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1126, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // msKullanicilar
            // 
            this.msKullanicilar.Name = "msKullanicilar";
            this.msKullanicilar.Size = new System.Drawing.Size(94, 24);
            this.msKullanicilar.Text = "Kullanicilar";
            this.msKullanicilar.Click += new System.EventHandler(this.msKullanicilar_Click);
            // 
            // msCalisanlar
            // 
            this.msCalisanlar.Name = "msCalisanlar";
            this.msCalisanlar.Size = new System.Drawing.Size(85, 24);
            this.msCalisanlar.Text = "Çalışanlar";
            this.msCalisanlar.Click += new System.EventHandler(this.msCalisanlar_Click);
            // 
            // msUrunler
            // 
            this.msUrunler.Name = "msUrunler";
            this.msUrunler.Size = new System.Drawing.Size(69, 24);
            this.msUrunler.Text = "Urunler";
            this.msUrunler.Click += new System.EventHandler(this.msUrunler_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgAna);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 429);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgAna
            // 
            this.dgAna.AllowUserToAddRows = false;
            this.dgAna.AllowUserToDeleteRows = false;
            this.dgAna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAna.ContextMenuStrip = this.cms;
            this.dgAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAna.Location = new System.Drawing.Point(0, 0);
            this.dgAna.Name = "dgAna";
            this.dgAna.ReadOnly = true;
            this.dgAna.RowTemplate.Height = 24;
            this.dgAna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAna.Size = new System.Drawing.Size(935, 429);
            this.dgAna.TabIndex = 2;
            this.dgAna.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAna_CellContentClick);
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmZimmetle,
            this.tsmUrunGun,
            this.tsmUrunSil,
            this.tsmUrunServis});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(221, 100);
            // 
            // tsmZimmetle
            // 
            this.tsmZimmetle.Name = "tsmZimmetle";
            this.tsmZimmetle.Size = new System.Drawing.Size(220, 24);
            this.tsmZimmetle.Text = "Ürünü Zimmetle";
            this.tsmZimmetle.Click += new System.EventHandler(this.tsmZimmetle_Click);
            // 
            // tsmUrunGun
            // 
            this.tsmUrunGun.Name = "tsmUrunGun";
            this.tsmUrunGun.Size = new System.Drawing.Size(220, 24);
            this.tsmUrunGun.Text = "Ürünü Güncelle";
            this.tsmUrunGun.Click += new System.EventHandler(this.tsmUrunGun_Click);
            // 
            // tsmUrunSil
            // 
            this.tsmUrunSil.Name = "tsmUrunSil";
            this.tsmUrunSil.Size = new System.Drawing.Size(220, 24);
            this.tsmUrunSil.Text = "Ürünü Sil";
            this.tsmUrunSil.Click += new System.EventHandler(this.tsmUrunSil_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnKategoriEkle);
            this.panel2.Controls.Add(this.btnAltKategori);
            this.panel2.Controls.Add(this.btnCalisan);
            this.panel2.Controls.Add(this.btnUrunEkle);
            this.panel2.Controls.Add(this.btnKulEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 591);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(133)))));
            this.btnKategoriEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKategoriEkle.Location = new System.Drawing.Point(22, 314);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(136, 51);
            this.btnKategoriEkle.TabIndex = 3;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnAltKategori
            // 
            this.btnAltKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(186)))));
            this.btnAltKategori.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAltKategori.Location = new System.Drawing.Point(22, 371);
            this.btnAltKategori.Name = "btnAltKategori";
            this.btnAltKategori.Size = new System.Drawing.Size(136, 51);
            this.btnAltKategori.TabIndex = 4;
            this.btnAltKategori.Text = "AltKategori Ekle";
            this.btnAltKategori.UseVisualStyleBackColor = false;
            this.btnAltKategori.Click += new System.EventHandler(this.btnAltKategori_Click);
            // 
            // btnCalisan
            // 
            this.btnCalisan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnCalisan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalisan.Location = new System.Drawing.Point(22, 257);
            this.btnCalisan.Name = "btnCalisan";
            this.btnCalisan.Size = new System.Drawing.Size(136, 51);
            this.btnCalisan.TabIndex = 2;
            this.btnCalisan.Text = "Çalışan Ekle";
            this.btnCalisan.UseVisualStyleBackColor = false;
            this.btnCalisan.Click += new System.EventHandler(this.btnCalisan_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnUrunEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUrunEkle.Location = new System.Drawing.Point(22, 200);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(136, 51);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnKulEkle
            // 
            this.btnKulEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.btnKulEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKulEkle.Location = new System.Drawing.Point(22, 140);
            this.btnKulEkle.Name = "btnKulEkle";
            this.btnKulEkle.Size = new System.Drawing.Size(136, 51);
            this.btnKulEkle.TabIndex = 0;
            this.btnKulEkle.Text = "Kullanıcı Ekle";
            this.btnKulEkle.UseVisualStyleBackColor = false;
            this.btnKulEkle.Click += new System.EventHandler(this.btnKulEkle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.panel3.Controls.Add(this.btnKullanicilar);
            this.panel3.Controls.Add(this.gpArama);
            this.panel3.Controls.Add(this.btnWord);
            this.panel3.Controls.Add(this.btnSilinenler);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(177, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 123);
            this.panel3.TabIndex = 3;
            // 
            // gpArama
            // 
            this.gpArama.Controls.Add(this.txtUrunAd);
            this.gpArama.Controls.Add(this.label2);
            this.gpArama.Controls.Add(this.btnAra);
            this.gpArama.Controls.Add(this.label1);
            this.gpArama.Controls.Add(this.txtBarkod);
            this.gpArama.Location = new System.Drawing.Point(10, 12);
            this.gpArama.Name = "gpArama";
            this.gpArama.Size = new System.Drawing.Size(605, 100);
            this.gpArama.TabIndex = 3;
            this.gpArama.TabStop = false;
            this.gpArama.Text = "Arama Paneli";
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.btnWord.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWord.Location = new System.Drawing.Point(621, 69);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(126, 51);
            this.btnWord.TabIndex = 1;
            this.btnWord.Text = "Word Demo";
            this.btnWord.UseVisualStyleBackColor = false;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnSilinenler
            // 
            this.btnSilinenler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.btnSilinenler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSilinenler.Location = new System.Drawing.Point(621, 12);
            this.btnSilinenler.Name = "btnSilinenler";
            this.btnSilinenler.Size = new System.Drawing.Size(126, 51);
            this.btnSilinenler.TabIndex = 2;
            this.btnSilinenler.Text = "Silinenler";
            this.btnSilinenler.UseVisualStyleBackColor = false;
            this.btnSilinenler.Click += new System.EventHandler(this.btnSilinenler_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tum);
            this.tabControl1.Controls.Add(this.Zimmet);
            this.tabControl1.Controls.Add(this.Bosta);
            this.tabControl1.Controls.Add(this.Servis);
            this.tabControl1.Controls.Add(this.Calisanlar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(177, 151);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 468);
            this.tabControl1.TabIndex = 5;
            // 
            // Tum
            // 
            this.Tum.Controls.Add(this.panel1);
            this.Tum.Location = new System.Drawing.Point(4, 29);
            this.Tum.Name = "Tum";
            this.Tum.Padding = new System.Windows.Forms.Padding(3);
            this.Tum.Size = new System.Drawing.Size(941, 435);
            this.Tum.TabIndex = 1;
            this.Tum.Text = "Tüm Ürünler";
            this.Tum.UseVisualStyleBackColor = true;
            // 
            // Zimmet
            // 
            this.Zimmet.Controls.Add(this.dgZimmetli);
            this.Zimmet.Location = new System.Drawing.Point(4, 29);
            this.Zimmet.Name = "Zimmet";
            this.Zimmet.Size = new System.Drawing.Size(941, 435);
            this.Zimmet.TabIndex = 2;
            this.Zimmet.Text = "Zimmetli Ürünler";
            this.Zimmet.UseVisualStyleBackColor = true;
            // 
            // dgZimmetli
            // 
            this.dgZimmetli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgZimmetli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZimmetli.ContextMenuStrip = this.cmsZimmetle;
            this.dgZimmetli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgZimmetli.Location = new System.Drawing.Point(0, 0);
            this.dgZimmetli.Name = "dgZimmetli";
            this.dgZimmetli.RowTemplate.Height = 24;
            this.dgZimmetli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgZimmetli.Size = new System.Drawing.Size(941, 435);
            this.dgZimmetli.TabIndex = 0;
            // 
            // cmsZimmetle
            // 
            this.cmsZimmetle.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsZimmetle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGeriAl,
            this.tsmServisKaydi});
            this.cmsZimmetle.Name = "cmsZimmetle";
            this.cmsZimmetle.Size = new System.Drawing.Size(209, 52);
            // 
            // tsmGeriAl
            // 
            this.tsmGeriAl.Name = "tsmGeriAl";
            this.tsmGeriAl.Size = new System.Drawing.Size(208, 24);
            this.tsmGeriAl.Text = "Ürünü Geri Al";
            this.tsmGeriAl.Click += new System.EventHandler(this.tsmGeriAl_Click);
            // 
            // tsmServisKaydi
            // 
            this.tsmServisKaydi.Name = "tsmServisKaydi";
            this.tsmServisKaydi.Size = new System.Drawing.Size(208, 24);
            this.tsmServisKaydi.Text = "Servis Kaydı Oluştur";
            this.tsmServisKaydi.Click += new System.EventHandler(this.tsmServisKaydi_Click);
            // 
            // Bosta
            // 
            this.Bosta.Controls.Add(this.dgBosta);
            this.Bosta.Location = new System.Drawing.Point(4, 29);
            this.Bosta.Name = "Bosta";
            this.Bosta.Size = new System.Drawing.Size(941, 435);
            this.Bosta.TabIndex = 3;
            this.Bosta.Text = "Boştaki Ürünler";
            this.Bosta.UseVisualStyleBackColor = true;
            // 
            // dgBosta
            // 
            this.dgBosta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBosta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBosta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBosta.Location = new System.Drawing.Point(0, 0);
            this.dgBosta.Name = "dgBosta";
            this.dgBosta.RowTemplate.Height = 24;
            this.dgBosta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBosta.Size = new System.Drawing.Size(941, 435);
            this.dgBosta.TabIndex = 0;
            // 
            // Servis
            // 
            this.Servis.Controls.Add(this.dgServis);
            this.Servis.Location = new System.Drawing.Point(4, 29);
            this.Servis.Name = "Servis";
            this.Servis.Size = new System.Drawing.Size(941, 435);
            this.Servis.TabIndex = 4;
            this.Servis.Text = "Servisteki Ürünler";
            this.Servis.UseVisualStyleBackColor = true;
            // 
            // dgServis
            // 
            this.dgServis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgServis.Location = new System.Drawing.Point(0, 0);
            this.dgServis.Name = "dgServis";
            this.dgServis.RowTemplate.Height = 24;
            this.dgServis.Size = new System.Drawing.Size(941, 435);
            this.dgServis.TabIndex = 0;
            // 
            // Calisanlar
            // 
            this.Calisanlar.Controls.Add(this.dgCalisanlar);
            this.Calisanlar.Location = new System.Drawing.Point(4, 29);
            this.Calisanlar.Name = "Calisanlar";
            this.Calisanlar.Size = new System.Drawing.Size(941, 435);
            this.Calisanlar.TabIndex = 5;
            this.Calisanlar.Text = "Çalışanlar";
            this.Calisanlar.UseVisualStyleBackColor = true;
            // 
            // dgCalisanlar
            // 
            this.dgCalisanlar.AllowUserToAddRows = false;
            this.dgCalisanlar.AllowUserToDeleteRows = false;
            this.dgCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCalisanlar.ContextMenuStrip = this.kullaniciAyrinti;
            this.dgCalisanlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCalisanlar.Location = new System.Drawing.Point(0, 0);
            this.dgCalisanlar.Name = "dgCalisanlar";
            this.dgCalisanlar.ReadOnly = true;
            this.dgCalisanlar.RowTemplate.Height = 24;
            this.dgCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCalisanlar.Size = new System.Drawing.Size(941, 435);
            this.dgCalisanlar.TabIndex = 0;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(112, 23);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(125, 27);
            this.txtBarkod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod :";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnAra.Location = new System.Drawing.Point(259, 30);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(92, 44);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Arama";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Urun Ad :";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(112, 54);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(125, 27);
            this.txtUrunAd.TabIndex = 4;
            // 
            // tsmUrunServis
            // 
            this.tsmUrunServis.Name = "tsmUrunServis";
            this.tsmUrunServis.Size = new System.Drawing.Size(220, 24);
            this.tsmUrunServis.Text = "Ürünü Servise Gönder";
            this.tsmUrunServis.Click += new System.EventHandler(this.tsmUrunServis_Click);
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(177)))), ((int)(((byte)(194)))));
            this.btnKullanicilar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKullanicilar.Location = new System.Drawing.Point(753, 12);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(126, 51);
            this.btnKullanicilar.TabIndex = 4;
            this.btnKullanicilar.Text = "Kullanıcılar";
            this.btnKullanicilar.UseVisualStyleBackColor = false;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // kullaniciAyrinti
            // 
            this.kullaniciAyrinti.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kullaniciAyrinti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspKullaniciGecmis});
            this.kullaniciAyrinti.Name = "kullaniciAyrinti";
            this.kullaniciAyrinti.Size = new System.Drawing.Size(209, 56);
            // 
            // tspKullaniciGecmis
            // 
            this.tspKullaniciGecmis.Name = "tspKullaniciGecmis";
            this.tspKullaniciGecmis.Size = new System.Drawing.Size(208, 24);
            this.tspKullaniciGecmis.Text = "Kullanıcının Eşyaları";
            this.tspKullaniciGecmis.Click += new System.EventHandler(this.tspKullaniciGecmis_Click);
            // 
            // mdi_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1126, 619);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mdi_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdi_Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mdi_Panel_FormClosed);
            this.Load += new System.EventHandler(this.mdi_Panel_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAna)).EndInit();
            this.cms.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.gpArama.ResumeLayout(false);
            this.gpArama.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Tum.ResumeLayout(false);
            this.Zimmet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgZimmetli)).EndInit();
            this.cmsZimmetle.ResumeLayout(false);
            this.Bosta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBosta)).EndInit();
            this.Servis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgServis)).EndInit();
            this.Calisanlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCalisanlar)).EndInit();
            this.kullaniciAyrinti.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem msKullanicilar;
        private System.Windows.Forms.ToolStripMenuItem msCalisanlar;
        private System.Windows.Forms.ToolStripMenuItem msUrunler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgAna;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnKulEkle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCalisan;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmZimmetle;
        private System.Windows.Forms.ToolStripMenuItem tsmUrunSil;
        private System.Windows.Forms.ToolStripMenuItem tsmUrunGun;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tum;
        private System.Windows.Forms.TabPage Zimmet;
        private System.Windows.Forms.DataGridView dgZimmetli;
        private System.Windows.Forms.TabPage Bosta;
        private System.Windows.Forms.DataGridView dgBosta;
        private System.Windows.Forms.ContextMenuStrip cmsZimmetle;
        private System.Windows.Forms.ToolStripMenuItem tsmGeriAl;
        private System.Windows.Forms.ToolStripMenuItem tsmServisKaydi;
        private System.Windows.Forms.TabPage Servis;
        private System.Windows.Forms.DataGridView dgServis;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnSilinenler;
        private System.Windows.Forms.TabPage Calisanlar;
        private System.Windows.Forms.DataGridView dgCalisanlar;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnAltKategori;
        private System.Windows.Forms.GroupBox gpArama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tsmUrunServis;
        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.ContextMenuStrip kullaniciAyrinti;
        private System.Windows.Forms.ToolStripMenuItem tspKullaniciGecmis;
    }
}