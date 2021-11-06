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
    public partial class Urun_Guncelle : Form
    {
        public Urun_Guncelle()
        {
            InitializeComponent();
        }
        int yil = (DateTime.Today.Year) - 2000;
        public int Urun_Barkod;
        DemirbasDBDataContext linq = new DemirbasDBDataContext();
        public string sayac()
        {
            var sayma = linq.tbl_Urunlers.Count(x => x.tbl_UrunKategori.id == Convert.ToInt32(cmbAltKategori.SelectedValue));
            int a = (int)sayma;
            string b = Convert.ToString(a);
            string c;
            if (a / 10 <= 1)
            {
                c = "00" + b;
                return c;
            }
            if (a / 10 >= 1 && a / 10 <= 10)
            {
                c = "0" + b;
                return c;
            }
            else
            {
                c = b;
                return c;
            }
        }
        private void Urun_Guncelle_Load(object sender, EventArgs e)
        {

            cmbKategori.ValueMember = "katid";
            cmbKategori.DisplayMember = "katAd";
            cmbKategori.DataSource = linq.tbl_UrunKategoris.Where(x => x.Silindi == false).Select(x => new
            {
                katid = x.id,
                katAd = x.Ad
            });
            

            var urungun = linq.tbl_Urunlers.Single(x => x.barkod == Urun_Barkod);
            txtBarkod.Text = urungun.barkod.ToString();
            txtUrunAdi.Text = urungun.Ad;
            

            
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAltKategori.ValueMember = "altid";
            cmbAltKategori.DisplayMember = "altAd";
            cmbAltKategori.DataSource = linq.tbl_AltUrunKategoris.Where(x => x.Silindi == false
            && x.UrunKategoriid == (int)(cmbKategori.SelectedValue)).Select(x => new
            {
                altid = x.id,
                altAd = x.Ad
            }
            );

        }

        private void cmbAltKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = cmbAltKategori.SelectedValue;
            txtBarkod.Text = (value.ToString().Length < 2 ? "0" + value.ToString() : value.ToString()) + yil + sayac();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Urunler guncelUrun = linq.tbl_Urunlers.Single(x => x.barkod.Equals(Urun_Barkod));

                guncelUrun.barkod = Convert.ToInt32(txtBarkod.Text);
                guncelUrun.Ad = txtUrunAdi.Text;
                guncelUrun.GirisTah = dtpUrunGiris.Value;
                guncelUrun.GarantiBas = dtpGarantiBas.Value;
                guncelUrun.GarantiSon = dtpGarantiSon.Value;
                guncelUrun.Kategoriid = (int)cmbKategori.SelectedValue;
                guncelUrun.AltKategoriid = (int)cmbAltKategori.SelectedValue;

                linq.SubmitChanges();

                lblUyari.Text = "Ürün Başarıyla Güncellendi";

                mdi_Panel frm = Application.OpenForms["mdi_Panel"] as mdi_Panel;
                frm.tumUrunler();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                lblUyari.Text = "Ürün Güncellenirken Bir Hata Oluştu";
            }

        
           

        }
    }
}
