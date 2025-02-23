using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormPageApp
{
    public partial class ProfileForm : Form
    {
        private string username;
        public ProfileForm(string username)
        {
            InitializeComponent();
            this.username = username;
            this.Load += new EventHandler(ProfileForm_Load);
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            profileLabel.Text = $"Welcome, {username}!!";

        }
    }
}
