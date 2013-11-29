using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeServer
{
    public class Server : IServer
    {
        #region create
        DatabaseModelDataContext db = new DatabaseModelDataContext();
        public string createReservation(string name, bool taken, DateTime dateReserved, int movieId, int seatCount)
        {
            string message = "The reservation was added succesfully!";
            try
            {
                Reservation reservation = new Reservation();
                reservation.Name = name;
                reservation.Taken = taken;
                reservation.DateReserved = dateReserved;
                reservation.MovieId = movieId;
                reservation.SeatCount = seatCount;
                db.Reservations.InsertOnSubmit(reservation);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string createMovie(string title, DateTime dateAndTime, int roomId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The movie was added succesfully!";
                try
                {
                    Movie movie = new Movie();
                    movie.Title = title;
                    movie.DateAndTime = dateAndTime;
                    movie.RoomId = roomId;
                    db.Movies.InsertOnSubmit(movie);
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }

        public string createRoom(int cols, int rows)
        {
            string message = "The room was added succesfully!";
            try
            {
                Room room = new Room();
                room.Cols = cols;
                room.Rows = rows;
                db.Rooms.InsertOnSubmit(room);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string createTicket(decimal standard, int reservationId, int discountId)
        {
            string message = "The ticket was added succesfully!";
            try
            {
                Ticket ticket = new Ticket();
                ticket.Standard = standard;
                ticket.ReservationId = reservationId;
                ticket.DiscountId = discountId;
                db.Tickets.InsertOnSubmit(ticket);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }
        #endregion

        #region update
        public string updateReservation(int reservationId, string name, bool taken, DateTime dateReserved, int movieId, int seatCount)
        {
            string message = "The room was updated succesfully!";
            try
            {
                Reservation obj = get(reservation);
                obj = newReservation;

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string updateMovie(int movieId, string title, DateTime dateAndTime, int roomId)
        {
            string message = "The movie was added succesfully!";
            try
            {
                Movie obj = (from m in db.Movies
                             where m == movie
                             select m).FirstOrDefault();
                obj = newMovie;

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string updateRoom(int roomId, int cols, int rows)
        {
            string message = "The room was added succesfully!";
            try
            {
                Room obj = (from r in db.Rooms
                            where r == room
                            select r).FirstOrDefault();
                obj = newRoom;

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string updateTicket(int ticketId, decimal standard, int reservationId, int discountId)
        {
            string message = "The ticket was added succesfully!";
            try
            {
                Ticket obj = (from r in db.Tickets
                              where r == ticket
                              select r).FirstOrDefault();
                obj = newTicket;

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string updateSeat(int seatId, int col, int row, bool usable, int roomId, int reservationId)
        {
            string message = "The seat was added succesfully!";
            try
            {
                Seat obj = (from r in db.Seats
                            where r == seat
                            select r).FirstOrDefault();
                obj = newSeat;

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }
        #endregion

        #region read
        public ICollection<Reservation> getReservation(int reservationId, string name, int movieId)
        {
            Reservation returnObj = null;
            try
            {
                if (reservation.Id != 0)
                    returnObj = (from r in db.Reservations
                                 where r.Id == reservation.Id
                                 select r).FirstOrDefault();
                else if (reservation.Name != null)
                    returnObj = (from r in db.Reservations
                                 where r.Name.Contains(reservation.Name)
                                 select r).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return returnObj;
        }

        public ICollection<Movie> getMovie(int movieId, string title, int roomId)
        {
            Movie returnObj = null;
            try
            {
                if (movie.Id != 0)
                    returnObj = db.Movies.SingleOrDefault(m => m.Id == movie.Id);
                //else if (movie.Title != null)
                //    returnObj = (from m in db.Movies
                //                 where m.Title.Contains(movie.Title)
                //                 select m).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return returnObj;
        }

        public Room getRoom(int roomId)
        {
            Room returnObj = null;
            try
            {
                returnObj = db.Rooms.SingleOrDefault(r => r.Id == room.Id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return returnObj;
        }

        public ICollection<Ticket> getTicket(int ticketId, int reservationId)
        {
            Ticket returnObj = null;
            try
            {
                returnObj = (from r in db.Tickets
                             where r.Id == ticket.Id
                             select r).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return returnObj;
        }

        public ICollection<Seat> getSeat(int seatId, int roomId)
        {
            Seat returnObj = null;
            try
            {
                if (seat.Id != 0)
                    returnObj = (from s in db.Seats
                                 where s.Id == seat.Id
                                 select s).FirstOrDefault();
                else if (seat.Col >= 0 && seat.Row >= 0)
                    returnObj = (from s in db.Seats
                                 where s.Col == seat.Col && s.Row == seat.Row
                                 select s).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return returnObj;
        }
        #endregion

        #region remove
        public string removeReservation(int reservationId, string name)
        {
            string message = "The reservation was removed succesfully!";
            try
            {

                db.Reservations.DeleteOnSubmit(get(reservation));
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string removeMovie(int movieId, string title, DateTime dateAndTime, int roomId)
        {
            string message = "The movie was removed succesfully!";
            try
            {
                db.Movies.DeleteOnSubmit(movie);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string removeRoom(int roomId)
        {
            string message = "The room was removed succesfully!";
            try
            {
                //TODO test this method !!!
                db.Rooms.DeleteOnSubmit(room);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string removeTicket(int ticketId, int reservationId)
        {
            string message = "The ticket was removed succesfully!";
            try
            {
                db.Tickets.DeleteOnSubmit(ticket);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }
        #endregion

        #region methods
        public IList<Seat> getAdjSeat(int noOfSeats)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
