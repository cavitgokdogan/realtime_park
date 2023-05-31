namespace OtoparkOtomasyonuEnSon
{
    partial class FormKayitlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKayitlar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girissaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabalarBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSet5 = new OtoparkOtomasyonuEnSon.otoparkDataSet5();
            this.arabalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSet = new OtoparkOtomasyonuEnSon.otoparkDataSet();
            this.arabalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.arabalarTableAdapter = new OtoparkOtomasyonuEnSon.otoparkDataSetTableAdapters.arabalarTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.arabalarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSet4 = new OtoparkOtomasyonuEnSon.otoparkDataSet4();
            this.arabalarBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.arabalarTableAdapter1 = new OtoparkOtomasyonuEnSon.otoparkDataSet4TableAdapters.arabalarTableAdapter();
            this.arabalarTableAdapter2 = new OtoparkOtomasyonuEnSon.otoparkDataSet5TableAdapters.arabalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plakaDataGridViewTextBoxColumn,
            this.telefonnoDataGridViewTextBoxColumn,
            this.girissaatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.arabalarBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(183, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(373, 334);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonnoDataGridViewTextBoxColumn
            // 
            this.telefonnoDataGridViewTextBoxColumn.DataPropertyName = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.HeaderText = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.Name = "telefonnoDataGridViewTextBoxColumn";
            this.telefonnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // girissaatiDataGridViewTextBoxColumn
            // 
            this.girissaatiDataGridViewTextBoxColumn.DataPropertyName = "giris_saati";
            this.girissaatiDataGridViewTextBoxColumn.HeaderText = "giris_saati";
            this.girissaatiDataGridViewTextBoxColumn.Name = "girissaatiDataGridViewTextBoxColumn";
            this.girissaatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arabalarBindingSource4
            // 
            this.arabalarBindingSource4.DataMember = "arabalar";
            this.arabalarBindingSource4.DataSource = this.otoparkDataSet5;
            // 
            // otoparkDataSet5
            // 
            this.otoparkDataSet5.DataSetName = "otoparkDataSet5";
            this.otoparkDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arabalarBindingSource1
            // 
            this.arabalarBindingSource1.DataMember = "arabalar";
            this.arabalarBindingSource1.DataSource = this.otoparkDataSetBindingSource;
            // 
            // otoparkDataSetBindingSource
            // 
            this.otoparkDataSetBindingSource.DataSource = this.otoparkDataSet;
            this.otoparkDataSetBindingSource.Position = 0;
            // 
            // otoparkDataSet
            // 
            this.otoparkDataSet.DataSetName = "otoparkDataSet";
            this.otoparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arabalarBindingSource
            // 
            this.arabalarBindingSource.DataMember = "arabalar";
            this.arabalarBindingSource.DataSource = this.otoparkDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Manuel Giriş Sayfası";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 4;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // arabalarTableAdapter
            // 
            this.arabalarTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Kayıtları Yenile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 44);
            this.button4.TabIndex = 6;
            this.button4.Text = "Araç Çıkış Yap";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(608, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plaka: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(594, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tel No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(558, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giriş Saati: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(688, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(688, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // arabalarBindingSource2
            // 
            this.arabalarBindingSource2.DataMember = "arabalar";
            this.arabalarBindingSource2.DataSource = this.otoparkDataSet;
            // 
            // otoparkDataSet4
            // 
            this.otoparkDataSet4.DataSetName = "otoparkDataSet4";
            this.otoparkDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arabalarBindingSource3
            // 
            this.arabalarBindingSource3.DataMember = "arabalar";
            this.arabalarBindingSource3.DataSource = this.otoparkDataSet4;
            // 
            // arabalarTableAdapter1
            // 
            this.arabalarTableAdapter1.ClearBeforeFill = true;
            // 
            // arabalarTableAdapter2
            // 
            this.arabalarTableAdapter2.ClearBeforeFill = true;
            // 
            // FormKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKayitlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKayitlar";
            this.Load += new System.EventHandler(this.FormKayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private otoparkDataSet otoparkDataSet;
        private System.Windows.Forms.BindingSource arabalarBindingSource;
        private otoparkDataSetTableAdapters.arabalarTableAdapter arabalarTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource arabalarBindingSource1;
        private System.Windows.Forms.BindingSource otoparkDataSetBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource arabalarBindingSource2;
        private otoparkDataSet4 otoparkDataSet4;
        private System.Windows.Forms.BindingSource arabalarBindingSource3;
        private otoparkDataSet4TableAdapters.arabalarTableAdapter arabalarTableAdapter1;
        private otoparkDataSet5 otoparkDataSet5;
        private System.Windows.Forms.BindingSource arabalarBindingSource4;
        private otoparkDataSet5TableAdapters.arabalarTableAdapter arabalarTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girissaatiDataGridViewTextBoxColumn;
    }
}