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
using System.Threading;
using System.Text.RegularExpressions;

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

                        MessageBox.Show(client.createMovie(movie.Title, movie.DateAndTime, movie.Duration, movie.RoomId));
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
                int[] desiredSeats = new int[index + 1];
                bool atLeastOne = false;
                for (int i = 0; i <= index; i++)
                {
                    desiredSeats[i] = seatIds[i];
                    atLeastOne = true;
                }
                if (atLeastOne)
                {
                    MessageBox.Show(client.createReservation(
                        reserv_txt_name.Text,
                        //reserv_txt_email.Text,
                        reserv_chk_taken.Checked,
                        index,
                        movie.First().Id,
                        desiredSeats));
                    reserv_btn_reset_Click(null, null);
                }
                else
                {
                    MessageBox.Show("At least one seat must be taken. Please select the desired seats");
                    reserv_btn_create.Enabled = true;
                }


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
                // lock the buttons
                reserv_btn_getRoom.Enabled = false;
                reserv_txt_movieId.Enabled = false;
                reserv_txt_name.Enabled = false;
                //reserv_txt_email.Enabled = false;
                reserv_txt_title.Enabled = false;
                reserv_chk_taken.Enabled = false;

                //do the magic
                var movie = client.getMovie(reserv_txt_movieId.Text != "" ? Convert.ToInt32(reserv_txt_movieId.Text) : 0, reserv_txt_title.Text, 0);

                //fill the list
                if (reserv_combo_movie.SelectedItem != null)
                {

                    int indexStart = reserv_combo_movie.SelectedItem.ToString().IndexOf("(");
                    int indexStop = reserv_combo_movie.SelectedItem.ToString().IndexOf(")");
                    string stringId = reserv_combo_movie.SelectedItem.ToString().Substring(indexStart + 1, indexStop - 1);
                    if (indexStart != -1 && indexStop != -1)
                    {
                        movie = client.getMovie(Convert.ToInt32(stringId), "", 0);
                        reserv_txt_movieId.Text = movie.First().Id.ToString();
                    }

                }
                //int id = Convert.ToInt32("");

                IList<string> dataSource = new List<string>();
                dataSource.Add("Select One...");
                foreach (var item in movie)
                    dataSource.Add("(" + item.Id + ")" + item.Title + " @ " + item.DateAndTime);

                reserv_combo_movie.DataSource = dataSource;
                reserv_combo_movie.SelectedIndex = movie.ToList().Count == 1 ? 1 : 0;


                if (movie.ToList().Count == 0)
                {
                    MessageBox.Show("No movie found with that id or title");
                }
                else if (movie.ToList().Count > 1)
                {
                    reserv_combo_movie.Enabled = true;
                    reserv_btn_getRoom.Enabled = true;
                }
                else
                {
                    reserv_combo_movie.Enabled = false;
                    reserv_btn_getRoom.Enabled = false;
                    Room room = client.getRoom(movie.First().RoomId);
                    IList<MovieSeat> movieSeats = movie.First().MovieSeats.ToList();
                    reserv_panel_room.Controls.Clear();
                    int k = -1;
                    for (int i = 0; i < room.Rows; i++)
                    {
                        IList<Seat> seats = client.getSeat(0, room.Id, 0, i + 1, 0);


                        for (int j = 0; j < room.Cols; j++)
                        {
                            k++;
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
                    //if everything went right, enable the create button
                    reserv_btn_create.Enabled = true;
                    reserv_txt_movieId.Text = movie.First().Id.ToString();
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The room does not exist.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select the movie from the list!");
                reserv_btn_getRoom.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }

        }

        private void reserv_btn_reset_Click(object sender, EventArgs e)
        {
            reserv_btn_create.Enabled = false;
            reserv_btn_getRoom.Enabled = true;
            reserv_chk_taken.Enabled = true;
            reserv_combo_movie.Enabled = false;
            reserv_combo_movie.DataSource = null;
            reserv_txt_movieId.Enabled = true;
            reserv_txt_movieId.Text = "";
            reserv_txt_name.Enabled = true;
            reserv_txt_name.Text = "";
            //reserv_txt_email.Enabled = true;
            //reserv_txt_email.Text = "";
            reserv_txt_title.Enabled = true;
            reserv_txt_title.Text = "";

            reserv_panel_room.Controls.Clear();
        }

        List<CheckBox> adjList = new List<CheckBox>();
        int index = 0;
        int noOfSeats = 1;

        private void reserv_btn_getAdj_Click(object sender, EventArgs e)
        {
            adjList = new List<CheckBox>();
            index = 0;
            Room room = new Room();
            Movie movie = new Movie();
            Thread.Sleep(50);
            movie = client.getMovie(Convert.ToInt32(reserv_txt_movieId.Text), "", 0).First();
            room = client.getRoom(movie.RoomId);


            List<CheckBox> permSeats = new List<CheckBox>();
            int k = -1;
            for (int i = 0; i < room.Rows; i++)
            {
                for (int j = 0; j < room.Cols; j++)
                {
                    k++;
                    if (reserv_panel_room.Controls[k].Enabled == true)
                    {
                        permSeats.Add((CheckBox)reserv_panel_room.Controls[k]);
                    }
                    else
                    {
                        if (permSeats.Count != 0 && permSeats.Count >= noOfSeats)
                        {
                            foreach (var item in permSeats)
                            {
                                adjList.Add(item);
                            }
                        }
                        permSeats.Clear();
                    }
                }
                if (permSeats.Count != 0 && permSeats.Count >= noOfSeats)
                {
                    foreach (var item in permSeats)
                    {
                        adjList.Add(item);
                    }
                    //permSeats.Clear();
                }
                permSeats.Clear();
            }
            if (adjList.Count == 0)
            {
                MessageBox.Show("There are no " + noOfSeats + " adjecent seats available, checking for " + (noOfSeats - 1));
                noOfSeats = noOfSeats - 1;
                reserv_btn_getAdj_Click(this, null);

            }
        }

        private void reserv_btn_next_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            Movie movie = new Movie();
            Thread.Sleep(50);
            movie = client.getMovie(Convert.ToInt32(reserv_txt_movieId.Text), "", 0).First();
            room = client.getRoom(movie.RoomId);
            int i = 0;
        Mark1:
            foreach (CheckBox item in adjList)
            {
                item.Checked = false;
            }
            int limit = index + noOfSeats;
            while(client.getSeat(Convert.ToInt32(adjList[index].Text),0,0,0,0).First().Row==client.getSeat(Convert.ToInt32(adjList[limit-1].Text),0,0,0,0).First().Row)
            {
                for (i = index; i < limit - 1; i++)
                {
                    if (Convert.ToInt32(adjList[i].Text) + 1 != Convert.ToInt32(adjList[i + 1].Text))
                    {
                        index++;
                        goto Mark1;
                    }

                }
                for (i = index; i < limit; i++)
                {
                    adjList[i].Checked = true;
                }
                break;
            }
            index++;
        }


        private void reserv_txt_name_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                
                string text = reserv_txt_name.Text;
                string reg = @"^[(a-zA-z)]+\s?[(a-zA-z)]+\s[(a-zA-z)]*$";
                int number = reserv_txt_name.TextLength;
             
                    if (number>=5 && number<=25 && Regex.IsMatch(text,reg))
                    {
                        Validation.Text = "Validated!";
                        //Validation.Font = new System.Drawing.Font(Validation.Font.FontFamily.Name, 12);
                        reserv_btn_create.Enabled = true;
                        //MessageBox.Show("Validated").ToString();
                    }
                    else
                    {
                        Validation.Text = "Not Valid";
                        reserv_btn_create.Enabled = false;
                    }     
 
            }
            catch (Exception exception)
            {

                MessageBox.Show("Not valid name: " + exception.Message);
            }

        }

        private void reserv_txt_SeatsNo_TextChanged(object sender, EventArgs e)
        {
            noOfSeats = Convert.ToInt32(reserv_txt_SeatsNo.Text);
        }


        private void create_reservationTab_Click(object sender, EventArgs e)
        {

        }

        private void movie_txt_title_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        


    }


}