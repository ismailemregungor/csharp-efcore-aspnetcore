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
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void btnAdminYonetimi_Click(object sender, EventArgs e)
        {
            frmAdminYonetimi frmAdminYonetimi = new frmAdminYonetimi();
            frmAdminYonetimi.ShowDialog();

        }

        private void btnKitapYonetimi_Click(object sender, EventArgs e)
        {
            frmKitapYonetimi frmKitapYonetimi = new frmKitapYonetimi();
            frmKitapYonetimi.ShowDialog();
        }

        private void btnYayinEviYonetimi_Click(object sender, EventArgs e)
        {
            frmYayinEviYonetimi frmYayinEviYonetimi = new frmYayinEviYonetimi();
            frmYayinEviYonetimi.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmRapor frmRapor = new frmRapor();
            frmRapor.ShowDialog();
        }
    }
}
