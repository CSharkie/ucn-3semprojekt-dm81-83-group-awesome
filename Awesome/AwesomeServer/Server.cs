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
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
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

        public Movie get(Movie movie)
        {
            Movie returnObj = null;
            try
            {
                if (movie.Id != 0)
                    returnObj = (from m in db.Movies
                                 where m.Id == movie.Id
                                 select m).FirstOrDefault();
                else if (movie.Title != null)
                    returnObj = (from m in db.Movies
                                 where m.Title.Contains(movie.Title)
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
                             select r).First();
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
                if (seat.Id != 0)
                    returnObj = (from s in db.Seats
                                 where s.Id == seat.Id
                                 select s).FirstOrDefault();
                else if (seat.Col >= 0 && seat.Row >=0)
                    returnObj = (from s in db.Seats
                                 where s.Col == seat.Col && s.Row ==seat.Row
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
        public string remove(Reservation reservation)
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
    }
}
