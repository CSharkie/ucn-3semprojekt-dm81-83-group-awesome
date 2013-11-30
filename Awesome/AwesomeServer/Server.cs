using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeServer
{
    public class Server : IServer
    {
        #region create
        public string createReservation(string name, bool taken, DateTime dateReserved, int movieId, int seatCount)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
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
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
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
        }

        public string createTicket(decimal standard, int reservationId, int discountId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
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
        }

        public string createDiscount(decimal dPercent)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The discount was added succesfully!";
                try
                {
                    Discount discount = new Discount();
                    discount.DPercent = dPercent;
                    db.Discounts.InsertOnSubmit(discount);
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }
        #endregion

        #region update
        public string updateReservation(int reservationId, string name, bool taken, int movieId, int seatCount)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The room was updated succesfully!";
                try
                {
                    var obj = db.Reservations.SingleOrDefault(r => r.Id == reservationId);
                    if (name != null && name != "")
                        obj.Name = name;
                    if (obj.Taken != taken) //Liam N.
                        obj.Taken = taken;
                    if (obj.MovieId != movieId)
                        obj.MovieId = movieId;
                    if (obj.SeatCount != seatCount)
                        obj.SeatCount = seatCount;
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }

        public string updateMovie(int movieId, string title, DateTime dateAndTime, int roomId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The movie was updated succesfully!";
                try
                {
                    var obj = db.Movies.SingleOrDefault(m => m.Id == movieId);
                    if (title != null && title != "")
                        obj.Title = title;
                    if (obj.DateAndTime != dateAndTime) //Liam N.
                        obj.DateAndTime = dateAndTime;
                    if (obj.RoomId != roomId)
                        obj.RoomId = roomId;
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }

        //public string updateRoom(int roomId, int cols, int rows)
        //{
        //    string message = "The room was added succesfully!";
        //    try
        //    {
        //        Room obj = (from r in db.Rooms
        //                    where r == room
        //                    select r).FirstOrDefault();
        //        obj = newRoom;

        //        db.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        message = "An error has occured: " + ex.Message;
        //    }
        //    return message;
        //}

        //public string updateTicket(int ticketId, decimal standard, int reservationId, int discountId)
        //{
        //    string message = "The ticket was added succesfully!";
        //    try
        //    {
        //        Ticket obj = (from r in db.Tickets
        //                      where r == ticket
        //                      select r).FirstOrDefault();
        //        obj = newTicket;

        //        db.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        message = "An error has occured: " + ex.Message;
        //    }
        //    return message;
        //}

        //public string updateSeat(int seatId, int col, int row, bool usable, int roomId, int reservationId)
        //{
        //    string message = "The seat was added succesfully!";
        //    try
        //    {
        //        Seat obj = (from r in db.Seats
        //                    where r == seat
        //                    select r).FirstOrDefault();
        //        obj = newSeat;

        //        db.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        message = "An error has occured: " + ex.Message;
        //    }
        //    return message;
        //}
        #endregion

        #region read

        public IList<Reservation> getReservation(int reservationId, string name, int movieId)
        {

            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                try
                {
                    IList<Reservation> returnObj = new List<Reservation>();
                    if (reservationId > 0)
                        returnObj.Add(db.Reservations.SingleOrDefault(r => r.Id == reservationId));
                    else if (name != null && name != "" && movieId > 0)
                    {
                        var query = db.Reservations.Where(r => r.Name.Contains(name) && r.MovieId == movieId);
                        foreach (Reservation r in query)
                            returnObj.Add(r);
                    }
                    else if (name != null && name != "")
                    {
                        var query = db.Reservations.Where(r => r.Name.Contains(name));
                        foreach (Reservation r in query)
                            returnObj.Add(r);
                    }
                    else if (movieId > 0)
                    {
                        var query = db.Reservations.Where(r => r.MovieId == movieId);
                        foreach (Reservation r in query)
                            returnObj.Add(r);
                    }
                    return returnObj;
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
        }

        public IList<Movie> getMovie(int movieId, string title, int roomId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                IList<Movie> returnObj = new List<Movie>();
                try
                {
                    if (movieId > 0)
                        returnObj.Add(db.Movies.SingleOrDefault(m => m.Id == movieId));
                    else if (title != null && title != "" && roomId > 0)
                    {
                        var query = db.Movies.Where(m => m.Title.Contains(title) && m.RoomId == roomId);
                        foreach (Movie item in query)
                        {
                            returnObj.Add(item);
                        }
                    }
                    else if (title != null && title != "")
                    {
                        var query = db.Movies.Where(m => m.Title.Contains(title));
                        foreach (Movie item in query)
                        {
                            returnObj.Add(item);
                        }
                    }
                    else if (roomId > 0)
                    {
                        var query = db.Movies.Where(m => m.RoomId == roomId);
                        foreach (Movie item in query)
                        {
                            returnObj.Add(item);
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                return returnObj;
            }
        }

        public Room getRoom(int roomId)
        {

            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                Room returnObj = null;
                try
                {
                    returnObj = db.Rooms.SingleOrDefault(r => r.Id == roomId);
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                return returnObj;
            }
        }
        public IList<Room> getAllRooms()
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                IList<Room> returnObj = new List<Room>();
                var query = db.Rooms;
                foreach (Room item in query)
                {
                    returnObj.Add(item);
                }
                return returnObj;
            }
        }
        public IList<Ticket> getTicket(int ticketId, int reservationId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                List<Ticket> returnObj = new List<Ticket>();
                try
                {
                    if (ticketId > 0)
                        returnObj.Add(db.Tickets.SingleOrDefault(r => r.Id == ticketId));
                    else if (reservationId > 0)
                    {
                        var query = db.Tickets.Where(r => r.ReservationId == reservationId);
                        foreach (Ticket item in query)
                        {
                            returnObj.Add(item);
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                return returnObj;
            }
        }

        public IList<Seat> getSeat(int seatId, int roomId, int col, int row)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                try
                {
                    IList<Seat> returnObj = new List<Seat>();

                    if (seatId != 0)
                        returnObj.Add(db.Seats.SingleOrDefault(r => r.Id == seatId));
                    else if (roomId > 0)
                        if (col > 0 && row > 0)
                            returnObj.Add(db.Seats.SingleOrDefault(r => r.RoomId == roomId && r.Row == row && r.Col == col));
                        else if (col > 0)
                            returnObj.Add(db.Seats.SingleOrDefault(r => r.RoomId == roomId && r.Col == col));
                        else if (row > 0)
                            returnObj.Add(db.Seats.SingleOrDefault(r => r.RoomId == roomId && r.Row == row));
                    return returnObj;
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
        }
        #endregion

        #region remove
        //public string removeReservation(int reservationId, string name)
        //{
        //    string message = "The reservation was removed succesfully!";
        //    try
        //    {

        //        db.Reservations.DeleteOnSubmit();
        //        db.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        message = "An error has occured: " + ex.Message;
        //    }
        //    return message;
        //}

        //public string removeMovie(int movieId, string title, DateTime dateAndTime, int roomId)
        //{
        //    string message = "The movie was removed succesfully!";
        //    try
        //    {
        //        db.Movies.DeleteOnSubmit(movie);
        //        db.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        message = "An error has occured: " + ex.Message;
        //    }
        //    return message;
        //}

        //public string removeRoom(int roomId)
        //{
        //    string message = "The room was removed succesfully!";
        //    try
        //    {
        //        //TODO test this method !!!
        //        db.Rooms.DeleteOnSubmit(room);
        //        db.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        message = "An error has occured: " + ex.Message;
        //    }
        //    return message;
        //}

        //public string removeTicket(int ticketId, int reservationId)
        //{
        //    string message = "The ticket was removed succesfully!";
        //    try
        //    {
        //        db.Tickets.DeleteOnSubmit(ticket);
        //        db.SubmitChanges();
        //    }
        //    catch (Exception ex)
        //    {
        //        message = "An error has occured: " + ex.Message;
        //    }
        //    return message;
        //}
        #endregion

        #region methods
        //public IList<Seat> getAdjSeat(int noOfSeats)
        //{
        //    throw new NotImplementedException();
        //}
        #endregion

    }
}
