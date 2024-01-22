using EFCoreSinavProvaWFA1.Data;
using EFCoreSinavProvaWFA1.Models;
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
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }

        KitapDukkaniContext _context = new KitapDukkaniContext();
        Admin admin = new Admin();
        KitapDukkaniManager<Kitap> kitapDukkaniManager = new KitapDukkaniManager<Kitap>();
        private void btnEnSonEklenenKitaplar_Click(object sender, EventArgs e)
        {
            GridSonEklenenKitaplarDoldur();
        }

        public void GridSonEklenenKitaplarDoldur()
        {
            var kitapListesi = kitapDukkaniManager.GetSonEklenenKitaplar();
            gridRapor.DataSource = kitapListesi;
        }

        private void btnYayinEvineGoreKitaplar_Click(object sender, EventArgs e)
        {
            GridYayinEvlerineGoreKitaplarDoldur();
        }

        public void GridYayinEvlerineGoreKitaplarDoldur()
        {
            var kitapListesi = kitapDukkaniManager.GetYayinEvlerineGoreKitaplar();
            gridRapor.DataSource = kitapListesi;
        }

        private void btnSatisiDurdurulanKitaplar_Click(object sender, EventArgs e)
        {
            GridSatisiDurdurulanKitaplarDoldur();
        }

        public void GridSatisiDurdurulanKitaplarDoldur()
        {
            var kitapListesi = kitapDukkaniManager.GetSatisiDurdurulanKitaplar();
            gridRapor.DataSource = kitapListesi;
        }

        private void btnFiyatinaGoreKitaplar_Click(object sender, EventArgs e)
        {
            GridFiyatinaGoreKitaplarDoldur();
        }
        public void GridFiyatinaGoreKitaplarDoldur()
        {
            var kitapListesi = kitapDukkaniManager.GetFiyatinaGoreKitaplar();
            gridRapor.DataSource = kitapListesi;
        }
    }
}
