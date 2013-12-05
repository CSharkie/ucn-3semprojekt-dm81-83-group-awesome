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
    public partial class Update : Form
    {
        ServiceClient client = new ServiceClient();

        public Update()
        {
            InitializeComponent();
        }
        #region Room
        private void room_roomId_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void room_cols_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void room_rows_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void room_seats_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void room_show_btn_Click(object sender, EventArgs e)
        {
            try
            {


                Room room = new Room();
                room = client.getRoom(Convert.ToInt32(room_txt_roomId.Text));
                room_txt_cols.Text = room.Cols.ToString();
                room_txt_rows.Text = room.Rows.ToString();

                // Sets the buttons to Usable after you get something
                room_btn_edit.Enabled = true;
                room_btn_save.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void room_edit_btn_Click(object sender, EventArgs e)
        {
            room_txt_roomId.Enabled = false;
            room_txt_cols.Enabled = true;
            room_txt_rows.Enabled = true;
        }

        private void room_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = new Room();
                room.Id = Convert.ToInt32(room_txt_roomId.Text);
                room.Cols = Convert.ToInt32(room_txt_cols.Text);
                room.Rows = Convert.ToInt32(room_txt_rows.Text);
                client.updateRoom(room.Id, room.Cols, room.Rows);
                // Sets the buttons to Not Usable after you save
                room_txt_roomId.Enabled = true;
                room_txt_cols.Enabled = false;
                room_txt_rows.Enabled = false;
                room_btn_edit.Enabled = false;
                room_btn_save.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }
        #endregion
        #region Movie
        private void movie_movieId_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void movie_title_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void movie_date_picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void movie_roomId_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void movie_show_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Movie movie = new Movie();
                IList<Movie> movies = new List<Movie>();
                if (movie.Title.Contains(movie_txt_title.Text) || movie.Id.Equals(movie_txt_movieId.Text) || movie.RoomId.Equals(movie_txt_roomId.Text))
                {
                    movie.Title = movie_txt_title.Text;
                    movie.Id = Convert.ToInt32(movie_txt_movieId.Text);
                    movie.RoomId = Convert.ToInt32(movie_txt_roomId.Text);
                    movies = client.getMovie(movie.Id, movie.Title, movie.RoomId);
                    // TODO Need to display the found movie/movies
                }

                movie_btn_edit.Enabled = true;
                movie_btn_save.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }

        private void movie_edit_btn_Click(object sender, EventArgs e)
        {
            movie_txt_roomId.Enabled = true;
            movie_date_picker.Enabled = true;
            movie_txt_title.Enabled = true;
        }

        private void movie_save_btn_Click(object sender, EventArgs e)
        {
            movie_txt_roomId.Enabled = false;
            movie_date_picker.Enabled = false;
            movie_btn_edit.Enabled = false;
            movie_btn_save.Enabled = false;
        }
        #endregion
        #region Reservation
        private void reserv_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reserv_taken_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reserv_movieId_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reserv_seatCount_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reserv_show_btn_Click(object sender, EventArgs e)
        {
            reserv_btn_edit.Enabled = true;
            reserv_btn_save.Enabled = true;
        }

        private void reserv_edit_btn_Click(object sender, EventArgs e)
        {
            reserv_txt_seatCount.Enabled = true;
            reserv_txt_movieId.Enabled = true;
            reserv_check_taken.Enabled = true;
        }

        private void reserv_save_btn_Click(object sender, EventArgs e)
        {
            reserv_txt_seatCount.Enabled = false;
            reserv_check_taken.Enabled = false;
            reserv_txt_movieId.Enabled = false;
            reserv_btn_edit.Enabled = false;
            reserv_btn_save.Enabled = false;
        }
        #endregion
        #region Discount
        private void discount_id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void discount_percent_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void discount_show_btn_Click(object sender, EventArgs e)
        {
            discount_btn_edit.Enabled = true;
            discount_btn_save.Enabled = true;
        }

        private void discount_edit_btn_Click(object sender, EventArgs e)
        {
            discount_txt_percent.Enabled = true;
        }

        private void discount_save_btn_Click(object sender, EventArgs e)
        {
            discount_txt_percent.Enabled = false;
            discount_btn_edit.Enabled = false;
            discount_btn_save.Enabled = false;
        }
        #endregion
        #region Ticket
        private void ticket_id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ticket_price_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ticket_reservId_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ticket_discount_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ticket_show_btn_Click(object sender, EventArgs e)
        {
            ticket_btn_edit.Enabled = true;
            ticket_btn_save.Enabled = true;
        }

        private void ticket_edit_btn_Click(object sender, EventArgs e)
        {
            ticket_txt_discount.Enabled = true;
            ticket_txt_price.Enabled = true;
            ticket_txt_reservId.Enabled = true;
        }

        private void ticket_save_btn_Click(object sender, EventArgs e)
        {
            ticket_txt_discount.Enabled = false;
            ticket_txt_price.Enabled = false;
            ticket_txt_reservId.Enabled = false;
            ticket_btn_edit.Enabled = false;
            ticket_btn_save.Enabled = false;
        }
        #endregion
    }
}
