namespace Otel.Formlar
{
    partial class Yorumlar
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
            this.FlpYorum = new System.Windows.Forms.FlowLayoutPanel();
            this.TbYorumBaslik = new System.Windows.Forms.TextBox();
            this.TbYorumMetin = new System.Windows.Forms.TextBox();
            this.BtnYorumyap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FlpYorum
            // 
            this.FlpYorum.Location = new System.Drawing.Point(211, 38);
            this.FlpYorum.Name = "FlpYorum";
            this.FlpYorum.Size = new System.Drawing.Size(257, 129);
            this.FlpYorum.TabIndex = 0;
            // 
            // TbYorumBaslik
            // 
            this.TbYorumBaslik.Location = new System.Drawing.Point(256, 216);
            this.TbYorumBaslik.Name = "TbYorumBaslik";
            this.TbYorumBaslik.Size = new System.Drawing.Size(100, 20);
            this.TbYorumBaslik.TabIndex = 1;
            // 
            // TbYorumMetin
            // 
            this.TbYorumMetin.Location = new System.Drawing.Point(256, 257);
            this.TbYorumMetin.Name = "TbYorumMetin";
            this.TbYorumMetin.Size = new System.Drawing.Size(100, 20);
            this.TbYorumMetin.TabIndex = 1;
            // 
            // BtnYorumyap
            // 
            this.BtnYorumyap.Location = new System.Drawing.Point(271, 307);
            this.BtnYorumyap.Name = "BtnYorumyap";
            this.BtnYorumyap.Size = new System.Drawing.Size(75, 23);
            this.BtnYorumyap.TabIndex = 2;
            this.BtnYorumyap.Text = "Yorum";
            this.BtnYorumyap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yorum Başlığı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yorum Metni : ";
            // 
            // Yorumlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnYorumyap);
            this.Controls.Add(this.TbYorumMetin);
            this.Controls.Add(this.TbYorumBaslik);
            this.Controls.Add(this.FlpYorum);
            this.Name = "Yorumlar";
            this.Text = "Yorumlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpYorum;
        private System.Windows.Forms.TextBox TbYorumBaslik;
        private System.Windows.Forms.TextBox TbYorumMetin;
        private System.Windows.Forms.Button BtnYorumyap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}