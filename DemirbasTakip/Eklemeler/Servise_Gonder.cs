using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemirbasTakip
{
    public partial class Servise_Gonder : Form
    {
        public Servise_Gonder()
        {
            InitializeComponent();
        }
        DemirbasDBDataContext linq = new DemirbasDBDataContext();
        public int SeciliBarkod;
        public int kategoriid;
        public int calisanid;
        public int tutar;
      

        private void Servise_Gonder_Load(object sender, EventArgs e)
        {
            //Ürünle ilgili load kısmı
            var urun = linq.tbl_Urunlers.Single(x => x.barkod == SeciliBarkod);
            lblBarkod.Text = SeciliBarkod.ToString();
            lblUrunAd.Text = urun.Ad;
            GarantiliMi();

            var urunzim = linq.tbl_Zimmetlilers.Single(x => x.Barkod == SeciliBarkod);

            //kategori load kısmı
            //var kategori = linq.tbl_AltUrunKategoris.Single(x => x.id == urun.AltKategoriid);
            //kategoriid = kategori.id;
            //lblKategori.Text = kategori.Ad.ToString() + " Servisi";
            var kategori = linq.tbl_Urunlers.Single(x => x.barkod == urunzim.Barkod);
            
            kategoriid = kategori.AltKategoriid;
            lblKategori.Text = kategori.Ad.ToString() + " Servisi";

            //çalışan load kısmı
            if (linq.tbl_Zimmetlilers.Any(x => x.Barkod == SeciliBarkod))
            {
                var zimmetliMi = linq.tbl_Zimmetlilers.Single(x => x.Barkod == SeciliBarkod);

                var calisan1 = linq.tbl_Calisanlars.Single(x => x.cid == zimmetliMi.Calisanid);
                calisanid = calisan1.cid;
                lblCalisan.Text = calisan1.cAdSoyad;
            }
            else
            {
                lblCalisan.Text = "Ürün Boşta";
                calisanid = 2;
            }
            
  }
        public void GarantiliMi()
        {

            try
            {
                var urun = linq.tbl_Urunlers.Single(x => x.barkod == SeciliBarkod);
                if (dtpServisGelis.Value <= urun.GarantiSon)
                {
                    lblGaranti.Text = "Ürün Garantili";
                    txtTutar.Text = "0";
                }
                else
                {
                    lblGaranti.Text = "Ürünün Garantisi Sona Ermiş";
                    TimeSpan aralik = dtpServisGelis.Value - dtpServisSüresi.Value;
                    int gun = Convert.ToInt32(aralik.TotalDays);
                    tutar = gun * 50;
                    txtTutar.Text = tutar.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dtpServisSüresi_ValueChanged(object sender, EventArgs e)
        {
            GarantiliMi();
        }

        private void dtpServisGelis_ValueChanged(object sender, EventArgs e)
        {
            GarantiliMi();
        }

        private void btnServisGonder_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Servisler servis = new tbl_Servisler();
                servis.Barkod = SeciliBarkod;
                servis.kategoriid = kategoriid;
                servis.tbl_Calisanlar = linq.tbl_Calisanlars.Where(x => x.cid == calisanid).First();
                servis.calisanid = calisanid;
                servis.serviseGelisTarihi = dtpServisGelis.Value;
                servis.servisSuresi = dtpServisSüresi.Value;
                servis.servisTutari = Convert.ToInt32(txtTutar.Text);
                servis.garantiliMi = tutar < 0 ? false : true;
                servis.silindi = false;

                linq.tbl_Servislers.InsertOnSubmit(servis);
                linq.SubmitChanges();

                lblUyari.Text = "Ürün Servise Gönderildi";

                mdi_Panel frm = Application.OpenForms["mdi_Panel"] as mdi_Panel;
                frm.Servistekiler();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                lblUyari.Text = "Ürünü kaydederken bir hata oluştu.";
            }
        }
    }
}
