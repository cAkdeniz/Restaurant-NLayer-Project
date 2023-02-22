using RestaurantNLayerProject.Business.Workers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestaurantNLayerProject.Entities.Tables;
using RestaurantNLayerProject.Entities.Dtos;
using RestaurantNLayerProject.UserControls;
using RestaurantNLayerProject.Entities.Enums;
using DevExpress.XtraEditors;
using RestaurantNLayerProject.Core.Extensions;
using DevExpress.XtraGrid.Views.Layout;

namespace RestaurantNLayerProject.UI.FrontOffice
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        enum KeyPadIslem
        {
            Yok,
            Iade,
            Ikram,
            Bolme
        }

        RestaurantWorker worker = new RestaurantWorker();
        private UrunHareket urunHareketEntity;
        private KeyPadIslem keyPadIslem = KeyPadIslem.Yok;

        public FrmMain()
        {
            InitializeComponent();
            KategoriButtonOlustur();
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            MasaButonOlustur();
        }

        void MasaButonOlustur()
        {
            foreach (var konum in worker.TanimService.GetList(c=>c.TanimTip==TanimTip.Konum))
            {
                ControlKonumButton button = new ControlKonumButton
                {
                    Name = konum.Id.ToString(),
                    Text = konum.Adi,
                    Height = 90,
                    Width = 150,
                    GroupIndex = 1,
                    Masalar = worker.MasaService.GetList(c=>c.KonumId==konum.Id)
                };
                button.CheckedChanged += KonumSecim;
                flowKonum.Controls.Add(button);
            }
        }

        private void KonumSecim(object sender, EventArgs e)
        {
            ControlKonumButton button = (ControlKonumButton)sender;
            flowMasalar.Controls.Clear();
            foreach (var masa in button.Masalar)
            {
                SimpleButton masaButton = new SimpleButton
                {
                    Name = masa.Id.ToString(),
                    Text = masa.Adi,
                    Height = 150,
                    Width = 150
                };
                flowMasalar.Controls.Add(masaButton);
            }
        }

        void MiktarArttir(int sayi)
        {
            UrunHareket row = (UrunHareket)layoutView1.GetFocusedRow();
            if (row == null)
            {
                return;
            }
            if(sayi<0 && row.Miktar < 2)
            {
                return;
            }
            row.Miktar += sayi;
            layoutView1.RefreshData();
        }

        private void KategoriButtonOlustur()
        {
            foreach (var Kategori in worker.TanimService.Select(c => c.TanimTip==TanimTip.UrunGrup,c=>new KategoriDto { Id = c.Id, Adi = c.Adi }).ToList())
            {
                ControlKategoriButton button = new ControlKategoriButton
                {
                    Name = Kategori.Id.ToString(),
                    Text = Kategori.Adi,
                    Id = Kategori.Id,
                    Urunler = worker.UrunService.GetList(c => c.UrunGrupId == Kategori.Id,c=>c.Porsiyonlar,calcEdit1=>calcEdit1.EkMalzemeler),
                    GroupIndex = 1,
                    Height = 80,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default,
                    Width = flowKategori.Width-6,
                };
                button.CheckedChanged += KategoriSecim;
                flowKategori.Controls.Add(button);
            }
        }

        private void KategoriSecim(object sender, EventArgs e)
        {
            flowKategoriUrunleri.Controls.Clear();
            ControlKategoriButton button = (ControlKategoriButton)sender;

            foreach (var item in button.Urunler)
            {
                ControlKategoriUrun urunButton = new ControlKategoriUrun
                {
                    Name = item.Id.ToString(),
                    UrunAdi = item.Adi,
                    Id = item.Id,
                    UrunImage = item.Fotograf.ByteArrayToImage(),
                    Height = 220,
                    Width = 300,
                    Aciklama = item.Aciklama,
                    Porsiyonlar = item.Porsiyonlar,
                    EkMalzemeler = item.EkMalzemeler
                };
                urunButton.ButtonClick += UrunClick;
                flowKategoriUrunleri.Controls.Add(urunButton);
            }
        }

        private void UrunClick(object sender, EventArgs e)
        {           
            ControlKategoriUrun button = (ControlKategoriUrun)sender;

            if (!button.Porsiyonlar.Any())
            {
                MessageBox.Show("Bu ürüne atanmış bir porsiyon bulunmamaktadır.");
                return;
            }

            btnUrunlereDon.Visible = true;
            flowPorsiyon.Controls.Clear();
            urunHareketEntity = new UrunHareket();
            //Silinecek
            Adisyon entity = new Adisyon();
            entity.Id = Guid.NewGuid();
            worker.AdisyonService.AddOrUpdate(entity);
            urunHareketEntity.AdisyonId = entity.Id;
            //Silinecek
            urunHareketEntity.Id = Guid.NewGuid();
            urunHareketEntity.UrunId = button.Id;
            urunHareketEntity.Miktar = txtMiktar.Value;
            urunHareketEntity.UrunHareketTip = UrunHareketTip.Satis;
            navigationKategori.SelectedPage = pageUrunPorsiyon;

            foreach (var porsiyon in button.Porsiyonlar)
            {
                ControlPorsiyonButton porsiyonButton = new ControlPorsiyonButton
                {
                    Name = porsiyon.Id.ToString(),
                    Text = porsiyon.Adi + "\n" + porsiyon.Fiyat.ToString("C2"),
                    Fiyat = porsiyon.Fiyat,
                    EkMalzemeCarpan = porsiyon.EkMalzemeCarpan,
                    Id = porsiyon.Id,
                    Height = 200,
                    Width = 200,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    EkMalzemeler = button.EkMalzemeler
                };
                porsiyonButton.Click += PorsiyonClick;
                flowPorsiyon.Controls.Add(porsiyonButton);
            }

            if (button.Porsiyonlar.Count() == 1)
            {
                ControlPorsiyonButton buttonPorsiyon = (ControlPorsiyonButton)flowPorsiyon.Controls[0];
                buttonPorsiyon.PerformClick();               
            }
        }

        private void PorsiyonClick(object sender, EventArgs e)
        {            
            ControlPorsiyonButton button = (ControlPorsiyonButton)sender;

            urunHareketEntity.PorsiyonId = button.Id;
            urunHareketEntity.BirimFiyat = button.Fiyat;         

            if (!button.EkMalzemeler.Any())
            {
                UrunHareketEkle();
                navigationKategori.SelectedPage = pageKategoriUrunler;
                return;
            }

            txtPorsiyonTutar.Value = button.Fiyat;
            EkMalzemeButonOlustur(button.EkMalzemeCarpan, button.EkMalzemeler);
        }

        void EkMalzemeButonOlustur(decimal EkMalzemeCarpan,IEnumerable<EkMalzeme> EkMalzemeList)
        {
            flowEkMalzeme.Controls.Clear();

            foreach (var malzeme in EkMalzemeList)
            {
                ControlEkMalzemeButton MalzemeButton = new ControlEkMalzemeButton
                {
                    Name = malzeme.Id.ToString(),
                    Text = malzeme.Adi + "\n" + (malzeme.Fiyat * EkMalzemeCarpan).ToString("C2"),
                    Height = 200,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat,
                    Width = 200,
                    Id = malzeme.Id,
                    Fiyat = malzeme.Fiyat * EkMalzemeCarpan
                };
                MalzemeButton.CheckedChanged += MalzemeCheckedChange;
                flowEkMalzeme.Controls.Add(MalzemeButton);
            }
            navigationKategori.SelectedPage = pageEkMalzeme;
        }

        private void MalzemeCheckedChange(object sender, EventArgs e)
        {
            EkMalzemeHesapla();
        }

        private void btnEkMalzemeOnay_Click(object sender, EventArgs e)
        {
            txtEkMalzemeTutar.Value = 0;
            txtToplamTutar.Value = 0;

            foreach (ControlEkMalzemeButton button in flowEkMalzeme.Controls)
            {
                if (button.Checked)
                {
                   
                    worker.EkMalzemeHareketService.Add(new EkMalzemeHareket
                    {
                        Id = Guid.NewGuid(),
                        UrunHareketId = urunHareketEntity.Id,
                        EkMalzemeId = button.Id,
                        Fiyat = button.Fiyat
                    });
                }
                else
                {
                    worker.EkMalzemeHareketService.EntityStateChange(c => c.UrunHareketId == urunHareketEntity.Id && c.EkMalzemeId==button.Id,System.Data.Entity.EntityState.Deleted);
                }
            }
            EkMalzemeHesapla();
            urunHareketEntity.BirimFiyat = txtToplamTutar.Value;
            UrunHareketEkle();
            navigationKategori.SelectedPage = pageKategoriUrunler;
        }

        void UrunHareketEkle()
        {
            btnUrunlereDon.Visible = false;
            worker.UrunHareketService.AddOrUpdate(urunHareketEntity);
            worker.UrunService.Load(c => c.Id == urunHareketEntity.UrunId);
            worker.PorsiyonService.Load(c => c.Id == urunHareketEntity.PorsiyonId);
            worker.TanimService.Load(c => c.Id == urunHareketEntity.Porsiyon.BirimId);
            layoutView1.RefreshData();
        }

        void EkMalzemeHesapla()
        {
            txtEkMalzemeTutar.Value = 0;

            foreach (ControlEkMalzemeButton button in flowEkMalzeme.Controls)
            {
                if (button.Checked)
                {
                    txtEkMalzemeTutar.Value += button.Fiyat;
                }
            }
            txtToplamTutar.Value = txtPorsiyonTutar.Value + txtEkMalzemeTutar.Value;
        }

        private void layoutView1_CustomCardStyle(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCardStyleEventArgs e)
        {
            LayoutView view = (LayoutView)sender;
            UrunHareket row = (UrunHareket)view.GetRow(e.RowHandle);

            if (view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.DarkSeaGreen;
                return;
            }

            switch (row.UrunHareketTip)
            {
                case UrunHareketTip.Satis:
                    e.Appearance.BackColor = Color.PaleTurquoise;
                    break;
                case UrunHareketTip.Ikram:
                    e.Appearance.BackColor = Color.MediumSpringGreen;
                    break;
                case UrunHareketTip.Iptal:
                    e.Appearance.BackColor = Color.Tomato;
                    break;
            }
        }

        private void KeyPadSend(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;
            txtMiktar.Focus();
            SendKeys.Send(button.Text);
        }

        private void btnUrunlereDon_Click(object sender, EventArgs e)
        {
            navigationKategori.SelectedPage = pageKategoriUrunler;
            btnUrunlereDon.Visible = false;
        }

        private void btnMiktarArttir_Click(object sender, EventArgs e)
        {
            MiktarArttir(1);
        }

        private void btnMiktarAzalt_Click(object sender, EventArgs e)
        {
            MiktarArttir(-1);
        }

        private void btnKeyPadOkey_Click(object sender, EventArgs e)
        {
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();

            switch (keyPadIslem)
            {
                case KeyPadIslem.Iade:
                    if (hareketEntity.Miktar == txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Iptal;                      
                    }
                    else if(hareketEntity.Miktar < txtMiktar.Value)
                    {
                        MessageBox.Show(hareketEntity.Miktar + "'den fazla iade yapılamaz.");
                        return;
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.UrunHareketTip = UrunHareketTip.Iptal;
                        yeniEntity.Miktar = txtMiktar.Value;
                        worker.UrunHareketService.AddOrUpdate(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;  
                    }
                    layoutView1.RefreshData();
                    break;

                case KeyPadIslem.Ikram:
                    if(hareketEntity.Miktar == txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                    }
                    else if (hareketEntity.Miktar < txtMiktar.Value)
                    {
                        MessageBox.Show(hareketEntity.Miktar + "'den fazla ikram yapılamaz.");
                        return;
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.UrunHareketTip = UrunHareketTip.Ikram;
                        yeniEntity.Miktar = txtMiktar.Value;
                        worker.UrunHareketService.AddOrUpdate(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                    }
                    layoutView1.RefreshData();
                    break;

                case KeyPadIslem.Bolme:
                    if (hareketEntity.Miktar == txtMiktar.Value)
                    {
                        return;
                    }
                    else if (hareketEntity.Miktar < txtMiktar.Value)
                    {
                        MessageBox.Show((hareketEntity.Miktar-1) + "'den fazla bölme yapılamaz.");
                        return;
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.Miktar = txtMiktar.Value;
                        worker.UrunHareketService.AddOrUpdate(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                    }
                    layoutView1.RefreshData();
                    break;
            }

            keyPadIslem = KeyPadIslem.Yok;
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.UrunHareketTip == UrunHareketTip.Iptal)
            {
                MessageBox.Show("Seçtiğiniz ürün zaten iade edilmiştir.");
            }
            else if (hareketEntity.Miktar == 1)
            {
                hareketEntity.UrunHareketTip = UrunHareketTip.Iptal;
                layoutView1.RefreshData();
            }
            else
            {
                keyPadIslem = KeyPadIslem.Iade;
                txtMiktar.Text = null;
                txtMiktar.Properties.NullValuePrompt = "Lütfen iade edilecek miktarı girin.";
            }
        }

        private void btnIkram_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.Miktar == 1)
            {
                hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                layoutView1.RefreshData();
            }
            else
            {
                keyPadIslem = KeyPadIslem.Ikram;
                txtMiktar.Text = null;
                txtMiktar.Properties.NullValuePrompt = "Lütfen ikram edilecek miktarı girin.";
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.Miktar == 1)
            {
                MessageBox.Show("Ürün daha fazla bölünemez.");
            }
            else
            {
                keyPadIslem = KeyPadIslem.Bolme;
                txtMiktar.Text = null;
                txtMiktar.Properties.NullValuePrompt = "Lütfen bölünecek edilecek miktarı girin.";
            }
        }

        private void btnEkMalzeme_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null)
            {
                return;
            }
            urunHareketEntity = (UrunHareket)layoutView1.GetFocusedRow();           
            Porsiyon porsiyonEntity = worker.PorsiyonService.Get(c => c.Id == urunHareketEntity.PorsiyonId);
            IEnumerable<EkMalzeme> ekMalzemeList = worker.EkMalzemeService.GetList(c => c.UrunId == urunHareketEntity.UrunId);
            EkMalzemeButonOlustur(porsiyonEntity.EkMalzemeCarpan, ekMalzemeList);

            List<EkMalzemeHareket> hareketList = worker.EkMalzemeHareketService.BindingList().ToList();
            foreach (var hareket in hareketList.Where(c=>c.UrunHareketId==urunHareketEntity.Id).ToList())
            {
                ControlEkMalzemeButton button = (ControlEkMalzemeButton)flowEkMalzeme.Controls.Find(hareket.EkMalzemeId.ToString(),true)[0];
                button.Checked = true;
            }
        }
    }
}
