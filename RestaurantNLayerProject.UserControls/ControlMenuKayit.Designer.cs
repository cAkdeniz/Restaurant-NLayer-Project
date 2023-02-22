namespace RestaurantNLayerProject.UserControls
{
    partial class ControlMenuKayit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlMenuKayit));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutItemKapat = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemVazgec = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemKaydet = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemSil = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemDuzenle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemEkle = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemSec = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemVazgec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSec)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSec);
            this.layoutControl1.Controls.Add(this.btnEkle);
            this.layoutControl1.Controls.Add(this.btnDuzenle);
            this.layoutControl1.Controls.Add(this.btnSil);
            this.layoutControl1.Controls.Add(this.btnKaydet);
            this.layoutControl1.Controls.Add(this.btnVazgec);
            this.layoutControl1.Controls.Add(this.btnKapat);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(655, 100);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSec
            // 
            this.btnSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSec.ImageOptions.Image")));
            this.btnSec.Location = new System.Drawing.Point(2, 2);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(90, 96);
            this.btnSec.StyleController = this.layoutControl1;
            this.btnSec.TabIndex = 11;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(96, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 96);
            this.btnEkle.StyleController = this.layoutControl1;
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(190, 2);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(90, 96);
            this.btnDuzenle.StyleController = this.layoutControl1;
            this.btnDuzenle.TabIndex = 9;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(284, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 96);
            this.btnSil.StyleController = this.layoutControl1;
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(378, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(89, 96);
            this.btnKaydet.StyleController = this.layoutControl1;
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.ImageOptions.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(471, 2);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(90, 96);
            this.btnVazgec.StyleController = this.layoutControl1;
            this.btnVazgec.TabIndex = 6;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(565, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(88, 96);
            this.btnKapat.StyleController = this.layoutControl1;
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutItemKapat,
            this.layoutItemVazgec,
            this.layoutItemKaydet,
            this.layoutItemSil,
            this.layoutItemDuzenle,
            this.layoutItemEkle,
            this.layoutItemSec});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(655, 100);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutItemKapat
            // 
            this.layoutItemKapat.Control = this.btnKapat;
            this.layoutItemKapat.Location = new System.Drawing.Point(563, 0);
            this.layoutItemKapat.MinSize = new System.Drawing.Size(41, 26);
            this.layoutItemKapat.Name = "layoutItemKapat";
            this.layoutItemKapat.Size = new System.Drawing.Size(92, 100);
            this.layoutItemKapat.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemKapat.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemKapat.TextVisible = false;
            // 
            // layoutItemVazgec
            // 
            this.layoutItemVazgec.Control = this.btnVazgec;
            this.layoutItemVazgec.Location = new System.Drawing.Point(469, 0);
            this.layoutItemVazgec.MinSize = new System.Drawing.Size(47, 26);
            this.layoutItemVazgec.Name = "layoutItemVazgec";
            this.layoutItemVazgec.Size = new System.Drawing.Size(94, 100);
            this.layoutItemVazgec.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemVazgec.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemVazgec.TextVisible = false;
            // 
            // layoutItemKaydet
            // 
            this.layoutItemKaydet.Control = this.btnKaydet;
            this.layoutItemKaydet.Location = new System.Drawing.Point(376, 0);
            this.layoutItemKaydet.MinSize = new System.Drawing.Size(47, 26);
            this.layoutItemKaydet.Name = "layoutItemKaydet";
            this.layoutItemKaydet.Size = new System.Drawing.Size(93, 100);
            this.layoutItemKaydet.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemKaydet.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemKaydet.TextVisible = false;
            // 
            // layoutItemSil
            // 
            this.layoutItemSil.Control = this.btnSil;
            this.layoutItemSil.Location = new System.Drawing.Point(282, 0);
            this.layoutItemSil.MinSize = new System.Drawing.Size(24, 26);
            this.layoutItemSil.Name = "layoutItemSil";
            this.layoutItemSil.Size = new System.Drawing.Size(94, 100);
            this.layoutItemSil.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemSil.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemSil.TextVisible = false;
            // 
            // layoutItemDuzenle
            // 
            this.layoutItemDuzenle.Control = this.btnDuzenle;
            this.layoutItemDuzenle.Location = new System.Drawing.Point(188, 0);
            this.layoutItemDuzenle.MinSize = new System.Drawing.Size(51, 26);
            this.layoutItemDuzenle.Name = "layoutItemDuzenle";
            this.layoutItemDuzenle.Size = new System.Drawing.Size(94, 100);
            this.layoutItemDuzenle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemDuzenle.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemDuzenle.TextVisible = false;
            // 
            // layoutItemEkle
            // 
            this.layoutItemEkle.Control = this.btnEkle;
            this.layoutItemEkle.Location = new System.Drawing.Point(94, 0);
            this.layoutItemEkle.MinSize = new System.Drawing.Size(32, 26);
            this.layoutItemEkle.Name = "layoutItemEkle";
            this.layoutItemEkle.Size = new System.Drawing.Size(94, 100);
            this.layoutItemEkle.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemEkle.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemEkle.TextVisible = false;
            // 
            // layoutItemSec
            // 
            this.layoutItemSec.Control = this.btnSec;
            this.layoutItemSec.Location = new System.Drawing.Point(0, 0);
            this.layoutItemSec.MinSize = new System.Drawing.Size(30, 26);
            this.layoutItemSec.Name = "layoutItemSec";
            this.layoutItemSec.Size = new System.Drawing.Size(94, 100);
            this.layoutItemSec.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemSec.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemSec.TextVisible = false;
            // 
            // ControlMenuKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ControlMenuKayit";
            this.Size = new System.Drawing.Size(655, 100);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemVazgec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemKapat;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemVazgec;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemKaydet;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemSil;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemDuzenle;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemEkle;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemSec;
    }
}
