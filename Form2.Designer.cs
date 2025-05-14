namespace CeresBusManagement
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            txtCurrentLocation = new TextBox();
            lblCurrentLocation = new Label();
            lblEnterMunicipalityCurrentLocation = new Label();
            lblEnterMunicipalityDestinatio = new Label();
            lblDestination = new Label();
            txtCurrentDestination = new TextBox();
            groupBoxBusType = new GroupBox();
            radioAircon = new RadioButton();
            radioNonAircon = new RadioButton();
            btnBack = new Button();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            radioSenior = new RadioButton();
            radioStudent = new RadioButton();
            radioPWD = new RadioButton();
            radioRegular = new RadioButton();
            button1 = new Button();
            btnClose = new Button();
            groupBoxBusType.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCurrentLocation
            // 
            txtCurrentLocation.BorderStyle = BorderStyle.None;
            txtCurrentLocation.Location = new Point(974, 199);
            txtCurrentLocation.Multiline = true;
            txtCurrentLocation.Name = "txtCurrentLocation";
            txtCurrentLocation.Size = new Size(366, 31);
            txtCurrentLocation.TabIndex = 0;
            // 
            // lblCurrentLocation
            // 
            lblCurrentLocation.Anchor = AnchorStyles.Right;
            lblCurrentLocation.AutoSize = true;
            lblCurrentLocation.BackColor = Color.Transparent;
            lblCurrentLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentLocation.ForeColor = Color.FromArgb(51, 51, 51);
            lblCurrentLocation.Location = new Point(726, 196);
            lblCurrentLocation.Name = "lblCurrentLocation";
            lblCurrentLocation.Size = new Size(227, 28);
            lblCurrentLocation.TabIndex = 1;
            lblCurrentLocation.Text = "Enter Current Location: ";
            // 
            // lblEnterMunicipalityCurrentLocation
            // 
            lblEnterMunicipalityCurrentLocation.Anchor = AnchorStyles.Right;
            lblEnterMunicipalityCurrentLocation.AutoSize = true;
            lblEnterMunicipalityCurrentLocation.BackColor = Color.Transparent;
            lblEnterMunicipalityCurrentLocation.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEnterMunicipalityCurrentLocation.Location = new Point(1048, 233);
            lblEnterMunicipalityCurrentLocation.Name = "lblEnterMunicipalityCurrentLocation";
            lblEnterMunicipalityCurrentLocation.Size = new Size(288, 21);
            lblEnterMunicipalityCurrentLocation.TabIndex = 2;
            lblEnterMunicipalityCurrentLocation.Text = "Enter Municipality (e.g., Argao, Bato Oslob)";
            // 
            // lblEnterMunicipalityDestinatio
            // 
            lblEnterMunicipalityDestinatio.Anchor = AnchorStyles.Right;
            lblEnterMunicipalityDestinatio.AutoSize = true;
            lblEnterMunicipalityDestinatio.BackColor = Color.Transparent;
            lblEnterMunicipalityDestinatio.Font = new Font("Segoe UI Light", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEnterMunicipalityDestinatio.Location = new Point(1048, 315);
            lblEnterMunicipalityDestinatio.Name = "lblEnterMunicipalityDestinatio";
            lblEnterMunicipalityDestinatio.Size = new Size(288, 21);
            lblEnterMunicipalityDestinatio.TabIndex = 5;
            lblEnterMunicipalityDestinatio.Text = "Enter Municipality (e.g., Argao, Bato Oslob)";
            // 
            // lblDestination
            // 
            lblDestination.Anchor = AnchorStyles.Right;
            lblDestination.AutoSize = true;
            lblDestination.BackColor = Color.Transparent;
            lblDestination.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestination.ForeColor = Color.FromArgb(51, 51, 51);
            lblDestination.Location = new Point(726, 278);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(180, 28);
            lblDestination.TabIndex = 4;
            lblDestination.Text = "Enter Destination: ";
            // 
            // txtCurrentDestination
            // 
            txtCurrentDestination.BorderStyle = BorderStyle.None;
            txtCurrentDestination.Location = new Point(974, 281);
            txtCurrentDestination.Multiline = true;
            txtCurrentDestination.Name = "txtCurrentDestination";
            txtCurrentDestination.Size = new Size(366, 31);
            txtCurrentDestination.TabIndex = 3;
            // 
            // groupBoxBusType
            // 
            groupBoxBusType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxBusType.AutoSize = true;
            groupBoxBusType.BackColor = Color.Transparent;
            groupBoxBusType.Controls.Add(radioAircon);
            groupBoxBusType.Controls.Add(radioNonAircon);
            groupBoxBusType.FlatStyle = FlatStyle.Flat;
            groupBoxBusType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxBusType.ForeColor = Color.FromArgb(51, 51, 51);
            groupBoxBusType.Location = new Point(726, 384);
            groupBoxBusType.Name = "groupBoxBusType";
            groupBoxBusType.Size = new Size(629, 103);
            groupBoxBusType.TabIndex = 6;
            groupBoxBusType.TabStop = false;
            groupBoxBusType.Text = "Type of Bus:";
            // 
            // radioAircon
            // 
            radioAircon.AutoSize = true;
            radioAircon.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioAircon.Location = new Point(488, 45);
            radioAircon.Name = "radioAircon";
            radioAircon.Size = new Size(83, 25);
            radioAircon.TabIndex = 1;
            radioAircon.TabStop = true;
            radioAircon.Text = "Aircon";
            radioAircon.UseVisualStyleBackColor = true;
            // 
            // radioNonAircon
            // 
            radioNonAircon.AutoSize = true;
            radioNonAircon.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioNonAircon.Location = new Point(233, 45);
            radioNonAircon.Name = "radioNonAircon";
            radioNonAircon.Size = new Size(120, 25);
            radioNonAircon.TabIndex = 0;
            radioNonAircon.TabStop = true;
            radioNonAircon.Text = "Non-Aircon";
            radioNonAircon.UseVisualStyleBackColor = true;
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
            btnBack.Location = new Point(489, 781);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 44);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.FromArgb(51, 51, 51);
            btnSearch.BackgroundImageLayout = ImageLayout.None;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(1181, 781);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(180, 44);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioSenior);
            groupBox1.Controls.Add(radioStudent);
            groupBox1.Controls.Add(radioPWD);
            groupBox1.Controls.Add(radioRegular);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(51, 51, 51);
            groupBox1.Location = new Point(726, 503);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 158);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Passenger Type:";
            // 
            // radioSenior
            // 
            radioSenior.AutoSize = true;
            radioSenior.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioSenior.Location = new Point(488, 100);
            radioSenior.Name = "radioSenior";
            radioSenior.Size = new Size(135, 25);
            radioSenior.TabIndex = 3;
            radioSenior.TabStop = true;
            radioSenior.Text = "Senior Citizen";
            radioSenior.UseVisualStyleBackColor = true;
            // 
            // radioStudent
            // 
            radioStudent.AutoSize = true;
            radioStudent.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioStudent.Location = new Point(233, 100);
            radioStudent.Name = "radioStudent";
            radioStudent.Size = new Size(93, 25);
            radioStudent.TabIndex = 2;
            radioStudent.TabStop = true;
            radioStudent.Text = "Student";
            radioStudent.UseVisualStyleBackColor = true;
            // 
            // radioPWD
            // 
            radioPWD.AutoSize = true;
            radioPWD.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioPWD.Location = new Point(488, 43);
            radioPWD.Name = "radioPWD";
            radioPWD.Size = new Size(70, 25);
            radioPWD.TabIndex = 1;
            radioPWD.TabStop = true;
            radioPWD.Text = "PWD";
            radioPWD.UseVisualStyleBackColor = true;
            // 
            // radioRegular
            // 
            radioRegular.AutoSize = true;
            radioRegular.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioRegular.Location = new Point(233, 43);
            radioRegular.Name = "radioRegular";
            radioRegular.Size = new Size(91, 25);
            radioRegular.TabIndex = 0;
            radioRegular.TabStop = true;
            radioRegular.Text = "Regular";
            radioRegular.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(51, 51, 51);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(711, 781);
            button1.Name = "button1";
            button1.Size = new Size(180, 44);
            button1.TabIndex = 10;
            button1.Text = "Generate Ticket";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnGenerateTicket_Click;
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
            btnClose.TabIndex = 72;
            btnClose.Text = "✖";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 844);
            Controls.Add(btnClose);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(btnBack);
            Controls.Add(groupBoxBusType);
            Controls.Add(lblEnterMunicipalityDestinatio);
            Controls.Add(lblDestination);
            Controls.Add(txtCurrentDestination);
            Controls.Add(lblEnterMunicipalityCurrentLocation);
            Controls.Add(lblCurrentLocation);
            Controls.Add(txtCurrentLocation);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            groupBoxBusType.ResumeLayout(false);
            groupBoxBusType.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label lblEnterMunicipalityCurrentLocation;
        private Label lblEnterMunicipalityDestinatio;
        private Label label4;
        private TextBox textBox2;
        private RadioButton radioAircon;
        private Button UserBut;
        private Button btnBack;
        private Button btnSearch;
        private TextBox txtCurrentLocation;
        private Label recLabelCurrentLocation;
        private Label recLabelDestination;
        private TextBox txtCurrentDestination;
        private GroupBox groupBoxBusType;
        private Label lblCurrentLocation;
        private Label lblDestination;
        private RadioButton radioNonAircon;
        private GroupBox groupBox1;
        private RadioButton radioPWD;
        private RadioButton radioRegular;
        private RadioButton radioSenior;
        private RadioButton radioStudent;
        private Button button1;
        private Button btnClose;
    }
}