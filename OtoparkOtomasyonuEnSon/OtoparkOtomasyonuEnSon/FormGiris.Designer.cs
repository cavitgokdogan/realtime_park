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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panCikisYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panCikisYap.Paint += new System.Windows.Forms.PaintEventHandler(this.PanCikisYap_Paint);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panCikisYap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 76);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(528, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Otopark Otomasyon Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(651, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "versiyon 2023.01";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(33)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
 
        private System.Windows.Forms.Panel panCikisYap;
        private System.Windows.Forms.PictureBox picCikisYap;
        private System.Windows.Forms.Label lblCikisYap;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stripSaat;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}