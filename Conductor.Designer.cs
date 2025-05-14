namespace CeresBusManagement
{
    partial class Conductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conductor));
            cmbPassengerStatus = new ComboBox();
            label3 = new Label();
            txtBusCode = new TextBox();
            txtUsername = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            btnSubmit = new Button();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtVacantSeats = new TextBox();
            label2 = new Label();
            btnEnter = new Button();
            btnBack = new Button();
            dataGridBusStatus = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridBusStatus).BeginInit();
            SuspendLayout();
            // 
            // cmbPassengerStatus
            // 
            cmbPassengerStatus.FormattingEnabled = true;
            cmbPassengerStatus.Items.AddRange(new object[] { "Vacant", "Standing", "Full" });
            cmbPassengerStatus.Location = new Point(938, 550);
            cmbPassengerStatus.Name = "cmbPassengerStatus";
            cmbPassengerStatus.Size = new Size(375, 33);
            cmbPassengerStatus.TabIndex = 30;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(685, 484);
            label3.Name = "label3";
            label3.Size = new Size(116, 36);
            label3.TabIndex = 49;
            label3.Text = "Bus Code:";
            // 
            // txtBusCode
            // 
            txtBusCode.BorderStyle = BorderStyle.FixedSingle;
            txtBusCode.Location = new Point(938, 488);
            txtBusCode.Multiline = true;
            txtBusCode.Name = "txtBusCode";
            txtBusCode.Size = new Size(375, 32);
            txtBusCode.TabIndex = 48;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(938, 136);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(375, 32);
            txtUsername.TabIndex = 55;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(686, 200);
            label6.Name = "label6";
            label6.Size = new Size(183, 36);
            label6.TabIndex = 58;
            label6.Text = "Enter Password: ";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(938, 201);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(375, 32);
            txtPassword.TabIndex = 57;
            // 
            // btnSubmit
            // 
            btnSubmit.AutoSize = true;
            btnSubmit.BackColor = Color.FromArgb(255, 193, 1);
            btnSubmit.BackgroundImageLayout = ImageLayout.None;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ActiveCaptionText;
            btnSubmit.Location = new Point(1196, 274);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 31);
            btnSubmit.TabIndex = 59;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(686, 135);
            label4.Name = "label4";
            label4.Size = new Size(188, 36);
            label4.TabIndex = 60;
            label4.Text = "Enter Username: ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(685, 107);
            label5.Name = "label5";
            label5.Size = new Size(0, 36);
            label5.TabIndex = 61;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(686, 547);
            label1.Name = "label1";
            label1.Size = new Size(203, 36);
            label1.TabIndex = 62;
            label1.Text = "Passenger Status: ";
            // 
            // txtVacantSeats
            // 
            txtVacantSeats.BorderStyle = BorderStyle.FixedSingle;
            txtVacantSeats.Location = new Point(938, 617);
            txtVacantSeats.Multiline = true;
            txtVacantSeats.Name = "txtVacantSeats";
            txtVacantSeats.Size = new Size(375, 32);
            txtVacantSeats.TabIndex = 63;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(686, 617);
            label2.Name = "label2";
            label2.Size = new Size(162, 36);
            label2.TabIndex = 64;
            label2.Text = "Vacant Seats: ";
            // 
            // btnEnter
            // 
            btnEnter.AutoSize = true;
            btnEnter.BackColor = Color.FromArgb(255, 193, 1);
            btnEnter.BackgroundImageLayout = ImageLayout.None;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = SystemColors.ActiveCaptionText;
            btnEnter.Location = new Point(1196, 710);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(117, 31);
            btnEnter.TabIndex = 65;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = Color.FromArgb(255, 193, 1);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(685, 710);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 31);
            btnBack.TabIndex = 66;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridBusStatus
            // 
            dataGridBusStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBusStatus.Location = new Point(22, 56);
            dataGridBusStatus.Name = "dataGridBusStatus";
            dataGridBusStatus.RowHeadersWidth = 62;
            dataGridBusStatus.Size = new Size(591, 661);
            dataGridBusStatus.TabIndex = 67;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1321, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 30);
            btnClose.TabIndex = 68;
            btnClose.Text = "✖";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Conductor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1356, 788);
            Controls.Add(btnClose);
            Controls.Add(dataGridBusStatus);
            Controls.Add(btnBack);
            Controls.Add(btnEnter);
            Controls.Add(label2);
            Controls.Add(txtVacantSeats);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSubmit);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtBusCode);
            Controls.Add(cmbPassengerStatus);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Conductor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conductor";
            ((System.ComponentModel.ISupportInitialize)dataGridBusStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbPassengerStatus;
        private Label label3;
        private TextBox txtBusCode;
        private TextBox txtUsername;
        private Label label6;
        private TextBox txtPassword;
        private Button btnSubmit;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox txtVacantSeats;
        private Label label2;
        private Button btnEnter;
        private Button btnBack;
        private DataGridView dataGridBusStatus;
        private Button btnClose;
    }
}