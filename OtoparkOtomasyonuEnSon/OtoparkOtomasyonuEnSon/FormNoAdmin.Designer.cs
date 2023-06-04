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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girissaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSet = new OtoparkOtomasyonuEnSon.otoparkDataSet();
            this.arabalarTableAdapter = new OtoparkOtomasyonuEnSon.otoparkDataSetTableAdapters.arabalarTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plakaDataGridViewTextBoxColumn,
            this.telefonnoDataGridViewTextBoxColumn,
            this.girissaatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.arabalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(260, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(497, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonnoDataGridViewTextBoxColumn
            // 
            this.telefonnoDataGridViewTextBoxColumn.DataPropertyName = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.HeaderText = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonnoDataGridViewTextBoxColumn.Name = "telefonnoDataGridViewTextBoxColumn";
            this.telefonnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // girissaatiDataGridViewTextBoxColumn
            // 
            this.girissaatiDataGridViewTextBoxColumn.DataPropertyName = "giris_saati";
            this.girissaatiDataGridViewTextBoxColumn.HeaderText = "giris_saati";
            this.girissaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.girissaatiDataGridViewTextBoxColumn.Name = "girissaatiDataGridViewTextBoxColumn";
            this.girissaatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // arabalarBindingSource
            // 
            this.arabalarBindingSource.DataMember = "arabalar";
            this.arabalarBindingSource.DataSource = this.otoparkDataSet;
            // 
            // otoparkDataSet
            // 
            this.otoparkDataSet.DataSetName = "otoparkDataSet";
            this.otoparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arabalarTableAdapter
            // 
            this.arabalarTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kullanıcı Giriş Ekranına Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormNoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNoAdmin";
            this.Load += new System.EventHandler(this.FormNoAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private otoparkDataSet otoparkDataSet;
        private System.Windows.Forms.BindingSource arabalarBindingSource;
        private otoparkDataSetTableAdapters.arabalarTableAdapter arabalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girissaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}