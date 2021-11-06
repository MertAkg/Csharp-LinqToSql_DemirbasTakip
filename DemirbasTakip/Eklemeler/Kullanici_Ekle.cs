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
    public partial class Kullanici_Ekle : Form
    {
        public Kullanici_Ekle()
        {
            InitializeComponent();
        }
        DemirbasDBDataContext linq = new DemirbasDBDataContext();
        private void Kullanici_Ekle_Load(object sender, EventArgs e)
        {
            

        


        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Kullanicilar kullanici = new tbl_Kullanicilar();
                kullanici.kTc = mtxtTc.Text;
                kullanici.kSifre = txtSifre.Text;
                kullanici.kSilindi = false;

                linq.tbl_Kullanicilars.InsertOnSubmit(kullanici);
                linq.SubmitChanges();

                lblUyari.Text = "Kullanici Başarıyla Kaydedildi";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                lblUyari.Text = "Kullanıcı Kaydedilirken Hata Oluştu";
            }
        }
    }
}
