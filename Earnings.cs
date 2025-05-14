using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CeresBusManagement
{
    public partial class Earnings : MainForm
    {
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aloan\Documents\CERESBUSMANAGEMENT\CeresDB.accdb;";

        public Earnings()
        {
            InitializeComponent();
        }

        private void Earnings_Load(object sender, EventArgs e)
        {
            LoadDailyEarnings(); 
        }

        // DAILY EARNINGS
        private void LoadDailyEarnings()
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string filter = "";
                    if (!string.IsNullOrEmpty(txtYear.Text) && !string.IsNullOrEmpty(cmbMonth.Text))
                    {
                        filter = $"WHERE Year(SaleDate) = {txtYear.Text} AND Month(SaleDate) = {cmbMonth.SelectedIndex + 1}";
                    }
                    else if (!string.IsNullOrEmpty(txtYear.Text))
                    {
                        filter = $"WHERE Year(SaleDate) = {txtYear.Text}";
                    }
                    else if (!string.IsNullOrEmpty(cmbMonth.Text))
                    {
                        filter = $"WHERE Month(SaleDate) = {cmbMonth.SelectedIndex + 1}";
                    }

                    string query = $"SELECT SaleDate, Amount FROM ManagementEarnings {filter} ORDER BY SaleDate ASC";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    chart1.Series.Clear();
                    Series series = new Series("Daily Earnings")
                    {
                        ChartType = SeriesChartType.Column,
                        Color = Color.DodgerBlue,
                        IsValueShownAsLabel = true,
                        IsXValueIndexed = true
                    };

                    decimal total = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        string saleDate = Convert.ToDateTime(row["SaleDate"]).ToString("yyyy-MM-dd");
                        decimal amount = Convert.ToDecimal(row["Amount"]);
                        series.Points.AddXY(saleDate, amount);
                        total += amount;
                    }

                    chart1.Series.Add(series);
                    FormatChart();
                    labelTotalEarnings.Text = "₱" + total.ToString("N2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading daily earnings: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                BeautifyDataGrid();
            }
        }


        // MONTHLY EARNINGS
        private void LoadMonthlyEarnings()
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string filter = "";
                    if (!string.IsNullOrEmpty(txtYear.Text))
                    {
                        filter = $"WHERE Year(SaleDate) = {txtYear.Text}";
                    }

                    string query = $@"SELECT 
                                Format(SaleDate, 'yyyy-mm') AS SaleMonth, 
                                Sum(Amount) AS TotalAmount 
                              FROM ManagementEarnings
                              {filter}
                              GROUP BY Format(SaleDate, 'yyyy-mm')
                              ORDER BY Format(SaleDate, 'yyyy-mm')";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    chart1.Series.Clear();
                    Series series = new Series("Monthly Earnings")
                    {
                        ChartType = SeriesChartType.Column,
                        Color = Color.MediumSeaGreen,
                        IsValueShownAsLabel = true,
                        IsXValueIndexed = true
                    };

                    decimal total = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        string saleMonth = row["SaleMonth"].ToString();
                        decimal amount = Convert.ToDecimal(row["TotalAmount"]);
                        series.Points.AddXY(saleMonth, amount);
                        total += amount;
                    }

                    chart1.Series.Add(series);
                    FormatChart();
                    labelTotalEarnings.Text = "₱" + total.ToString("N2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading monthly earnings: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                BeautifyDataGrid();
            }
        }


        // YEARLY EARNINGS
        private void LoadYearlyEarnings()
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                                        Year(SaleDate) AS SaleYear, 
                                        Sum(Amount) AS TotalAmount 
                                     FROM ManagementEarnings 
                                     GROUP BY Year(SaleDate)
                                     ORDER BY Year(SaleDate)";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    chart1.Series.Clear();
                    Series series = new Series("Yearly Earnings")
                    {
                        ChartType = SeriesChartType.Column,
                        Color = Color.Goldenrod,
                        IsValueShownAsLabel = true,
                        IsXValueIndexed = true
                    };

                    decimal total = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        string saleYear = row["SaleYear"].ToString();
                        decimal amount = Convert.ToDecimal(row["TotalAmount"]);
                        series.Points.AddXY(saleYear, amount);
                        total += amount;
                    }

                    chart1.Series.Add(series);
                    FormatChart();
                    labelTotalEarnings.Text = "₱" + total.ToString("N2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading yearly earnings: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                BeautifyDataGrid();
            }
        }

        private void btnEnterAmount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter an amount!", "Missing Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Invalid amount entered. Please enter a valid number greater than 0.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime saleDate = dateTimePicker1.Value.Date;

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM ManagementEarnings WHERE SaleDate = ?";
                    OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("?", saleDate);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        string updateQuery = "UPDATE ManagementEarnings SET Amount = Amount + ? WHERE SaleDate = ?";
                        OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("?", amount);
                        updateCmd.Parameters.AddWithValue("?", saleDate);
                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO ManagementEarnings (SaleDate, Amount) VALUES (?, ?)";
                        OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("?", saleDate);
                        insertCmd.Parameters.AddWithValue("?", amount);
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("✅ Amount added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Clear();
                    LoadDailyEarnings(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving earnings: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            LoadDailyEarnings();
        }
        private void btnMonthly_Click(object sender, EventArgs e)
        {
            LoadMonthlyEarnings();
        }

        private void btnYearly_Click(object sender, EventArgs e)
        {
            LoadYearlyEarnings();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnterYear_Click(object sender, EventArgs e)
        {
            if (btnDaily.Focused) 
            {
                LoadDailyEarnings();
            }
            else if (btnMonthly.Focused) 
            {
                LoadMonthlyEarnings();
            }
            else if (btnYearly.Focused) 
            {
                LoadYearlyEarnings();
            }
        }

        private void FormatChart()
        {
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorTickMark.Enabled = true;
            chart1.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorTickMark.Enabled = true;

            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void BeautifyDataGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }
    }
}
