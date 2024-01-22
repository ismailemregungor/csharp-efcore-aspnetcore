using EFCoreWFA1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWFA1
{
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }

        ModelContext context = new ModelContext();
        private void GridDoldur()
        {
            var urunlerVeKategoriler = context.Urunlers.Include(u => u.Kategori/*"Kategori"*/)
                                    .Select(x => new
                                    {
                                       UrunID = x.UrunId,
                                       UrunAdi =  x.UrunAdi,
                                       UrunFiyati = x.UrunFiyati,
                                       KategoriAdi= x.Kategori.KategoriAdi
                                    }).OrderBy(x=> x.UrunID).ToList();

            grdUrunler.DataSource = urunlerVeKategoriler;
        }

        private void ComboKategorilerDoldur()
        {
            var kategoriler = context.Kategorilers
                                //.Select(k => new
                                //{
                                //    KategoriId = k.KategoriId,
                                //    KategoriAdi = k.KategoriAdi
                                //})
                                .ToList();

            cmbKategoriler.DataSource = kategoriler;
            cmbKategoriler.ValueMember = "KategoriId";
            cmbKategoriler.DisplayMember = "KategoriAdi";
            
        }

        private Urunler UrunAl()
        {
            Urunler urun = new Urunler();
            urun.UrunId = int.Parse(txtUrunID.Text);
            urun.UrunAdi = txtUrunAdi.Text;
            urun.UrunFiyati = double.Parse(txtFiyat.Text);
            urun.KategoriId = Convert.ToInt32(cmbKategoriler.SelectedValue);
            return urun;
        }

        private Urunler Ara(int urunID)
        {
            Urunler urun = context.Urunlers.Find(urunID);
            context.Entry(urun).State = EntityState.Detached;
            return urun;
        }

        private void VerileriKontrollereDoldur(Urunler urun)
        {
            txtUrunAdi.Text = urun.UrunAdi;
            txtFiyat.Text = urun.UrunFiyati.ToString();
            cmbKategoriler.SelectedValue = urun.KategoriId;
        }

        private void ShowHide(bool value)
        {
            btnKaydet.Enabled = value;
            pnlUpdateDelete.Enabled = !value;
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            GridDoldur();
            ComboKategorilerDoldur();
            ShowHide(true);
        }

        private void Kaydet()
        {
            context.Urunlers.Add(UrunAl());
            context.SaveChanges();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
            GridDoldur();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtUrunID.Text == "")
                MessageBox.Show("Boş geçemezsiniz...");
            Urunler urun = Ara(int.Parse(txtUrunID.Text));
            if (urun == null)
            {
                MessageBox.Show("Aradığınız kayıt bulunamadi...");
            }
            else
            {
                ShowHide(false);
                VerileriKontrollereDoldur(urun);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Urunler urun = UrunAl();
            context.Entry(urun).State = EntityState.Modified;
            context.SaveChanges();
            GridDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("UYARI", "Kaydı silmek istiyor musunuz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                context.Urunlers.Remove(UrunAl());
                context.SaveChanges();
                GridDoldur();
            }
        }
    }
}