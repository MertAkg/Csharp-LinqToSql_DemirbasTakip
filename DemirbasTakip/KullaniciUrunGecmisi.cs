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
    public partial class KullaniciUrunGecmisi : Form
    {
        public KullaniciUrunGecmisi()
        {
            InitializeComponent();
        }
        public int kullaniciid;
        public string seciliAd;
        DemirbasDBDataContext linq = new DemirbasDBDataContext();
        private void KullaniciUrunGecmisi_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = seciliAd;
            
            var calisan = linq.tbl_Calisanlars.Single(x => x.cAdSoyad.Equals(seciliAd));
            lblPozisyon.Text = calisan.cTur;

            var urunleri = linq.tbl_Zimmetlilers.Where(x => x.Calisanid == calisan.cid).
                Select(x => new
                {
                    UrununBarkodu = x.Barkod,
                    UrununAdı = x.tbl_Urunler.Ad,
                    ZimmetBaslangicTarihi = x.Baslangic,
                    ZimmetBitis = x.Bitis

                });
            dgKullaniciUrun.DataSource = urunleri;



            var servis = linq.tbl_Servislers.Where(x => x.silindi == false && x.calisanid == calisan.cid).
                Select(x => new
                {
                    UrunBarkod = x.Barkod,
                    Kategorisi = x.tbl_AltUrunKategori.Ad,
                    GelisTarihi = x.serviseGelisTarihi,
                    ServisSüresi = x.servisSuresi,
                    ServisTutari = x.servisTutari,
                    GarantiliMiydi = x.garantiliMi
                    
                });

            dgServisGecmisi.DataSource = servis;

        }
    }
}
