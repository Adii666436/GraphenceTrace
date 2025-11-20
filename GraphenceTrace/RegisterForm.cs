using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphenceTrace
{
    
    public partial class RegisterForm : Form
    {
        public static List<User> Users = new List<User>();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string role = cboRole.SelectedItem?.ToString();

            if (username == "" || password == "" || confirmPassword == "" || role == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            MessageBox.Show("Account created successfully!");

            // Go back to login
            Loginform login = new Loginform();
            login.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
