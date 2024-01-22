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
    public partial class frmYayinEviYonetimi : Form
    {
        public frmYayinEviYonetimi()
        {
            InitializeComponent();
        }

        KitapDukkaniContext _context = new KitapDukkaniContext();
        Admin admin = new Admin();
        KitapDukkaniManager<YayinEvi> kitapDukkaniManager = new KitapDukkaniManager<YayinEvi>();
        private void frmYayinEviYonetimi_Load(object sender, EventArgs e)
        {
            GridYayinEvleriDoldur();
        }

        public void GridYayinEvleriDoldur()
        {
            //var yayinEviListesi = _context.YayinEvleri
            //                              .Select(ye => new { ye.YayinEviID, ye.Adi })
            //                              .OrderBy(ye => ye.YayinEviID)
            //                              .ToList();

            //gridYayinEviYonetimi.DataSource = yayinEviListesi;

            var yayinEviListesi = kitapDukkaniManager.Listele();
            gridYayinEviYonetimi.DataSource = yayinEviListesi;

        }

        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            string yayinEviAdi = txtYayinEviAdi.Text;

            YayinEvi yeniYayinEvi = new YayinEvi
            {
                Adi = yayinEviAdi,
            };

            try
            {
                kitapDukkaniManager.Ekle(yeniYayinEvi);
                _context.SaveChanges();
                MessageBox.Show("Yeni yayin evi başarıyla eklendi.");
                GridYayinEvleriDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
            GridYayinEvleriDoldur();
        }
    }
}
