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

        private void movie_btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                var movie = client.getMovie(movie_txt_movieId.Text != "" ? Convert.ToInt32(movie_txt_movieId.Text) : 0, movie_txt_title.Text, 0);

                if (movie_combo_movies.SelectedItem != null)
                {

                    int indexStart = movie_combo_movies.SelectedItem.ToString().IndexOf("(");
                    int indexStop = movie_combo_movies.SelectedItem.ToString().IndexOf(")");
                    string stringId = movie_combo_movies.SelectedItem.ToString().Substring(indexStart + 1, indexStop - 1);
                    if (indexStart != -1 && indexStop != -1)
                    {
                        movie = client.getMovie(Convert.ToInt32(stringId), "", 0);
                        movie_txt_movieId.Text = movie.First().Id.ToString();
                    }

                }
                IList<string> dataSource = new List<string>();
                dataSource.Add("Select One...");
                foreach (var item in movie)
                    dataSource.Add("(" + item.Id + ")" + item.Title + " @ " + item.DateAndTime);

                movie_combo_movies.DataSource = dataSource;
                movie_combo_movies.SelectedIndex = movie.ToList().Count == 1 ? 1 : 0;


                if (movie.ToList().Count == 0)
                {
                    MessageBox.Show("No movie found with that id or title");
                }
                else if (movie.ToList().Count > 1)
                {
                    movie_combo_movies.Enabled = true;
                    movie_btn_show.Enabled = true;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The movie does not exist.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select the movie from the list!");
                movie_btn_show.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
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
                    // TODO Need to get the displayed movie on select from Combo Box
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

            try
            {
                var reserv = client.getReservation(reserv_txt_movieId.Text != "" ? Convert.ToInt32(reserv_txt_reservId.Text) : 0, reserv_txt_name.Text);

                if (reserv_combo_reservations != null)
                {
                    int indexStart = reserv_combo_reservations.SelectedItem.ToString().IndexOf("(");
                    int indexStop = reserv_combo_reservations.SelectedItem.ToString().IndexOf(")");
                    string stringId = reserv_combo_reservations.SelectedItem.ToString().Substring(indexStart + 1, indexStop - 1);
                    if (indexStart != -1 && indexStop != -1)
                    {
                        reserv = client.getReservation(Convert.ToInt32(stringId), "");
                        reserv_txt_movieId.Text = reserv.First().Id.ToString();
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The Reservation does not exist.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select the reservation from the list!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
        }

        private void reserv_edit_btn_Click(object sender, EventArgs e)
        {
            Reservation reserv = new Reservation();
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
            try
            {
                //Discount discount = new Discount();
                var discount = client.getDiscount(discount_txt_id.Text != "" ? Convert.ToInt32(discount_txt_id.Text) : 0, discount_txt_percent.Text != "" ? Convert.ToDecimal(discount_txt_percent.Text) : 0);
                discount_txt_id.Text = discount.Id.ToString();
                discount_txt_percent.Text = discount.DPercent.ToString();


                discount_btn_edit.Enabled = true;
                discount_btn_save.Enabled = false;
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

        private void discount_edit_btn_Click(object sender, EventArgs e)
        {
            discount_btn_show.Enabled = false;
            discount_btn_edit.Enabled = false;
            discount_btn_save.Enabled = true;
        }

        private void discount_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Discount discount = new Discount();
                discount.Id = Convert.ToInt32(discount_txt_id.Text);
                discount.DPercent = Convert.ToDecimal(discount_txt_percent.Text);
                client.updateDiscount(discount.Id, discount.DPercent);
                // Sets the buttons to Not Usable after you save
                discount_btn_edit.Enabled = false;
                discount_btn_save.Enabled = false;
                discount_btn_show.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured: " + ex.Message);
            }
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
            try
            {
                Ticket ticket = new Ticket();
                var tickets = client.getTicket(ticket_txt_id.Text != "" ? Convert.ToInt32(ticket_txt_id.Text) : 0, ticket_txt_reservId.Text != "" ? Convert.ToInt32(ticket_txt_reservId.Text) : 0);

                ticket_txt_id.Text = ticket.Id.ToString();
                ticket_txt_reservId.Text = ticket.ReservationId.ToString();
                ticket_txt_price.Text = ticket.Price.ToString();
                ticket_txt_discount.Text = ticket.Discount.ToString();

                ticket_btn_edit.Enabled = true;
                ticket_btn_save.Enabled = true;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
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
