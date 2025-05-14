namespace CeresBusManagement
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            lblEnterMunicipalityDestinatio = new Label();
            lblDestination = new Label();
            txtPassword = new TextBox();
            lblEnterMunicipalityCurrentLocation = new Label();
            lblCurrentLocation = new Label();
            txtUsername = new TextBox();
            btnEnter = new Button();
            btnBack = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblEnterMunicipalityDestinatio
            // 
            lblEnterMunicipalityDestinatio.AutoSize = true;
            lblEnterMunicipalityDestinatio.BackColor = Color.Transparent;
            lblEnterMunicipalityDestinatio.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEnterMunicipalityDestinatio.Location = new Point(998, 389);
            lblEnterMunicipalityDestinatio.Name = "lblEnterMunicipalityDestinatio";
            lblEnterMunicipalityDestinatio.Size = new Size(0, 21);
            lblEnterMunicipalityDestinatio.TabIndex = 11;
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.BackColor = Color.Transparent;
            lblDestination.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestination.ForeColor = Color.FromArgb(51, 51, 51);
            lblDestination.Location = new Point(763, 354);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(161, 28);
            lblDestination.TabIndex = 10;
            lblDestination.Text = "Enter Password: ";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(996, 355);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(338, 31);
            txtPassword.TabIndex = 9;
            // 
            // lblEnterMunicipalityCurrentLocation
            // 
            lblEnterMunicipalityCurrentLocation.AutoSize = true;
            lblEnterMunicipalityCurrentLocation.BackColor = Color.Transparent;
            lblEnterMunicipalityCurrentLocation.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEnterMunicipalityCurrentLocation.Location = new Point(996, 279);
            lblEnterMunicipalityCurrentLocation.Name = "lblEnterMunicipalityCurrentLocation";
            lblEnterMunicipalityCurrentLocation.Size = new Size(0, 21);
            lblEnterMunicipalityCurrentLocation.TabIndex = 8;
            // 
            // lblCurrentLocation
            // 
            lblCurrentLocation.AutoSize = true;
            lblCurrentLocation.BackColor = Color.Transparent;
            lblCurrentLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentLocation.ForeColor = Color.FromArgb(51, 51, 51);
            lblCurrentLocation.Location = new Point(761, 244);
            lblCurrentLocation.Name = "lblCurrentLocation";
            lblCurrentLocation.Size = new Size(168, 28);
            lblCurrentLocation.TabIndex = 7;
            lblCurrentLocation.Text = "Enter Username: ";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(994, 245);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(340, 31);
            txtUsername.TabIndex = 6;
            // 
            // btnEnter
            // 
            btnEnter.AutoSize = true;
            btnEnter.BackColor = Color.FromArgb(51, 51, 51);
            btnEnter.BackgroundImageLayout = ImageLayout.None;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = SystemColors.ButtonFace;
            btnEnter.Location = new Point(1177, 784);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(180, 44);
            btnEnter.TabIndex = 13;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = Color.FromArgb(51, 51, 51);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(717, 784);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 44);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1343, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 30);
            btnClose.TabIndex = 73;
            btnClose.Text = "✖";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 844);
            Controls.Add(btnClose);
            Controls.Add(btnEnter);
            Controls.Add(btnBack);
            Controls.Add(lblEnterMunicipalityDestinatio);
            Controls.Add(lblDestination);
            Controls.Add(txtPassword);
            Controls.Add(lblEnterMunicipalityCurrentLocation);
            Controls.Add(lblCurrentLocation);
            Controls.Add(txtUsername);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnterMunicipalityDestinatio;
        private Label lblDestination;
        private TextBox txtPassword;
        private Label lblEnterMunicipalityCurrentLocation;
        private Label lblCurrentLocation;
        private TextBox txtUsername;
        private Button btnEnter;
        private Button btnBack;
        private Button btnClose;
    }
}