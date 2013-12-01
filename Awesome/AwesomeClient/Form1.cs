using AwesomeClient.ServiceReference;
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
            //Room room = new Room();
            //room.Rows = 10;
            //room.Cols = 10;
            //client.createRoom(room);
            MessageBox.Show("WERKZ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Movie movie = new Movie();
            //movie.Title = "TEST";
            //movie.DateAndTime = DateTime.Now;
            //movie.RoomId = 1;
            //client.createMovie(movie);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text=client.getRoom(8).Id.ToString();
        }
    }
}
