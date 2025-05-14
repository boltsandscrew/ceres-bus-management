using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace CeresBusManagement
{
    public partial class Form2 : MainForm
    {
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aloan\Documents\CERESBUSMANAGEMENT\CeresDB.accdb;";

        public Form2()
        {
            InitializeComponent();
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string currentLocation = txtCurrentLocation.Text.Trim();
            string destination = txtCurrentDestination.Text.Trim();
            string busType = radioAircon.Checked ? "Aircon" : "Non-Aircon";
            string passengerType = GetPassengerType();

            if (currentLocation == "" || destination == "")
            {
                MessageBox.Show("Please enter both current location and destination.");
                return;
            }

            List<string> generalRoute = LoadGeneralRoute();

            int currentIndex = generalRoute.FindIndex(t => t.ToLower().Contains(currentLocation.ToLower()));
            int destinationIndex = generalRoute.FindIndex(t => t.ToLower().Contains(destination.ToLower()));

            if (currentIndex == -1 || destinationIndex == -1)
            {
                MessageBox.Show("Invalid locations. Please check your spelling or if towns exist in the route.");
                return;
            }

            List<string> results = new List<string>();

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Buses WHERE Type = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", busType);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string busCode = reader["BusID"].ToString();
                            string start = reader["StartingPoint"].ToString();
                            string end = reader["Destination"].ToString();
                            string departure = reader["DepartureTime"].ToString();
                            string passengerStatus = reader["PassengerStatus"].ToString();
                            string vacantSeats = reader["VacantSeats"].ToString();

                            int startIndex = generalRoute.FindIndex(t => t.Equals(start, StringComparison.OrdinalIgnoreCase));
                            int endIndex = generalRoute.FindIndex(t => t.Equals(end, StringComparison.OrdinalIgnoreCase));

                            bool isValidDirection = false;

                            if (startIndex < endIndex) // Forward
                            {
                                isValidDirection = currentIndex >= startIndex &&
                                                   destinationIndex <= endIndex &&
                                                   currentIndex < destinationIndex;
                            }
                            else if (startIndex > endIndex) // Reverse
                            {
                                isValidDirection = currentIndex <= startIndex &&
                                                   destinationIndex >= endIndex &&
                                                   currentIndex > destinationIndex;
                            }

                            if (isValidDirection)
                            {
                                decimal fare = GetFare(currentLocation, destination, busType, passengerType);

                                string statusColor = "";
                                if (passengerStatus.Equals("Vacant", StringComparison.OrdinalIgnoreCase))
                                    statusColor = "🟩 Vacant";
                                else if (passengerStatus.Equals("Standing", StringComparison.OrdinalIgnoreCase))
                                    statusColor = "🟧 Standing";
                                else if (passengerStatus.Equals("Full", StringComparison.OrdinalIgnoreCase))
                                    statusColor = "🟥 Full";
                                else
                                    statusColor = "⚪ Unknown";

                                results.Add(
                                    $"🚌 Bus Code: {busCode}\n" +
                                    $"📍 From: {start} ➡ {end}\n" +
                                    $"🕒 Departure: {departure}\n" +
                                    $"💺 Type: {busType}\n" +
                                    $"📊 Passenger Status: {statusColor}\n" +
                                    $"🔢 Available Seats: {vacantSeats}\n" +
                                    $"💰 Fare ({passengerType}): ₱{fare:F2}");
                            }
                        }
                    }
                }
            }

            if (results.Count > 0)
            {
                MessageBox.Show(string.Join("\n\n-----------------------------\n\n", results), "Available Buses");
            }
            else
            {
                MessageBox.Show("No available buses found for your selected criteria.");
            }
        }

   
        private void btnGenerateTicket_Click(object sender, EventArgs e)
        {
            string currentLocation = txtCurrentLocation.Text.Trim();
            string destination = txtCurrentDestination.Text.Trim();
            string busType = radioAircon.Checked ? "Aircon" : "Non-Aircon";
            string passengerType = GetPassengerType();

            if (currentLocation == "" || destination == "")
            {
                MessageBox.Show("Please enter both current location and destination.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal baseFare = GetFare(currentLocation, destination, busType, passengerType);
            decimal discount = 0;
            decimal totalFare = baseFare;

            if (passengerType == "Student" || passengerType == "PWD" || passengerType == "Senior")
            {
                discount = baseFare * 0.20m;
                totalFare = baseFare - discount;
            }

            int doorNumber = (busType == "Aircon") ? 7 : 6;

            string ticketID = GenerateProTicketID(currentLocation, destination);

            PassengerTicket ticketForm = new PassengerTicket();
            ticketForm.LoadTicket(ticketID, currentLocation, destination, DateTime.Now, passengerType, baseFare, discount, totalFare, doorNumber);
            ticketForm.Show();
        }


        private string GetPassengerType()
        {
            if (radioStudent.Checked) return "Student";
            if (radioPWD.Checked) return "PWD";
            if (radioSenior.Checked) return "Senior";
            return "Regular";
        }

        private List<string> LoadGeneralRoute()
        {
            List<string> route = new List<string>();
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query = "SELECT TownName FROM GeneralRoutes ORDER BY StopOrder ASC";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string town = reader["TownName"].ToString();
                    route.Add(town);
                }
            }
            return route;
        }

        private decimal GetFare(string origin, string destination, string busType, string passengerType)
        {
            decimal fare = 0;
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM FareRates WHERE StartingPoint = ? AND Destination = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", origin);
                cmd.Parameters.AddWithValue("?", destination);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    fare = busType == "Aircon"
                        ? Convert.ToDecimal(reader["AirconFare"])
                        : Convert.ToDecimal(reader["NonAirconFare"]);

                    if (passengerType == "Student" || passengerType == "PWD" || passengerType == "Senior")
                    {
                        fare *= 0.80m;
                    }
                }
            }
            return fare;
        }

        private string GenerateProTicketID(string currentLocation, string destination)
        {
            Random random = new Random();
            int randomNum = random.Next(1000, 9999);
            string datePart = DateTime.Now.ToString("yyMMdd");

            string start = currentLocation.Length >= 3 ? currentLocation.Substring(0, 3).ToUpper() : currentLocation.ToUpper();
            string end = destination.Length >= 3 ? destination.Substring(0, 3).ToUpper() : destination.ToUpper();

            return $"{start}{end}-{datePart}-{randomNum}";
        }

        private string GetFullRoute(string busType)
        {
            string fullStart = "";
            string fullDestination = "";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string query = "SELECT StartingPoint, Destination FROM Buses WHERE Type = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", busType);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            fullStart = reader["StartingPoint"].ToString();
                            fullDestination = reader["Destination"].ToString();
                        }
                    }
                }
            }

            return $"{fullStart} to {fullDestination}";
        }
    }
}
