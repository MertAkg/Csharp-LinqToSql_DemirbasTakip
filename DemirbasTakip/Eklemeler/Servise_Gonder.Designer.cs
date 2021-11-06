namespace DemirbasTakip
{
    partial class Servise_Gonder
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
            this.btnServisGonder = new System.Windows.Forms.Button();
            this.dtpServisGelis = new System.Windows.Forms.DateTimePicker();
            this.dtpServisSüresi = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGaranti = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCalisan = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnServisGonder
            // 
            this.btnServisGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.btnServisGonder.Location = new System.Drawing.Point(412, 226);
            this.btnServisGonder.Name = "btnServisGonder";
            this.btnServisGonder.Size = new System.Drawing.Size(144, 44);
            this.btnServisGonder.TabIndex = 0;
            this.btnServisGonder.Text = "Servise Gönder";
            this.btnServisGonder.UseVisualStyleBackColor = false;
            this.btnServisGonder.Click += new System.EventHandler(this.btnServisGonder_Click);
            // 
            // dtpServisGelis
            // 
            this.dtpServisGelis.Location = new System.Drawing.Point(192, 162);
            this.dtpServisGelis.Name = "dtpServisGelis";
            this.dtpServisGelis.Size = new System.Drawing.Size(200, 30);
            this.dtpServisGelis.TabIndex = 2;
            this.dtpServisGelis.ValueChanged += new System.EventHandler(this.dtpServisGelis_ValueChanged);
            // 
            // dtpServisSüresi
            // 
            this.dtpServisSüresi.Location = new System.Drawing.Point(192, 198);
            this.dtpServisSüresi.Name = "dtpServisSüresi";
            this.dtpServisSüresi.Size = new System.Drawing.Size(200, 30);
            this.dtpServisSüresi.TabIndex = 6;
            this.dtpServisSüresi.ValueChanged += new System.EventHandler(this.dtpServisSüresi_ValueChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(192, 234);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(200, 30);
            this.txtTutar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Barkod :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Servise Geliş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kategori :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Servis Süresi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tutar :";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Location = new System.Drawing.Point(26, 319);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(184, 23);
            this.lblUyari.TabIndex = 17;
            this.lblUyari.Text = "Servise Gönderiliyor >>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Garanti Durumu :";
            // 
            // lblGaranti
            // 
            this.lblGaranti.AutoSize = true;
            this.lblGaranti.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGaranti.Location = new System.Drawing.Point(188, 273);
            this.lblGaranti.Name = "lblGaranti";
            this.lblGaranti.Size = new System.Drawing.Size(120, 23);
            this.lblGaranti.TabIndex = 21;
            this.lblGaranti.Text = "Garantili mi ?";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkod.Location = new System.Drawing.Point(191, 17);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(69, 23);
            this.lblBarkod.TabIndex = 22;
            this.lblBarkod.Text = "Barkod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ürün Adı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Çalışan Adı :";
            // 
            // lblCalisan
            // 
            this.lblCalisan.AutoSize = true;
            this.lblCalisan.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalisan.Location = new System.Drawing.Point(191, 89);
            this.lblCalisan.Name = "lblCalisan";
            this.lblCalisan.Size = new System.Drawing.Size(80, 23);
            this.lblCalisan.TabIndex = 26;
            this.lblCalisan.Text = "Kullanan";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(191, 128);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(79, 23);
            this.lblKategori.TabIndex = 27;
            this.lblKategori.Text = "Kategori";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAd.Location = new System.Drawing.Point(191, 53);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(82, 23);
            this.lblUrunAd.TabIndex = 28;
            this.lblUrunAd.Text = "Ürün Adı";
            // 
            // Servise_Gonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(589, 354);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblCalisan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblGaranti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.dtpServisSüresi);
            this.Controls.Add(this.dtpServisGelis);
            this.Controls.Add(this.btnServisGonder);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Servise_Gonder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servise_Gonder";
            this.Load += new System.EventHandler(this.Servise_Gonder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServisGonder;
        private System.Windows.Forms.DateTimePicker dtpServisGelis;
        private System.Windows.Forms.DateTimePicker dtpServisSüresi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGaranti;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCalisan;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblUrunAd;
    }
}