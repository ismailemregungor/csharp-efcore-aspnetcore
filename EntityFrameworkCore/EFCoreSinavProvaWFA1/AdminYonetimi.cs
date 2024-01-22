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
    public partial class frmAdminYonetimi : Form
    {
        public frmAdminYonetimi()
        {
            InitializeComponent();
        }

        KitapDukkaniContext _context = new KitapDukkaniContext();
        Admin admin = new Admin();
        KitapDukkaniManager<Admin> kitapDukkaniManager = new KitapDukkaniManager<Admin>();
        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            //// TextBox'lardan kullanıcı adı ve şifre alınıyor.
            //string kullaniciAdi = txtKullaniciAdi.Text;
            //string sifre = txtSifre.Text;

            //// Gerekli alanların boş olup olmadığını kontrol et
            //if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            //{
            //    MessageBox.Show("Kullanıcı adı ve şifre alanları doldurulmalıdır.");
            //    return;
            //}

            //// Şifreyi MD5 ile hashle
            //string hashedSifre = admin.CalculateMD5Hash(sifre);

            //// Yeni Admin nesnesi oluştur
            //Admin yeniAdmin = new Admin
            //{
            //    KullaniciAdi = kullaniciAdi,
            //    Sifre = hashedSifre // Şifreyi MD5 hash olarak atama
            //};

            //// Veritabanına yeni admin ekle
            //try
            //{
            //    _context.Adminler.Add(yeniAdmin);
            //    _context.SaveChanges(); // Değişiklikleri kaydet

            //    MessageBox.Show("Yeni admin başarıyla eklendi.");
            //    GridDoldur();
            //}
            //catch (Exception ex)
            //{
            //    // Hata mesajı göster
            //    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            //}

            // TextBox'lardan kullanıcı adı ve şifre alınıyor.
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            // Gerekli alanların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanları doldurulmalıdır.");
                return;
            }

            // Şifreyi MD5 ile hashle
            string hashedSifre = admin.CalculateMD5Hash(sifre);

            // Yeni Admin nesnesi oluştur
            Admin yeniAdmin = new Admin
            {
                KullaniciAdi = kullaniciAdi,
                Sifre = hashedSifre // Şifreyi MD5 hash olarak atama
            };

            // Veritabanına yeni admin ekle
            try
            {
                kitapDukkaniManager.Ekle(yeniAdmin);
                _context.SaveChanges();

                MessageBox.Show("Yeni admin başarıyla eklendi.");
                GridAdminDoldur();
            }
            catch (Exception ex)
            {
                // Hata mesajı göster
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void frmAdminYonetimi_Load(object sender, EventArgs e)
        {
            GridAdminDoldur();
        }

        public void GridAdminDoldur()
        {

            //var adminListesi = _context.Adminler
            //                   .Select(a => new { a.AdminID, a.KullaniciAdi, a.Sifre }).OrderBy(a => a.AdminID)
            //                   .ToList();

            //gridAdminYonetimi.DataSource = adminListesi;

            var adminListesi = kitapDukkaniManager.Listele();
            gridAdminYonetimi.DataSource = adminListesi;

        }
    }
}
