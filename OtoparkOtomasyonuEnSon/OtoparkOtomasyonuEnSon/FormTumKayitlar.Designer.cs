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
            this.otoparkDataSet4 = new OtoparkOtomasyonuEnSon.otoparkDataSet4();
            this.otoparkDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arabalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arabalarTableAdapter = new OtoparkOtomasyonuEnSon.otoparkDataSet4TableAdapters.arabalarTableAdapter();
            this.otoparkDataSet = new OtoparkOtomasyonuEnSon.otoparkDataSet();
            this.arabalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.arabalarTableAdapter1 = new OtoparkOtomasyonuEnSon.otoparkDataSetTableAdapters.arabalarTableAdapter();
            this.arabalarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girissaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCikisYap = new System.Windows.Forms.Panel();
            this.lblCikisYap = new System.Windows.Forms.Label();
            this.picCikisYap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.registryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource2)).BeginInit();
            this.pnlCikisYap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).BeginInit();
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
            this.registryGridView.DataSource = this.arabalarBindingSource2;
            this.registryGridView.Location = new System.Drawing.Point(197, 37);
            this.registryGridView.Margin = new System.Windows.Forms.Padding(5);
            this.registryGridView.Name = "registryGridView";
            this.registryGridView.ReadOnly = true;
            this.registryGridView.RowHeadersWidth = 51;
            this.registryGridView.Size = new System.Drawing.Size(1048, 514);
            this.registryGridView.TabIndex = 1;
            // 
            // otoparkDataSet4
            // 
            this.otoparkDataSet4.DataSetName = "otoparkDataSet4";
            this.otoparkDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otoparkDataSet4BindingSource
            // 
            this.otoparkDataSet4BindingSource.DataSource = this.otoparkDataSet4;
            this.otoparkDataSet4BindingSource.Position = 0;
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
            // arabalarBindingSource2
            // 
            this.arabalarBindingSource2.DataMember = "arabalar";
            this.arabalarBindingSource2.DataSource = this.otoparkDataSet4BindingSource;
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
            // pnlCikisYap
            // 
            this.pnlCikisYap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCikisYap.Controls.Add(this.lblCikisYap);
            this.pnlCikisYap.Controls.Add(this.picCikisYap);
            this.pnlCikisYap.Location = new System.Drawing.Point(560, 585);
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
            // FormTumKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(33)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1423, 683);
            this.Controls.Add(this.pnlCikisYap);
            this.Controls.Add(this.registryGridView);
            this.MaximumSize = new System.Drawing.Size(1441, 730);
            this.Name = "FormTumKayitlar";
            this.Text = "FormTumKayitlar";
            this.Load += new System.EventHandler(this.FormTumKayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource2)).EndInit();
            this.pnlCikisYap.ResumeLayout(false);
            this.pnlCikisYap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCikisYap)).EndInit();
            this.ResumeLayout(false);

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
    }
}