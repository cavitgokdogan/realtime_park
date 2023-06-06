namespace OtoparkOtomasyonuEnSon
{
    partial class FormTumKayitlar
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
            this.registryGridView = new System.Windows.Forms.DataGridView();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girissaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logArabalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tumKayitlar = new OtoparkOtomasyonuEnSon.tumKayitlar();
            this.arabalarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSet4 = new OtoparkOtomasyonuEnSon.otoparkDataSet4();
            this.arabalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arabalarTableAdapter = new OtoparkOtomasyonuEnSon.otoparkDataSet4TableAdapters.arabalarTableAdapter();
            this.otoparkDataSet = new OtoparkOtomasyonuEnSon.otoparkDataSet();
            this.arabalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.arabalarTableAdapter1 = new OtoparkOtomasyonuEnSon.otoparkDataSetTableAdapters.arabalarTableAdapter();
            this.pnlCikisYap = new System.Windows.Forms.Panel();
            this.lblCikisYap = new System.Windows.Forms.Label();
            this.picCikisYap = new System.Windows.Forms.PictureBox();
            this.logArabalarTableAdapter = new OtoparkOtomasyonuEnSon.tumKayitlarTableAdapters.logArabalarTableAdapter();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stripKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.@__groupBox1 = new System.Windows.Forms.GroupBox();
            this.@__label2 = new System.Windows.Forms.Label();
            this.@__label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logArabalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumKayitlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource1)).BeginInit();
            this.pnlCikisYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.@__groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registryGridView
            // 
            this.registryGridView.AllowUserToAddRows = false;
            this.registryGridView.AllowUserToDeleteRows = false;
            this.registryGridView.AllowUserToOrderColumns = true;
            this.registryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registryGridView.AutoGenerateColumns = false;
            this.registryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(42)))), ((int)(((byte)(235)))));
            this.registryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plakaDataGridViewTextBoxColumn,
            this.telefonnoDataGridViewTextBoxColumn,
            this.girissaatiDataGridViewTextBoxColumn});
            this.registryGridView.DataSource = this.logArabalarBindingSource;
            this.registryGridView.Location = new System.Drawing.Point(13, 119);
            this.registryGridView.Margin = new System.Windows.Forms.Padding(5);
            this.registryGridView.Name = "registryGridView";
            this.registryGridView.ReadOnly = true;
            this.registryGridView.RowHeadersWidth = 51;
            this.registryGridView.Size = new System.Drawing.Size(1155, 478);
            this.registryGridView.TabIndex = 1;
            this.registryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registryGridView_CellContentClick);
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonnoDataGridViewTextBoxColumn
            // 
            this.telefonnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonnoDataGridViewTextBoxColumn.DataPropertyName = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.HeaderText = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonnoDataGridViewTextBoxColumn.Name = "telefonnoDataGridViewTextBoxColumn";
            this.telefonnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // girissaatiDataGridViewTextBoxColumn
            // 
            this.girissaatiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.girissaatiDataGridViewTextBoxColumn.DataPropertyName = "giris_saati";
            this.girissaatiDataGridViewTextBoxColumn.HeaderText = "giris_saati";
            this.girissaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.girissaatiDataGridViewTextBoxColumn.Name = "girissaatiDataGridViewTextBoxColumn";
            this.girissaatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logArabalarBindingSource
            // 
            this.logArabalarBindingSource.DataMember = "logArabalar";
            this.logArabalarBindingSource.DataSource = this.tumKayitlar;
            // 
            // tumKayitlar
            // 
            this.tumKayitlar.DataSetName = "tumKayitlar";
            this.tumKayitlar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arabalarBindingSource2
            // 
            this.arabalarBindingSource2.DataMember = "arabalar";
            this.arabalarBindingSource2.DataSource = this.otoparkDataSet4BindingSource;
            // 
            // otoparkDataSet4BindingSource
            // 
            this.otoparkDataSet4BindingSource.DataSource = this.otoparkDataSet4;
            this.otoparkDataSet4BindingSource.Position = 0;
            // 
            // otoparkDataSet4
            // 
            this.otoparkDataSet4.DataSetName = "otoparkDataSet4";
            this.otoparkDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arabalarBindingSource
            // 
            this.arabalarBindingSource.DataMember = "arabalar";
            this.arabalarBindingSource.DataSource = this.otoparkDataSet4;
            // 
            // arabalarTableAdapter
            // 
            this.arabalarTableAdapter.ClearBeforeFill = true;
            // 
            // otoparkDataSet
            // 
            this.otoparkDataSet.DataSetName = "otoparkDataSet";
            this.otoparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arabalarBindingSource1
            // 
            this.arabalarBindingSource1.DataMember = "arabalar";
            this.arabalarBindingSource1.DataSource = this.otoparkDataSet;
            // 
            // arabalarTableAdapter1
            // 
            this.arabalarTableAdapter1.ClearBeforeFill = true;
            // 
            // pnlCikisYap
            // 
            this.pnlCikisYap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCikisYap.Controls.Add(this.lblCikisYap);
            this.pnlCikisYap.Controls.Add(this.picCikisYap);
            this.pnlCikisYap.Location = new System.Drawing.Point(9, 17);
            this.pnlCikisYap.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCikisYap.Name = "pnlCikisYap";
            this.pnlCikisYap.Size = new System.Drawing.Size(318, 71);
            this.pnlCikisYap.TabIndex = 14;
            this.pnlCikisYap.Click += new System.EventHandler(this.picCikisYap_Click);
            this.pnlCikisYap.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCikisYap_Paint);
            this.pnlCikisYap.MouseEnter += new System.EventHandler(this.pnlCikisYap_MouseEnter);
            this.pnlCikisYap.MouseLeave += new System.EventHandler(this.pnlCikisYap_MouseLeave);
            // 
            // lblCikisYap
            // 
            this.lblCikisYap.AutoSize = true;
            this.lblCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisYap.ForeColor = System.Drawing.Color.White;
            this.lblCikisYap.Location = new System.Drawing.Point(79, 22);
            this.lblCikisYap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCikisYap.Name = "lblCikisYap";
            this.lblCikisYap.Size = new System.Drawing.Size(85, 24);
            this.lblCikisYap.TabIndex = 1;
            this.lblCikisYap.Text = "Geri Dön";
            this.lblCikisYap.Click += new System.EventHandler(this.picCikisYap_Click);
            this.lblCikisYap.MouseEnter += new System.EventHandler(this.lblCikisYap_MouseEnter);
            this.lblCikisYap.MouseLeave += new System.EventHandler(this.lblCikisYap_MouseLeave);
            // 
            // picCikisYap
            // 
            this.picCikisYap.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_logout;
            this.picCikisYap.Location = new System.Drawing.Point(4, 4);
            this.picCikisYap.Margin = new System.Windows.Forms.Padding(4);
            this.picCikisYap.Name = "picCikisYap";
            this.picCikisYap.Size = new System.Drawing.Size(67, 62);
            this.picCikisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCikisYap.TabIndex = 0;
            this.picCikisYap.TabStop = false;
            this.picCikisYap.Click += new System.EventHandler(this.picCikisYap_Click);
            this.picCikisYap.MouseEnter += new System.EventHandler(this.picCikisYap_MouseEnter);
            this.picCikisYap.MouseLeave += new System.EventHandler(this.picCikisYap_MouseLeave);
            // 
            // logArabalarTableAdapter
            // 
            this.logArabalarTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(28)))), ((int)(((byte)(158)))));
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripKullanici,
            this.toolStripStatusLabel1,
            this.stripSaat});
            this.statusStrip.Location = new System.Drawing.Point(0, 618);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1182, 35);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 17;
            // 
            // stripKullanici
            // 
            this.stripKullanici.ForeColor = System.Drawing.Color.White;
            this.stripKullanici.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_admin;
            this.stripKullanici.Name = "stripKullanici";
            this.stripKullanici.Size = new System.Drawing.Size(87, 29);
            this.stripKullanici.Text = "Admin";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(950, 29);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // stripSaat
            // 
            this.stripSaat.BackColor = System.Drawing.Color.Transparent;
            this.stripSaat.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.stripSaat.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stripSaat.ForeColor = System.Drawing.Color.White;
            this.stripSaat.Image = global::OtoparkOtomasyonuEnSon.Properties.Resources.icon_clock;
            this.stripSaat.Name = "stripSaat";
            this.stripSaat.Size = new System.Drawing.Size(125, 29);
            this.stripSaat.Text = "Saat: 12.00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // __groupBox1
            // 
            this.@__groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.@__groupBox1.Controls.Add(this.@__label2);
            this.@__groupBox1.Controls.Add(this.@__label1);
            this.@__groupBox1.Controls.Add(this.pnlCikisYap);
            this.@__groupBox1.Location = new System.Drawing.Point(13, 13);
            this.@__groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.@__groupBox1.Name = "__groupBox1";
            this.@__groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.@__groupBox1.Size = new System.Drawing.Size(1156, 97);
            this.@__groupBox1.TabIndex = 22;
            this.@__groupBox1.TabStop = false;
            // 
            // __label2
            // 
            this.@__label2.AutoSize = true;
            this.@__label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.@__label2.ForeColor = System.Drawing.Color.White;
            this.@__label2.Location = new System.Drawing.Point(990, 52);
            this.@__label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.@__label2.Name = "__label2";
            this.@__label2.Size = new System.Drawing.Size(150, 24);
            this.@__label2.TabIndex = 11;
            this.@__label2.Text = "versiyon 2023.01";
            // 
            // __label1
            // 
            this.@__label1.AutoSize = true;
            this.@__label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.@__label1.ForeColor = System.Drawing.Color.White;
            this.@__label1.Location = new System.Drawing.Point(827, 23);
            this.@__label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.@__label1.Name = "__label1";
            this.@__label1.Size = new System.Drawing.Size(313, 29);
            this.@__label1.TabIndex = 10;
            this.@__label1.Text = "Otopark Otomasyon Sistemi";
            // 
            // FormTumKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(33)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.@__groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.registryGridView);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FormTumKayitlar";
            this.Text = "FormTumKayitlar";
            this.Load += new System.EventHandler(this.FormTumKayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logArabalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumKayitlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource1)).EndInit();
            this.pnlCikisYap.ResumeLayout(false);
            this.pnlCikisYap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.@__groupBox1.ResumeLayout(false);
            this.@__groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView registryGridView;
        private System.Windows.Forms.BindingSource otoparkDataSet4BindingSource;
        private otoparkDataSet4 otoparkDataSet4;
        private System.Windows.Forms.BindingSource arabalarBindingSource;
        private otoparkDataSet4TableAdapters.arabalarTableAdapter arabalarTableAdapter;
        private otoparkDataSet otoparkDataSet;
        private System.Windows.Forms.BindingSource arabalarBindingSource1;
        private otoparkDataSetTableAdapters.arabalarTableAdapter arabalarTableAdapter1;
        private System.Windows.Forms.BindingSource arabalarBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girissaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlCikisYap;
        private System.Windows.Forms.Label lblCikisYap;
        private System.Windows.Forms.PictureBox picCikisYap;
        private tumKayitlar tumKayitlar;
        private System.Windows.Forms.BindingSource logArabalarBindingSource;
        private tumKayitlarTableAdapters.logArabalarTableAdapter logArabalarTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stripKullanici;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stripSaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox __groupBox1;
        private System.Windows.Forms.Label __label2;
        private System.Windows.Forms.Label __label1;
    }
}