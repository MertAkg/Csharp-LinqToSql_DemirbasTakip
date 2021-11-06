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
    public partial class Zimmetli_Panel : Form
    {
        public Zimmetli_Panel()
        {
            InitializeComponent();
        }
        DemirbasDBDataContext linq = new DemirbasDBDataContext();
        public int Urun_Barkod;

        private void Zimmetli_Panel_Load(object sender, EventArgs e)
        {
            var urun = linq.tbl_Urunlers.Single(x => x.barkod.Equals(Urun_Barkod));
            txtBarkod.Text = urun.barkod.ToString();

            cmbCalisan.ValueMember = "cid";
            cmbCalisan.DisplayMember = "cAdSoyad";
            cmbCalisan.DataSource = linq.tbl_Calisanlars.Where(x=> x.cSilindi==false).Select(x => new
            {
                cid = x.cid,
                cAdSoyad = x.cAdSoyad


            }).ToList();
        }

        private void btnZimmetle_Click(object sender, EventArgs e)
        {
            try
            {          
                tbl_Zimmetliler zimmet = new tbl_Zimmetliler();
                zimmet.Barkod = Convert.ToInt32(txtBarkod.Text);
                zimmet.Calisanid = (int)cmbCalisan.SelectedValue;
                zimmet.Baslangic = dtpBas.Value;
                zimmet.Bitis = dtpSon.Value;
                zimmet.Silindi = false;
                linq.tbl_Zimmetlilers.InsertOnSubmit(zimmet);
                linq.SubmitChanges();
                lblUyari.Text = "İşleminiz Başarıyla Gerçekleşti";

                mdi_Panel frm = Application.OpenForms["mdi_Panel"] as mdi_Panel;
                frm.tumZimmetliler();
                frm.bostakiler();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
