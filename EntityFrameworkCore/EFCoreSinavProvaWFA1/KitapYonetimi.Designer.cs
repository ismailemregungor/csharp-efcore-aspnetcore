namespace EFCoreSinavProvaWFA1
{
    partial class frmKitapYonetimi
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
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapFiyati = new System.Windows.Forms.TextBox();
            this.cbxKitapDurumu = new System.Windows.Forms.CheckBox();
            this.cmbYayinEvi = new System.Windows.Forms.ComboBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.gridKitapYonetimi = new System.Windows.Forms.DataGridView();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblKitapFiyati = new System.Windows.Forms.Label();
            this.lblKitapDurumu = new System.Windows.Forms.Label();
            this.lblYayinEvi = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblKitapID = new System.Windows.Forms.Label();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitapYonetimi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(111, 42);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 23);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // txtKitapFiyati
            // 
            this.txtKitapFiyati.Location = new System.Drawing.Point(111, 71);
            this.txtKitapFiyati.Name = "txtKitapFiyati";
            this.txtKitapFiyati.Size = new System.Drawing.Size(100, 23);
            this.txtKitapFiyati.TabIndex = 1;
            // 
            // cbxKitapDurumu
            // 
            this.cbxKitapDurumu.AutoSize = true;
            this.cbxKitapDurumu.Location = new System.Drawing.Point(111, 109);
            this.cbxKitapDurumu.Name = "cbxKitapDurumu";
            this.cbxKitapDurumu.Size = new System.Drawing.Size(100, 19);
            this.cbxKitapDurumu.TabIndex = 2;
            this.cbxKitapDurumu.Text = "Kitap Durumu";
            this.cbxKitapDurumu.UseVisualStyleBackColor = true;
            // 
            // cmbYayinEvi
            // 
            this.cmbYayinEvi.FormattingEnabled = true;
            this.cmbYayinEvi.Location = new System.Drawing.Point(111, 143);
            this.cmbYayinEvi.Name = "cmbYayinEvi";
            this.cmbYayinEvi.Size = new System.Drawing.Size(121, 23);
            this.cmbYayinEvi.TabIndex = 3;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(111, 184);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(110, 34);
            this.btnKitapEkle.TabIndex = 4;
            this.btnKitapEkle.Text = "Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // gridKitapYonetimi
            // 
            this.gridKitapYonetimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKitapYonetimi.Location = new System.Drawing.Point(238, 12);
            this.gridKitapYonetimi.Name = "gridKitapYonetimi";
            this.gridKitapYonetimi.RowTemplate.Height = 25;
            this.gridKitapYonetimi.Size = new System.Drawing.Size(562, 326);
            this.gridKitapYonetimi.TabIndex = 5;
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(12, 45);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(55, 15);
            this.lblKitapAdi.TabIndex = 6;
            this.lblKitapAdi.Text = "Kitap Adi";
            // 
            // lblKitapFiyati
            // 
            this.lblKitapFiyati.AutoSize = true;
            this.lblKitapFiyati.Location = new System.Drawing.Point(12, 74);
            this.lblKitapFiyati.Name = "lblKitapFiyati";
            this.lblKitapFiyati.Size = new System.Drawing.Size(65, 15);
            this.lblKitapFiyati.TabIndex = 7;
            this.lblKitapFiyati.Text = "Kitap Fiyati";
            // 
            // lblKitapDurumu
            // 
            this.lblKitapDurumu.AutoSize = true;
            this.lblKitapDurumu.Location = new System.Drawing.Point(12, 109);
            this.lblKitapDurumu.Name = "lblKitapDurumu";
            this.lblKitapDurumu.Size = new System.Drawing.Size(81, 15);
            this.lblKitapDurumu.TabIndex = 8;
            this.lblKitapDurumu.Text = "Kitap Durumu";
            // 
            // lblYayinEvi
            // 
            this.lblYayinEvi.AutoSize = true;
            this.lblYayinEvi.Location = new System.Drawing.Point(12, 146);
            this.lblYayinEvi.Name = "lblYayinEvi";
            this.lblYayinEvi.Size = new System.Drawing.Size(53, 15);
            this.lblYayinEvi.TabIndex = 9;
            this.lblYayinEvi.Text = "Yayin Evi";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(111, 224);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 34);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(111, 264);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 34);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(111, 304);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(110, 34);
            this.btnAra.TabIndex = 14;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblKitapID
            // 
            this.lblKitapID.AutoSize = true;
            this.lblKitapID.Location = new System.Drawing.Point(12, 20);
            this.lblKitapID.Name = "lblKitapID";
            this.lblKitapID.Size = new System.Drawing.Size(51, 15);
            this.lblKitapID.TabIndex = 17;
            this.lblKitapID.Text = "Kitap ID:";
            // 
            // txtKitapID
            // 
            this.txtKitapID.Location = new System.Drawing.Point(111, 12);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(100, 23);
            this.txtKitapID.TabIndex = 18;
            // 
            // frmKitapYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 348);
            this.Controls.Add(this.txtKitapID);
            this.Controls.Add(this.lblKitapID);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblYayinEvi);
            this.Controls.Add(this.lblKitapDurumu);
            this.Controls.Add(this.lblKitapFiyati);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.gridKitapYonetimi);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.cmbYayinEvi);
            this.Controls.Add(this.cbxKitapDurumu);
            this.Controls.Add(this.txtKitapFiyati);
            this.Controls.Add(this.txtKitapAdi);
            this.Name = "frmKitapYonetimi";
            this.Text = "Kitap Yönetimi";
            this.Load += new System.EventHandler(this.frmKitapYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKitapYonetimi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtKitapAdi;
        private TextBox txtKitapFiyati;
        private CheckBox cbxKitapDurumu;
        private ComboBox cmbYayinEvi;
        private Button btnKitapEkle;
        private DataGridView gridKitapYonetimi;
        private Label lblKitapAdi;
        private Label lblKitapFiyati;
        private Label lblKitapDurumu;
        private Label lblYayinEvi;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnAra;
        private Label lblKitapID;
        private TextBox txtKitapID;
    }
}