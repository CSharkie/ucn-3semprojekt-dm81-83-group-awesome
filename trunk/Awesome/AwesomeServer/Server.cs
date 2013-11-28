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
        public string create(Reservation reservation)
        {
            string message = "The reservation was added succesfully!";
            try
            {
                db.Reservations.InsertOnSubmit(reservation);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string create(Movie movie)
        {
            string message = "The movie was added succesfully!";
            try
            {
                db.Movies.InsertOnSubmit(movie);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string create(Room room)
        {
            string message = "The room was added succesfully!";
            try
            {
                db.Rooms.InsertOnSubmit(room);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string create(Ticket ticket)
        {
            string message = "The ticket was added succesfully!";
            try
            {
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
        public string update(Reservation reservation, Reservation newReservation)
        {
            string message = "The room was added succesfully!";
            try
            {
                Reservation obj = (from r in db.Reservations
                                   where r == reservation
                                   select r).FirstOrDefault();
                obj = newReservation;

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string update(Movie movie, Movie newMovie)
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

        public string update(Room room, Room newRoom)
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

        public string update(Ticket ticket, Ticket newTicket)
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

        public string update(Seat seat, Seat newSeat)
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
        public Reservation get(Reservation reservation)
        {
            Reservation returnObj = null;
            try
            {
                returnObj = (from r in db.Reservations
                             where r.Id == reservation.Id
                             select r).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return returnObj;
        }

        public Movie get(Movie movie)
        {
            Movie returnObj = null;
            try
            {
                returnObj = (from m in db.Movies
                             where m.Id == movie.Id
                             select m).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return returnObj;
        }

        public Room get(Room room)
        {
            Room returnObj = null;
            try
            {
                returnObj = (from r in db.Rooms
                             where r.Id == room.Id
                             select r).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return returnObj;
        }

        public Ticket get(Ticket ticket)
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

        public Seat get(Seat seat)
        {
            Seat returnObj = null;
            try
            {
                returnObj = (from r in db.Seats
                             where r.Id == seat.Id
                             select r).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return returnObj;
        }
        #endregion

        #region remove
        public string remove(Reservation reservation)
        {
            string message = "The reservation was removed succesfully!";
            try
            {
                db.Reservations.DeleteOnSubmit(reservation);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                message = "An error has occured: " + ex.Message;
            }
            return message;
        }

        public string remove(Movie movie)
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

        public string remove(Room room)
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

        public string remove(Ticket ticket)
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


        public string addMovieToRoom(int noOfSeats)
        {
            return "";
        }
    }
}
