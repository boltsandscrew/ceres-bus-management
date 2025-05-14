namespace CeresBusManagement
{
    partial class ConductorAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConductorAcc));
            btnBack = new Button();
            btnEnter = new Button();
            btnLoadData = new Button();
            dgvEmployeeAccounts = new DataGridView();
            label4 = new Label();
            label6 = new Label();
            txtUsername = new TextBox();
            txtEmployeeName = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeAccounts).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = Color.FromArgb(243, 146, 0);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(680, 773);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 44);
            btnBack.TabIndex = 51;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnEnter
            // 
            btnEnter.AutoSize = true;
            btnEnter.BackColor = Color.FromArgb(243, 146, 0);
            btnEnter.BackgroundImageLayout = ImageLayout.None;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = SystemColors.ActiveCaptionText;
            btnEnter.Location = new Point(1175, 773);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(180, 44);
            btnEnter.TabIndex = 50;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.AutoSize = true;
            btnLoadData.BackColor = Color.FromArgb(243, 146, 0);
            btnLoadData.BackgroundImageLayout = ImageLayout.None;
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadData.ForeColor = SystemColors.ActiveCaptionText;
            btnLoadData.Location = new Point(436, 773);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(180, 44);
            btnLoadData.TabIndex = 52;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // dgvEmployeeAccounts
            // 
            dgvEmployeeAccounts.BackgroundColor = SystemColors.ButtonFace;
            dgvEmployeeAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeAccounts.Location = new Point(23, 35);
            dgvEmployeeAccounts.Name = "dgvEmployeeAccounts";
            dgvEmployeeAccounts.RowHeadersWidth = 62;
            dgvEmployeeAccounts.Size = new Size(602, 705);
            dgvEmployeeAccounts.TabIndex = 53;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(701, 188);
            label4.Name = "label4";
            label4.Size = new Size(144, 36);
            label4.TabIndex = 64;
            label4.Text = "Enter Name: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(701, 253);
            label6.Name = "label6";
            label6.Size = new Size(188, 36);
            label6.TabIndex = 63;
            label6.Text = "Enter Username: ";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(931, 253);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(375, 32);
            txtUsername.TabIndex = 62;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BorderStyle = BorderStyle.FixedSingle;
            txtEmployeeName.Location = new Point(931, 188);
            txtEmployeeName.Multiline = true;
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(375, 32);
            txtEmployeeName.TabIndex = 61;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(701, 321);
            label1.Name = "label1";
            label1.Size = new Size(183, 36);
            label1.TabIndex = 66;
            label1.Text = "Enter Password: ";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(931, 321);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(375, 32);
            txtPassword.TabIndex = 65;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1342, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 30);
            btnClose.TabIndex = 69;
            btnClose.Text = "✖";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ConductorAcc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 844);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(txtUsername);
            Controls.Add(txtEmployeeName);
            Controls.Add(dgvEmployeeAccounts);
            Controls.Add(btnLoadData);
            Controls.Add(btnBack);
            Controls.Add(btnEnter);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConductorAcc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConductorAcc";
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnEnter;
        private Button btnLoadData;
        private DataGridView dgvEmployeeAccounts;
        private Label label4;
        private Label label6;
        private TextBox txtUsername;
        private TextBox txtEmployeeName;
        private Label label1;
        private TextBox txtPassword;
        private Button btnClose;
    }
}