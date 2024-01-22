namespace EFCoreSinavProvaWFA1
{
    partial class frmAnaMenu
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
            this.btnAdminYonetimi = new System.Windows.Forms.Button();
            this.btnKitapYonetimi = new System.Windows.Forms.Button();
            this.btnYayinEviYonetimi = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminYonetimi
            // 
            this.btnAdminYonetimi.Location = new System.Drawing.Point(28, 27);
            this.btnAdminYonetimi.Name = "btnAdminYonetimi";
            this.btnAdminYonetimi.Size = new System.Drawing.Size(209, 49);
            this.btnAdminYonetimi.TabIndex = 0;
            this.btnAdminYonetimi.Text = "Admin Yönetimi";
            this.btnAdminYonetimi.UseVisualStyleBackColor = true;
            this.btnAdminYonetimi.Click += new System.EventHandler(this.btnAdminYonetimi_Click);
            // 
            // btnKitapYonetimi
            // 
            this.btnKitapYonetimi.Location = new System.Drawing.Point(28, 82);
            this.btnKitapYonetimi.Name = "btnKitapYonetimi";
            this.btnKitapYonetimi.Size = new System.Drawing.Size(209, 49);
            this.btnKitapYonetimi.TabIndex = 1;
            this.btnKitapYonetimi.Text = "Kitap Yönetimi";
            this.btnKitapYonetimi.UseVisualStyleBackColor = true;
            this.btnKitapYonetimi.Click += new System.EventHandler(this.btnKitapYonetimi_Click);
            // 
            // btnYayinEviYonetimi
            // 
            this.btnYayinEviYonetimi.Location = new System.Drawing.Point(28, 137);
            this.btnYayinEviYonetimi.Name = "btnYayinEviYonetimi";
            this.btnYayinEviYonetimi.Size = new System.Drawing.Size(209, 49);
            this.btnYayinEviYonetimi.TabIndex = 2;
            this.btnYayinEviYonetimi.Text = "Yayin Evi Yönetimi";
            this.btnYayinEviYonetimi.UseVisualStyleBackColor = true;
            this.btnYayinEviYonetimi.Click += new System.EventHandler(this.btnYayinEviYonetimi_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(28, 192);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(209, 49);
            this.btnRapor.TabIndex = 3;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // frmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 263);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnYayinEviYonetimi);
            this.Controls.Add(this.btnKitapYonetimi);
            this.Controls.Add(this.btnAdminYonetimi);
            this.Name = "frmAnaMenu";
            this.Text = "Ana Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAdminYonetimi;
        private Button btnKitapYonetimi;
        private Button btnYayinEviYonetimi;
        private Button btnRapor;
    }
}