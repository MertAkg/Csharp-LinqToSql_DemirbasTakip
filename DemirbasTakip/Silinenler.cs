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
    public partial class Silinenler : Form
    {
        public Silinenler()
        {
            InitializeComponent();
        }
        public void silindiler()
        {
            var Silinenler = linq.tbl_Urunlers.Where(x => x.Silindi == true).ToList();
            dgSilinenler.DataSource = Silinenler;
        }
        DemirbasDBDataContext linq = new DemirbasDBDataContext();
        private void tsmEkle_Click(object sender, EventArgs e)
        {
           int seciliBarkod = Convert.ToInt32(dgSilinenler.SelectedRows[0].Cells["barkod"].Value);
            var geriAl = linq.tbl_Urunlers.Single(x => x.barkod == seciliBarkod);
            geriAl.Silindi = false;

            linq.SubmitChanges();

            MessageBox.Show("Urun geri yüklendi");
            silindiler();
            mdi_Panel frm = Application.OpenForms["mdi_Panel"] as mdi_Panel;
            frm.tumUrunler();
        }

        private void Silinenler_Load(object sender, EventArgs e)
        {
            silindiler();
        }
    }
}
