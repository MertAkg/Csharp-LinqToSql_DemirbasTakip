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
    public partial class Giris_Panel : Form
    {
        public Giris_Panel()
        {
            InitializeComponent();
        }
        Form T;
        DemirbasDBDataContext linq = new DemirbasDBDataContext();
        private bool giris(string Tc, string Sifre)
        {
            var sorgu = from p in linq.tbl_Kullanicilars
                        where p.kTc == Tc
                        && p.kSifre == Sifre
                        && p.kSilindi == false
                        select p;
            if (sorgu.Any())
            {

                return true;
            }

            else
            {
                return false;
            }
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (giris(txtTc.Text, (txtSifre.Text)))
            {

                if (Application.OpenForms["mdi_Panel"] != null)
                {
                    T = Application.OpenForms["mdi_Panel"];
                    T.Focus();

                }
                else
                {
                    Form anaForm = Application.OpenForms["mdi_Panel"];
                    T = new mdi_Panel();
                    //T.MdiParent = mdi_Panel.ActiveForm;
                    this.Hide();
                    T.Show();
                   
                }
            }
        }

        private void Giris_Panel_Load(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Kullanici_Ekle f1 = new Kullanici_Ekle();
            f1.Show();
        }
    }
}