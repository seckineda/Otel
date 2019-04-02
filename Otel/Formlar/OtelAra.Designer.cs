namespace Otel.Formlar
{
    partial class OtelAra
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
            this.PbOtelResmi = new System.Windows.Forms.PictureBox();
            this.TbOtelSehirAra = new System.Windows.Forms.TextBox();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOtelSehirAra = new System.Windows.Forms.Button();
            this.DgwOtelİsimleri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PbOtelResmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwOtelİsimleri)).BeginInit();
            this.SuspendLayout();
            // 
            // PbOtelResmi
            // 
            this.PbOtelResmi.Location = new System.Drawing.Point(184, 28);
            this.PbOtelResmi.Name = "PbOtelResmi";
            this.PbOtelResmi.Size = new System.Drawing.Size(334, 123);
            this.PbOtelResmi.TabIndex = 0;
            this.PbOtelResmi.TabStop = false;
            // 
            // TbOtelSehirAra
            // 
            this.TbOtelSehirAra.Location = new System.Drawing.Point(149, 203);
            this.TbOtelSehirAra.Name = "TbOtelSehirAra";
            this.TbOtelSehirAra.Size = new System.Drawing.Size(198, 20);
            this.TbOtelSehirAra.TabIndex = 1;
            this.TbOtelSehirAra.Text = "Orn : Otel,Şehir";
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Location = new System.Drawing.Point(148, 244);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.DtpGirisTarihi.TabIndex = 2;
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Location = new System.Drawing.Point(437, 244);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.DtpCikisTarihi.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(640, 28);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(27, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Giris";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(713, 28);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(46, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Kayıt Ol ";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giriş Tarihi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çıkış Tarihi : ";
            // 
            // BtnOtelSehirAra
            // 
            this.BtnOtelSehirAra.Location = new System.Drawing.Point(376, 203);
            this.BtnOtelSehirAra.Name = "BtnOtelSehirAra";
            this.BtnOtelSehirAra.Size = new System.Drawing.Size(75, 23);
            this.BtnOtelSehirAra.TabIndex = 5;
            this.BtnOtelSehirAra.Text = "ARA";
            this.BtnOtelSehirAra.UseVisualStyleBackColor = true;
            this.BtnOtelSehirAra.Click += new System.EventHandler(this.BtnOtelSehirAra_Click);
            // 
            // DgwOtelİsimleri
            // 
            this.DgwOtelİsimleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwOtelİsimleri.Location = new System.Drawing.Point(67, 280);
            this.DgwOtelİsimleri.Name = "DgwOtelİsimleri";
            this.DgwOtelİsimleri.Size = new System.Drawing.Size(600, 150);
            this.DgwOtelİsimleri.TabIndex = 6;
            this.DgwOtelİsimleri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwOtelİsimleri_CellContentClick);
            // 
            // OtelAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgwOtelİsimleri);
            this.Controls.Add(this.BtnOtelSehirAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.DtpCikisTarihi);
            this.Controls.Add(this.DtpGirisTarihi);
            this.Controls.Add(this.TbOtelSehirAra);
            this.Controls.Add(this.PbOtelResmi);
            this.Name = "OtelAra";
            this.Text = "OtelAra";
            ((System.ComponentModel.ISupportInitialize)(this.PbOtelResmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwOtelİsimleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbOtelResmi;
        private System.Windows.Forms.TextBox TbOtelSehirAra;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOtelSehirAra;
        private System.Windows.Forms.DataGridView DgwOtelİsimleri;
    }
}