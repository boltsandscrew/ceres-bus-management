using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace CeresBusManagement
{
    public partial class Form3 : MainForm
    {
        public Form3()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = new Form1();

            if (this.WindowState == FormWindowState.Maximized)
            {
                form1.WindowState = FormWindowState.Maximized;
            }

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
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string hashedInputPassword = HashPassword(password);

            string storedHashedPassword = HashPassword("12345");

            if (username == "admin" && hashedInputPassword == storedHashedPassword)
            {
                Form4 form4 = new Form4();

                if (this.WindowState == FormWindowState.Maximized)
                {
                    form4.WindowState = FormWindowState.Maximized;
                }
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
