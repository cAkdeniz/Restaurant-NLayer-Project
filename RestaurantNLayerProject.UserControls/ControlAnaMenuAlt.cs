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

namespace RestaurantNLayerProject.UserControls
{
    public partial class ControlAnaMenuAlt : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler ButtonEkle;
        public event EventHandler ButtonDuzenle;
        public event EventHandler ButtonSil;
        public event EventHandler ButtonGuncelle;
        public event EventHandler ButtonKapat;
        private Font _buttonFont = new Font("Tahoma",8,FontStyle.Bold);

        public Font ButtonFont
        {
            get
            {
                return _buttonFont;
            }
            set
            {
                btnEkle.Font = value;
                btnDuzenle.Font = value;
                btnSil.Font = value;
                btnGuncelle.Font = value;
                btnKapat.Font = value;
                _buttonFont = value;
            }
        }

        public ControlAnaMenuAlt()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ButtonEkle?.Invoke(this, e);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            ButtonDuzenle?.Invoke(this, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ButtonSil?.Invoke(this, e);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ButtonGuncelle?.Invoke(this, e);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            ButtonKapat?.Invoke(this, e);
        }
    }
}
