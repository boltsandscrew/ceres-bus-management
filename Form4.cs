using System;
using System.Windows.Forms;

namespace CeresBusManagement
{
    public partial class Form4 : MainForm
    {
        private BusManagement busManager;

        public Form4()
        {
            InitializeComponent();
            busManager = new BusManagement(); 
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            AddNewBusForm addForm = new AddNewBusForm(busManager); 
            addForm.ShowDialog();
        }

        private void btnRemoveBus_Click(object sender, EventArgs e)
        {
            RemoveBus removeBusForm = new RemoveBus();
            removeBusForm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
        private void btnTicket_Click(object sender, EventArgs e)
        {
            TicketStation TicketStationForm = new TicketStation();
            TicketStationForm.ShowDialog();
        }
        private void btnUpdateBus_Click(object sender, EventArgs e)
        {
            UpdateBus UpdateBusForm = new UpdateBus();
            UpdateBusForm.ShowDialog();
        }
        private void btnSearchBus_Click(object sender, EventArgs e)
        {
            SearchBus SearchBusForm = new SearchBus();
            SearchBusForm.ShowDialog();
        }
        private void btnEmployeeAccount_Click(object sender, EventArgs e)
        {
           ConductorAcc ConductorAccForm = new ConductorAcc();
            ConductorAccForm.ShowDialog();
        }
        private void btnEarnings_Click(object sender, EventArgs e)
        {
            Earnings EarningsForm = new Earnings();
            EarningsForm.ShowDialog();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

    }
}
