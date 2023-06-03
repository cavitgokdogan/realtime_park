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
            this.registryGridView = new System.Windows.Forms.DataGridView();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girissaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arabalarBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSet4 = new OtoparkOtomasyonuEnSon.otoparkDataSet4();
            this.arabalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSet = new OtoparkOtomasyonuEnSon.otoparkDataSet();
            this.arabalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manualFormButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.arabalarTableAdapter = new OtoparkOtomasyonuEnSon.otoparkDataSetTableAdapters.arabalarTableAdapter();
            this.refreshButton = new System.Windows.Forms.Button();
            this.carExitButton = new System.Windows.Forms.Button();
            this.numberPlateLabel = new System.Windows.Forms.Label();
            this.telNoLabel = new System.Windows.Forms.Label();
            this.entranceDateLabel = new System.Windows.Forms.Label();
            this.numberPlateTextBox = new System.Windows.Forms.TextBox();
            this.telNoTextBox = new System.Windows.Forms.TextBox();
            this.entranceDateTextBox = new System.Windows.Forms.TextBox();
            this.arabalarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.arabalarBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.arabalarTableAdapter1 = new OtoparkOtomasyonuEnSon.otoparkDataSet4TableAdapters.arabalarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.registryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource3)).BeginInit();
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
            this.registryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plakaDataGridViewTextBoxColumn,
            this.telefonnoDataGridViewTextBoxColumn,
            this.girissaatiDataGridViewTextBoxColumn});
            this.registryGridView.DataSource = this.arabalarBindingSource4;
            this.registryGridView.Location = new System.Drawing.Point(244, 34);
            this.registryGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registryGridView.Name = "registryGridView";
            this.registryGridView.ReadOnly = true;
            this.registryGridView.RowHeadersWidth = 51;
            this.registryGridView.Size = new System.Drawing.Size(497, 411);
            this.registryGridView.TabIndex = 0;
            this.registryGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registryGridView_CellDoubleClick);
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.ReadOnly = true;
            this.plakaDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonnoDataGridViewTextBoxColumn
            // 
            this.telefonnoDataGridViewTextBoxColumn.DataPropertyName = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.HeaderText = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonnoDataGridViewTextBoxColumn.Name = "telefonnoDataGridViewTextBoxColumn";
            this.telefonnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // girissaatiDataGridViewTextBoxColumn
            // 
            this.girissaatiDataGridViewTextBoxColumn.DataPropertyName = "giris_saati";
            this.girissaatiDataGridViewTextBoxColumn.HeaderText = "giris_saati";
            this.girissaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.girissaatiDataGridViewTextBoxColumn.Name = "girissaatiDataGridViewTextBoxColumn";
            this.girissaatiDataGridViewTextBoxColumn.ReadOnly = true;
            this.girissaatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // arabalarBindingSource4
            // 
            this.arabalarBindingSource4.DataMember = "arabalar";
            this.arabalarBindingSource4.DataSource = this.otoparkDataSet4;
            this.otoparkDataSet4.DataSetName = "otoparkDataSet4";
            this.otoparkDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // manualFormButton
            // 
            this.manualFormButton.Location = new System.Drawing.Point(152, 476);
            this.manualFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manualFormButton.Name = "manualFormButton";
            this.manualFormButton.Size = new System.Drawing.Size(167, 54);
            this.manualFormButton.TabIndex = 2;
            this.manualFormButton.Text = "Manuel Giriş Sayfası";
            this.manualFormButton.UseVisualStyleBackColor = true;
            this.manualFormButton.Click += new System.EventHandler(this.manualFormButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(327, 476);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(167, 54);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "Geri Dön";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1067, 31);
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
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(501, 476);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(167, 54);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Kayıtları Yenile";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.loadRegistryForm);
            // 
            // carExitButton
            // 
            this.carExitButton.Location = new System.Drawing.Point(676, 476);
            this.carExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carExitButton.Name = "carExitButton";
            this.carExitButton.Size = new System.Drawing.Size(167, 54);
            this.carExitButton.TabIndex = 6;
            this.carExitButton.Text = "Araç Çıkış Yap";
            this.carExitButton.UseVisualStyleBackColor = true;
            this.carExitButton.Click += new System.EventHandler(this.carExitButton_Click);
            // 
            // numberPlateLabel
            // 
            this.numberPlateLabel.AutoSize = true;
            this.numberPlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberPlateLabel.Location = new System.Drawing.Point(811, 66);
            this.numberPlateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberPlateLabel.Name = "numberPlateLabel";
            this.numberPlateLabel.Size = new System.Drawing.Size(105, 36);
            this.numberPlateLabel.TabIndex = 7;
            this.numberPlateLabel.Text = "Plaka: ";
            // 
            // telNoLabel
            // 
            this.telNoLabel.AutoSize = true;
            this.telNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNoLabel.Location = new System.Drawing.Point(792, 155);
            this.telNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telNoLabel.Name = "telNoLabel";
            this.telNoLabel.Size = new System.Drawing.Size(119, 36);
            this.telNoLabel.TabIndex = 8;
            this.telNoLabel.Text = "Tel No: ";
            // 
            // entranceDateLabel
            // 
            this.entranceDateLabel.AutoSize = true;
            this.entranceDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.entranceDateLabel.Location = new System.Drawing.Point(744, 239);
            this.entranceDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.entranceDateLabel.Name = "entranceDateLabel";
            this.entranceDateLabel.Size = new System.Drawing.Size(168, 36);
            this.entranceDateLabel.TabIndex = 9;
            this.entranceDateLabel.Text = "Giriş Saati: ";
            // 
            // numberPlateTextBox
            // 
            this.numberPlateTextBox.Location = new System.Drawing.Point(917, 78);
            this.numberPlateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberPlateTextBox.Name = "numberPlateTextBox";
            this.numberPlateTextBox.Size = new System.Drawing.Size(132, 22);
            this.numberPlateTextBox.TabIndex = 10;
            // 
            // telNoTextBox
            // 
            this.telNoTextBox.Location = new System.Drawing.Point(917, 166);
            this.telNoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telNoTextBox.Name = "telNoTextBox";
            this.telNoTextBox.Size = new System.Drawing.Size(132, 22);
            this.telNoTextBox.TabIndex = 11;
            // 
            // entranceDateTextBox
            // 
            this.entranceDateTextBox.Location = new System.Drawing.Point(917, 250);
            this.entranceDateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entranceDateTextBox.Name = "entranceDateTextBox";
            this.entranceDateTextBox.Size = new System.Drawing.Size(132, 22);
            this.entranceDateTextBox.TabIndex = 12;
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
            // FormKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 555);
            this.Controls.Add(this.entranceDateTextBox);
            this.Controls.Add(this.telNoTextBox);
            this.Controls.Add(this.numberPlateTextBox);
            this.Controls.Add(this.entranceDateLabel);
            this.Controls.Add(this.telNoLabel);
            this.Controls.Add(this.numberPlateLabel);
            this.Controls.Add(this.carExitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.manualFormButton);
            this.Controls.Add(this.registryGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormKayitlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKayitlar";
            this.Load += new System.EventHandler(this.loadRegistryForm);
            ((System.ComponentModel.ISupportInitialize)(this.registryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arabalarBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView registryGridView;
        private System.Windows.Forms.Button manualFormButton;
        private System.Windows.Forms.Button goBackButton;
        private otoparkDataSet otoparkDataSet;
        private System.Windows.Forms.BindingSource arabalarBindingSource;
        private otoparkDataSetTableAdapters.arabalarTableAdapter arabalarTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.BindingSource arabalarBindingSource1;
        private System.Windows.Forms.BindingSource otoparkDataSetBindingSource;
        private System.Windows.Forms.Button carExitButton;
        private System.Windows.Forms.Label numberPlateLabel;
        private System.Windows.Forms.Label telNoLabel;
        private System.Windows.Forms.Label entranceDateLabel;
        private System.Windows.Forms.TextBox numberPlateTextBox;
        private System.Windows.Forms.TextBox telNoTextBox;
        private System.Windows.Forms.TextBox entranceDateTextBox;
        private System.Windows.Forms.BindingSource arabalarBindingSource2;
        private otoparkDataSet4 otoparkDataSet4;
        private System.Windows.Forms.BindingSource arabalarBindingSource3;
        private otoparkDataSet4TableAdapters.arabalarTableAdapter arabalarTableAdapter1;
        private System.Windows.Forms.BindingSource arabalarBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girissaatiDataGridViewTextBoxColumn;
    }
}