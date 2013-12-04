using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomeClient
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            Create form = new Create();
            form.ShowDialog();
        }

        private void read_Click(object sender, EventArgs e)
        {
            Read form = new Read();
            form.ShowDialog();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Update form = new Update();
            form.ShowDialog();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            Remove form = new Remove();
            form.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seats_btn_Click(object sender, EventArgs e)
        {
            Seats form = new Seats();
            form.ShowDialog();
        }
    }
}
