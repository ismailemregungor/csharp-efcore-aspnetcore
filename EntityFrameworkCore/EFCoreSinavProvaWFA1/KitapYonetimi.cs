using EFCoreSinavProvaWFA1.Data;
using EFCoreSinavProvaWFA1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCoreSinavProvaWFA1
{
    public partial class frmKitapYonetimi : Form
    {
        public frmKitapYonetimi()
        {
            InitializeComponent();
        }

        KitapDukkaniContext _context = new KitapDukkaniContext();
        Admin admin = new Admin();
        
        private void frmKitapYonetimi_Load(object sender, EventArgs e)
        {
            GridKitaplarDoldur();
            CmbYayinEvleriDoldur();
        }

        public void GridKitaplarDoldur()
        {
            KitapDukkaniManager<Kitap> kitapDukkaniManager = 
                new KitapDukkaniManager<Kitap>();
            var kitapListesi = kitapDukkaniManager.ListeleJoin("YayinEvi")
            .Select(k => new
            {
                KitapID = k.KitapID,
                KitapAdi = k.Adi,
                Fiyat = k.Fiyat,
                Durum = k.Durum ? "Satışta" : "Satışta Değil", // Durumu metinsel olarak ifade ediyoruz
                YayinEviID = k.YayinEviID,
                YayinEviAdi = k.YayinEvi.Adi

            }).ToList();

            gridKitapYonetimi.DataSource = kitapListesi;
        }

        public void CmbYayinEvleriDoldur()
        {
            KitapDukkaniManager<YayinEvi> kitapDukkaniManager = new KitapDukkaniManager<YayinEvi>();
            var yayinEviListesi = kitapDukkaniManager.Listele();
            cmbYayinEvi.DataSource = yayinEviListesi;
            cmbYayinEvi.DisplayMember = "Adi"; // Görüntülenecek metin
            cmbYayinEvi.ValueMember = "YayinEviID"; // Arkaplanda tutulacak değer
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            string kitapAdi = txtKitapAdi.Text;
            decimal fiyat = decimal.Parse(txtKitapFiyati.Text);
            bool durum = cbxKitapDurumu.Checked; // CheckBox kontrolü, satış durumunu temsil ediyor.
            int yayinEviId = (int)cmbYayinEvi.SelectedValue;

            Kitap yeniKitap = new Kitap
            {
                Adi = kitapAdi,
                Fiyat = fiyat,
                Durum = durum,
                YayinEviID = yayinEviId
            };

            try
            {
                KitapDukkaniManager<Kitap> kitapManager = new KitapDukkaniManager<Kitap>();
                kitapManager.Ekle(yeniKitap);
                MessageBox.Show("Kitap başarıyla eklendi.");
                GridKitaplarDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int kitapId = Convert.ToInt32(txtKitapID.Text); // Güncellenecek kitabın ID'si
            string kitapAdi = txtKitapAdi.Text;
            decimal fiyat = Convert.ToDecimal(txtKitapFiyati.Text);
            bool durum = cbxKitapDurumu.Checked; // CheckBox kontrolü
            int yayinEviId = Convert.ToInt32(cmbYayinEvi.SelectedValue);

            KitapDukkaniManager<Kitap> kitapManager = new KitapDukkaniManager<Kitap>();
            Kitap kitap = kitapManager.Bul(kitapId);

            if (kitap != null)
            {
                kitap.Adi = kitapAdi;
                kitap.Fiyat = fiyat;
                kitap.Durum = durum;
                kitap.YayinEviID = yayinEviId;

                kitapManager.Guncelle(kitap);
                MessageBox.Show("Kitap başarıyla güncellendi.");
                GridKitaplarDoldur();
            }
            else
            {
                MessageBox.Show("Güncellenecek kitap bulunamadı.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int kitapId = Convert.ToInt32(txtKitapID.Text); // Silinecek kitabın ID'si

            KitapDukkaniManager<Kitap> kitapManager = new KitapDukkaniManager<Kitap>();
            Kitap kitap = kitapManager.Bul(kitapId);

            if (kitap != null)
            {
                kitapManager.Sil(kitapId);
                MessageBox.Show("Kitap başarıyla silindi.");
                GridKitaplarDoldur();
            }
            else
            {
                MessageBox.Show("Silinecek kitap bulunamadı.");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int kitapId = Convert.ToInt32(txtKitapID.Text); // Aranan kitabın ID'si

            KitapDukkaniManager<Kitap> kitapManager = new KitapDukkaniManager<Kitap>();
            Kitap kitap = kitapManager.Bul(kitapId);

            if (kitap != null)
            {
                // Aranan kitap bulunduğunda ne yapılacağı buraya yazılır.
                // Örneğin, formdaki kontrolleri bulunan kitap bilgileriyle doldurabilirsiniz.
                txtKitapAdi.Text = kitap.Adi;
                txtKitapFiyati.Text = kitap.Fiyat.ToString();
                cbxKitapDurumu.Checked = kitap.Durum;
                cmbYayinEvi.SelectedValue = kitap.YayinEviID;

                MessageBox.Show("Kitap bulundu ve bilgiler yüklendi.");
            }
            else
            {
                MessageBox.Show("Aranan kitap bulunamadı.");
            }
        }
    }
}
