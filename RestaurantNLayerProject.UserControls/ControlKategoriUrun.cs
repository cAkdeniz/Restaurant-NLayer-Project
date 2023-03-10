using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RestaurantNLayerProject.Entities.Tables;

namespace RestaurantNLayerProject.UserControls
{
    public partial class ControlKategoriUrun : DevExpress.XtraEditors.XtraUserControl
    {
        public EventHandler ButtonClick;

        public ControlKategoriUrun()
        {
            InitializeComponent();
        }

        public Guid Id { get; set; }

        public Image UrunImage
        {
            get
            {
                return picFoto.Image;
            }
            set
            {
                picFoto.Image = value;
            }
        }

        public string UrunAdi
        {
            get
            {
                return groupBase.Text;
            }
            set
            {
                groupBase.Text = value;
            }
        }

        public string Aciklama
        {
            get
            {
                return lblAciklama.Text;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    lblAciklama.Visible = false;
                }
                lblAciklama.Text = value;
            }
        }

        public IEnumerable<Porsiyon> Porsiyonlar { get; set; }

        public IEnumerable<EkMalzeme> EkMalzemeler { get; set; }

        private void groupBase_Click(object sender, EventArgs e)
        {
            ButtonClick(this, e);
        }

        private void lblAciklama_Click(object sender, EventArgs e)
        {
            ButtonClick(this, e);
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ButtonClick(this, e);
        }
    }
}
