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
    public partial class AltKategori_Ekle : Form
    {
        public AltKategori_Ekle()
        {
            InitializeComponent();
        }
        DemirbasDBDataContext linq = new DemirbasDBDataContext();
        private void AltKategori_Ekle_Load(object sender, EventArgs e)
        {
            cmbKategoriler.ValueMember = "katid";
            cmbKategoriler.DisplayMember = "katAd";


            cmbKategoriler.DataSource = linq.tbl_UrunKategoris.Where(x => x.Silindi == false).Select(x => new
            {
                katid = x.id,
                katAd = x.Ad


            }).ToList();
            //cmbKategoriler.SelectedIndex = 0; 

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_AltUrunKategori altkategori = new tbl_AltUrunKategori();
                altkategori.UrunKategoriid = (int)cmbKategoriler.SelectedValue;
                altkategori.Ad = txtAltKategoriAd.Text;
                altkategori.Silindi = false;

                linq.tbl_AltUrunKategoris.InsertOnSubmit(altkategori);
                linq.SubmitChanges();

                lblUyari.Text = "Alt Kategori Başarıyla Kaydedidi";



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                lblUyari.Text = "Alt Kategori Kaydedilirken Hata Oluştu";
            }
        }
    }
}
