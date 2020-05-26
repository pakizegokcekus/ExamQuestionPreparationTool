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
    public partial class frm_klasik : Form
    {
        public frm_klasik()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT*FROM Klasik", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }

        private void frm_klasik_Load(object sender, EventArgs e)
        {
            listele();
            cmb_seviye.Items.Add("Kolay");
            cmb_seviye.Items.Add("Orta");
            cmb_seviye.Items.Add("Zor");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Klasik(DERSADI,SORU,YANIT,SEVIYE,PUAN)values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_dersadi.Text);
            komut.Parameters.AddWithValue("@p2", txt_soru.Text);
            komut.Parameters.AddWithValue("@p3", txt_dogruyanıt.Text);
            komut.Parameters.AddWithValue("@p4", cmb_seviye.Text);
            komut.Parameters.AddWithValue("@p5", txt_puan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Soru Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Klasik where ID=@p1", bgl.baglanti());
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
            txt_soru.Text = dr["SORU"].ToString();
            txt_dogruyanıt.Text = dr["YANIT"].ToString();
            cmb_seviye.Text = dr["SEVIYE"].ToString();
            txt_puan.Text = dr["PUAN"].ToString();
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Klasik set DERSADI=@p1,SORU=@p2,YANIT=@p3,SEVIYE=@p4,PUAN=@p5 where ID=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_dersadi.Text);
            komut.Parameters.AddWithValue("@p2", txt_soru.Text);
            komut.Parameters.AddWithValue("@p3", txt_dogruyanıt.Text);
            komut.Parameters.AddWithValue("@p4", cmb_seviye.Text);
            komut.Parameters.AddWithValue("@p5", txt_puan.Text);
            komut.Parameters.AddWithValue("@p6", txt_id.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }

        
    }
}
