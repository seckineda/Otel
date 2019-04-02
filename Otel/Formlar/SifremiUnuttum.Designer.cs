namespace Otel.Formlar
{
    partial class SifremiUnuttum
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
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSifremiUnuttumGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(112, 57);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(100, 20);
            this.TbEmail.TabIndex = 0;
            // 
            // TbKullaniciAdi
            // 
            this.TbKullaniciAdi.Location = new System.Drawing.Point(112, 94);
            this.TbKullaniciAdi.Name = "TbKullaniciAdi";
            this.TbKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.TbKullaniciAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı : ";
            // 
            // BtnSifremiUnuttumGiris
            // 
            this.BtnSifremiUnuttumGiris.Location = new System.Drawing.Point(112, 145);
            this.BtnSifremiUnuttumGiris.Name = "BtnSifremiUnuttumGiris";
            this.BtnSifremiUnuttumGiris.Size = new System.Drawing.Size(75, 23);
            this.BtnSifremiUnuttumGiris.TabIndex = 2;
            this.BtnSifremiUnuttumGiris.Text = "GİRİS";
            this.BtnSifremiUnuttumGiris.UseVisualStyleBackColor = true;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 439);
            this.Controls.Add(this.BtnSifremiUnuttumGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbKullaniciAdi);
            this.Controls.Add(this.TbEmail);
            this.Name = "SifremiUnuttum";
            this.Text = "SifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSifremiUnuttumGiris;
    }
}