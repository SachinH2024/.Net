using LoginFormPageApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormPageApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            AuthenticationService authService = new AuthenticationService();
            bool isAuthenticated = authService.Authenticate(username, password);

            if (!isAuthenticated)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }

            this.Hide();
            ProfileForm profileForm = new ProfileForm(username);
            profileForm.Show();
        }
    }
}
