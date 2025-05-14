namespace CeresBusManagement
{
    partial class Earnings
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Earnings));
            btnDaily = new Button();
            btnMonthly = new Button();
            btnYearly = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblCurrentLocation = new Label();
            txtAmount = new TextBox();
            label1 = new Label();
            btnEnter = new Button();
            btnBack = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            labelTotalEarnings = new Label();
            label4 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            txtYear = new TextBox();
            btnEnterYear = new Button();
            label3 = new Label();
            cmbMonth = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // btnDaily
            // 
            btnDaily.AutoSize = true;
            btnDaily.BackColor = Color.FromArgb(243, 146, 0);
            btnDaily.BackgroundImageLayout = ImageLayout.None;
            btnDaily.FlatAppearance.BorderSize = 0;
            btnDaily.FlatStyle = FlatStyle.Flat;
            btnDaily.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaily.ForeColor = Color.FromArgb(241, 237, 224);
            btnDaily.Location = new Point(586, 33);
            btnDaily.Name = "btnDaily";
            btnDaily.Size = new Size(251, 73);
            btnDaily.TabIndex = 3;
            btnDaily.Text = " Daily Earnings";
            btnDaily.UseVisualStyleBackColor = false;
            btnDaily.Click += btnDaily_Click;
            // 
            // btnMonthly
            // 
            btnMonthly.AutoSize = true;
            btnMonthly.BackColor = Color.FromArgb(243, 146, 0);
            btnMonthly.BackgroundImageLayout = ImageLayout.None;
            btnMonthly.FlatAppearance.BorderSize = 0;
            btnMonthly.FlatStyle = FlatStyle.Flat;
            btnMonthly.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMonthly.ForeColor = Color.FromArgb(241, 237, 224);
            btnMonthly.Location = new Point(851, 33);
            btnMonthly.Name = "btnMonthly";
            btnMonthly.Size = new Size(251, 73);
            btnMonthly.TabIndex = 4;
            btnMonthly.Text = "Monthly Earnings";
            btnMonthly.UseVisualStyleBackColor = false;
            btnMonthly.Click += btnMonthly_Click;
            // 
            // btnYearly
            // 
            btnYearly.AutoSize = true;
            btnYearly.BackColor = Color.FromArgb(243, 146, 0);
            btnYearly.BackgroundImageLayout = ImageLayout.None;
            btnYearly.FlatAppearance.BorderSize = 0;
            btnYearly.FlatStyle = FlatStyle.Flat;
            btnYearly.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYearly.ForeColor = Color.FromArgb(241, 237, 224);
            btnYearly.Location = new Point(1115, 33);
            btnYearly.Name = "btnYearly";
            btnYearly.Size = new Size(251, 73);
            btnYearly.TabIndex = 5;
            btnYearly.Text = "Yearly Earnings";
            btnYearly.UseVisualStyleBackColor = false;
            btnYearly.Click += btnYearly_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(376, 779);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // lblCurrentLocation
            // 
            lblCurrentLocation.AutoSize = true;
            lblCurrentLocation.BackColor = Color.Transparent;
            lblCurrentLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentLocation.ForeColor = Color.FromArgb(241, 237, 224);
            lblCurrentLocation.Location = new Point(706, 780);
            lblCurrentLocation.Name = "lblCurrentLocation";
            lblCurrentLocation.Size = new Size(150, 28);
            lblCurrentLocation.TabIndex = 9;
            lblCurrentLocation.Text = "Enter Amount: ";
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Location = new Point(857, 779);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(263, 31);
            txtAmount.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(241, 237, 224);
            label1.Location = new Point(248, 780);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 10;
            label1.Text = "Enter Date: ";
            // 
            // btnEnter
            // 
            btnEnter.AutoSize = true;
            btnEnter.BackColor = Color.FromArgb(243, 146, 0);
            btnEnter.BackgroundImageLayout = ImageLayout.None;
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = SystemColors.ButtonFace;
            btnEnter.Location = new Point(1186, 788);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(180, 44);
            btnEnter.TabIndex = 27;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnterAmount_Click;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = Color.FromArgb(243, 146, 0);
            btnBack.BackgroundImageLayout = ImageLayout.None;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(21, 788);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 44);
            btnBack.TabIndex = 26;
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
            btnClose.Location = new Point(1344, -3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 30);
            btnClose.TabIndex = 70;
            btnClose.Text = "✖";
            btnClose.TextAlign = ContentAlignment.TopCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.MenuBar;
            dataGridView1.Location = new Point(32, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(435, 359);
            dataGridView1.TabIndex = 71;
            // 
            // labelTotalEarnings
            // 
            labelTotalEarnings.AutoSize = true;
            labelTotalEarnings.BackColor = Color.Transparent;
            labelTotalEarnings.Font = new Font("Space Mono", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalEarnings.Location = new Point(221, 550);
            labelTotalEarnings.Name = "labelTotalEarnings";
            labelTotalEarnings.Size = new Size(80, 24);
            labelTotalEarnings.TabIndex = 75;
            labelTotalEarnings.Text = "label12";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Space Mono", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 550);
            label4.Name = "label4";
            label4.Size = new Size(170, 24);
            label4.TabIndex = 72;
            label4.Text = "Total Earnings: ";
            // 
            // chart1
            // 
            chart1.BorderlineColor = Color.DimGray;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(489, 177);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(857, 480);
            chart1.TabIndex = 78;
            chart1.Text = "chart1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Space Mono", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 633);
            label2.Name = "label2";
            label2.Size = new Size(70, 24);
            label2.TabIndex = 80;
            label2.Text = "Year: ";
            // 
            // txtYear
            // 
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Location = new Point(189, 626);
            txtYear.Multiline = true;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(263, 31);
            txtYear.TabIndex = 79;
            // 
            // btnEnterYear
            // 
            btnEnterYear.AutoSize = true;
            btnEnterYear.BackColor = Color.FromArgb(255, 251, 246);
            btnEnterYear.BackgroundImageLayout = ImageLayout.None;
            btnEnterYear.FlatAppearance.BorderSize = 0;
            btnEnterYear.FlatStyle = FlatStyle.Flat;
            btnEnterYear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnterYear.ForeColor = Color.FromArgb(255, 251, 246);
            btnEnterYear.Location = new Point(-2, 686);
            btnEnterYear.Name = "btnEnterYear";
            btnEnterYear.Size = new Size(124, 38);
            btnEnterYear.TabIndex = 81;
            btnEnterYear.Text = "Show Data";
            btnEnterYear.UseVisualStyleBackColor = false;
            btnEnterYear.Click += btnEnterYear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Space Mono", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(35, 596);
            label3.Name = "label3";
            label3.Size = new Size(80, 24);
            label3.TabIndex = 83;
            label3.Text = "Month: ";
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cmbMonth.Location = new Point(189, 587);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(263, 33);
            cmbMonth.TabIndex = 84;
            // 
            // Earnings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 844);
            Controls.Add(cmbMonth);
            Controls.Add(label3);
            Controls.Add(btnEnterYear);
            Controls.Add(label2);
            Controls.Add(txtYear);
            Controls.Add(chart1);
            Controls.Add(labelTotalEarnings);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnEnter);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(lblCurrentLocation);
            Controls.Add(txtAmount);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnYearly);
            Controls.Add(btnMonthly);
            Controls.Add(btnDaily);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Earnings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Earnings";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDaily;
        private Button btnMonthly;
        private Button btnYearly;
        private DateTimePicker dateTimePicker1;
        private Label lblCurrentLocation;
        private TextBox txtAmount;
        private Label label1;
        private Button btnEnter;
        private Button btnBack;
        private Button btnClose;
        private DataGridView dataGridView1;
        private Label labelTotalEarnings;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label2;
        private TextBox txtYear;
        private Button btnEnterYear;
        private Label label3;
        private ComboBox cmbMonth;
    }
}