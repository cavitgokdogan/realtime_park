namespace OtoparkOtomasyonuEnSon
{
    partial class ManualForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualForm));
            this.numberPlateTextBox = new System.Windows.Forms.TextBox();
            this.telNoTextBox = new System.Windows.Forms.TextBox();
            this.numberPlateLabel = new System.Windows.Forms.Label();
            this.telNoLabel = new System.Windows.Forms.Label();
            this.entranceDateLabel = new System.Windows.Forms.Label();
            this.createRegistryButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.registryPageButton = new System.Windows.Forms.Button();
            this.entranceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // numberPlateTextBox
            // 
            this.numberPlateTextBox.Location = new System.Drawing.Point(488, 112);
            this.numberPlateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberPlateTextBox.Name = "numberPlateTextBox";
            this.numberPlateTextBox.Size = new System.Drawing.Size(132, 22);
            this.numberPlateTextBox.TabIndex = 0;
            // 
            // telNoTextBox
            // 
            this.telNoTextBox.Location = new System.Drawing.Point(488, 172);
            this.telNoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telNoTextBox.Name = "telNoTextBox";
            this.telNoTextBox.Size = new System.Drawing.Size(132, 22);
            this.telNoTextBox.TabIndex = 1;
            // 
            // numberPlateLabel
            // 
            this.numberPlateLabel.AutoSize = true;
            this.numberPlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numberPlateLabel.Location = new System.Drawing.Point(391, 106);
            this.numberPlateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberPlateLabel.Name = "numberPlateLabel";
            this.numberPlateLabel.Size = new System.Drawing.Size(84, 29);
            this.numberPlateLabel.TabIndex = 3;
            this.numberPlateLabel.Text = "Plaka:";
            // 
            // telNoLabel
            // 
            this.telNoLabel.AutoSize = true;
            this.telNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telNoLabel.Location = new System.Drawing.Point(328, 172);
            this.telNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telNoLabel.Name = "telNoLabel";
            this.telNoLabel.Size = new System.Drawing.Size(143, 29);
            this.telNoLabel.TabIndex = 4;
            this.telNoLabel.Text = "Telefon No:";
            // 
            // entranceDateLabel
            // 
            this.entranceDateLabel.AutoSize = true;
            this.entranceDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.entranceDateLabel.Location = new System.Drawing.Point(337, 236);
            this.entranceDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.entranceDateLabel.Name = "entranceDateLabel";
            this.entranceDateLabel.Size = new System.Drawing.Size(137, 29);
            this.entranceDateLabel.TabIndex = 5;
            this.entranceDateLabel.Text = "Giriş Saati:";
            // 
            // createRegistryButton
            // 
            this.createRegistryButton.Location = new System.Drawing.Point(213, 421);
            this.createRegistryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createRegistryButton.Name = "createRegistryButton";
            this.createRegistryButton.Size = new System.Drawing.Size(176, 68);
            this.createRegistryButton.TabIndex = 6;
            this.createRegistryButton.Text = "Kayıt Oluştur";
            this.createRegistryButton.UseVisualStyleBackColor = true;
            this.createRegistryButton.Click += new System.EventHandler(this.createRegistryButtonClick);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(397, 421);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(176, 68);
            this.goBackButton.TabIndex = 11;
            this.goBackButton.Text = "Geri Dön";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButtonClick);
            // 
            // registryPageButton
            // 
            this.registryPageButton.Location = new System.Drawing.Point(581, 421);
            this.registryPageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registryPageButton.Name = "registryPageButton";
            this.registryPageButton.Size = new System.Drawing.Size(176, 68);
            this.registryPageButton.TabIndex = 12;
            this.registryPageButton.Text = "Kayıtlar Sayfası";
            this.registryPageButton.UseVisualStyleBackColor = true;
            this.registryPageButton.Click += new System.EventHandler(this.registryPageButtonClick);
            // 
            // entranceDatePicker
            // 
            this.entranceDatePicker.Location = new System.Drawing.Point(488, 240);
            this.entranceDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.entranceDatePicker.Name = "entranceDatePicker";
            this.entranceDatePicker.Size = new System.Drawing.Size(265, 22);
            this.entranceDatePicker.TabIndex = 13;
            this.entranceDatePicker.ValueChanged += new System.EventHandler(this.entranceDateValueChanged);
            // 
            // ManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.entranceDatePicker);
            this.Controls.Add(this.registryPageButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.createRegistryButton);
            this.Controls.Add(this.entranceDateLabel);
            this.Controls.Add(this.telNoLabel);
            this.Controls.Add(this.numberPlateLabel);
            this.Controls.Add(this.telNoTextBox);
            this.Controls.Add(this.numberPlateTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManualForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManualForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberPlateTextBox;
        private System.Windows.Forms.TextBox telNoTextBox;
        private System.Windows.Forms.Label numberPlateLabel;
        private System.Windows.Forms.Label telNoLabel;
        private System.Windows.Forms.Label entranceDateLabel;
        private System.Windows.Forms.Button createRegistryButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button registryPageButton;
        private System.Windows.Forms.DateTimePicker entranceDatePicker;
    }
}