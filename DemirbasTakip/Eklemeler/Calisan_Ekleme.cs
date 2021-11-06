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
    public partial class Calisan_Ekleme : Form
    {
        public Calisan_Ekleme()
        {
            InitializeComponent();
        }

        DemirbasDBDataContext linq = new DemirbasDBDataContext();

        private void Calisan_Ekleme_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Calisanlar calisan = new tbl_Calisanlar();
                calisan.cAdSoyad = txtAdSoyad.Text;
                calisan.cTur = txtTip.Text;
                calisan.cGirTah = Convert.ToDateTime(dtpGiris.Text);
                calisan.cSilindi = false;

                linq.tbl_Calisanlars.InsertOnSubmit(calisan);
                linq.SubmitChanges();

                MessageBox.Show("Çalışan Başarıyla Kaydedildi");
                lblUyari.Text = "Çalışan Kaydedildi";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                lblUyari.Text = "Çalışan Kaydedilirken bir hata oluştu";
            }
        }
    }
}
