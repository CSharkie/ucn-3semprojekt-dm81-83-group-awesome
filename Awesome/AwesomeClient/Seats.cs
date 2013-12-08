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
using AwesomeServer;
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
            Task task = new Task(() =>
                {
                    try
                    {

                        seats_pictureBox.CreateGraphics().Clear(Color.WhiteSmoke);
                        Movie movie = client.getMovie(Convert.ToInt32(txt_roomId.Text), "", 0).First();
                        IList<MovieSeat> movieSeats = movie.MovieSeats.ToList();
                        Room room = client.getRoom(movie.RoomId);
                        
                        int width = 20; //this.ClientRectangle.Width / room.Cols-(5*room.Cols);
                        for (int i = 0; i < room.Rows; i++)
                        {
                            IList<Seat> seats = client.getSeat(0, room.Id, 0, i + 1, 0);
                            for(int j=0; j< room.Cols; j++)
                            {
                                Rectangle r = new Rectangle(j * width + j * 5, i * width + i * 5, width, width);
                                SolidBrush pen = new SolidBrush(Color.Green);
                                MovieSeat ms = movieSeats.Where(m => m.SeatId == seats[j].Id).First();
                                if (ms.ReservationId != null)
                                    pen = new SolidBrush(Color.Red);
                                seats_pictureBox.CreateGraphics().FillRectangle(pen, r);
                            }
                        }

                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("The room does not exist.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured: " + ex.Message);
                    }
                });
            task.Start();
        }
    }
}
