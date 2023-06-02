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
            this.manualFormButton = new System.Windows.Forms.Button();
            this.automaticEntranceButton = new System.Windows.Forms.Button();
            this.registriesButton = new System.Windows.Forms.Button();
            this.loginPageButton = new System.Windows.Forms.Button();
            this.automaticExitButton = new System.Windows.Forms.Button();
            this.costManagerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manualFormButton
            // 
            this.manualFormButton.Location = new System.Drawing.Point(260, 240);
            this.manualFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manualFormButton.Name = "manualFormButton";
            this.manualFormButton.Size = new System.Drawing.Size(469, 78);
            this.manualFormButton.TabIndex = 0;
            this.manualFormButton.Text = "Manuel Giriş";
            this.manualFormButton.UseVisualStyleBackColor = true;
            this.manualFormButton.Click += new System.EventHandler(this.manualFormButton_Click);
            // 
            // automaticEntranceButton
            // 
            this.automaticEntranceButton.Location = new System.Drawing.Point(260, 153);
            this.automaticEntranceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.automaticEntranceButton.Name = "automaticEntranceButton";
            this.automaticEntranceButton.Size = new System.Drawing.Size(215, 78);
            this.automaticEntranceButton.TabIndex = 1;
            this.automaticEntranceButton.Text = "Otomatik Giriş";
            this.automaticEntranceButton.UseVisualStyleBackColor = true;
            this.automaticEntranceButton.Click += new System.EventHandler(this.automaticEntranceButton_Click);
            // 
            // registriesButton
            // 
            this.registriesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registriesButton.Location = new System.Drawing.Point(260, 325);
            this.registriesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registriesButton.Name = "registriesButton";
            this.registriesButton.Size = new System.Drawing.Size(469, 78);
            this.registriesButton.TabIndex = 2;
            this.registriesButton.Text = "Kayıtlar";
            this.registriesButton.UseVisualStyleBackColor = true;
            this.registriesButton.Click += new System.EventHandler(this.registriesButton_Click);
            // 
            // loginPageButton
            // 
            this.loginPageButton.Location = new System.Drawing.Point(124, 511);
            this.loginPageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginPageButton.Name = "loginPageButton";
            this.loginPageButton.Size = new System.Drawing.Size(100, 28);
            this.loginPageButton.TabIndex = 4;
            this.loginPageButton.Text = "Giriş Sayfası";
            this.loginPageButton.UseVisualStyleBackColor = true;
            this.loginPageButton.Click += new System.EventHandler(this.loginPageButton_Click);
            // 
            // automaticExitButton
            // 
            this.automaticExitButton.Location = new System.Drawing.Point(521, 153);
            this.automaticExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.automaticExitButton.Name = "automaticExitButton";
            this.automaticExitButton.Size = new System.Drawing.Size(208, 78);
            this.automaticExitButton.TabIndex = 5;
            this.automaticExitButton.Text = "Otomatik Çıkış";
            this.automaticExitButton.UseVisualStyleBackColor = true;
            this.automaticExitButton.Click += new System.EventHandler(this.automaticExitButton_Click);
            // 
            // costManagerButton
            // 
            this.costManagerButton.Location = new System.Drawing.Point(233, 511);
            this.costManagerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.costManagerButton.Name = "costManagerButton";
            this.costManagerButton.Size = new System.Drawing.Size(100, 28);
            this.costManagerButton.TabIndex = 6;
            this.costManagerButton.Text = "Fiyat Tarifesi";
            this.costManagerButton.UseVisualStyleBackColor = true;
            this.costManagerButton.Click += new System.EventHandler(this.costManagerButton_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.costManagerButton);
            this.Controls.Add(this.automaticExitButton);
            this.Controls.Add(this.loginPageButton);
            this.Controls.Add(this.registriesButton);
            this.Controls.Add(this.automaticEntranceButton);
            this.Controls.Add(this.manualFormButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manualFormButton;
        private System.Windows.Forms.Button automaticEntranceButton;
        private System.Windows.Forms.Button registriesButton;
        private System.Windows.Forms.Button loginPageButton;
        private System.Windows.Forms.Button automaticExitButton;
        private System.Windows.Forms.Button costManagerButton;
    }
}