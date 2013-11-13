using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GroupAwesomeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class GACinemaService : IGACinemaService
    {
        protected DBModelDataContext db = new DBModelDataContext();
        #region create
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
            throw new NotImplementedException();
        }

        public string update(Room room, Room newRoom)
        {
            throw new NotImplementedException();
        }

        public string update(Ticket ticket, Ticket newTicket)
        {
            throw new NotImplementedException();
        }

        public string update(Seat seat)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region read
        public Reservation get(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public Movie get(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Room get(Room room)
        {
            throw new NotImplementedException();
        }

        public Ticket get(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Seat get(Seat seat)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region remove
        public string remove(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public string remove(Movie movie)
        {
            throw new NotImplementedException();
        }

        public string remove(Room room)
        {
            throw new NotImplementedException();
        }

        public string remove(Ticket ticket)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
