namespace CeresBusManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPassenger = new Button();
            btnManagement = new Button();
            btnEmployee = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnPassenger
            // 
            btnPassenger.AutoSize = true;
            btnPassenger.BackColor = Color.Transparent;
            btnPassenger.BackgroundImage = Properties.Resources.Welcome_to_Ceres_Line__your_journey_to_comfort_and_convenience_starts_here1;
            btnPassenger.BackgroundImageLayout = ImageLayout.None;
            btnPassenger.FlatAppearance.BorderSize = 0;
            btnPassenger.FlatStyle = FlatStyle.Flat;
            btnPassenger.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPassenger.Location = new Point(980, 636);
            btnPassenger.Name = "btnPassenger";
            btnPassenger.Size = new Size(240, 60);
            btnPassenger.TabIndex = 0;
            btnPassenger.Text = "Passenger";
            btnPassenger.UseVisualStyleBackColor = false;
            btnPassenger.Click += btnPassenger_Click;
            // 
            // btnManagement
            // 
            btnManagement.AutoSize = true;
            btnManagement.BackColor = Color.Transparent;
            btnManagement.BackgroundImage = Properties.Resources.Welcome_to_Ceres_Line__your_journey_to_comfort_and_convenience_starts_here1;
            btnManagement.BackgroundImageLayout = ImageLayout.None;
            btnManagement.FlatAppearance.BorderSize = 0;
            btnManagement.FlatStyle = FlatStyle.Flat;
            btnManagement.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManagement.Location = new Point(184, 636);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(240, 60);
            btnManagement.TabIndex = 1;
            btnManagement.Text = "Management";
            btnManagement.UseVisualStyleBackColor = false;
            btnManagement.Click += btnManagement_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.AutoSize = true;
            btnEmployee.BackColor = Color.Transparent;
            btnEmployee.BackgroundImage = Properties.Resources.Welcome_to_Ceres_Line__your_journey_to_comfort_and_convenience_starts_here1;
            btnEmployee.BackgroundImageLayout = ImageLayout.None;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.Location = new Point(588, 636);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(240, 60);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1345, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 30);
            btnClose.TabIndex = 71;
            btnClose.Text = "✖";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 252, 241);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 844);
            Controls.Add(btnClose);
            Controls.Add(btnEmployee);
            Controls.Add(btnManagement);
            Controls.Add(btnPassenger);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPassenger;
        private Button btnManagement;
        private Button btnEmployee;
        private Button btnClose;
    }
}
