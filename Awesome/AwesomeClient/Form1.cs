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
            room.Rows = 10;
            room.Cols = 10;
            client.createRoom(room);
            MessageBox.Show("WERKZ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.DateAndTime = DateTime.Now;
            movie.Title = "GERAPPA";
            Room room=new Room();
            room.Id=1;
            room = client.getRoom(room);
            movie.Room = room;
            client.createMovie(movie);
        }
    }
}
