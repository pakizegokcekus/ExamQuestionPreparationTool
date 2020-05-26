using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmSoruBankası : Form
    {
        public frmSoruBankası()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        frm_CoktanSecmeli fr;
        private void btn_coktanSecmeli_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new frm_CoktanSecmeli();
                fr.MdiParent = this;
                fr.Show();
            }
            

        }

        frm_DogruYanlıs fr2;
        private void btn_dogruYanlis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr2==null)
            {
                fr2 = new frm_DogruYanlıs();
                fr2.MdiParent = this;
                fr2.Show();

            }
        }
        frm_klasik fr3;
        private void btn_klasik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new frm_klasik();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
    }
}
