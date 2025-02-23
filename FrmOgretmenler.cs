﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraLayout.Resizing;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace OkulOtomasyon
{
    public partial class FrmOgretmenler : Form
    {
        public FrmOgretmenler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_OGRETMENLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void ilekle()
        {
            SqlCommand komut = new SqlCommand("select * from TBL_iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        void bransgetir()
        {
            SqlCommand komut = new SqlCommand("select * from TBL_BRANSLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            msktc.Text = "";
            msktelefon.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            cmbbrans.Text = "";
            txtmail.Text = "";
            rchadres.Text = "";
            pcrresim.ImageLocation = "";
        }

        private void FrmOgretmenler_Load(object sender, EventArgs e)
        {
            listele();
            ilekle();
            bransgetir();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            cmbilce.Text = " ";
            SqlCommand komut = new SqlCommand("select * from TBL_ilceler where ilid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnkayitet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_OGRETMENLER (OGRTAD, OGRTSOYAD, OGRTTC, OGRTTEL, OGRTMAIL, OGRTIL, OGRTILCE, OGRTADRES, OGRTBRANS, OGRTFOTO) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtmail.Text);
            komut.Parameters.AddWithValue("@p6", cmbil.Text);
            komut.Parameters.AddWithValue("@p7", cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", rchadres.Text);
            komut.Parameters.AddWithValue("@p9", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["OGRTID"].ToString();
                txtad.Text = dr["OGRTAD"].ToString();
                txtsoyad.Text = dr["OGRTSOYAD"].ToString();
                msktc.Text = dr["OGRTTC"].ToString();
                msktelefon.Text = dr["OGRTTEL"].ToString();
                cmbil.Text = dr["OGRTIL"].ToString();
                cmbilce.Text = dr["OGRTILCE"].ToString();
                cmbbrans.Text = dr["OGRTBRANS"].ToString();
                txtmail.Text = dr["OGRTMAIL"].ToString();
                rchadres.Text = dr["OGRTADRES"].ToString();
                yeniyol = "C:\\users\\bahar\\Desktop\\projeler\\proje1\\OkulOtomasyon" + "\\resimler\\" + dr["OGRTFOTO"].ToString();
                pcrresim.ImageLocation = yeniyol;
            }
        }

        public string yeniyol;

        private void btnresimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*png;*nef| Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\users\\bahar\\Desktop\\projeler\\proje1\\OkulOtomasyon" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);
            pcrresim.ImageLocation = yeniyol;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_OGRETMENLER set OGRTAD = @p1, OGRTSOYAD = @p2, OGRTTC = @p3, OGRTTEL = @p4, OGRTMAIL = @p5, OGRTIL = @p6, OGRTILCE = @p7, OGRTADRES = @p8, OGRTBRANS = @p9, OGRTFOTO = @p10 where OGRTID = @p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtmail.Text);
            komut.Parameters.AddWithValue("@p6", cmbil.Text);
            komut.Parameters.AddWithValue("@p7", cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", rchadres.Text);
            komut.Parameters.AddWithValue("@p9", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            komut.Parameters.AddWithValue("@p11", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_OGRETMENLER where OGRTID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
