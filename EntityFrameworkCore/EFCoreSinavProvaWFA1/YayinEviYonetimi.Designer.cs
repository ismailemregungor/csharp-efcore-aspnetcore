namespace EFCoreSinavProvaWFA1
{
    partial class frmYayinEviYonetimi
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
            this.btnYayinEviEkle = new System.Windows.Forms.Button();
            this.txtYayinEviAdi = new System.Windows.Forms.TextBox();
            this.lblYayinEviAdi = new System.Windows.Forms.Label();
            this.gridYayinEviYonetimi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridYayinEviYonetimi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYayinEviEkle
            // 
            this.btnYayinEviEkle.Location = new System.Drawing.Point(98, 65);
            this.btnYayinEviEkle.Name = "btnYayinEviEkle";
            this.btnYayinEviEkle.Size = new System.Drawing.Size(100, 30);
            this.btnYayinEviEkle.TabIndex = 0;
            this.btnYayinEviEkle.Text = "Ekle";
            this.btnYayinEviEkle.UseVisualStyleBackColor = true;
            this.btnYayinEviEkle.Click += new System.EventHandler(this.btnYayinEviEkle_Click);
            // 
            // txtYayinEviAdi
            // 
            this.txtYayinEviAdi.Location = new System.Drawing.Point(98, 26);
            this.txtYayinEviAdi.Name = "txtYayinEviAdi";
            this.txtYayinEviAdi.Size = new System.Drawing.Size(100, 23);
            this.txtYayinEviAdi.TabIndex = 1;
            // 
            // lblYayinEviAdi
            // 
            this.lblYayinEviAdi.AutoSize = true;
            this.lblYayinEviAdi.Location = new System.Drawing.Point(12, 29);
            this.lblYayinEviAdi.Name = "lblYayinEviAdi";
            this.lblYayinEviAdi.Size = new System.Drawing.Size(80, 15);
            this.lblYayinEviAdi.TabIndex = 2;
            this.lblYayinEviAdi.Text = "Yayin Evi Adı: ";
            // 
            // gridYayinEviYonetimi
            // 
            this.gridYayinEviYonetimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridYayinEviYonetimi.Location = new System.Drawing.Point(216, 12);
            this.gridYayinEviYonetimi.Name = "gridYayinEviYonetimi";
            this.gridYayinEviYonetimi.RowTemplate.Height = 25;
            this.gridYayinEviYonetimi.Size = new System.Drawing.Size(285, 213);
            this.gridYayinEviYonetimi.TabIndex = 3;
            // 
            // frmYayinEviYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 237);
            this.Controls.Add(this.gridYayinEviYonetimi);
            this.Controls.Add(this.lblYayinEviAdi);
            this.Controls.Add(this.txtYayinEviAdi);
            this.Controls.Add(this.btnYayinEviEkle);
            this.Name = "frmYayinEviYonetimi";
            this.Text = "Yayin Evi Yönetimi";
            this.Load += new System.EventHandler(this.frmYayinEviYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridYayinEviYonetimi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnYayinEviEkle;
        private TextBox txtYayinEviAdi;
        private Label lblYayinEviAdi;
        private DataGridView gridYayinEviYonetimi;
    }
}