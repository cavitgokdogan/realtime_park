using OtoparkOtomasyonuEnSon.Properties;
using System;

namespace OtoparkOtomasyonuEnSon
{
    partial class FormFiyatTarife
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiyatTarife));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxBirSaat = new System.Windows.Forms.TextBox();
            this.txtBoxSaatlik = new System.Windows.Forms.TextBox();
            this.txtBoxGunluk = new System.Windows.Forms.TextBox();
            this.pnlGeriDon = new System.Windows.Forms.Panel();
            this.lblGeriDon = new System.Windows.Forms.Label();
            this.picGeriDon = new System.Windows.Forms.PictureBox();
            this.pnlKaydet = new System.Windows.Forms.Panel();
            this.lblKaydet = new System.Windows.Forms.Label();
            this.picKaydet = new System.Windows.Forms.PictureBox();
            this.pnlGeriDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGeriDon)).BeginInit();
            this.pnlKaydet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKaydet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 Saat\'e Kadar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(193, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saatlik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(193, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Günlük";
            // 
            // txtBoxBirSaat
            // 
            this.txtBoxBirSaat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(42)))), ((int)(((byte)(235)))));
            this.txtBoxBirSaat.ForeColor = System.Drawing.Color.White;
            this.txtBoxBirSaat.Location = new System.Drawing.Point(305, 137);
            this.txtBoxBirSaat.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxBirSaat.Name = "txtBoxBirSaat";
            this.txtBoxBirSaat.Size = new System.Drawing.Size(90, 23);
            this.txtBoxBirSaat.TabIndex = 4;
            // 
            // txtBoxSaatlik
            // 
            this.txtBoxSaatlik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(42)))), ((int)(((byte)(235)))));
            this.txtBoxSaatlik.ForeColor = System.Drawing.Color.White;
            this.txtBoxSaatlik.Location = new System.Drawing.Point(305, 189);
            this.txtBoxSaatlik.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSaatlik.Name = "txtBoxSaatlik";
            this.txtBoxSaatlik.Size = new System.Drawing.Size(90, 23);
            this.txtBoxSaatlik.TabIndex = 4;
            // 
            // txtBoxGunluk
            // 
            this.txtBoxGunluk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(42)))), ((int)(((byte)(235)))));
            this.txtBoxGunluk.ForeColor = System.Drawing.Color.White;
            this.txtBoxGunluk.Location = new System.Drawing.Point(305, 242);
            this.txtBoxGunluk.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxGunluk.Name = "txtBoxGunluk";
            this.txtBoxGunluk.Size = new System.Drawing.Size(90, 23);
            this.txtBoxGunluk.TabIndex = 4;
            // 
            // pnlGeriDon
            // 
            this.pnlGeriDon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlGeriDon.Controls.Add(this.lblGeriDon);
            this.pnlGeriDon.Controls.Add(this.picGeriDon);
            this.pnlGeriDon.Location = new System.Drawing.Point(27, 379);
            this.pnlGeriDon.Name = "pnlGeriDon";
            this.pnlGeriDon.Size = new System.Drawing.Size(145, 56);
            this.pnlGeriDon.TabIndex = 15;
            this.pnlGeriDon.Click += new System.EventHandler(this.pnlGeriDon_Click);
            // 
            // lblGeriDon
            // 
            this.lblGeriDon.AutoSize = true;
            this.lblGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGeriDon.ForeColor = System.Drawing.Color.White;
            this.lblGeriDon.Location = new System.Drawing.Point(59, 18);
            this.lblGeriDon.Name = "lblGeriDon";
            this.lblGeriDon.Size = new System.Drawing.Size(85, 24);
            this.lblGeriDon.TabIndex = 1;
            this.lblGeriDon.Text = "Geri Dön";
            this.lblGeriDon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGeriDon.Click += new System.EventHandler(this.lblGeriDon_Click);
            // 
            // picGeriDon
            // 
            this.picGeriDon.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_logout;
            this.picGeriDon.Location = new System.Drawing.Point(3, 3);
            this.picGeriDon.Name = "picGeriDon";
            this.picGeriDon.Size = new System.Drawing.Size(50, 50);
            this.picGeriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGeriDon.TabIndex = 0;
            this.picGeriDon.TabStop = false;
            this.picGeriDon.Click += new System.EventHandler(this.picGeriDon_Click);
            // 
            // pnlKaydet
            // 
            this.pnlKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlKaydet.Controls.Add(this.lblKaydet);
            this.pnlKaydet.Controls.Add(this.picKaydet);
            this.pnlKaydet.Location = new System.Drawing.Point(423, 379);
            this.pnlKaydet.Name = "pnlKaydet";
            this.pnlKaydet.Size = new System.Drawing.Size(133, 56);
            this.pnlKaydet.TabIndex = 16;
            this.pnlKaydet.Click += new System.EventHandler(this.pnlKaydet_Click);
            // 
            // lblKaydet
            // 
            this.lblKaydet.AutoSize = true;
            this.lblKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaydet.ForeColor = System.Drawing.Color.White;
            this.lblKaydet.Location = new System.Drawing.Point(59, 18);
            this.lblKaydet.Name = "lblKaydet";
            this.lblKaydet.Size = new System.Drawing.Size(67, 24);
            this.lblKaydet.TabIndex = 1;
            this.lblKaydet.Text = "Kaydet";
            this.lblKaydet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKaydet.Click += new System.EventHandler(this.lblKaydet_Click);
            // 
            // picKaydet
            // 
            this.picKaydet.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_price;
            this.picKaydet.Location = new System.Drawing.Point(3, 3);
            this.picKaydet.Name = "picKaydet";
            this.picKaydet.Size = new System.Drawing.Size(50, 50);
            this.picKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKaydet.TabIndex = 0;
            this.picKaydet.TabStop = false;
            this.picKaydet.Click += new System.EventHandler(this.picKaydet_Click);
            // 
            // FormFiyatTarife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(33)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(594, 462);
            this.Controls.Add(this.pnlKaydet);
            this.Controls.Add(this.pnlGeriDon);
            this.Controls.Add(this.txtBoxGunluk);
            this.Controls.Add(this.txtBoxSaatlik);
            this.Controls.Add(this.txtBoxBirSaat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(602, 493);
            this.Name = "FormFiyatTarife";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiyatTarifeForm";
            this.Load += new System.EventHandler(this.FormFiyatTarife_Load);
            this.pnlGeriDon.ResumeLayout(false);
            this.pnlGeriDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGeriDon)).EndInit();
            this.pnlKaydet.ResumeLayout(false);
            this.pnlKaydet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKaydet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxBirSaat;
        private System.Windows.Forms.TextBox txtBoxSaatlik;
        private System.Windows.Forms.TextBox txtBoxGunluk;
        private System.Windows.Forms.Panel pnlGeriDon;
        private System.Windows.Forms.Panel pnlKaydet;
        private System.Windows.Forms.Label lblKaydet;
        private System.Windows.Forms.PictureBox picKaydet;
        private System.Windows.Forms.Label lblGeriDon;
        private System.Windows.Forms.PictureBox picGeriDon;
    }
}