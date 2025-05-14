namespace CeresBusManagement
{
    partial class AddNewBusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewBusForm));
            lblEnterMunicipalityDestinatio = new Label();
            lblDestination = new Label();
            txtStartingPoint = new TextBox();
            lblCurrentLocation = new Label();
            txtBusCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDestination = new TextBox();
            groupBoxBusType = new GroupBox();
            rbAircon = new RadioButton();
            rbNonAircon = new RadioButton();
            dataGridBuses = new DataGridView();
            label5 = new Label();
            txtConductor = new TextBox();
            label6 = new Label();
            txtDriver = new TextBox();
            label7 = new Label();
            btnEnter = new Button();
            btnBack = new Button();
            btnLoadData = new Button();
            label3 = new Label();
            txtDepartureTime = new TextBox();
            btnClose = new Button();
            groupBoxBusType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBuses).BeginInit();
            SuspendLayout();
            // 
            // lblEnterMunicipalityDestinatio
            // 
            lblEnterMunicipalityDestinatio.Anchor = AnchorStyles.Right;
            lblEnterMunicipalityDestinatio.AutoSize = true;
            lblEnterMunicipalityDestinatio.BackColor = Color.Transparent;
            lblEnterMunicipalityDestinatio.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEnterMunicipalityDestinatio.Location = new Point(1068, 218);
            lblEnterMunicipalityDestinatio.Name = "lblEnterMunicipalityDestinatio";
            lblEnterMunicipalityDestinatio.Size = new Size(288, 21);
            lblEnterMunicipalityDestinatio.TabIndex = 11;
            lblEnterMunicipalityDestinatio.Text = "Enter Municipality (e.g., Argao, Bato Oslob)";
            // 
            // lblDestination
            // 
            lblDestination.Anchor = AnchorStyles.Right;
            lblDestination.AutoSize = true;
            lblDestination.BackColor = Color.Transparent;
            lblDestination.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestination.ForeColor = Color.FromArgb(51, 51, 51);
            lblDestination.Location = new Point(744, 186);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(200, 28);
            lblDestination.TabIndex = 10;
            lblDestination.Text = "Enter Starting Point: ";
            // 
            // txtStartingPoint
            // 
            txtStartingPoint.BorderStyle = BorderStyle.None;
            txtStartingPoint.Location = new Point(992, 184);
            txtStartingPoint.Multiline = true;
            txtStartingPoint.Name = "txtStartingPoint";
            txtStartingPoint.Size = new Size(366, 31);
            txtStartingPoint.TabIndex = 9;
            // 
            // lblCurrentLocation
            // 
            lblCurrentLocation.Anchor = AnchorStyles.Right;
            lblCurrentLocation.AutoSize = true;
            lblCurrentLocation.BackColor = Color.Transparent;
            lblCurrentLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentLocation.ForeColor = Color.FromArgb(51, 51, 51);
            lblCurrentLocation.Location = new Point(744, 130);
            lblCurrentLocation.Name = "lblCurrentLocation";
            lblCurrentLocation.Size = new Size(162, 28);
            lblCurrentLocation.TabIndex = 7;
            lblCurrentLocation.Text = "Enter Bus Code: ";
            // 
            // txtBusCode
            // 
            txtBusCode.BorderStyle = BorderStyle.None;
            txtBusCode.Location = new Point(992, 128);
            txtBusCode.Multiline = true;
            txtBusCode.Name = "txtBusCode";
            txtBusCode.Size = new Size(366, 31);
            txtBusCode.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(1067, 291);
            label1.Name = "label1";
            label1.Size = new Size(288, 21);
            label1.TabIndex = 14;
            label1.Text = "Enter Municipality (e.g., Argao, Bato Oslob)";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(51, 51, 51);
            label2.Location = new Point(744, 258);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 13;
            label2.Text = "Enter Destination: ";
            // 
            // txtDestination
            // 
            txtDestination.BorderStyle = BorderStyle.None;
            txtDestination.Location = new Point(992, 256);
            txtDestination.Multiline = true;
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(366, 31);
            txtDestination.TabIndex = 12;
            // 
            // groupBoxBusType
            // 
            groupBoxBusType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxBusType.AutoSize = true;
            groupBoxBusType.BackColor = Color.Transparent;
            groupBoxBusType.Controls.Add(rbAircon);
            groupBoxBusType.Controls.Add(rbNonAircon);
            groupBoxBusType.FlatStyle = FlatStyle.Flat;
            groupBoxBusType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxBusType.ForeColor = Color.FromArgb(51, 51, 51);
            groupBoxBusType.Location = new Point(744, 388);
            groupBoxBusType.Name = "groupBoxBusType";
            groupBoxBusType.Size = new Size(622, 103);
            groupBoxBusType.TabIndex = 15;
            groupBoxBusType.TabStop = false;
            groupBoxBusType.Text = "Type of Bus:";
            // 
            // rbAircon
            // 
            rbAircon.AutoSize = true;
            rbAircon.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbAircon.Location = new Point(488, 38);
            rbAircon.Name = "rbAircon";
            rbAircon.Size = new Size(83, 25);
            rbAircon.TabIndex = 1;
            rbAircon.TabStop = true;
            rbAircon.Text = "Aircon";
            rbAircon.UseVisualStyleBackColor = true;
            // 
            // rbNonAircon
            // 
            rbNonAircon.AutoSize = true;
            rbNonAircon.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbNonAircon.Location = new Point(233, 38);
            rbNonAircon.Name = "rbNonAircon";
            rbNonAircon.Size = new Size(120, 25);
            rbNonAircon.TabIndex = 0;
            rbNonAircon.TabStop = true;
            rbNonAircon.Text = "Non-Aircon";
            rbNonAircon.UseVisualStyleBackColor = true;
            // 
            // dataGridBuses
            // 
            dataGridBuses.AllowUserToAddRows = false;
            dataGridBuses.BackgroundColor = SystemColors.ButtonFace;
            dataGridBuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBuses.Location = new Point(31, 105);
            dataGridBuses.Name = "dataGridBuses";
            dataGridBuses.ReadOnly = true;
            dataGridBuses.RowHeadersWidth = 62;
            dataGridBuses.Size = new Size(657, 661);
            dataGridBuses.TabIndex = 16;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(51, 51, 51);
            label5.Location = new Point(744, 680);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 21;
            label5.Text = "Enter Conductor:";
            // 
            // txtConductor
            // 
            txtConductor.BorderStyle = BorderStyle.None;
            txtConductor.Location = new Point(992, 681);
            txtConductor.Multiline = true;
            txtConductor.Name = "txtConductor";
            txtConductor.Size = new Size(366, 31);
            txtConductor.TabIndex = 20;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(51, 51, 51);
            label6.Location = new Point(744, 619);
            label6.Name = "label6";
            label6.Size = new Size(131, 28);
            label6.TabIndex = 19;
            label6.Text = "Enter Driver: ";
            // 
            // txtDriver
            // 
            txtDriver.BorderStyle = BorderStyle.None;
            txtDriver.Location = new Point(992, 620);
            txtDriver.Multiline = true;
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(366, 31);
            txtDriver.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(940, 500);
            label7.Name = "label7";
            label7.Size = new Size(0, 42);
            label7.TabIndex = 23;
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
            btnEnter.Location = new Point(1185, 789);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(180, 44);
            btnEnter.TabIndex = 25;
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
            btnBack.Location = new Point(741, 788);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 44);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.AutoSize = true;
            btnLoadData.BackColor = Color.FromArgb(51, 51, 51);
            btnLoadData.BackgroundImageLayout = ImageLayout.None;
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadData.ForeColor = SystemColors.ButtonFace;
            btnLoadData.Location = new Point(31, 788);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(180, 44);
            btnLoadData.TabIndex = 26;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(51, 51, 51);
            label3.Location = new Point(744, 336);
            label3.Name = "label3";
            label3.Size = new Size(219, 28);
            label3.TabIndex = 28;
            label3.Text = "Enter Departure Time: ";
            // 
            // txtDepartureTime
            // 
            txtDepartureTime.BorderStyle = BorderStyle.None;
            txtDepartureTime.Location = new Point(992, 334);
            txtDepartureTime.Multiline = true;
            txtDepartureTime.Name = "txtDepartureTime";
            txtDepartureTime.Size = new Size(366, 31);
            txtDepartureTime.TabIndex = 27;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1343, -3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 30);
            btnClose.TabIndex = 29;
            btnClose.Text = "✖";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // AddNewBusForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 844);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(txtDepartureTime);
            Controls.Add(btnLoadData);
            Controls.Add(btnEnter);
            Controls.Add(btnBack);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtConductor);
            Controls.Add(label6);
            Controls.Add(txtDriver);
            Controls.Add(dataGridBuses);
            Controls.Add(groupBoxBusType);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtDestination);
            Controls.Add(lblEnterMunicipalityDestinatio);
            Controls.Add(lblDestination);
            Controls.Add(txtStartingPoint);
            Controls.Add(lblCurrentLocation);
            Controls.Add(txtBusCode);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddNewBusForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewBusForm";
            groupBoxBusType.ResumeLayout(false);
            groupBoxBusType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBuses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnterMunicipalityDestinatio;
        private Label lblDestination;
        private TextBox txtStartingPoint;
        private Label lblCurrentLocation;
        private TextBox txtBusCode;
        private Label label1;
        private Label label2;
        private TextBox txtDestination;
        private GroupBox groupBoxBusType;
        private RadioButton rbAircon;
        private RadioButton rbNonAircon;
        private DataGridView dataGridBuses;
        private Label label5;
        private TextBox txtConductor;
        private Label label6;
        private TextBox txtDriver;
        private Label label7;
        private Button btnEnter;
        private Button btnBack;
        private Button btnLoadData;
        private Label label3;
        private TextBox txtDepartureTime;
        private Button btnClose;
    }
}