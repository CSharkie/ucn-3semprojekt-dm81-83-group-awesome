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
    public partial class Remove : Form
    {
        ServiceClient client = new ServiceClient();

        public Remove()
        {
            InitializeComponent();
        }

        #region Room
        private void room_btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = new Room();
                room.Id = Convert.ToInt32(room_txt_roomId.Text);
                MessageBox.Show(client.removeRoom(room.Id));
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }
        #endregion
        #region Movie
        private void movie_btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                Movie mov = new Movie();
                mov.Id = Convert.ToInt32(movie_txt_movieId.Text);
                MessageBox.Show(client.removeMovie(mov.Id));
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }
        #endregion
        #region Reservation
        private void reserv_btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation reserv = new Reservation();
                reserv.Id = Convert.ToInt32(reserv_txt_reservId.Text);
                MessageBox.Show(client.removeReservation(reserv.Id));
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }
        #endregion
        #region Discount
        private void discount_btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                Discount discount = new Discount();
                discount.Id = Convert.ToInt32(discount_txt_discountId.Text);
                MessageBox.Show(client.removeDiscount(discount.Id));
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }
        #endregion
        #region Ticket
        private void ticket_btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = new Ticket();
                ticket.Id = Convert.ToInt32(ticket_txt_ticketId.Text);
                MessageBox.Show(client.removeTicket(ticket.Id));
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error has occured: " + ex.Message);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            var movies = client.getMovie(movie_txt_movieId.Text != "" ? Convert.ToInt32(movie_txt_movieId.Text) : 0, movie_txt_title.Text, 0);

            if (movie_combo_movie.SelectedItem != null)
            {

                int indexStart = movie_combo_movie.SelectedItem.ToString().IndexOf("(");
                int indexStop = movie_combo_movie.SelectedItem.ToString().IndexOf(")");
                string stringId = movie_combo_movie.SelectedItem.ToString().Substring(indexStart + 1, indexStop - 1);
                if (indexStart != -1 && indexStop != -1)
                {
                    movies = client.getMovie(Convert.ToInt32(stringId), "", 0);
                    movie_txt_movieId.Text = movies.First().Id.ToString();
                    movie_txt_title.Text = movies.First().Title;
                }

            }
            IList<string> dataSource = new List<string>();
            dataSource.Add("Select One...");
            foreach (var item in movies)
                dataSource.Add("(" + item.Id + ")" + item.Title + " @ " + item.DateAndTime);

            movie_combo_movie.DataSource = dataSource;
            movie_combo_movie.SelectedIndex = movies.ToList().Count == 1 ? 1 : 0;


            if (movies.ToList().Count == 0)
            {
                MessageBox.Show("No movie found with that id or title");
            }
            else if (movies.ToList().Count > 1)
            {
                movie_combo_movie.Enabled = true;
            }
            else
            {
                movie_combo_movie.Enabled = false;
                movie_txt_movieId.Text = movies.First().Id.ToString();
                movie_txt_title.Text = movies.First().Title;
            }
        }

    }
}
