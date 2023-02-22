using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RestaurantNLayerProject.Business.Workers;
using RestaurantNLayerProject.UI.BackOffice.Fotograf;
using RestaurantNLayerProject.Core.Extensions;

namespace RestaurantNLayerProject.UI.BackOffice.Urun
{
    public partial class FrmUrun : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmUrun()
        {
            InitializeComponent();
            Listele();
        }

        void Listele()
        {
            worker.UrunService.Load(null, c => c.UrunGrup);
            gridControlUrunler.DataSource = worker.UrunService.BindingList();
        }

        private void controlMenu_ButtonEkle(object sender, EventArgs e)
        {
            FrmUrunIslem form = new FrmUrunIslem(new Entities.Tables.Urun());
            form.ShowDialog();

            if (form.Eklendi)
            {                
                gridUrunler.RefreshData();
                Listele();
            }
        }

        private void controlMenu_ButtonDuzenle(object sender, EventArgs e)
        {
            if (gridUrunler.GetFocusedRow() == null)
            {
                return;
            }

            FrmUrunIslem form = new FrmUrunIslem((Entities.Tables.Urun)gridUrunler.GetFocusedRow());
            form.ShowDialog();

            if (form.Eklendi)
            {
                Listele();
                gridUrunler.RefreshData();
            }
        }

        private void controlMenu_ButtonSil(object sender, EventArgs e)
        {
            if (gridUrunler.GetFocusedRow() == null)
            {
                return;
            }

            if (MessageBox.Show("Seçili olan veriyi silmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridUrunler.DeleteSelectedRows();
                worker.Commit();
                gridUrunler.RefreshData();
            }
        }

        private void controlMenu_ButtonGuncelle(object sender, EventArgs e)
        {
            Listele();
        }

        private void controlMenu_ButtonKapat(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFotografEkle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Entities.Tables.Urun entity = (Entities.Tables.Urun)gridUrunler.GetFocusedRow();
            FrmImageEditor form = new FrmImageEditor();
            form.ShowDialog();
            if (form.ReturnedImage != null)
            {
                entity.Fotograf =form.ReturnedImage.ImageToByteArray();
                worker.Commit();
                gridUrunler.RefreshData();
            }
        }
    }
}