using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace DemirbasTakip
{
    public partial class mdi_Panel : Form
    {
        public mdi_Panel()
        {
            InitializeComponent();
        }

        DemirbasDBDataContext linq = new DemirbasDBDataContext();
        public static DataSet dsUrunler = new DataSet();
        public static DataSet dsCalisanlar = new DataSet();
        public static DataSet dsZimmetliler = new DataSet();
        public static DataSet dsbostakiUrunler = new DataSet();
        public static DataSet dsServistekiUrunler = new DataSet();
        
        int kullaniciid;


        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun_Ekleme f1 = new Urun_Ekleme();
            f1.Show();
        }

        private void btnCalisan_Click(object sender, EventArgs e)
        {
            Calisan_Ekleme f1 = new Calisan_Ekleme();
            f1.Show();
        }

        private void dgAna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void tumUrunler()
        {
            //tüm ürünler tablosu

            var urunler = linq.tbl_Urunlers.Where(x => x.Silindi == false
            ).Select(x => new
            {
                Barkod = x.barkod,
                UrunAd = x.Ad,
                Kategori = x.tbl_UrunKategori.Ad,
                AltKategori = x.tbl_AltUrunKategori.Ad,
                Urun_Giris_Tarih = x.GirisTah,
                Garanti_Bas = x.GarantiBas,
                Garanti_Son = x.GarantiSon


            });
            dsUrunler.Tables.Clear();
            dsUrunler.Tables.Add(DS.ToDataTable(urunler.ToList()));
            dgAna.DataSource = dsUrunler.Tables[0];
        }

        public void tumZimmetliler()
        {
            //zimmetli tablosu

            var zimmetli = linq.tbl_Zimmetlilers.Where(x => x.Silindi == false).
                Select(x => new
                {
                    Barkod = x.Barkod,
                    Urun_Adi = x.tbl_Urunler.Ad,
                    Calisan = x.tbl_Calisanlar.cAdSoyad,
                    Baslangic = x.Baslangic,
                    Bitis = x.Bitis,
                });
            dsZimmetliler.Tables.Clear();
            dsZimmetliler.Tables.Add(DS.ToDataTable(zimmetli.ToList()));
            dgZimmetli.DataSource = dsZimmetliler.Tables[0];

        }

        public void bostakiler()
        {
            //boştaki ürün tablosu

            //var bosta = from u in linq.tbl_Urunlers
            //            where !(from x in linq.tbl_Zimmetlilers select x.Barkod)
            //            .Contains(u.barkod) || (from x in linq.tbl_Zimmetlilers where
            //                                x.Bitis <= DateTime.Today)
            //            select new
            //            {
            //                Barkod = u.barkod,
            //                Urun_Adi = u.Ad
            //            };

            var deneme = linq.tbl_Urunlers.Where(x => !(linq.tbl_Zimmetlilers.Select(y => y.Barkod)).Contains(x.barkod)
            || (linq.tbl_Zimmetlilers.Where(z => z.Bitis < DateTime.Today).Select(a => a.Barkod)).Contains(x.barkod))
            .Select(b => new
            {
                Barkod = b.barkod,
                         Urun_Adi = b.Ad
            })
                .ToList();

            //var deneme = linq.tbl_Zimmetlilers.Where(x => x.tbl_Urunler.barkod != x.Barkod || x.Bitis < DateTime.Today).
            //     Select(y => new
            //     {

            //         Barkod = y.tbl_Urunler.barkod,
            //         Urun_Adi = y.tbl_Urunler.Ad
            //     }).ToList();

            //var dolu = linq.tbl_Urunlers.Where(x=> !(linq.tbl_Zimmetlilers.Select(y=> y.Barkod).Contains(x.barkod))
            //|| )
            //);


            //var bosta = from u in linq.tbl_Urunlers
            //            join z in linq.tbl_Zimmetlilers on u.barkod equals z.Barkod

            //            where (z.Bitis <= DateTime.Today && u.Silindi == false)
            //            || (u.barkod != z.Barkod)

            //            select new
            //            {
            //                Barkod = u.barkod,
            //                Urun_Adi = u.Ad,
            //            };


            dsbostakiUrunler.Tables.Clear();
            dsbostakiUrunler.Tables.Add(DS.ToDataTable(deneme.ToList()));
            dgBosta.DataSource = dsbostakiUrunler.Tables[0];
        }

        public void Servistekiler()
        {
            var serviste = linq.tbl_Servislers.Where(x => x.silindi == false).Select(x => new
            {
                Barkod = x.Barkod,
                Urun_Adi = x.tbl_Urunler.Ad,
                Kimdeydi = x.tbl_Calisanlar.cAdSoyad,
                Kategori = x.tbl_AltUrunKategori.Ad,
                Gelis_Tarihi = x.serviseGelisTarihi,
                ServisSuresi = x.servisSuresi,
                ServisTutar = x.servisTutari,
                Garantili_mi = x.garantiliMi
            });
            dsServistekiUrunler.Tables.Clear();
            dsServistekiUrunler.Tables.Add(DS.ToDataTable(serviste.ToList()));
            dgServis.DataSource = dsServistekiUrunler.Tables[0];

        }

        public void Kullanicilar()
        {
            
            var Calisanlar = linq.tbl_Calisanlars.Where(x => x.cSilindi == false).Select(x => new
            {
                AdSoyad = x.cAdSoyad,
                GirisTarii = x.cGirTah,
                Pozisyon = x.cTur
            });
            
            dsCalisanlar.Tables.Clear();
            dsCalisanlar.Tables.Add(DS.ToDataTable(Calisanlar.ToList()));
            dgCalisanlar.DataSource = dsCalisanlar.Tables[0];
        }

        private void mdi_Panel_Load(object sender, EventArgs e)
        {

            tumUrunler();

            tumZimmetliler();

            bostakiler();

            Servistekiler();

            Kullanicilar();


        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void msKullanicilar_Click(object sender, EventArgs e)
        {

        }

        private void msCalisanlar_Click(object sender, EventArgs e)
        {

        }

        private void msUrunler_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKulEkle_Click(object sender, EventArgs e)
        {
            Kullanici_Ekle f1 = new Kullanici_Ekle();
            f1.Show();
        }

        private void tsmZimmetle_Click(object sender, EventArgs e)
        {
            try
            {

                int seciliBarkod = Convert.ToInt32(dgAna.SelectedRows[0].Cells["Barkod"].Value);
                bool deneme = linq.tbl_Zimmetlilers.Any(i => i.Barkod == seciliBarkod);
                if (deneme)
                {
                    MessageBox.Show("Seçiğiniz Ürünün Zaten Sahibi Var");
                }
                else
                {
                    Zimmetli_Panel f1 = new Zimmetli_Panel();
                    f1.Urun_Barkod = seciliBarkod;
                    f1.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tsmGeriAl_Click(object sender, EventArgs e)
        {
            int seciliBarkod = Convert.ToInt32(dgZimmetli.SelectedRows[0].Cells["barkod"].Value);
            var urunuBosaAl = linq.tbl_Zimmetlilers.Single(x => x.Barkod == seciliBarkod);
            urunuBosaAl.Silindi = false;
            linq.SubmitChanges();
            tumZimmetliler();
            bostakiler();


        }

        private void tsmUrunGun_Click(object sender, EventArgs e)
        {
            int seciliBarkod = Convert.ToInt32(dgAna.SelectedRows[0].Cells["Barkod"].Value);
            Urun_Guncelle f1 = new Urun_Guncelle();
            f1.Urun_Barkod = seciliBarkod;
            f1.Show();
        }

        private void tsmServisKaydi_Click(object sender, EventArgs e)
        {

            int seciliBarkod = Convert.ToInt32(dgZimmetli.SelectedRows[0].Cells["Barkod"].Value);
            Servise_Gonder f1 = new Servise_Gonder();
            f1.SeciliBarkod = seciliBarkod;
            f1.Show();
        }

        private void btnServis_Click(object sender, EventArgs e)
        {

        }

        private void tsmUrunSil_Click(object sender, EventArgs e)
        {
            int seciliBarkod = Convert.ToInt32(dgAna.SelectedRows[0].Cells["Barkod"].Value);
            var urunSil = linq.tbl_Urunlers.Single(x => x.barkod == seciliBarkod);
            urunSil.Silindi = true;
            linq.SubmitChanges();
            tumUrunler();
        }

        private void btnSilinenler_Click(object sender, EventArgs e)
        {
            Silinenler f1 = new Silinenler();
            f1.Show();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                WordeDonustur.Export_Data_To_Word(dgServis, sfd.FileName);
            }


        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            Eklemeler.Kategori_Ekle f = new Eklemeler.Kategori_Ekle();
            f.Show();

        }

        private void btnAltKategori_Click(object sender, EventArgs e)
        {
            Eklemeler.AltKategori_Ekle f = new Eklemeler.AltKategori_Ekle();
            f.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            
            DataView dvUrun= dsUrunler.Tables[0].DefaultView;
            //dvUrun.RowFilter = "Convert(Barkod, 'System.String') like '%" + txtBarkod.Text + "%'";

            //dvUrun.RowFilter = "UrunAd Like '" + txtUrunAd.Text + "%'";
            //dgAna.DataSource = dvUrun;
            dvUrun.RowFilter = "Convert(Barkod, 'System.String') like '%" + txtBarkod.Text +
                "%' AND UrunAd like '%" + txtUrunAd.Text + "%'";
             dgAna.DataSource = dvUrun;
        }

        private void tsmUrunServis_Click(object sender, EventArgs e)
        {
            int seciliBarkod = Convert.ToInt32(dgAna.SelectedRows[0].Cells["Barkod"].Value);
            Eklemeler.UrunuServiseGonder f1 = new Eklemeler.UrunuServiseGonder();
            f1.SeciliBarkod = seciliBarkod;
            f1.Show();
        }

        private void mdi_Panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris_Panel frm = Application.OpenForms["Giris_Panel"] as Giris_Panel;
            frm.Show();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {

        }

        private void tspKullaniciGecmis_Click(object sender, EventArgs e)
        {
            string seciliAd= dgCalisanlar.SelectedRows[0].Cells["AdSoyad"].Value.ToString();
            KullaniciUrunGecmisi f1 = new KullaniciUrunGecmisi();
            f1.seciliAd = seciliAd;
            f1.Show();
        }
    }
}
