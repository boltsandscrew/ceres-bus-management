namespace CeresBusManagement
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            btnAddBus = new Button();
            SearchByRoute = new Button();
            btnRemoveBus = new Button();
            btnUpdateBus = new Button();
            btnBack = new Button();
            btnEarnings = new Button();
            btnEmployeeAccount = new Button();
            btnTicket = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnAddBus
            // 
            btnAddBus.AutoSize = true;
            btnAddBus.BackColor = Color.FromArgb(243, 146, 0);
            btnAddBus.BackgroundImageLayout = ImageLayout.None;
            btnAddBus.FlatAppearance.BorderSize = 0;
            btnAddBus.FlatStyle = FlatStyle.Flat;
            btnAddBus.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBus.ForeColor = Color.FromArgb(241, 237, 224);
            btnAddBus.Location = new Point(-2, 190);
            btnAddBus.Name = "btnAddBus";
            btnAddBus.Size = new Size(388, 69);
            btnAddBus.TabIndex = 2;
            btnAddBus.Text = "       ➕              Add New Bus";
            btnAddBus.TextAlign = ContentAlignment.MiddleLeft;
            btnAddBus.UseVisualStyleBackColor = false;
            btnAddBus.Click += btnAddBus_Click;
            // 
            // SearchByRoute
            // 
            SearchByRoute.AutoSize = true;
            SearchByRoute.BackColor = Color.Transparent;
            SearchByRoute.BackgroundImage = Properties.Resources.Welcome_to_Ceres_Line__your_journey_to_comfort_and_convenience_starts_here1;
            SearchByRoute.BackgroundImageLayout = ImageLayout.None;
            SearchByRoute.FlatAppearance.BorderSize = 0;
            SearchByRoute.FlatStyle = FlatStyle.Flat;
            SearchByRoute.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchByRoute.Location = new Point(-2, 407);
            SearchByRoute.Name = "SearchByRoute";
            SearchByRoute.Size = new Size(388, 61);
            SearchByRoute.TabIndex = 3;
            SearchByRoute.Text = "     🔍         Search Bus  ";
            SearchByRoute.TextAlign = ContentAlignment.MiddleLeft;
            SearchByRoute.UseVisualStyleBackColor = false;
            SearchByRoute.Click += btnSearchBus_Click;
            // 
            // btnRemoveBus
            // 
            btnRemoveBus.AutoSize = true;
            btnRemoveBus.BackColor = Color.Transparent;
            btnRemoveBus.BackgroundImage = Properties.Resources.Welcome_to_Ceres_Line__your_journey_to_comfort_and_convenience_starts_here1;
            btnRemoveBus.BackgroundImageLayout = ImageLayout.None;
            btnRemoveBus.FlatAppearance.BorderSize = 0;
            btnRemoveBus.FlatStyle = FlatStyle.Flat;
            btnRemoveBus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveBus.Location = new Point(-2, 265);
            btnRemoveBus.Name = "btnRemoveBus";
            btnRemoveBus.Size = new Size(388, 61);
            btnRemoveBus.TabIndex = 4;
            btnRemoveBus.Text = "     🗑️         Remove Bus";
            btnRemoveBus.TextAlign = ContentAlignment.MiddleLeft;
            btnRemoveBus.UseVisualStyleBackColor = false;
            btnRemoveBus.Click += btnRemoveBus_Click;
            // 
            // btnUpdateBus
            // 
            btnUpdateBus.AutoSize = true;
            btnUpdateBus.BackColor = Color.FromArgb(243, 146, 0);
            btnUpdateBus.BackgroundImageLayout = ImageLayout.None;
            btnUpdateBus.FlatAppearance.BorderSize = 0;
            btnUpdateBus.FlatStyle = FlatStyle.Flat;
            btnUpdateBus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateBus.ForeColor = Color.FromArgb(241, 237, 224);
            btnUpdateBus.Location = new Point(-2, 332);
            btnUpdateBus.Name = "btnUpdateBus";
            btnUpdateBus.Size = new Size(388, 69);
            btnUpdateBus.TabIndex = 6;
            btnUpdateBus.Text = "     🛠️         Update Bus Details";
            btnUpdateBus.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateBus.UseVisualStyleBackColor = false;
            btnUpdateBus.Click += btnUpdateBus_Click;
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
            btnBack.Location = new Point(1162, 766);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 44);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnEarnings
            // 
            btnEarnings.AutoSize = true;
            btnEarnings.BackColor = Color.FromArgb(243, 146, 0);
            btnEarnings.BackgroundImageLayout = ImageLayout.None;
            btnEarnings.FlatAppearance.BorderSize = 0;
            btnEarnings.FlatStyle = FlatStyle.Flat;
            btnEarnings.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEarnings.ForeColor = Color.FromArgb(241, 237, 224);
            btnEarnings.Location = new Point(-2, 616);
            btnEarnings.Name = "btnEarnings";
            btnEarnings.Size = new Size(388, 61);
            btnEarnings.TabIndex = 9;
            btnEarnings.Text = "     💰         Earnings";
            btnEarnings.TextAlign = ContentAlignment.MiddleLeft;
            btnEarnings.UseVisualStyleBackColor = false;
            btnEarnings.Click += btnEarnings_Click;
            // 
            // btnEmployeeAccount
            // 
            btnEmployeeAccount.AutoSize = true;
            btnEmployeeAccount.BackColor = Color.FromArgb(243, 146, 0);
            btnEmployeeAccount.BackgroundImageLayout = ImageLayout.None;
            btnEmployeeAccount.FlatAppearance.BorderSize = 0;
            btnEmployeeAccount.FlatStyle = FlatStyle.Flat;
            btnEmployeeAccount.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployeeAccount.ForeColor = Color.FromArgb(241, 237, 224);
            btnEmployeeAccount.Location = new Point(-2, 474);
            btnEmployeeAccount.Name = "btnEmployeeAccount";
            btnEmployeeAccount.Size = new Size(388, 69);
            btnEmployeeAccount.TabIndex = 11;
            btnEmployeeAccount.Text = "        👔            Employee Account";
            btnEmployeeAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeAccount.UseVisualStyleBackColor = false;
            btnEmployeeAccount.Click += btnEmployeeAccount_Click;
            // 
            // btnTicket
            // 
            btnTicket.AutoSize = true;
            btnTicket.BackColor = Color.Transparent;
            btnTicket.BackgroundImage = Properties.Resources.Welcome_to_Ceres_Line__your_journey_to_comfort_and_convenience_starts_here1;
            btnTicket.BackgroundImageLayout = ImageLayout.None;
            btnTicket.FlatAppearance.BorderSize = 0;
            btnTicket.FlatStyle = FlatStyle.Flat;
            btnTicket.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTicket.Location = new Point(-2, 549);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(388, 61);
            btnTicket.TabIndex = 12;
            btnTicket.Text = "     🎟️         Ticket";
            btnTicket.TextAlign = ContentAlignment.MiddleLeft;
            btnTicket.UseVisualStyleBackColor = false;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1344, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 30);
            btnClose.TabIndex = 73;
            btnClose.Text = "✖";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 844);
            Controls.Add(btnClose);
            Controls.Add(btnTicket);
            Controls.Add(btnEmployeeAccount);
            Controls.Add(btnEarnings);
            Controls.Add(btnBack);
            Controls.Add(btnUpdateBus);
            Controls.Add(btnRemoveBus);
            Controls.Add(SearchByRoute);
            Controls.Add(btnAddBus);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddBus;
        private Button SearchByRoute;
        private Button btnRemoveBus;
        private Button btnUpdateBus;
        private Button btnBack;
        private Button btnEarnings;
        private Button btnEmployeeAccount;
        private Button btnTicket;
        private Button btnClose;
    }
}