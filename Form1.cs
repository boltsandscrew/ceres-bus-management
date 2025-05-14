using CeresBusManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeresBusManagement
{
    public partial class Form1 : MainForm
    {
        private Size formOriginalSize;
        private Rectangle recPassenger;
        private Rectangle recManagement;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            formOriginalSize = this.Size;
            recPassenger = new Rectangle(btnPassenger.Location, btnPassenger.Size);
            recManagement = new Rectangle(btnManagement.Location, btnManagement.Size);
        }

        private void btnPassenger_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            Form3 managementForm = new Form3();
            managementForm.Show();

            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conductor conductorForm = new Conductor();
            conductorForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}