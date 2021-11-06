using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemirbasTakip.Eklemeler
{
    public partial class UrunuServiseGonder : Form
    {
        public UrunuServiseGonder()
        {
            InitializeComponent();
        }
        DemirbasDBDataContext linq = new DemirbasDBDataContext();
        public int SeciliBarkod;
        public int kategoriid;
        public int calisanid;
        public int tutar;


        private void UrunuServiseGonder_Load(object sender, EventArgs e)
        {
            //Ürünle ilgili load kısmı
            var urun = linq.tbl_Urunlers.Single(x => x.barkod == SeciliBarkod);
            lblBarkod.Text = SeciliBarkod.ToString();
            lblUrunAd.Text = urun.Ad;
            GarantiliMi();



            //kategori load kısmı
            var kategori = linq.tbl_AltUrunKategoris.Single(x => x.id == urun.AltKategoriid);
            kategoriid = kategori.id;
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
                var urun2 = linq.tbl_Urunlers.Single(x => x.barkod == SeciliBarkod);
                if (dtpServisGelis2.Value <= urun2.GarantiSon)
                {
                    lblGaranti2.Text = "Ürün Garantili";
                    txtTutar2.Text = "0";
                }
                else
                {
                    lblGaranti2.Text = "Ürünün Garantisi Sona Ermiş";
                    TimeSpan aralik2 = dtpServisGelis2.Value - dtpServisSüresi2.Value;
                    int gun = Convert.ToInt32(aralik2.TotalDays);
                    tutar = gun * 50;
                    txtTutar2.Text =Convert.ToString(tutar);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void dtpServisGelis2_ValueChanged(object sender, EventArgs e)
        {
            GarantiliMi();
        }

        private void dtpServisSüresi2_ValueChanged(object sender, EventArgs e)
        {
            GarantiliMi();
        }

        private void btnServisGonder_Click_1(object sender, EventArgs e)
        {
            try
            {
                tbl_Servisler servis = new tbl_Servisler();
                servis.Barkod = SeciliBarkod;
                servis.kategoriid = kategoriid;

                servis.calisanid = calisanid;
                servis.serviseGelisTarihi = dtpServisGelis2.Value;
                servis.servisSuresi = dtpServisSüresi2.Value;
                servis.servisTutari = Convert.ToInt32(txtTutar2.Text);
                servis.garantiliMi = tutar < 0 ? false : true;
                servis.silindi = false;

                linq.tbl_Servislers.InsertOnSubmit(servis);
                linq.SubmitChanges();

                lblUyari2.Text = "Ürün Servise Gönderildi";

                mdi_Panel frm = Application.OpenForms["mdi_Panel"] as mdi_Panel;
                frm.Servistekiler();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                lblUyari2.Text = "Ürünü kaydederken bir hata oluştu.";
            }
        }
    }
}
