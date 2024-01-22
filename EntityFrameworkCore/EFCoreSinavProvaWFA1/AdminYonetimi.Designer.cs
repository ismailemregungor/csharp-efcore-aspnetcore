namespace EFCoreSinavProvaWFA1
{
    partial class frmAdminYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdminEkle = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.gridAdminYonetimi = new System.Windows.Forms.DataGridView();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdminYonetimi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminEkle
            // 
            this.btnAdminEkle.Location = new System.Drawing.Point(99, 90);
            this.btnAdminEkle.Name = "btnAdminEkle";
            this.btnAdminEkle.Size = new System.Drawing.Size(68, 34);
            this.btnAdminEkle.TabIndex = 0;
            this.btnAdminEkle.Text = "Ekle";
            this.btnAdminEkle.UseVisualStyleBackColor = true;
            this.btnAdminEkle.Click += new System.EventHandler(this.btnAdminEkle_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(99, 12);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 23);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(99, 51);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 23);
            this.txtSifre.TabIndex = 2;
            // 
            // gridAdminYonetimi
            // 
            this.gridAdminYonetimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAdminYonetimi.Location = new System.Drawing.Point(222, 12);
            this.gridAdminYonetimi.Name = "gridAdminYonetimi";
            this.gridAdminYonetimi.RowTemplate.Height = 25;
            this.gridAdminYonetimi.Size = new System.Drawing.Size(328, 188);
            this.gridAdminYonetimi.TabIndex = 3;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(14, 20);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(79, 15);
            this.lblKullaniciAdi.TabIndex = 4;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı: ";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(14, 59);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(36, 15);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre: ";
            // 
            // frmAdminYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 210);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.gridAdminYonetimi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.btnAdminEkle);
            this.Name = "frmAdminYonetimi";
            this.Text = "Admin Yönetimi";
            this.Load += new System.EventHandler(this.frmAdminYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAdminYonetimi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdminEkle;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private DataGridView gridAdminYonetimi;
        private Label lblKullaniciAdi;
        private Label lblSifre;
    }
}