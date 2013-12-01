using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeServer
{
    public delegate void createSeatDelegate();
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
            //TODO: If we have time implement the custom stair!
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The room was added succesfully!";
                try
                {
                    Room room = new Room();
                    room.Cols = cols;
                    room.Rows = rows;

                    //generating seats

                    createSeatDelegate del = new createSeatDelegate(() =>
                    {
                        for (int i = 1; i <= rows; i++)
                        {
                            for (int j = 1; j <= cols; j++)
                            {
                                Seat seat = new Seat();
                                seat.Row = i;
                                seat.Col = j;
                                seat.Usable = true;
                                seat.RoomId = room.Id;
                                room.Seats.Add(seat);
                            }
                        }
                    });

                    IAsyncResult result = del.BeginInvoke(new AsyncCallback((IAsyncResult async) =>
                    {
                        del.EndInvoke(async);
                    }), "Success");



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

        //public Seat createSeat(int col, int row, bool usable, int roomId)
        //{
        //    using (DatabaseModelDataContext db = new DatabaseModelDataContext())
        //    {
        //        string message = "The seat was added succesfully!";
        //        Seat seat = new Seat();
        //        try
        //        {
        //            seat.Col = col;
        //            seat.Row = row;
        //            seat.Usable = usable;
        //            seat.RoomId = roomId;

        //            db.Seats.InsertOnSubmit(seat);
        //            db.SubmitChanges();

        //        }
        //        catch (Exception ex)
        //        {
        //            message = "An error has occured: " + ex.Message;
        //        }
        //        return seat;
        //    }
        //}

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

        public string updateRoom(int roomId, int cols, int rows)
        {

            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The room was updated succesfully!";
                try
                {
                    emptyRoom(roomId);
                    var obj = db.Rooms.SingleOrDefault(r => r.Id == roomId);
                    if (rows != 0)
                        obj.Rows = rows;
                    if (cols != 0)
                        obj.Cols = cols;
                    //TODO: AT UPDATE OF ROOM, MAKE NEW SEATS FOR THE WHOLE ROOM
                    //TODO: MAX connections to database 3
                    Room room = db.Rooms.SingleOrDefault(r => r.Id == roomId);
                    for (int i = 1; i <= rows; i++)
                    {
                        for (int j = 1; j <= cols; j++)
                        {
                            Seat seat = new Seat();
                            seat.Row = i;
                            seat.Col = j;
                            seat.Usable = true;
                            seat.RoomId = room.Id;
                            room.Seats.Add(seat);
                        }
                    }

                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }

        public string updateTicket(int ticketId, decimal standard, int reservationId, int discountId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The ticket was updated succesfully!";
                try
                {
                    var obj = db.Tickets.SingleOrDefault(t => t.Id == ticketId);
                    if (obj.Standard != standard)
                        obj.Standard = standard;
                    if (obj.ReservationId != reservationId)
                        obj.ReservationId = reservationId;
                    if (obj.DiscountId != discountId)
                        obj.DiscountId = discountId;

                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }

        public string updateSeat(int seatId, int col, int row, bool usable, int roomId, int reservationId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The seat was updated succesfully!";
                try
                {
                    var obj = db.Seats.SingleOrDefault(s => s.Id == seatId);
                    if (col >= 0)
                        obj.Col = col;
                    if (row >= 0)
                        obj.Row = row;
                    if (obj.Usable != usable)
                        obj.Usable = usable;
                    if (obj.ReservationId != reservationId)
                        obj.ReservationId = reservationId;

                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }
        public string updateDiscount(int discountId, decimal dPercent)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The discount was updated succesfully!";
                try
                {
                    var obj = db.Discounts.SingleOrDefault(d => d.Id == discountId);
                    if (obj.DPercent != dPercent)
                        obj.DPercent = dPercent;

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
                        {
                            var query = db.Seats.Where(s => s.RoomId == roomId && s.Col == col);
                            foreach (Seat seat in query)
                            {
                                returnObj.Add(seat);
                            }
                        }
                        else if (row > 0)
                        {
                            var query = db.Seats.Where(s => s.RoomId == roomId && s.Row == row);
                            foreach (Seat seat in query)
                            {
                                returnObj.Add(seat);
                            }
                        }
                        else
                        {
                            var query = db.Seats.Where(s => s.RoomId == roomId);
                            foreach (Seat seat in query)
                            {
                                returnObj.Add(seat);
                            }

                        }

                    return returnObj;
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
        }
        public Discount getDiscount(int discountId, decimal dPercent)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                Discount returnObj = null;
                try
                {
                    returnObj = db.Discounts.SingleOrDefault(r => r.Id == discountId || r.DPercent == dPercent);
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                return returnObj;
            }
        }
        #endregion

        #region remove
        public string removeReservation(int reservationId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The reservation was removed succesfully!";
                try
                {
                    var reservation = db.Reservations.SingleOrDefault(r => r.Id == reservationId);

                    if (reservation != null)
                    {
                        db.Reservations.DeleteOnSubmit(reservation);
                        db.SubmitChanges();
                    }
                    else
                        message = "There was nothing to remove.";
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }

        public string removeMovie(int movieId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The reservation was removed succesfully!";
                try
                {
                    var movie = db.Movies.SingleOrDefault(m => m.Id == movieId);
                    if (movie != null)
                    {
                        db.Movies.DeleteOnSubmit(movie);
                        db.SubmitChanges();
                    }
                    else
                    {
                        message = "There was nothing to remove.";
                    }
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }

        }

        public string removeRoom(int roomId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The Room was removed succesfully!";
                try
                {
                    var room = db.Rooms.SingleOrDefault(r => r.Id == roomId);
                    if (room != null)
                    {
                        db.Rooms.DeleteOnSubmit(room);
                        db.SubmitChanges();
                    }
                    else
                    {
                        message = "There was nothing to remove.";
                    }
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }

        public string removeTicket(int ticketId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The Ticket was removed succesfully!";
                try
                {
                    var ticket = db.Tickets.SingleOrDefault(t => t.Id == ticketId);
                    if (ticket != null)
                    {
                        db.Tickets.DeleteOnSubmit(ticket);
                        db.SubmitChanges();
                    }
                    else
                    {
                        message = "There was nothing to remove.";
                    }
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }
        public string removeDiscount(int discountId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The Discount was removed succesfully!";
                try
                {
                    var discount = db.Discounts.SingleOrDefault(d => d.Id == discountId);
                    if (discount != null)
                    {
                        db.Discounts.DeleteOnSubmit(discount);
                        db.SubmitChanges();
                    }
                    else
                    {
                        message = "There was nothing to remove.";
                    }
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }
        public string removeSeat(int seatId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The Seat was removed succesfully!";
                try
                {
                    var seat = db.Seats.SingleOrDefault(s => s.Id == seatId);
                    if (seat != null)
                    {
                        db.Seats.DeleteOnSubmit(seat);
                        db.SubmitChanges();
                    }
                    else
                    {
                        message = "There was nothing to remove.";
                    }
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }
        #endregion

        #region methods
        //public IList<Seat> getAdjSeat(int noOfSeats)
        //{
        //    throw new NotImplementedException();
        //}
        public bool emptyRoom(int roomId)
        {
            bool success = true;
            try
            {
                using (DatabaseModelDataContext db = new DatabaseModelDataContext())
                {
                    var seats = db.Seats.Where(s => s.RoomId == roomId);
                    db.Seats.DeleteAllOnSubmit(seats);

                    var room = db.Rooms.SingleOrDefault(r => r.Id == roomId);
                    room.Cols = 0;
                    room.Rows = 0;

                    db.SubmitChanges();
                }


            }
            catch (Exception)
            {
                success = false;
            }
            return success;
        }
        #endregion

    }
}
