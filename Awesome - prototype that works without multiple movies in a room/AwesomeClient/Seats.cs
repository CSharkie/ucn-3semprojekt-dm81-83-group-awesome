using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AwesomeClient.ServiceReference;

namespace AwesomeClient
{
    public partial class Seats : Form
    {
        ServiceClient client = new ServiceClient();

        public Seats()
        {
            InitializeComponent();
        }

        private void getRoom_btn_Click(object sender, EventArgs e)
        {
            seats_pictureBox.CreateGraphics().Clear(Color.WhiteSmoke);
            Room room = new Room();
            room = client.getRoom(Convert.ToInt32(txt_roomId.Text));
            int width = 20; //this.ClientRectangle.Width / room.Cols-(5*room.Cols);
            for (int i = 0; i < room.Rows; i++)
            {
                IList<Seat> seats = client.getSeat(0, room.Id, 0, i+1, 0);
                for (int j = 0; j < room.Cols; j++)
                {
                    Rectangle r = new Rectangle(j * width+j*5, i * width+i*5, width, width);
                    SolidBrush pen = new SolidBrush(Color.Green);
                    if(seats[j].Usable==false)
                        pen = new SolidBrush(Color.Red);
                        seats_pictureBox.CreateGraphics().FillRectangle(pen, r);
                }
            }
        }
    }
}
