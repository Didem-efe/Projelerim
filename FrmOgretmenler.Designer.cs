﻿namespace OkulOtomasyon
{
    partial class FrmOgretmenler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbbrans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtad = new DevExpress.XtraEditors.TextEdit();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pcrresim = new System.Windows.Forms.PictureBox();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkayitet = new DevExpress.XtraEditors.SimpleButton();
            this.btnresimsec = new DevExpress.XtraEditors.SimpleButton();
            this.rchadres = new System.Windows.Forms.RichTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(810, 619);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(829, 13);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(338, 618);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(336, 574);
            this.xtraTabPage1.Text = "Öğretmen Bilgi -1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbbrans);
            this.groupControl1.Controls.Add(this.cmbilce);
            this.groupControl1.Controls.Add(this.cmbil);
            this.groupControl1.Controls.Add(this.msktelefon);
            this.groupControl1.Controls.Add(this.msktc);
            this.groupControl1.Controls.Add(this.txtsoyad);
            this.groupControl1.Controls.Add(this.txtad);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(329, 567);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // cmbbrans
            // 
            this.cmbbrans.Location = new System.Drawing.Point(85, 193);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbbrans.Size = new System.Drawing.Size(227, 20);
            this.cmbbrans.TabIndex = 15;
            // 
            // cmbilce
            // 
            this.cmbilce.Location = new System.Drawing.Point(85, 169);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbilce.Size = new System.Drawing.Size(227, 20);
            this.cmbilce.TabIndex = 14;
            // 
            // cmbil
            // 
            this.cmbil.Location = new System.Drawing.Point(85, 145);
            this.cmbil.Name = "cmbil";
            this.cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbil.Size = new System.Drawing.Size(227, 20);
            this.cmbil.TabIndex = 13;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(85, 116);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(227, 21);
            this.msktelefon.TabIndex = 12;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(85, 92);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(227, 21);
            this.msktc.TabIndex = 11;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(85, 65);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(227, 20);
            this.txtsoyad.TabIndex = 10;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(85, 41);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(227, 20);
            this.txtad.TabIndex = 9;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(85, 17);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(227, 20);
            this.txtid.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(24, 192);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 18);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "BRANŞ :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(39, 168);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 18);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "İLÇE :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(56, 144);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 18);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "İL :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(7, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 18);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "TELEFON :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(40, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "T.C. :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "SOYAD :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(50, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "AD :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(336, 574);
            this.xtraTabPage2.Text = "Öğretmen Bilgi -2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pcrresim);
            this.groupControl2.Controls.Add(this.btntemizle);
            this.groupControl2.Controls.Add(this.btnguncelle);
            this.groupControl2.Controls.Add(this.btnsil);
            this.groupControl2.Controls.Add(this.btnkayitet);
            this.groupControl2.Controls.Add(this.btnresimsec);
            this.groupControl2.Controls.Add(this.rchadres);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.txtmail);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Location = new System.Drawing.Point(4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(329, 567);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // pcrresim
            // 
            this.pcrresim.Location = new System.Drawing.Point(200, 5);
            this.pcrresim.Name = "pcrresim";
            this.pcrresim.Size = new System.Drawing.Size(100, 90);
            this.pcrresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrresim.TabIndex = 18;
            this.pcrresim.TabStop = false;
            // 
            // btntemizle
            // 
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(87, 440);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(189, 26);
            this.btntemizle.TabIndex = 17;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(87, 408);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(189, 26);
            this.btnguncelle.TabIndex = 16;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(87, 376);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(189, 26);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkayitet
            // 
            this.btnkayitet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkayitet.ImageOptions.Image")));
            this.btnkayitet.Location = new System.Drawing.Point(87, 344);
            this.btnkayitet.Name = "btnkayitet";
            this.btnkayitet.Size = new System.Drawing.Size(189, 26);
            this.btnkayitet.TabIndex = 14;
            this.btnkayitet.Text = "Kaydet";
            this.btnkayitet.Click += new System.EventHandler(this.btnkayitet_Click);
            // 
            // btnresimsec
            // 
            this.btnresimsec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnresimsec.ImageOptions.Image")));
            this.btnresimsec.Location = new System.Drawing.Point(87, 312);
            this.btnresimsec.Name = "btnresimsec";
            this.btnresimsec.Size = new System.Drawing.Size(189, 26);
            this.btnresimsec.TabIndex = 13;
            this.btnresimsec.Text = "Resim Seç";
            this.btnresimsec.Click += new System.EventHandler(this.btnresimsec_Click);
            // 
            // rchadres
            // 
            this.rchadres.Location = new System.Drawing.Point(73, 144);
            this.rchadres.Name = "rchadres";
            this.rchadres.Size = new System.Drawing.Size(227, 162);
            this.rchadres.TabIndex = 12;
            this.rchadres.Text = "";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(13, 144);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(54, 18);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "ADRES :";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(73, 101);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(227, 20);
            this.txtmail.TabIndex = 10;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(23, 100);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 18);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "MAİL :";
            // 
            // FrmOgretmenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 641);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmOgretmenler";
            this.Text = "FrmOgretmenler";
            this.Load += new System.EventHandler(this.FrmOgretmenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbbrans;
        private DevExpress.XtraEditors.ComboBoxEdit cmbilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbil;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.MaskedTextBox msktc;
        private DevExpress.XtraEditors.TextEdit txtsoyad;
        private DevExpress.XtraEditors.TextEdit txtad;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkayitet;
        private DevExpress.XtraEditors.SimpleButton btnresimsec;
        private System.Windows.Forms.RichTextBox rchadres;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtmail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.PictureBox pcrresim;
    }
}