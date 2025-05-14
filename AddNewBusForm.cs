using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CeresBusManagement
{
    public partial class AddNewBusForm : MainForm
    {
        private BusManagement busManager;

        public AddNewBusForm(BusManagement manager)
        {
            InitializeComponent();
            busManager = manager;
            this.Load += AddNewBusForm_Load; 
        }

        private void AddNewBusForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string busID = txtBusCode.Text.Trim();
            string startPoint = txtStartingPoint.Text.Trim();
            string destination = txtDestination.Text.Trim();
            string route = $"{startPoint} to {destination}";
            string type = rbAircon.Checked ? "Aircon" : "Non-Aircon";
            string driver = txtDriver.Text.Trim();
            string conductor = txtConductor.Text.Trim();
            string departureTime = txtDepartureTime.Text.Trim();

            // Validate
            if (string.IsNullOrWhiteSpace(busID) || string.IsNullOrWhiteSpace(startPoint) ||
                string.IsNullOrWhiteSpace(destination) || string.IsNullOrWhiteSpace(driver) ||
                string.IsNullOrWhiteSpace(conductor) || (!rbAircon.Checked && !rbNonAircon.Checked))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to add this bus?", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            Employee driverEmp = new Employee(driver, "Driver");
            Employee conductorEmp = new Employee(conductor, "Conductor");
            Bus newBus = new Bus(busID, $"{route} ({type})", driverEmp, conductorEmp, departureTime);

            // INSERT into Access
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aloan\Documents\CERESBUSMANAGEMENT\CeresDB.accdb;";
            string query = "INSERT INTO Buses (BusID, StartingPoint, Destination, Route, Type, DriverName, ConductorName, DepartureTime) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", busID);
                    cmd.Parameters.AddWithValue("?", startPoint);
                    cmd.Parameters.AddWithValue("?", destination);
                    cmd.Parameters.AddWithValue("?", route);
                    cmd.Parameters.AddWithValue("?", type);
                    cmd.Parameters.AddWithValue("?", driver);
                    cmd.Parameters.AddWithValue("?", conductor);
                    cmd.Parameters.AddWithValue("?", departureTime);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bus added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        busManager.AddBus(newBus);

                        ClearFields();
                        LoadData();
                    }
                    catch (OleDbException ex)
                    {
                        if (ex.Message.Contains("duplicate") || ex.Message.Contains("constraint") || ex.ErrorCode == -2147467259)
                        {
                            MessageBox.Show("Bus ID already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Error adding bus to database:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadData()
        {
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aloan\Documents\CERESBUSMANAGEMENT\CeresDB.accdb;";
            string query = "SELECT BusID, StartingPoint, Destination, Route, Type, DriverName, ConductorName, DepartureTime FROM Buses";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        System.Data.DataTable table = new System.Data.DataTable();
                        adapter.Fill(table);
                        dataGridBuses.DataSource = table;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading buses: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ClearFields()
        {
            txtBusCode.Clear();
            txtStartingPoint.Clear();
            txtDestination.Clear();
            txtDriver.Clear();
            txtConductor.Clear();
            txtDepartureTime.Clear();
            rbAircon.Checked = false;
            rbNonAircon.Checked = false;
        }
    }
}
