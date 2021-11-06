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
    public partial class Urun_Ekleme : Form
    {
        public Urun_Ekleme()
        {
            InitializeComponent();
        }
        DemirbasDBDataContext linq = new DemirbasDBDataContext();
        int yil = (DateTime.Today.Year) - 2000;
        
        
      public string sayac()
        {
            var sayma = linq.tbl_Urunlers.Count(x => x.tbl_AltUrunKategori.id == Convert.ToInt32(cmbAltKategori.SelectedValue));
            int a = (int)sayma;
            string b = Convert.ToString(a);
            string c;
            if (a / 10 < 1)
            {
                c = "00" + b;
                return c;
            }
            if (a /10 >=1 && a /10 <=10)
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
        private void Urun_Ekleme_Load(object sender, EventArgs e)
        {
            cmKat.ValueMember = "katid";
            cmKat.DisplayMember = "katAd";
           
                
            cmKat.DataSource = linq.tbl_UrunKategoris.Where(x => x.Silindi == false).Select(x => new
            {
                katid = x.id,
                katAd = x.Ad
              

        }).ToList();
            cmKat.SelectedIndex = 0;
            

        }   
        private void cmKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAltKategori.ValueMember = "altid";
            cmbAltKategori.DisplayMember = "altAd";
            cmbAltKategori.DataSource = linq.tbl_AltUrunKategoris.Where(x => x.Silindi == false
            && x.UrunKategoriid == (int)(cmKat.SelectedValue)).Select(x => new
            {
                altid = x.id,
                altAd = x.Ad
            }
            );
        
        }
       private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {        
            tbl_Urunler urun = new tbl_Urunler();
            urun.barkod = Convert.ToInt32(txtBarkod.Text);
            urun.Ad = txtUrunAd.Text;
            urun.GirisTah = dtpGiris.Value.Date;
            urun.GarantiBas = dtpGarBas.Value.Date;
            urun.GarantiSon = dtpGarSon.Value.Date;
            urun.AltKategoriid = (int)cmbAltKategori.SelectedValue;
            urun.Kategoriid = (int)cmKat.SelectedValue; 
            urun.Silindi = false;
            linq.tbl_Urunlers.InsertOnSubmit(urun);
            linq.SubmitChanges();
            lblUyari.Text = "Ürün Başarıyla Eklendi";

                mdi_Panel frm = Application.OpenForms["mdi_Panel"] as mdi_Panel;
                frm.tumUrunler();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                lblUyari.Text = "Ürün Eklenirken Bir Hata Oldu";
            }
        }

    
        private void cmbAltKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = cmbAltKategori.SelectedValue;
            txtBarkod.Text = (value.ToString().Length < 2 ? "0" + value.ToString() : value.ToString()) + yil + sayac();
        }
    }
}
