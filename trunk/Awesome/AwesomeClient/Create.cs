using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            try
            {
                Movie movie = new Movie();
                movie.Title = movie_txt_title.Text;
                movie.DateAndTime = movie_date_picker.Value;
                movie.RoomId = Convert.ToInt32(movie_txt_roomId.Text);
                client.createMovie(movie.Title, movie.DateAndTime, movie.RoomId);
                MessageBox.Show("The movie was added succesfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void reserv_btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation reserv = new Reservation();
                reserv.Name = reserv_txt_name.Text;
                if (reserv_taken_chk.Checked)
                {
                    reserv.Taken = true;
                }
                else
                {
                    reserv.Taken = false;
                }
                reserv.DateReserved = reserv_date_picker.Value;
                reserv.MovieId = Convert.ToInt32(reserv_txt_movieId.Text);
                reserv.SeatCount = Convert.ToInt32(reserv_txt_seatCount.Text);
                // TODO Fix create reservation
                //client.createReservation(reserv.Name, reserv.Taken, reserv.DateReserved, reserv.MovieId, reserv.SeatCount);
                MessageBox.Show("The reservation has been created succesfully!");
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

        
    }
}
