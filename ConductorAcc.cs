using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CeresBusManagement
{
    public partial class ConductorAcc : MainForm
    {
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aloan\Documents\CERESBUSMANAGEMENT\CeresDB.accdb;";

        public ConductorAcc()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            using (OleDbConnection connection = new OleDbConnection(connStr))
            {
                string query = @"SELECT 
                            EmployeeAccounts.EmployeeID, 
                            EmployeeAccounts.EmployeeName, 
                            EmployeeAccounts.Username, 
                            EmployeeAccounts.[Password], 
                            Buses.BusID AS AssignedBusID
                         FROM EmployeeAccounts
                         LEFT JOIN Buses ON Buses.ConductorName = EmployeeAccounts.EmployeeName";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvEmployeeAccounts.DataSource = dt;
            }
        }

        private bool UsernameExists(string username)
        {
            using (OleDbConnection connection = new OleDbConnection(connStr))
            {
                string checkQuery = "SELECT COUNT(*) FROM EmployeeAccounts WHERE Username = @username";
                OleDbCommand cmd = new OleDbCommand(checkQuery, connection);
                cmd.Parameters.AddWithValue("@username", username);

                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields must be filled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UsernameExists(username))
            {
                MessageBox.Show("Username already exists! Please choose another username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connStr))
            {
                string insertQuery = "INSERT INTO EmployeeAccounts (EmployeeName, Username, [Password]) " +
                                     "VALUES (@employeeName, @username, @password)";

                OleDbCommand cmd = new OleDbCommand(insertQuery, connection);
                cmd.Parameters.AddWithValue("@employeeName", employeeName);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); 

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadEmployeeData(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void ClearFields()
        {
            txtEmployeeName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
      
    }
}
