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
    public partial class Kategori_Ekle : Form
    {
        public Kategori_Ekle()
        {
            InitializeComponent();
        }
        DemirbasDBDataContext linq = new DemirbasDBDataContext();

        private void Kategori_Ekle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_UrunKategori kategori = new tbl_UrunKategori();
                kategori.Ad = txtKategoriAd.Text;
                kategori.Silindi = false;
                linq.tbl_UrunKategoris.InsertOnSubmit(kategori);
                linq.SubmitChanges();
                lblUyari.Text = "Kategori Başarıyla Kaydedildi";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                lblUyari.Text = "Kategori Kaydedilirken Hata Oluştu";
            }
        }
    }
}
