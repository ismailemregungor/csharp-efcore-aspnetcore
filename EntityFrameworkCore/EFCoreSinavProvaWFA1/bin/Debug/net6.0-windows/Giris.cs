using EFCoreSinavProvaWFA1.Data;
using EFCoreSinavProvaWFA1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSinavProvaWFA1
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        KitapDukkaniContext context = new KitapDukkaniContext();
        Admin admin = new Admin();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            string hashedSifre = admin.CalculateMD5Hash(sifre);

            var adminKontrol = context.Adminler
                            .FirstOrDefault(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == hashedSifre);


            if (adminKontrol != null)
            {
                
                frmAnaMenu frmAnaMenu = new frmAnaMenu();
                frmAnaMenu.ShowDialog();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}