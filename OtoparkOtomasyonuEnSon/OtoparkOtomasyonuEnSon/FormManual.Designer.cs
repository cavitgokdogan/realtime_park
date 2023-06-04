namespace OtoparkOtomasyonuEnSon
{
    partial class FormManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            this.numberPlateTextBox = new System.Windows.Forms.TextBox();
            this.telNoTextBox = new System.Windows.Forms.TextBox();
            this.numberPlateLabel = new System.Windows.Forms.Label();
            this.telNoLabel = new System.Windows.Forms.Label();
            this.entranceDateLabel = new System.Windows.Forms.Label();
            this.entranceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.picCikisYap = new System.Windows.Forms.PictureBox();
            this.lblCikisYap = new System.Windows.Forms.Label();
            this.pnlCikisYap = new System.Windows.Forms.Panel();
            this.pnlKayitOlustur = new System.Windows.Forms.Panel();
            this.lblKayitOlustur = new System.Windows.Forms.Label();
            this.picKayitOlustur = new System.Windows.Forms.PictureBox();
            this.pnlKayitlar = new System.Windows.Forms.Panel();
            this.lblKayitlar = new System.Windows.Forms.Label();
            this.picKayitlar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).BeginInit();
            this.pnlCikisYap.SuspendLayout();
            this.pnlKayitOlustur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKayitOlustur)).BeginInit();
            this.pnlKayitlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // numberPlateTextBox
            // 
            this.numberPlateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numberPlateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(42)))), ((int)(((byte)(235)))));
            this.numberPlateTextBox.ForeColor = System.Drawing.Color.White;
            this.numberPlateTextBox.Location = new System.Drawing.Point(386, 102);
            this.numberPlateTextBox.Name = "numberPlateTextBox";
            this.numberPlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberPlateTextBox.TabIndex = 0;
            // 
            // telNoTextBox
            // 
            this.telNoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.telNoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(42)))), ((int)(((byte)(235)))));
            this.telNoTextBox.ForeColor = System.Drawing.Color.White;
            this.telNoTextBox.Location = new System.Drawing.Point(395, 148);
            this.telNoTextBox.Name = "telNoTextBox";
            this.telNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telNoTextBox.TabIndex = 1;
            // 
            // numberPlateLabel
            // 
            this.numberPlateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numberPlateLabel.AutoSize = true;
            this.numberPlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numberPlateLabel.ForeColor = System.Drawing.Color.White;
            this.numberPlateLabel.Location = new System.Drawing.Point(312, 98);
            this.numberPlateLabel.Name = "numberPlateLabel";
            this.numberPlateLabel.Size = new System.Drawing.Size(67, 25);
            this.numberPlateLabel.TabIndex = 3;
            this.numberPlateLabel.Text = "Plaka:";
            // 
            // telNoLabel
            // 
            this.telNoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.telNoLabel.AutoSize = true;
            this.telNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNoLabel.ForeColor = System.Drawing.Color.White;
            this.telNoLabel.Location = new System.Drawing.Point(273, 143);
            this.telNoLabel.Name = "telNoLabel";
            this.telNoLabel.Size = new System.Drawing.Size(114, 25);
            this.telNoLabel.TabIndex = 4;
            this.telNoLabel.Text = "Telefon No:";
            // 
            // entranceDateLabel
            // 
            this.entranceDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.entranceDateLabel.AutoSize = true;
            this.entranceDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.entranceDateLabel.ForeColor = System.Drawing.Color.White;
            this.entranceDateLabel.Location = new System.Drawing.Point(220, 190);
            this.entranceDateLabel.Name = "entranceDateLabel";
            this.entranceDateLabel.Size = new System.Drawing.Size(107, 25);
            this.entranceDateLabel.TabIndex = 5;
            this.entranceDateLabel.Text = "Giriş Saati:";
            // 
            // entranceDatePicker
            // 
            this.entranceDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.entranceDatePicker.Location = new System.Drawing.Point(328, 194);
            this.entranceDatePicker.Name = "entranceDatePicker";
            this.entranceDatePicker.Size = new System.Drawing.Size(200, 20);
            this.entranceDatePicker.TabIndex = 13;
            this.entranceDatePicker.ValueChanged += new System.EventHandler(this.entranceDate_ValueChanged);
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
            this.picCikisYap.Click += new System.EventHandler(this.goBackButton_Click);
            this.picCikisYap.MouseEnter += new System.EventHandler(this.picCikisYap_MouseEnter);
            this.picCikisYap.MouseLeave += new System.EventHandler(this.picCikisYap_MouseLeave);
            // 
            // lblCikisYap
            // 
            this.lblCikisYap.AutoSize = true;
            this.lblCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisYap.ForeColor = System.Drawing.Color.White;
            this.lblCikisYap.Location = new System.Drawing.Point(59, 18);
            this.lblCikisYap.Name = "lblCikisYap";
            this.lblCikisYap.Size = new System.Drawing.Size(68, 18);
            this.lblCikisYap.TabIndex = 1;
            this.lblCikisYap.Text = "Geri Dön";
            this.lblCikisYap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCikisYap.Click += new System.EventHandler(this.goBackButton_Click);
            this.lblCikisYap.MouseEnter += new System.EventHandler(this.lblCikisYap_MouseEnter);
            this.lblCikisYap.MouseLeave += new System.EventHandler(this.lblCikisYap_MouseLeave);
            // 
            // pnlCikisYap
            // 
            this.pnlCikisYap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlCikisYap.Controls.Add(this.lblCikisYap);
            this.pnlCikisYap.Controls.Add(this.picCikisYap);
            this.pnlCikisYap.Location = new System.Drawing.Point(108, 361);
            this.pnlCikisYap.Name = "pnlCikisYap";
            this.pnlCikisYap.Size = new System.Drawing.Size(133, 56);
            this.pnlCikisYap.TabIndex = 14;
            this.pnlCikisYap.Click += new System.EventHandler(this.goBackButton_Click);
            this.pnlCikisYap.MouseEnter += new System.EventHandler(this.pnlCikisYap_MouseEnter);
            this.pnlCikisYap.MouseLeave += new System.EventHandler(this.pnlCikisYap_MouseLeave);
            // 
            // pnlKayitOlustur
            // 
            this.pnlKayitOlustur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlKayitOlustur.Controls.Add(this.lblKayitOlustur);
            this.pnlKayitOlustur.Controls.Add(this.picKayitOlustur);
            this.pnlKayitOlustur.Location = new System.Drawing.Point(327, 361);
            this.pnlKayitOlustur.Name = "pnlKayitOlustur";
            this.pnlKayitOlustur.Size = new System.Drawing.Size(151, 56);
            this.pnlKayitOlustur.TabIndex = 15;
            this.pnlKayitOlustur.Click += new System.EventHandler(this.createRegistryButton_Click);
            this.pnlKayitOlustur.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKayitOlustur_Paint);
            this.pnlKayitOlustur.MouseEnter += new System.EventHandler(this.pnlKayitOlustur_MouseEnter);
            this.pnlKayitOlustur.MouseLeave += new System.EventHandler(this.pnlKayitOlustur_MouseLeave);
            // 
            // lblKayitOlustur
            // 
            this.lblKayitOlustur.AutoSize = true;
            this.lblKayitOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitOlustur.ForeColor = System.Drawing.Color.White;
            this.lblKayitOlustur.Location = new System.Drawing.Point(59, 18);
            this.lblKayitOlustur.Name = "lblKayitOlustur";
            this.lblKayitOlustur.Size = new System.Drawing.Size(92, 18);
            this.lblKayitOlustur.TabIndex = 1;
            this.lblKayitOlustur.Text = "Kayıt Oluştur";
            this.lblKayitOlustur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKayitOlustur.Click += new System.EventHandler(this.createRegistryButton_Click);
            this.lblKayitOlustur.MouseEnter += new System.EventHandler(this.lblKayitOlustur_MouseEnter);
            this.lblKayitOlustur.MouseLeave += new System.EventHandler(this.lblKayitOlustur_MouseLeave);
            // 
            // picKayitOlustur
            // 
            this.picKayitOlustur.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_car;
            this.picKayitOlustur.Location = new System.Drawing.Point(3, 3);
            this.picKayitOlustur.Name = "picKayitOlustur";
            this.picKayitOlustur.Size = new System.Drawing.Size(50, 50);
            this.picKayitOlustur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKayitOlustur.TabIndex = 0;
            this.picKayitOlustur.TabStop = false;
            this.picKayitOlustur.Click += new System.EventHandler(this.createRegistryButton_Click);
            this.picKayitOlustur.MouseEnter += new System.EventHandler(this.picKayitOlustur_MouseEnter);
            this.picKayitOlustur.MouseLeave += new System.EventHandler(this.picKayitOlustur_MouseLeave);
            // 
            // pnlKayitlar
            // 
            this.pnlKayitlar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlKayitlar.Controls.Add(this.lblKayitlar);
            this.pnlKayitlar.Controls.Add(this.picKayitlar);
            this.pnlKayitlar.Location = new System.Drawing.Point(566, 361);
            this.pnlKayitlar.Name = "pnlKayitlar";
            this.pnlKayitlar.Size = new System.Drawing.Size(151, 56);
            this.pnlKayitlar.TabIndex = 16;
            this.pnlKayitlar.Click += new System.EventHandler(this.registryPageButton_Click);
            this.pnlKayitlar.MouseEnter += new System.EventHandler(this.pnlKayitlar_MouseEnter);
            this.pnlKayitlar.MouseLeave += new System.EventHandler(this.pnlKayitlar_MouseLeave);
            // 
            // lblKayitlar
            // 
            this.lblKayitlar.AutoSize = true;
            this.lblKayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitlar.ForeColor = System.Drawing.Color.White;
            this.lblKayitlar.Location = new System.Drawing.Point(59, 18);
            this.lblKayitlar.Name = "lblKayitlar";
            this.lblKayitlar.Size = new System.Drawing.Size(56, 18);
            this.lblKayitlar.TabIndex = 1;
            this.lblKayitlar.Text = "Kayıtlar";
            this.lblKayitlar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKayitlar.Click += new System.EventHandler(this.registryPageButton_Click);
            this.lblKayitlar.MouseEnter += new System.EventHandler(this.lblKayitlar_MouseEnter);
            this.lblKayitlar.MouseLeave += new System.EventHandler(this.lblKayitlar_MouseLeave);
            // 
            // picKayitlar
            // 
            this.picKayitlar.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_ledger;
            this.picKayitlar.Location = new System.Drawing.Point(3, 3);
            this.picKayitlar.Name = "picKayitlar";
            this.picKayitlar.Size = new System.Drawing.Size(50, 50);
            this.picKayitlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKayitlar.TabIndex = 0;
            this.picKayitlar.TabStop = false;
            this.picKayitlar.Click += new System.EventHandler(this.registryPageButton_Click);
            this.picKayitlar.MouseEnter += new System.EventHandler(this.picKayitlar_MouseEnter);
            this.picKayitlar.MouseLeave += new System.EventHandler(this.picKayitlar_MouseLeave);
            // 
            // FormManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(33)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(792, 469);
            this.Controls.Add(this.pnlKayitlar);
            this.Controls.Add(this.pnlKayitOlustur);
            this.Controls.Add(this.pnlCikisYap);
            this.Controls.Add(this.entranceDatePicker);
            this.Controls.Add(this.entranceDateLabel);
            this.Controls.Add(this.telNoLabel);
            this.Controls.Add(this.numberPlateLabel);
            this.Controls.Add(this.telNoTextBox);
            this.Controls.Add(this.numberPlateTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(602, 493);
            this.Name = "FormManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManualForm";
            this.Load += new System.EventHandler(this.FormManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).EndInit();
            this.pnlCikisYap.ResumeLayout(false);
            this.pnlCikisYap.PerformLayout();
            this.pnlKayitOlustur.ResumeLayout(false);
            this.pnlKayitOlustur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKayitOlustur)).EndInit();
            this.pnlKayitlar.ResumeLayout(false);
            this.pnlKayitlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKayitlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberPlateTextBox;
        private System.Windows.Forms.TextBox telNoTextBox;
        private System.Windows.Forms.Label numberPlateLabel;
        private System.Windows.Forms.Label telNoLabel;
        private System.Windows.Forms.Label entranceDateLabel;
        private System.Windows.Forms.DateTimePicker entranceDatePicker;
        private System.Windows.Forms.PictureBox picCikisYap;
        private System.Windows.Forms.Label lblCikisYap;
        private System.Windows.Forms.Panel pnlCikisYap;
        private System.Windows.Forms.Panel pnlKayitOlustur;
        private System.Windows.Forms.Label lblKayitOlustur;
        private System.Windows.Forms.PictureBox picKayitOlustur;
        private System.Windows.Forms.Panel pnlKayitlar;
        private System.Windows.Forms.Label lblKayitlar;
        private System.Windows.Forms.PictureBox picKayitlar;
    }
}