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
using System.Drawing.Imaging;

namespace RestaurantNLayerProject.UI.BackOffice.Fotograf
{
    public partial class FrmImageEditor : DevExpress.XtraEditors.XtraForm
    {
        public Image ReturnedImage;

        public FrmImageEditor()
        {
            InitializeComponent();

            lblCervece.Draggable(true);
            lblCervece.Parent = picFoto;
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "JPG Dosyası (*.jpg)|*.jpg|BMP Dosyası (*.bmp)|*.bmp|PNG Dosyası (*.png)|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(dialog.FileName);
                lblCervece.Visible = true;
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            if (picFoto.Image == null)
            {
                MessageBox.Show("Bir fotoğraf seçilmedi.");
                return;
            }
            ReturnedImage = CroppedImage();
            Close();
        }

        private Image CroppedImage()
        {
            Image croppedImage = new Bitmap(GetZoomedImage(picFoto), picFoto.ClientSize);

            Rectangle rect = new Rectangle(lblCervece.Location.X,lblCervece.Location.Y,lblCervece.Width,lblCervece.Height);
            Bitmap bmp = new Bitmap(rect.Width,rect.Height,PixelFormat.Format32bppPArgb);

            Graphics graphic = Graphics.FromImage(bmp);

            graphic.DrawImage(croppedImage, new Rectangle(0, 0, lblCervece.Width, lblCervece.Height),lblCervece.Left,lblCervece.Top,lblCervece.Width,lblCervece.Height,GraphicsUnit.Pixel);
            return bmp;
        }

        private Image GetZoomedImage(PictureEdit sourcePicture)
        {
            lblCervece.Visible = false;
            Bitmap bmp = new Bitmap(sourcePicture.Width, sourcePicture.Height);
            sourcePicture.DrawToBitmap(bmp, sourcePicture.Bounds);
            return bmp;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zoomTrackBarControl1_ValueChanged(object sender, EventArgs e)
        {
            picFoto.Properties.ZoomPercent = zoomTrackBarControl1.Value;
            txtZoom.Value = zoomTrackBarControl1.Value;
        }

        private void txtZoom_EditValueChanged(object sender, EventArgs e)
        {
            zoomTrackBarControl1.Value = Convert.ToInt32(txtZoom.Value);
        }

        private void picFoto_ZoomPercentChanged(object sender, EventArgs e)
        {
            zoomTrackBarControl1.Value = Convert.ToInt32(picFoto.Properties.ZoomPercent);
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            picFoto.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        private void btnKamera_Click(object sender, EventArgs e)
        {
            FrmKamera form = new FrmKamera();
            form.ShowDialog();
            if (form.ReturnedImage != null)
            {
                picFoto.Image = form.ReturnedImage;
                picFoto.Properties.ZoomPercent = 100;
                txtZoom.Value = 100;
                zoomTrackBarControl1.Value = 100;
                lblCervece.Visible = true;
            }
        }
    }
}