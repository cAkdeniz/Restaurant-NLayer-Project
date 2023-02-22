using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using RestaurantNLayerProject.UI.BackOffice.Urun;
using RestaurantNLayerProject.Core.Functions;
using RestaurantNLayerProject.UI.BackOffice.Musteri;
using RestaurantNLayerProject.UI.BackOffice.Masa;

namespace RestaurantNLayerProject.UI.BackOffice.AnaMenu
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
            if (!ConnectionStringInfo.Check())
            {
                FrmSetupConnection form = new FrmSetupConnection();
                form.ShowDialog();
            }
        }

        private void btnUrun_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUrun frmUrun = new FrmUrun();
            frmUrun.MdiParent = this;
            frmUrun.Show();
        }

        private void btnMusteri_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri();
            frmMusteri.MdiParent = this;
            frmMusteri.Show();
        }

        private void btnMasa_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMasa frmMasa = new FrmMasa();
            frmMasa.MdiParent = this;
            frmMasa.Show();
        }
    }
}