namespace RestaurantNLayerProject.UI.BackOffice.Tanim
{
    partial class FrmTanim
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupTanimBilgi = new DevExpress.XtraEditors.GroupControl();
            this.txtTanim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.controlMenu = new RestaurantNLayerProject.UserControls.ControlMenuKayit();
            this.gridControlTanim = new DevExpress.XtraGrid.GridControl();
            this.gridTanim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupTanimBilgi)).BeginInit();
            this.groupTanimBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(621, 49);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürünler";
            // 
            // groupTanimBilgi
            // 
            this.groupTanimBilgi.Controls.Add(this.txtAciklama);
            this.groupTanimBilgi.Controls.Add(this.txtTanim);
            this.groupTanimBilgi.Controls.Add(this.labelControl2);
            this.groupTanimBilgi.Controls.Add(this.labelControl6);
            this.groupTanimBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTanimBilgi.Location = new System.Drawing.Point(0, 49);
            this.groupTanimBilgi.Name = "groupTanimBilgi";
            this.groupTanimBilgi.Size = new System.Drawing.Size(621, 131);
            this.groupTanimBilgi.TabIndex = 2;
            this.groupTanimBilgi.Text = "Tanım İşlemleri";
            this.groupTanimBilgi.Visible = false;
            // 
            // txtTanim
            // 
            this.txtTanim.Location = new System.Drawing.Point(117, 23);
            this.txtTanim.Name = "txtTanim";
            this.txtTanim.Size = new System.Drawing.Size(491, 20);
            this.txtTanim.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(29, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 20);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Tanım:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.controlMenu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 180);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(621, 70);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Menü";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(29, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 20);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(117, 49);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(491, 76);
            this.txtAciklama.TabIndex = 6;
            // 
            // controlMenu
            // 
            this.controlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMenu.KapatVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            this.controlMenu.KayitAc = false;
            this.controlMenu.Location = new System.Drawing.Point(2, 20);
            this.controlMenu.Name = "controlMenu";
            this.controlMenu.SecVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            this.controlMenu.Size = new System.Drawing.Size(617, 48);
            this.controlMenu.TabIndex = 0;
            this.controlMenu.SecClick += new System.EventHandler(this.controlMenu_SecClick);
            this.controlMenu.EkleClick += new System.EventHandler(this.controlMenu_EkleClick);
            this.controlMenu.DuzenleClick += new System.EventHandler(this.controlMenu_DuzenleClick);
            this.controlMenu.SilClick += new System.EventHandler(this.controlMenu_SilClick);
            this.controlMenu.KaydetClick += new System.EventHandler(this.controlMenu_KaydetClick);
            this.controlMenu.VazgecClick += new System.EventHandler(this.controlMenu_VazgecClick);
            this.controlMenu.KapatClick += new System.EventHandler(this.controlMenu_KapatClick);
            // 
            // gridControlTanim
            // 
            this.gridControlTanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTanim.Location = new System.Drawing.Point(0, 250);
            this.gridControlTanim.MainView = this.gridTanim;
            this.gridControlTanim.Name = "gridControlTanim";
            this.gridControlTanim.Size = new System.Drawing.Size(621, 327);
            this.gridControlTanim.TabIndex = 4;
            this.gridControlTanim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTanim});
            // 
            // gridTanim
            // 
            this.gridTanim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTanim,
            this.colAciklama});
            this.gridTanim.GridControl = this.gridControlTanim;
            this.gridTanim.Name = "gridTanim";
            this.gridTanim.OptionsView.ShowAutoFilterRow = true;
            this.gridTanim.OptionsView.ShowGroupPanel = false;
            // 
            // colTanim
            // 
            this.colTanim.Caption = "Tanım";
            this.colTanim.FieldName = "Adi";
            this.colTanim.Name = "colTanim";
            this.colTanim.OptionsColumn.AllowEdit = false;
            this.colTanim.Visible = true;
            this.colTanim.VisibleIndex = 0;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            // 
            // FrmTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 577);
            this.Controls.Add(this.gridControlTanim);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupTanimBilgi);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTanim";
            ((System.ComponentModel.ISupportInitialize)(this.groupTanimBilgi)).EndInit();
            this.groupTanimBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTanim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupTanimBilgi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtTanim;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private UserControls.ControlMenuKayit controlMenu;
        private DevExpress.XtraGrid.GridControl gridControlTanim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}