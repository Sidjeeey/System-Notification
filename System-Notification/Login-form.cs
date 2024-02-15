using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace System_Notification
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=FTP-IT-LAG042\SQLEXPRESS;Initial Catalog=EmplyeeCertManagement;Integrated Security=True");

        private void Loginbttn_Click(object sender, EventArgs e)
        {
            string username = UserNameBox.Text.Trim();
            string password = PasswordBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Check if the username and password match
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Hardcoded username and password for demonstration purposes
            const string validUsername = "admin";
            const string validPassword = "admin";

            return username == validUsername && password == validPassword;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
        }
    }

}
