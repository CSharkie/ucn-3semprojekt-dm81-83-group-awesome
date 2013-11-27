using AwesomeClient.ServiceReference;
using AwesomeServer;
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
    public partial class Form1 : Form
    {
        ServiceClient client = new ServiceClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Cols = 7;
            room.Rows = 7;
            client.createRoom(room);
        }
    }
}
