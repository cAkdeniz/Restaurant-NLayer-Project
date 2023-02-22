namespace RestaurantNLayerProject.UI.BackOffice.Fotograf
{
    partial class FrmImageEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImageEditor));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtZoom = new DevExpress.XtraEditors.SpinEdit();
            this.zoomTrackBarControl1 = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.btnAktar = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnCevir = new DevExpress.XtraEditors.SimpleButton();
            this.btnKamera = new DevExpress.XtraEditors.SimpleButton();
            this.btnAc = new DevExpress.XtraEditors.SimpleButton();
            this.picFoto = new DevExpress.XtraEditors.PictureEdit();
            this.lblCervece = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtZoom);
            this.panelControl1.Controls.Add(this.zoomTrackBarControl1);
            this.panelControl1.Controls.Add(this.btnAktar);
            this.panelControl1.Controls.Add(this.btnKapat);
            this.panelControl1.Controls.Add(this.btnCevir);
            this.panelControl1.Controls.Add(this.btnKamera);
            this.panelControl1.Controls.Add(this.btnAc);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(858, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // txtZoom
            // 
            this.txtZoom.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtZoom.Location = new System.Drawing.Point(580, 13);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtZoom.Properties.Appearance.Options.UseFont = true;
            this.txtZoom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtZoom.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtZoom.Size = new System.Drawing.Size(100, 22);
            this.txtZoom.TabIndex = 6;
            this.txtZoom.EditValueChanged += new System.EventHandler(this.txtZoom_EditValueChanged);
            // 
            // zoomTrackBarControl1
            // 
            this.zoomTrackBarControl1.EditValue = 100;
            this.zoomTrackBarControl1.Location = new System.Drawing.Point(260, 13);
            this.zoomTrackBarControl1.Name = "zoomTrackBarControl1";
            this.zoomTrackBarControl1.Properties.Maximum = 500;
            this.zoomTrackBarControl1.Properties.Middle = 250;
            this.zoomTrackBarControl1.Properties.SmallChangeUseMode = DevExpress.XtraEditors.Repository.SmallChangeUseMode.ArrowKeysAndMouse;
            this.zoomTrackBarControl1.Size = new System.Drawing.Size(314, 23);
            this.zoomTrackBarControl1.TabIndex = 5;
            this.zoomTrackBarControl1.Value = 100;
            this.zoomTrackBarControl1.ValueChanged += new System.EventHandler(this.zoomTrackBarControl1_ValueChanged);
            // 
            // btnAktar
            // 
            this.btnAktar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAktar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAktar.ImageOptions.Image")));
            this.btnAktar.Location = new System.Drawing.Point(690, 2);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(84, 42);
            this.btnAktar.TabIndex = 4;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(774, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(82, 42);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnCevir
            // 
            this.btnCevir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnCevir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCevir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCevir.ImageOptions.Image")));
            this.btnCevir.Location = new System.Drawing.Point(169, 2);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(85, 42);
            this.btnCevir.TabIndex = 2;
            this.btnCevir.Text = "Çevir";
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // btnKamera
            // 
            this.btnKamera.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnKamera.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKamera.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKamera.ImageOptions.Image")));
            this.btnKamera.Location = new System.Drawing.Point(84, 2);
            this.btnKamera.Name = "btnKamera";
            this.btnKamera.Size = new System.Drawing.Size(85, 42);
            this.btnKamera.TabIndex = 1;
            this.btnKamera.Text = "Kamera";
            this.btnKamera.Click += new System.EventHandler(this.btnKamera_Click);
            // 
            // btnAc
            // 
            this.btnAc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAc.ImageOptions.Image")));
            this.btnAc.Location = new System.Drawing.Point(2, 2);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(82, 42);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Aç";
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // picFoto
            // 
            this.picFoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFoto.Location = new System.Drawing.Point(2, 2);
            this.picFoto.Name = "picFoto";
            this.picFoto.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.picFoto.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.picFoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picFoto.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.picFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picFoto.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel;
            this.picFoto.Size = new System.Drawing.Size(854, 506);
            this.picFoto.TabIndex = 1;
            this.picFoto.ZoomPercentChanged += new System.EventHandler(this.picFoto_ZoomPercentChanged);
            // 
            // lblCervece
            // 
            this.lblCervece.Appearance.Options.UseTextOptions = true;
            this.lblCervece.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCervece.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCervece.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblCervece.Location = new System.Drawing.Point(0, 0);
            this.lblCervece.Name = "lblCervece";
            this.lblCervece.Size = new System.Drawing.Size(300, 200);
            this.lblCervece.TabIndex = 2;
            this.lblCervece.Text = "300x200\r\nLütfen kesmek istediğiniz bölümü çerçeve içine yerleştirin.\r\n\r\n";
            this.lblCervece.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lblCervece);
            this.panelControl2.Controls.Add(this.picFoto);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 46);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(858, 510);
            this.panelControl2.TabIndex = 3;
            // 
            // FrmImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 556);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImageEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImageEditor";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtZoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ZoomTrackBarControl zoomTrackBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnAktar;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnCevir;
        private DevExpress.XtraEditors.SimpleButton btnKamera;
        private DevExpress.XtraEditors.SimpleButton btnAc;
        private DevExpress.XtraEditors.SpinEdit txtZoom;
        private DevExpress.XtraEditors.PictureEdit picFoto;
        private DevExpress.XtraEditors.LabelControl lblCervece;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}