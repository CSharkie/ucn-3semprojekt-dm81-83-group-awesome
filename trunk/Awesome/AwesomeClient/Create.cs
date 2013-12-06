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
    public partial class Create : Form
    {
        ServiceClient client = new ServiceClient();

        public Create()
        {
            InitializeComponent();
        }

        private void room_create_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = new Room();
                room.Cols = Convert.ToInt32(room_txt_col.Text);
                room.Rows = Convert.ToInt32(room_txt_row.Text);
                client.createRoom(room.Cols, room.Rows);
                MessageBox.Show("The room was created succesfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void movie_btn_create_Click(object sender, EventArgs e)
        {
            Task task = new Task(new Action(() =>
                {
                    try
                    {

                        Movie movie = new Movie();
                        movie.Title = movie_txt_title.Text;
                        movie.DateAndTime = movie_date_picker.Value;
                        movie.RoomId = Convert.ToInt32(movie_txt_roomId.Text);
                        movie.Duration = new TimeSpan(0, Convert.ToInt32(movie_txt_duration.Text), 0);
                        client.createMovie(movie.Title, movie.DateAndTime, movie.Duration, movie.RoomId);
                        MessageBox.Show("The movie was added succesfully!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error has occured: " + ex.Message);
                    }
                }));
            task.Start();
        }

        private void reserv_btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                reserv_btn_create.Enabled = false;
                var movie = client.getMovie(reserv_txt_movieId.Text != "" ? Convert.ToInt32(reserv_txt_movieId.Text) : 0, reserv_txt_title.Text, 0);
                var movieSeats = movie.First().MovieSeats.ToList();
                int[] seatIds = new int[movieSeats.Count];
                int index = -1;
                foreach (CheckBox c in reserv_panel_room.Controls)
                {
                    if (c.Enabled && c.Checked)
                    {
                        index++;
                        seatIds[index] = (Convert.ToInt32(c.Name));
                    }
                }
                int[] desiredSeats = new int[index+1];
                for (int i = 0; i <= index; i++)
                {
                    desiredSeats[i] = seatIds[i];
                }
                MessageBox.Show(client.createReservation(
                    reserv_txt_name.Text,
                    reserv_chk_taken.Checked,
                    index,
                    movie.First().Id,
                    desiredSeats));

                reserv_btn_create.Enabled = false;
                reserv_btn_getRoom.Enabled = true;
                reserv_txt_movieId.Enabled = true;
                reserv_txt_name.Enabled = true;
                reserv_txt_title.Enabled = true;
                reserv_date_picker.Enabled = true;
                reserv_chk_taken.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
            
        }

        private void discount_btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                Discount disc = new Discount();
                disc.DPercent = Convert.ToDecimal(discount_txt_dPercent.Text);
                client.createDiscount(disc.DPercent);
                MessageBox.Show("The discount has been added succesfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void reserv_txt_movieId_TextChanged(object sender, EventArgs e)
        {

        }

        private void reserv_btn_getRoom_Click(object sender, EventArgs e)
        {
            try
            {
                //reserv_btn_getRoom.Enabled = false;
                //seats_pictureBox.CreateGraphics().Clear(Color.WhiteSmoke);

                var movie = client.getMovie(reserv_txt_movieId.Text != "" ? Convert.ToInt32(reserv_txt_movieId.Text) : 0, reserv_txt_title.Text, 0);
                if (movie.ToList().Count == 0)
                {
                    MessageBox.Show("No movie found with that id or title");
                }
                else if (movie.ToList().Count > 1)
                {
                    MessageBox.Show("More than one movie resulted from your search");
                }
                else
                {
                    Room room = client.getRoom(movie.First().RoomId);
                    IList<MovieSeat> movieSeats = movie.First().MovieSeats.ToList();
                    foreach (Control c in reserv_panel_room.Controls)
                        c.Dispose();
                    for (int i = 0; i < room.Rows; i++)
                    {
                        IList<Seat> seats = client.getSeat(0, room.Id, 0, i + 1, 0);
                        

                        for (int j=0; j < room.Cols; j++)
                        {
                            CheckBox cb = new CheckBox();
                            cb.Name = seats[j].Id.ToString();
                            cb.Text = seats[j].Id.ToString();
                            cb.Location = new System.Drawing.Point(j * 50, i * 50);
                            cb.Size = new System.Drawing.Size(50, 50);
                            MovieSeat ms = movieSeats.Single(item => item.SeatId == seats[j].Id);

                            if (ms != null && ms.ReservationId != null)
                            {
                                cb.Checked = true;
                                cb.Enabled = false;
                            }
                            this.reserv_panel_room.Controls.Add(cb);
                        }
                    }
                    reserv_btn_create.Enabled = true;
                    reserv_btn_getRoom.Enabled = false;
                    reserv_txt_movieId.Enabled = false;
                    reserv_txt_name.Enabled = false;
                    reserv_txt_title.Enabled = false;
                    reserv_date_picker.Enabled = false;
                    reserv_chk_taken.Enabled = false;
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
        }


    }
}
