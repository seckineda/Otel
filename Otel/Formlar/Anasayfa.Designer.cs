namespace Otel
{
    partial class Anasayfa
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
            this.PbAnasayfa = new System.Windows.Forms.PictureBox();
            this.TbAra = new System.Windows.Forms.TextBox();
            this.BtnAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbAnasayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // PbAnasayfa
            // 
            this.PbAnasayfa.Location = new System.Drawing.Point(59, 41);
            this.PbAnasayfa.Name = "PbAnasayfa";
            this.PbAnasayfa.Size = new System.Drawing.Size(364, 91);
            this.PbAnasayfa.TabIndex = 0;
            this.PbAnasayfa.TabStop = false;
            // 
            // TbAra
            // 
            this.TbAra.Location = new System.Drawing.Point(162, 166);
            this.TbAra.Name = "TbAra";
            this.TbAra.Size = new System.Drawing.Size(146, 20);
            this.TbAra.TabIndex = 1;
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(328, 163);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(93, 25);
            this.BtnAra.TabIndex = 2;
            this.BtnAra.Text = "ARA";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(66, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otel / Şehir : ";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TbAra);
            this.Controls.Add(this.PbAnasayfa);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbAnasayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbAnasayfa;
        private System.Windows.Forms.TextBox TbAra;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Label label1;
    }
}

