using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class frm_CoktanSecmeli : Form
    {
        public frm_CoktanSecmeli()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT*FROM CoktanSecmeli",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmCoktanSecmeli_Load(object sender, EventArgs e)
        {
            listele();
            cmb_seviye.Items.Add("Kolay");
            cmb_seviye.Items.Add("Orta");
            cmb_seviye.Items.Add("Zor");
            cmb_seviye.Items.Add("A");
            cmb_seviye.Items.Add("B");
            cmb_seviye.Items.Add("C");
            cmb_seviye.Items.Add("D");

            
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into CoktanSecmeli (DERSADI,CSORU,SECENEKA,SECENEKB,SECENEKC,SECENEKD,CDOGRUYANIT,SEVIYE,PUAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_dersadi.Text);
            komut.Parameters.AddWithValue("@p2", txt_soru.Text);
            komut.Parameters.AddWithValue("@p3", txt_a.Text);
            komut.Parameters.AddWithValue("@p4", txt_b.Text);
            komut.Parameters.AddWithValue("@p5", txt_c.Text);
            komut.Parameters.AddWithValue("@p6", txt_d.Text);
            komut.Parameters.AddWithValue("@p7", cmb_dyanıt.Text);
            komut.Parameters.AddWithValue("@p8", cmb_seviye.Text);
            komut.Parameters.AddWithValue("@p9", txt_puan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Soru Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From CoktanSecmeli where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txt_id.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sorunuz Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txt_id.Text = dr["ID"].ToString();
            txt_dersadi.Text = dr["DERSADI"].ToString();
            txt_soru.Text = dr["CSORU"].ToString();
            txt_a.Text = dr["SECENEKA"].ToString();
            txt_b.Text = dr["SECENEKB"].ToString();
            txt_c.Text = dr["SECENEKC"].ToString();
            txt_d.Text = dr["SECENEKD"].ToString();
            cmb_dyanıt.Text = dr["CDOGRUYANIT"].ToString();
            cmb_seviye.Text = dr["SEVIYE"].ToString();
            txt_puan.Text = dr["PUAN"].ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update CoktanSecmeli set DERSADI=@p1,CSORU=@p2,SECENEKA=@p3,SECENEKB=@p4," +
                "SECENEKC=@p5,SECENEKD=@p6,CDOGRUYANIT=@p7,SEVIYE=@p8,PUAN=@p9 where ID=@p10",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_dersadi.Text);
            komut.Parameters.AddWithValue("@p2", txt_soru.Text);
            komut.Parameters.AddWithValue("@p3", txt_a.Text);
            komut.Parameters.AddWithValue("@p4", txt_b.Text);
            komut.Parameters.AddWithValue("@p5", txt_c.Text);
            komut.Parameters.AddWithValue("@p6", txt_d.Text);
            komut.Parameters.AddWithValue("@p7", cmb_dyanıt.Text);
            komut.Parameters.AddWithValue("@p8", cmb_seviye.Text);
            komut.Parameters.AddWithValue("@p9", txt_puan.Text);
            komut.Parameters.AddWithValue("@p10", txt_id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
