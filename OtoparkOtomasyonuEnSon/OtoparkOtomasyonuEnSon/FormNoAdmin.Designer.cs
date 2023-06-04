namespace OtoparkOtomasyonuEnSon
{
    partial class FormNoAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoAdmin));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.@__groupBox1 = new System.Windows.Forms.GroupBox();
            this.@__label2 = new System.Windows.Forms.Label();
            this.@__label1 = new System.Windows.Forms.Label();
            this.pnlCikisYap = new System.Windows.Forms.Panel();
            this.lblCikisYap = new System.Windows.Forms.Label();
            this.picCikisYap = new System.Windows.Forms.PictureBox();
            this.@__groupBox2 = new System.Windows.Forms.GroupBox();
            this.tablo = new System.Windows.Forms.DataGridView();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girissaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSet4 = new OtoparkOtomasyonuEnSon.otoparkDataSet4();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.arabalarTableAdapter = new OtoparkOtomasyonuEnSon.otoparkDataSet4TableAdapters.arabalarTableAdapter();
            this.statusStrip.SuspendLayout();
            this.@__groupBox1.SuspendLayout();
            this.pnlCikisYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).BeginInit();
            this.@__groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(28)))), ((int)(((byte)(158)))));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripKullanici,
            this.toolStripStatusLabel1,
            this.stripSaat});
            this.statusStrip.Location = new System.Drawing.Point(0, 444);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(792, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // stripKullanici
            // 
            this.stripKullanici.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stripKullanici.ForeColor = System.Drawing.Color.White;
            this.stripKullanici.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_user;
            this.stripKullanici.Name = "stripKullanici";
            this.stripKullanici.Size = new System.Drawing.Size(85, 20);
            this.stripKullanici.Text = "Kullanıcı";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(592, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // stripSaat
            // 
            this.stripSaat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stripSaat.ForeColor = System.Drawing.Color.White;
            this.stripSaat.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_clock;
            this.stripSaat.Name = "stripSaat";
            this.stripSaat.Size = new System.Drawing.Size(100, 20);
            this.stripSaat.Text = "Saat: 12:00";
            // 
            // __groupBox1
            // 
            this.@__groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.@__groupBox1.Controls.Add(this.@__label2);
            this.@__groupBox1.Controls.Add(this.@__label1);
            this.@__groupBox1.Controls.Add(this.pnlCikisYap);
            this.@__groupBox1.Location = new System.Drawing.Point(12, 12);
            this.@__groupBox1.Name = "__groupBox1";
            this.@__groupBox1.Size = new System.Drawing.Size(768, 76);
            this.@__groupBox1.TabIndex = 10;
            this.@__groupBox1.TabStop = false;
            // 
            // __label2
            // 
            this.@__label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.@__label2.AutoSize = true;
            this.@__label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.@__label2.ForeColor = System.Drawing.Color.White;
            this.@__label2.Location = new System.Drawing.Point(643, 39);
            this.@__label2.Name = "__label2";
            this.@__label2.Size = new System.Drawing.Size(119, 18);
            this.@__label2.TabIndex = 11;
            this.@__label2.Text = "versiyon 2023.01";
            this.@__label2.Click += new System.EventHandler(this.@__label2_Click);
            // 
            // __label1
            // 
            this.@__label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.@__label1.AutoSize = true;
            this.@__label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.@__label1.ForeColor = System.Drawing.Color.White;
            this.@__label1.Location = new System.Drawing.Point(520, 15);
            this.@__label1.Name = "__label1";
            this.@__label1.Size = new System.Drawing.Size(242, 24);
            this.@__label1.TabIndex = 10;
            this.@__label1.Text = "Otopark Otomasyon Sistemi";
            this.@__label1.Click += new System.EventHandler(this.@__label1_Click);
            // 
            // pnlCikisYap
            // 
            this.pnlCikisYap.Controls.Add(this.lblCikisYap);
            this.pnlCikisYap.Controls.Add(this.picCikisYap);
            this.pnlCikisYap.Location = new System.Drawing.Point(6, 12);
            this.pnlCikisYap.Name = "pnlCikisYap";
            this.pnlCikisYap.Size = new System.Drawing.Size(133, 56);
            this.pnlCikisYap.TabIndex = 7;
            this.pnlCikisYap.MouseEnter += new System.EventHandler(this.PnlCikisYap_MouseEnter);
            this.pnlCikisYap.MouseLeave += new System.EventHandler(this.PnlCikisYap_MouseLeave);
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
            this.lblCikisYap.MouseEnter += new System.EventHandler(this.LblCikisYap_MouseEnter);
            this.lblCikisYap.MouseLeave += new System.EventHandler(this.LblCikisYap_MouseLeave);
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
            this.picCikisYap.MouseEnter += new System.EventHandler(this.PicCikisYap_MouseEnter);
            this.picCikisYap.MouseLeave += new System.EventHandler(this.PicCikisYap_MouseLeave);
            // 
            // __groupBox2
            // 
            this.@__groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.@__groupBox2.Controls.Add(this.tablo);
            this.@__groupBox2.Location = new System.Drawing.Point(12, 94);
            this.@__groupBox2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.@__groupBox2.Name = "__groupBox2";
            this.@__groupBox2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.@__groupBox2.Size = new System.Drawing.Size(768, 347);
            this.@__groupBox2.TabIndex = 11;
            this.@__groupBox2.TabStop = false;
            // 
            // tablo
            // 
            this.tablo.AllowUserToAddRows = false;
            this.tablo.AllowUserToDeleteRows = false;
            this.tablo.AutoGenerateColumns = false;
            this.tablo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(42)))), ((int)(((byte)(235)))));
            this.tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plakaDataGridViewTextBoxColumn,
            this.telefonnoDataGridViewTextBoxColumn,
            this.girissaatiDataGridViewTextBoxColumn});
            this.tablo.DataSource = this.arabalarBindingSource;
            this.tablo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablo.Location = new System.Drawing.Point(3, 13);
            this.tablo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tablo.Name = "tablo";
            this.tablo.RowHeadersWidth = 51;
            this.tablo.Size = new System.Drawing.Size(762, 331);
            this.tablo.TabIndex = 1;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // telefonnoDataGridViewTextBoxColumn
            // 
            this.telefonnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonnoDataGridViewTextBoxColumn.DataPropertyName = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.telefonnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonnoDataGridViewTextBoxColumn.Name = "telefonnoDataGridViewTextBoxColumn";
            // 
            // girissaatiDataGridViewTextBoxColumn
            // 
            this.girissaatiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.girissaatiDataGridViewTextBoxColumn.DataPropertyName = "giris_saati";
            this.girissaatiDataGridViewTextBoxColumn.HeaderText = "Giriş Saati";
            this.girissaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.girissaatiDataGridViewTextBoxColumn.Name = "girissaatiDataGridViewTextBoxColumn";
            // 
            // arabalarBindingSource
            // 
            this.arabalarBindingSource.DataMember = "arabalar";
            this.arabalarBindingSource.DataSource = this.otoparkDataSet4;
            // 
            // otoparkDataSet4
            // 
            this.otoparkDataSet4.DataSetName = "otoparkDataSet4";
            this.otoparkDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // arabalarTableAdapter
            // 
            this.arabalarTableAdapter.ClearBeforeFill = true;
            // 
            // FormNoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(33)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(792, 469);
            this.Controls.Add(this.@__groupBox2);
            this.Controls.Add(this.@__groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormNoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNoAdmin";
            this.Load += new System.EventHandler(this.FormNoAdmin_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.@__groupBox1.ResumeLayout(false);
            this.@__groupBox1.PerformLayout();
            this.pnlCikisYap.ResumeLayout(false);
            this.pnlCikisYap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).EndInit();
            this.@__groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private otoparkDataSet4 otoparkDataSet4;
        private System.Windows.Forms.BindingSource arabalarBindingSource;
        private otoparkDataSet4TableAdapters.arabalarTableAdapter arabalarTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stripKullanici;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stripSaat;
        private System.Windows.Forms.GroupBox __groupBox1;
        private System.Windows.Forms.Label __label2;
        private System.Windows.Forms.Label __label1;
        private System.Windows.Forms.Panel pnlCikisYap;
        private System.Windows.Forms.Label lblCikisYap;
        private System.Windows.Forms.PictureBox picCikisYap;
        private System.Windows.Forms.GroupBox __groupBox2;
        private System.Windows.Forms.DataGridView tablo;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girissaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer;
    }
}