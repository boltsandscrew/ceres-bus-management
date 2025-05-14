using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CeresBusManagement
{
    public partial class Conductor : MainForm
    {
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aloan\Documents\CERESBUSMANAGEMENT\CeresDB.accdb;";

        public Conductor()
        {
            InitializeComponent();
            LoadBusData(); 
        }

        private void LoadBusData()
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "SELECT BusID, StartingPoint, Destination, Route, Type, DriverName, ConductorName, PassengerStatus, VacantSeats FROM Buses";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridBusStatus.DataSource = dt;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string query = "SELECT EmployeeName FROM EmployeeAccounts WHERE Username = @username AND [Password] = @password";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); 

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string employeeName = result.ToString();

                        string busQuery = "SELECT BusID FROM Buses WHERE ConductorName = @conductorName";
                        OleDbCommand busCmd = new OleDbCommand(busQuery, conn);
                        busCmd.Parameters.AddWithValue("@conductorName", employeeName);

                        object busResult = busCmd.ExecuteScalar();

                        if (busResult != null)
                        {
                            txtBusCode.Text = busResult.ToString(); 
                            MessageBox.Show("Login Successful!");
                        }
                        else
                        {
                            MessageBox.Show("No assigned bus found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string busID = txtBusCode.Text.Trim();
            string passengerStatus = cmbPassengerStatus.Text.Trim();
            int vacantSeats;

            if (string.IsNullOrEmpty(busID) || string.IsNullOrEmpty(passengerStatus) || !int.TryParse(txtVacantSeats.Text.Trim(), out vacantSeats))
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                string updateQuery = "UPDATE Buses SET PassengerStatus = ?, VacantSeats = ? WHERE BusID = ?";
                OleDbCommand cmd = new OleDbCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@PassengerStatus", passengerStatus);
                cmd.Parameters.AddWithValue("@VacantSeats", vacantSeats);
                cmd.Parameters.AddWithValue("@BusID", busID);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Passenger status updated successfully!");
                        LoadBusData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update. Please check the Bus Code.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating passenger status: " + ex.Message);
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = new Form1();
            if (this.WindowState == FormWindowState.Maximized)
                form1.WindowState = FormWindowState.Maximized;

            form1.Show();
            this.Hide();
        }
    }
}
