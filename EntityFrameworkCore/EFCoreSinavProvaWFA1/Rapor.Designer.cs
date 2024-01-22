namespace EFCoreSinavProvaWFA1
{
    partial class frmRapor
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
            this.gridRapor = new System.Windows.Forms.DataGridView();
            this.btnEnSonEklenenKitaplar = new System.Windows.Forms.Button();
            this.btnYayinEvineGoreKitaplar = new System.Windows.Forms.Button();
            this.btnSatisiDurdurulanKitaplar = new System.Windows.Forms.Button();
            this.btnFiyatinaGoreKitaplar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRapor
            // 
            this.gridRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRapor.Location = new System.Drawing.Point(212, 25);
            this.gridRapor.Name = "gridRapor";
            this.gridRapor.RowTemplate.Height = 25;
            this.gridRapor.Size = new System.Drawing.Size(576, 251);
            this.gridRapor.TabIndex = 0;
            // 
            // btnEnSonEklenenKitaplar
            // 
            this.btnEnSonEklenenKitaplar.Location = new System.Drawing.Point(12, 25);
            this.btnEnSonEklenenKitaplar.Name = "btnEnSonEklenenKitaplar";
            this.btnEnSonEklenenKitaplar.Size = new System.Drawing.Size(178, 46);
            this.btnEnSonEklenenKitaplar.TabIndex = 1;
            this.btnEnSonEklenenKitaplar.Text = "En Son Eklenen Kitaplar";
            this.btnEnSonEklenenKitaplar.UseVisualStyleBackColor = true;
            this.btnEnSonEklenenKitaplar.Click += new System.EventHandler(this.btnEnSonEklenenKitaplar_Click);
            // 
            // btnYayinEvineGoreKitaplar
            // 
            this.btnYayinEvineGoreKitaplar.Location = new System.Drawing.Point(12, 89);
            this.btnYayinEvineGoreKitaplar.Name = "btnYayinEvineGoreKitaplar";
            this.btnYayinEvineGoreKitaplar.Size = new System.Drawing.Size(178, 46);
            this.btnYayinEvineGoreKitaplar.TabIndex = 2;
            this.btnYayinEvineGoreKitaplar.Text = "Yayın Evine Göre Kitaplar";
            this.btnYayinEvineGoreKitaplar.UseVisualStyleBackColor = true;
            this.btnYayinEvineGoreKitaplar.Click += new System.EventHandler(this.btnYayinEvineGoreKitaplar_Click);
            // 
            // btnSatisiDurdurulanKitaplar
            // 
            this.btnSatisiDurdurulanKitaplar.Location = new System.Drawing.Point(12, 160);
            this.btnSatisiDurdurulanKitaplar.Name = "btnSatisiDurdurulanKitaplar";
            this.btnSatisiDurdurulanKitaplar.Size = new System.Drawing.Size(178, 46);
            this.btnSatisiDurdurulanKitaplar.TabIndex = 3;
            this.btnSatisiDurdurulanKitaplar.Text = "Satışı Durdurulan Kitaplar";
            this.btnSatisiDurdurulanKitaplar.UseVisualStyleBackColor = true;
            this.btnSatisiDurdurulanKitaplar.Click += new System.EventHandler(this.btnSatisiDurdurulanKitaplar_Click);
            // 
            // btnFiyatinaGoreKitaplar
            // 
            this.btnFiyatinaGoreKitaplar.Location = new System.Drawing.Point(12, 230);
            this.btnFiyatinaGoreKitaplar.Name = "btnFiyatinaGoreKitaplar";
            this.btnFiyatinaGoreKitaplar.Size = new System.Drawing.Size(178, 46);
            this.btnFiyatinaGoreKitaplar.TabIndex = 4;
            this.btnFiyatinaGoreKitaplar.Text = "Fiyatına Göre Kitaplar";
            this.btnFiyatinaGoreKitaplar.UseVisualStyleBackColor = true;
            this.btnFiyatinaGoreKitaplar.Click += new System.EventHandler(this.btnFiyatinaGoreKitaplar_Click);
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.btnFiyatinaGoreKitaplar);
            this.Controls.Add(this.btnSatisiDurdurulanKitaplar);
            this.Controls.Add(this.btnYayinEvineGoreKitaplar);
            this.Controls.Add(this.btnEnSonEklenenKitaplar);
            this.Controls.Add(this.gridRapor);
            this.Name = "frmRapor";
            this.Text = "Rapor";
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gridRapor;
        private Button btnEnSonEklenenKitaplar;
        private Button btnYayinEvineGoreKitaplar;
        private Button btnSatisiDurdurulanKitaplar;
        private Button btnFiyatinaGoreKitaplar;
    }
}