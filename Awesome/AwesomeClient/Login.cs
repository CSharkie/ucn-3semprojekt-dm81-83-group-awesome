using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AwesomeServer;
using AwesomeClient.ServiceReference;

namespace AwesomeClient
{
    public partial class Login : Form
    {
        ServiceClient client = new ServiceClient();
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (client.login(username_txt.Text, password_txt.Text))
                {
                    new Main().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }
    }
}
