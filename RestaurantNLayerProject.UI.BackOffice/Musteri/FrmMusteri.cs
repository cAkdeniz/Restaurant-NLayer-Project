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

namespace RestaurantNLayerProject.UI.BackOffice.Musteri
{
    public partial class FrmMusteri : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();

        public FrmMusteri()
        {
            InitializeComponent();
            Listele();
        }

        void Listele()
        {
            worker.MusteriService.Load(null);
            gridControlMusteri.DataSource = worker.MusteriService.BindingList();
        }

        private void controlMenu_ButtonEkle(object sender, EventArgs e)
        {
            FrmMusteriIslem form = new FrmMusteriIslem(new Entities.Tables.Musteri());
            form.ShowDialog();

            if (form.Kaydedildi)
            {
                gridMusteri.RefreshData();
            }
        }

        private void controlMenu_ButtonDuzenle(object sender, EventArgs e)
        {
            if (gridMusteri.GetFocusedRow() == null)
            {
                return;
            }

            FrmMusteriIslem form = new FrmMusteriIslem((Entities.Tables.Musteri)gridMusteri.GetFocusedRow());
            form.ShowDialog();

            if (form.Kaydedildi)
            {
                gridMusteri.RefreshData(); 
            }
        }

        private void controlMenu_ButtonSil(object sender, EventArgs e)
        {
            if (gridMusteri.GetFocusedRow() == null)
            {
                return;
            }

            if (MessageBox.Show("Seçili olan veriyi silmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridMusteri.DeleteSelectedRows();
                gridMusteri.RefreshData();
            }
        }

        private void controlMenu_ButtonGuncelle(object sender, EventArgs e)
        {
            gridMusteri.RefreshData();
        }

        private void controlMenu_ButtonKapat(object sender, EventArgs e)
        {
            Close();
        }
    }
}