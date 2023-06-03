namespace OtoparkOtomasyonuEnSon
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.panCikisYap = new System.Windows.Forms.Panel();
            this.lblCikisYap = new System.Windows.Forms.Label();
            this.picCikisYap = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.@__groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlFiyatTarifesi = new System.Windows.Forms.Panel();
            this.lblFiyatTarifesi = new System.Windows.Forms.Label();
            this.picFiyatTarifesi = new System.Windows.Forms.PictureBox();
            this.@__label2 = new System.Windows.Forms.Label();
            this.@__label1 = new System.Windows.Forms.Label();
            this.panCikisYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.@__groupBox1.SuspendLayout();
            this.pnlFiyatTarifesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFiyatTarifesi)).BeginInit();
            this.SuspendLayout();
            // 
            // panCikisYap
            // 
            this.panCikisYap.Controls.Add(this.lblCikisYap);
            this.panCikisYap.Controls.Add(this.picCikisYap);
            this.panCikisYap.Location = new System.Drawing.Point(6, 12);
            this.panCikisYap.Name = "panCikisYap";
            this.panCikisYap.Size = new System.Drawing.Size(133, 56);
            this.panCikisYap.TabIndex = 7;
            this.panCikisYap.Click += new System.EventHandler(this.PanCikisYap_Click);
            this.panCikisYap.MouseEnter += new System.EventHandler(this.PanCikisYap_MouseEnter);
            this.panCikisYap.MouseLeave += new System.EventHandler(this.PanCikisYap_MouseLeave);
            // 
            // lblCikisYap
            // 
            this.lblCikisYap.AutoSize = true;
            this.lblCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisYap.ForeColor = System.Drawing.Color.White;
            this.lblCikisYap.Location = new System.Drawing.Point(59, 18);
            this.lblCikisYap.Name = "lblCikisYap";
            this.lblCikisYap.Size = new System.Drawing.Size(70, 18);
            this.lblCikisYap.TabIndex = 1;
            this.lblCikisYap.Text = "Çıkış Yap";
            this.lblCikisYap.Click += new System.EventHandler(this.LblCikisYap_Click);
            // 
            // picCikisYap
            // 
            this.picCikisYap.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_logout;
            this.picCikisYap.Location = new System.Drawing.Point(3, 3);
            this.picCikisYap.Name = "picCikisYap";
            this.picCikisYap.Size = new System.Drawing.Size(50, 50);
            this.picCikisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCikisYap.TabIndex = 0;
            this.picCikisYap.TabStop = false;
            this.picCikisYap.Click += new System.EventHandler(this.PicCikisYap_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(28)))), ((int)(((byte)(158)))));
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripSaat});
            this.statusStrip.Location = new System.Drawing.Point(0, 421);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(800, 29);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 8;
            // 
            // stripSaat
            // 
            this.stripSaat.BackColor = System.Drawing.Color.Transparent;
            this.stripSaat.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.stripSaat.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stripSaat.ForeColor = System.Drawing.Color.White;
            this.stripSaat.Name = "stripSaat";
            this.stripSaat.Size = new System.Drawing.Size(84, 24);
            this.stripSaat.Text = "Saat: 12.00";
            // 
            // __groupBox1
            // 
            this.@__groupBox1.Controls.Add(this.pnlFiyatTarifesi);
            this.@__groupBox1.Controls.Add(this.@__label2);
            this.@__groupBox1.Controls.Add(this.@__label1);
            this.@__groupBox1.Controls.Add(this.panCikisYap);
            this.@__groupBox1.Location = new System.Drawing.Point(12, 12);
            this.@__groupBox1.Name = "__groupBox1";
            this.@__groupBox1.Size = new System.Drawing.Size(776, 76);
            this.@__groupBox1.TabIndex = 9;
            this.@__groupBox1.TabStop = false;
            // 
            // pnlFiyatTarifesi
            // 
            this.pnlFiyatTarifesi.Controls.Add(this.lblFiyatTarifesi);
            this.pnlFiyatTarifesi.Controls.Add(this.picFiyatTarifesi);
            this.pnlFiyatTarifesi.Location = new System.Drawing.Point(145, 12);
            this.pnlFiyatTarifesi.Name = "pnlFiyatTarifesi";
            this.pnlFiyatTarifesi.Size = new System.Drawing.Size(151, 56);
            this.pnlFiyatTarifesi.TabIndex = 8;
            this.pnlFiyatTarifesi.Click += new System.EventHandler(this.PnlFiyatTarifesi_Click);
            // 
            // lblFiyatTarifesi
            // 
            this.lblFiyatTarifesi.AutoSize = true;
            this.lblFiyatTarifesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyatTarifesi.ForeColor = System.Drawing.Color.White;
            this.lblFiyatTarifesi.Location = new System.Drawing.Point(59, 18);
            this.lblFiyatTarifesi.Name = "lblFiyatTarifesi";
            this.lblFiyatTarifesi.Size = new System.Drawing.Size(91, 18);
            this.lblFiyatTarifesi.TabIndex = 1;
            this.lblFiyatTarifesi.Text = "Fiyat Tarifesi";
            this.lblFiyatTarifesi.Click += new System.EventHandler(this.LblFiyatTarifesi_Click);
            // 
            // picFiyatTarifesi
            // 
            this.picFiyatTarifesi.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_price;
            this.picFiyatTarifesi.Location = new System.Drawing.Point(3, 3);
            this.picFiyatTarifesi.Name = "picFiyatTarifesi";
            this.picFiyatTarifesi.Size = new System.Drawing.Size(50, 50);
            this.picFiyatTarifesi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFiyatTarifesi.TabIndex = 0;
            this.picFiyatTarifesi.TabStop = false;
            this.picFiyatTarifesi.Click += new System.EventHandler(this.PicFiyatTarifesi_Click);
            // 
            // __label2
            // 
            this.@__label2.AutoSize = true;
            this.@__label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.@__label2.ForeColor = System.Drawing.Color.White;
            this.@__label2.Location = new System.Drawing.Point(651, 39);
            this.@__label2.Name = "__label2";
            this.@__label2.Size = new System.Drawing.Size(119, 18);
            this.@__label2.TabIndex = 11;
            this.@__label2.Text = "versiyon 2023.01";
            // 
            // __label1
            // 
            this.@__label1.AutoSize = true;
            this.@__label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.@__label1.ForeColor = System.Drawing.Color.White;
            this.@__label1.Location = new System.Drawing.Point(528, 15);
            this.@__label1.Name = "__label1";
            this.@__label1.Size = new System.Drawing.Size(242, 24);
            this.@__label1.TabIndex = 10;
            this.@__label1.Text = "Otopark Otomasyon Sistemi";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(33)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.@__groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGiris_FormClosed);
            this.panCikisYap.ResumeLayout(false);
            this.panCikisYap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.@__groupBox1.ResumeLayout(false);
            this.@__groupBox1.PerformLayout();
            this.pnlFiyatTarifesi.ResumeLayout(false);
            this.pnlFiyatTarifesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFiyatTarifesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
 
        private System.Windows.Forms.Panel panCikisYap;
        private System.Windows.Forms.PictureBox picCikisYap;
        private System.Windows.Forms.Label lblCikisYap;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stripSaat;

        #endregion

        private System.Windows.Forms.GroupBox __groupBox1;
        private System.Windows.Forms.Label __label1;
        private System.Windows.Forms.Label __label2;
        private System.Windows.Forms.Panel pnlFiyatTarifesi;
        private System.Windows.Forms.Label lblFiyatTarifesi;
        private System.Windows.Forms.PictureBox picFiyatTarifesi;
    }
}