using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Metadata.Edm;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AwesomeServer
{
    public delegate void createSeatDelegate();
    public class Server : IServer
    {
        #region create
        public string createReservation(string name, bool taken, int seatCount, int movieId, IList<int> seatIds)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The reservation was added succesfully!";
                try
                {
                    bool allAvailable = true;
                    foreach (int id in seatIds)
                    {
                        var movieSeats = db.MovieSeats.Where(ms => ms.MovieId == movieId && ms.SeatId == id).First();
                        if (movieSeats.ReservationId != null && movieSeats.ReservationId != 0)
                        {
                            allAvailable = false;
                            message = "Some or all of the seats are taken!";
                            break;
                        }
                    }
                    if (allAvailable)
                    {
                        Reservation reservation = new Reservation();
                        reservation.Name = name;
                        reservation.Taken = taken;
                        reservation.DateOfReserve = (from m in db.Movies where m.Id == movieId select m.DateAndTime).First();
                        reservation.SeatCount = seatIds.Count;
                        db.Reservations.InsertOnSubmit(reservation);
                        db.SubmitChanges();

                        int reservationId = (from r in db.Reservations select r.Id).Max();
                        foreach (int id in seatIds)
                        {
                            var movieSeats = db.MovieSeats.Where(ms => ms.MovieId == movieId && ms.SeatId == id).First();
                            movieSeats.ReservationId = reservationId;
                        }
                        db.SubmitChanges();
                    }
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }
        public string createMovie(string title, DateTime dateAndTime, TimeSpan duration, int roomId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The movie was added succesfully!";
                try
                {
                    Movie movie = new Movie();
                    movie.Title = title;
                    movie.DateAndTime = dateAndTime;

                    movie.Duration = duration;
                    movie.RoomId = roomId;

                    //TODO CHECK IF MOVIE ENDED IN THE ROOM
                    db.Movies.InsertOnSubmit(movie);
                    db.SubmitChanges();
                    var seats = db.Seats.Where(s => s.RoomId == movie.RoomId);
                    int movieId = (from m in db.Movies select m.Id).Max();
                    foreach (Seat seat in seats)
                    {
                        MovieSeat movieSeat = new MovieSeat();
                        movieSeat.MovieId = movieId;
                        movieSeat.SeatId = seat.Id;
                        db.MovieSeats.InsertOnSubmit(movieSeat);
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
        public string createRoom(int cols, int rows)
        {
            //    //TODO: If we have time implement the custom stair!
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The room was added succesfully!";
                try
                {
                    Room room = new Room();
                    room.Cols = cols;
                    room.Rows = rows;

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
        public string createTicket(decimal standard, int reservationId, int discountId, int col, int row)
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
                    ticket.Col = col;
                    ticket.Row = row;
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
        public string updateReservation(int reservationId, string name, bool taken)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The room was updated succesfully!";
                try
                {
                    var obj = db.Reservations.SingleOrDefault(r => r.Id == reservationId);
                    if (name != null && name != "")
                        obj.Name = name;
                    if (obj.Taken != taken)
                        obj.Taken = taken;
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    message = "An error has occured: " + ex.Message;
                }
                return message;
            }
        }
        public string updateMovie(int movieId, string title, DateTime dateAndTime, TimeSpan Duration, int roomId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                string message = "The movie was updated succesfully!";
                try
                {
                    var obj = db.Movies.SingleOrDefault(m => m.Id == movieId);
                    if (title != null && title != "")
                        obj.Title = title;
                    if (obj.DateAndTime != dateAndTime)
                        obj.DateAndTime = dateAndTime;
                    if (roomId != 0)
                    {
                        var movieSeats = db.MovieSeats.Where(ms => ms.Movie.RoomId == roomId);
                        db.MovieSeats.DeleteAllOnSubmit(movieSeats);
                        obj.RoomId = roomId;
                        var seats = db.Seats.Where(s => s.RoomId == roomId);
                        foreach (var item in seats)
                        {
                            MovieSeat ms = new MovieSeat();
                            ms.MovieId = movieId;
                            ms.SeatId = item.Id;
                            db.MovieSeats.InsertOnSubmit(ms);
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
                    var movies = db.Movies.Where(m => m.RoomId == roomId);
                    foreach (var item in movies)
                    {
                        updateMovie(item.Id, "", item.DateAndTime, item.Duration, roomId);
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
            //using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            //{
            string message = "The ticket was updated succesfully!";
            //    try
            //    {
            //        var obj = db.Tickets.SingleOrDefault(t => t.Id == ticketId);
            //        if (obj.Standard != standard)
            //            obj.Standard = standard;
            //        if (obj.ReservationId != reservationId)
            //            obj.ReservationId = reservationId;
            //        if (obj.DiscountId != discountId)
            //            obj.DiscountId = discountId;

            //        db.SubmitChanges();
            //    }
            //    catch (Exception ex)
            //    {
            //        message = "An error has occured: " + ex.Message;
            //    }
            return message;
            //}
        }
        public string updateSeat(int seatId, int col, int row, bool usable, DateTime dateAndTime, int roomId)
        {
            //using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            //{
            string message = "The seat was updated succesfully!";
            //    try
            //    {
            //        var obj = db.Seats.SingleOrDefault(s => s.Id == seatId);
            //        if (col >= 0)
            //            obj.Col = col;
            //        if (row >= 0)
            //            obj.Row = row;
            //        if (obj.Usable != usable)
            //            obj.Usable = usable;
            //        if (obj.ReservationId != reservationId)
            //            obj.ReservationId = reservationId;

            //        db.SubmitChanges();
            //    }
            //    catch (Exception ex)
            //    {
            //        message = "An error has occured: " + ex.Message;
            //    }
            return message;
            //}
        }
        public string updateDiscount(int discountId, decimal dPercent)
        {
            //using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            //{
            string message = "The discount was updated succesfully!";
            //    try
            //    {
            //        var obj = db.Discounts.SingleOrDefault(d => d.Id == discountId);
            //        if (obj.DPercent != dPercent)
            //            obj.DPercent = dPercent;

            //        db.SubmitChanges();
            //    }
            //    catch (Exception ex)
            //    {
            //        message = "An error has occured: " + ex.Message;
            //    }
            return message;
            //}
        }

        #endregion

        #region read

        public IList<Reservation> getReservation(int reservationId, string name)
        {

            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                try
                {
                    IList<Reservation> returnObj = new List<Reservation>();
                    if (reservationId > 0)
                        returnObj.Add(db.Reservations.SingleOrDefault(r => r.Id == reservationId));
                    else if (name != null && name != "" && reservationId > 0)
                    {
                        var query = db.Reservations.Where(r => r.Name.Contains(name) && r.Id == reservationId);
                        foreach (Reservation r in query)
                            returnObj.Add(r);
                    }
                    else if (name != null && name != "")
                    {
                        var query = db.Reservations.Where(r => r.Name.Contains(name));
                        foreach (Reservation r in query)
                            returnObj.Add(r);
                    }
                    else if (reservationId > 0)
                    {
                        var query = db.Reservations.Where(r => r.Id == reservationId);
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

        //TODO : we should get back the movieseats too
        //TODO : FIX THE MOVIESEAT GET BACK, because now its working if you go step by step, but not if you just run it =))
        public IList<Movie> getMovie(int movieId, string title, int roomId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                IList<Movie> returnObj = new List<Movie>();
                try
                {
                    if (movieId > 0)
                    {
                        var movie=db.Movies.SingleOrDefault(m => m.Id == movieId);
                        var query = db.MovieSeats.Where(ms => ms.MovieId == movie.Id);
                        foreach (MovieSeat ms in query)
                        {
                            movie.MovieSeats.Add(ms);
                        }
                        returnObj.Add(movie);
                    }
                    else if (title != null && title != "" && roomId > 0)
                    {
                        var query = db.Movies.Where(m => m.Title.Contains(title) && m.RoomId == roomId);
                        foreach (Movie item in query)
                        {
                            var query2 = db.MovieSeats.Where(ms => ms.MovieId == item.Id);
                            foreach (MovieSeat ms in query2)
                            {
                                item.MovieSeats.Add(ms);
                            }
                            returnObj.Add(item);

                        }

                    }
                    else if (title != null && title != "")
                    {
                        var query = db.Movies.Where(m => m.Title.Contains(title));
                        foreach (Movie item in query)
                        {
                            var query2 = db.MovieSeats.Where(ms => ms.MovieId == item.Id);
                            foreach (MovieSeat ms in query2)
                            {
                                item.MovieSeats.Add(ms);
                            }
                            returnObj.Add(item);
                        }
                    }
                    else if (roomId > 0)
                    {
                        var query = db.Movies.Where(m => m.RoomId == roomId);
                        foreach (Movie item in query)
                        {
                            var query2 = db.MovieSeats.Where(ms => ms.MovieId == item.Id);
                            foreach (MovieSeat ms in query2)
                            {
                                item.MovieSeats.Add(ms);
                            }
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

        public IList<MovieSeat> getMovieSeatsForMovie(int movieId)
        {
            using (DatabaseModelDataContext db = new DatabaseModelDataContext())
            {
                IList<MovieSeat> returnObj = new List<MovieSeat>();
                try
                {
                    if (movieId > 0)
                    {
                        var query = db.MovieSeats.Where(ms => ms.MovieId == movieId);
                        foreach (MovieSeat ms in query)
                        {
                            returnObj.Add(ms);
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
                    returnObj = (from r in db.Rooms where r.Id == roomId select r).FirstOrDefault();
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
        public IList<Seat> getSeat(int seatId, int roomId, int col, int row, int movieId)
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
                    else if (movieId > 0)
                    {
                        var query = db.Seats.Where(ms => ms.Id == movieId);
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
        public Discount getDiscount(int? discountId, decimal dPercent)
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
                string message = "The movie was removed succesfully!";
                try
                {
                    var movie = db.Movies.SingleOrDefault(m => m.Id == movieId);
                    if (movie != null)
                    {
                        var movieSeats = db.MovieSeats.Where(ms => ms.Movie.RoomId == movie.RoomId);
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
        //public IList<Seat> getAdjSeatSingleThread(int noOfSeats, int roomId)
        //{
        //    try
        //    {
        //        Room room = getRoom(roomId);
        //        int rows = room.Rows;
        //        IList<Seat> adjSeats = new List<Seat>();  //this is being returned
        //        IList<Seat> permSeats = new List<Seat>();
        //        for (int i = 1; i <= rows; i++) //i = rows
        //        {
        //            IList<Seat> seats = getSeat(0, roomId, 0, i, 0);
        //            for (int j = 0; j <= room.Cols - 1; j++)  //j= cols
        //            {
        //                if (seats[j].Usable == true)
        //                {
        //                    permSeats.Add(seats[j]);
        //                }
        //                else
        //                {
        //                    if (permSeats.Count != 0 && permSeats.Count >= noOfSeats)
        //                    {
        //                        foreach (Seat seat in permSeats)
        //                        {
        //                            adjSeats.Add(seat);
        //                        }
        //                    }
        //                    permSeats.Clear();
        //                }
        //            }
        //            if (permSeats.Count != 0 && permSeats.Count >= noOfSeats)
        //            {
        //                foreach (Seat seat in permSeats)
        //                {
        //                    adjSeats.Add(seat);
        //                }
        //            }
        //            permSeats.Clear();
        //        }
        //        return adjSeats;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}
        //public IList<Seat> getAdjSeatMultiThread(int noOfSeats, int roomId)
        //{
        //    Room room = getRoom(roomId);
        //    int rows = room.Rows;
        //    IList<Seat> adjSeats = new List<Seat>();  //this is being returned
        //    IList<Seat> permSeats = new List<Seat>();
        //    var temp = new Object();
        //    Thread[] threads = new Thread[rows];


        //    for (int i = 0; i < rows; i++)
        //    {
        //        IList<Seat> seats = getSeat(0, roomId, 0, 0, 0);
        //        threads[i] = new Thread(new ThreadStart(() =>
        //        {
        //            for (int j = 0; j <= room.Cols - 1; j++)  //j= cols
        //            {
        //                lock (temp)
        //                {
        //                    if (seats[j].Usable == true)
        //                    {
        //                        permSeats.Add(seats[j]);
        //                    }
        //                    else
        //                    {
        //                        if (permSeats.Count != 0 && permSeats.Count >= noOfSeats)
        //                        {
        //                            foreach (Seat seat in permSeats)
        //                            {
        //                                adjSeats.Add(seat);
        //                            }
        //                        }
        //                        permSeats.Clear();
        //                    }
        //                }
        //            }
        //            lock (temp)
        //            {
        //                if (permSeats.Count != 0 && permSeats.Count >= noOfSeats)
        //                {
        //                    foreach (Seat seat in permSeats)
        //                    {
        //                        adjSeats.Add(seat);
        //                    }
        //                    permSeats.Clear();
        //                }
        //            }
        //        }));
        //    }
        //    foreach (Thread t in threads)
        //    {
        //        t.Start();
        //    }
        //    foreach (Thread t in threads)
        //    {
        //        t.Join();
        //    }
        //    return adjSeats;
        //}
        //public IList<Seat> getAdjSeatParallel(int noOfSeats, int roomId)
        //{
        //    Room room = getRoom(roomId);
        //    int rows = room.Rows;
        //    var temp = new Object();
        //    IList<Seat> adjSeats = new List<Seat>();  //this is being returned
        //    IList<Seat> permSeats = new List<Seat>();

        //    Parallel.For(1, rows + 1, (i) =>
        //    {
        //        IList<Seat> seats = getSeat(0, roomId, 0, i, 0);
        //        if (seats.Count > 0)
        //        {
        //            for (int j = 0; j < room.Cols; j++)
        //            {
        //                lock (temp)
        //                {
        //                    if (seats[j].Usable == true)
        //                    {
        //                        permSeats.Add(seats[j]);
        //                    }
        //                    else
        //                    {
        //                        if (permSeats.Count != 0 && permSeats.Count >= noOfSeats)
        //                        {
        //                            foreach (Seat seat in permSeats)
        //                            {
        //                                adjSeats.Add(seat);
        //                            }
        //                        }
        //                        permSeats.Clear();
        //                    }
        //                }
        //            }
        //            lock (temp)
        //            {
        //                if (permSeats.Count != 0 && permSeats.Count >= noOfSeats)
        //                {
        //                    foreach (Seat seat in permSeats)
        //                    {
        //                        adjSeats.Add(seat);
        //                    }
        //                }
        //                permSeats.Clear();
        //            }
        //        }
        //    });

        //    return adjSeats;
        //}
        //public IList<string> adj2(int noOfSeats, int roomId)
        //{
        //    IList<string> messages = new List<string>();
        //    Stopwatch s = new Stopwatch();
        //    s.Reset();
        //    s.Start();
        //    getAdjSeatMultiThreadV2(noOfSeats, roomId);
        //    s.Stop();
        //    messages.Add(s.ElapsedMilliseconds.ToString());

        //    return messages;
        //}
        //public IList<Seat> getAdjSeatSingleThreadV2(int noOfSeats, int roomId)
        //{
        //    Room room = getRoom(roomId);
        //    int rows = room.Rows;
        //    IList<Seat> adjSeats = new List<Seat>();  //this is being returned
        //    IList<Seat> permSeats = new List<Seat>();
        //    Object temp = new Object();

        //    for (int i = 1; i <= rows; i++) //i = rows
        //    {
        //        IList<Seat> seats = (List<Seat>)getSeat(0, roomId, 0, i, 0);
        //        //for (int j = noOfSeats-1; j+noOfSeats <= room.Cols - 1; j++)  //j= cols
        //        int j = noOfSeats - 1;
        //        while (j < room.Cols)
        //        {
        //            if (seats[j].Usable)
        //            {
        //                for (int k = j - noOfSeats + 1; k <= j; k++)
        //                {
        //                    lock (temp)
        //                    {
        //                        if (seats[k].Usable)
        //                        {
        //                            permSeats.Add(seats[k]);
        //                        }
        //                        else
        //                        {
        //                            j = k + noOfSeats;
        //                            break;
        //                        }
        //                    }
        //                }
        //                lock (temp)
        //                {
        //                    if (permSeats.Count >= noOfSeats)
        //                    {
        //                        foreach (Seat seat in permSeats)
        //                        {
        //                            adjSeats.Add(seat);
        //                        }
        //                        j += noOfSeats;
        //                    }
        //                    permSeats.Clear();
        //                }
        //            }
        //            else
        //            {
        //                j += noOfSeats;
        //            }
        //        }

        //    }
        //    return adjSeats;
        //}
        //public IList<Seat> getAdjSeatMultiThreadV2(int noOfSeats, int roomId)
        //{
        //    Room room = getRoom(roomId);
        //    int rows = room.Rows;
        //    IList<Seat> adjSeats = new List<Seat>();  //this is being returned
        //    IList<Seat> permSeats = new List<Seat>();
        //    Object temp = new Object();
        //    Thread[] threads = new Thread[rows];

        //    for (int i = 0; i < rows; i++)
        //    {
        //        IList<Seat> seats = (List<Seat>)getSeat(0, roomId, 0, i, 0);
        //        Thread thread = new Thread(() =>
        //        {

        //            //for (int j = noOfSeats-1; j+noOfSeats <= room.Cols - 1; j++)  //j= cols
        //            int j = noOfSeats - 1;
        //            while (j < room.Cols)
        //            {
        //                if (seats[j].Usable)
        //                {
        //                    for (int k = j - noOfSeats + 1; k <= j; k++)
        //                    {
        //                        lock (temp)
        //                        {
        //                            if (seats[k].Usable)
        //                            {
        //                                permSeats.Add(seats[k]);
        //                            }
        //                            else
        //                            {
        //                                j = k + noOfSeats;
        //                                break;
        //                            }
        //                        }
        //                    }
        //                    lock (temp)
        //                    {
        //                        if (permSeats.Count >= noOfSeats)
        //                        {

        //                            foreach (Seat seat in permSeats)
        //                            {
        //                                adjSeats.Add(seat);
        //                            }
        //                            j += noOfSeats;
        //                        }
        //                        permSeats.Clear();
        //                    }
        //                }
        //                else
        //                {
        //                    j += noOfSeats;
        //                }
        //            }
        //        });
        //        threads[i] = thread;
        //    }
        //    foreach (Thread t in threads)
        //        t.Start();
        //    foreach (Thread t in threads)
        //    {
        //        t.Join();
        //    }
        //    return adjSeats;
        //}
        //public string threadingTest()
        //{
        //    string message = "";
        //    message = "OLOLOLOLOLO";
        //    Thread.Sleep(2000);
        //    Thread thread = new Thread(() => { message = "ASD"; });
        //    thread.Start();
        //    Thread.Sleep(2000);


        //    return message;
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
                    var movieSeats = db.MovieSeats.Where(ms => ms.Movie.RoomId == roomId);
                    db.MovieSeats.DeleteAllOnSubmit(movieSeats);

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
        //public string takeTickets(int reservationId)
        //{
        //    using (DatabaseModelDataContext db = new DatabaseModelDataContext())
        //    {
        //        string message = "The tickets were printed: {0}";
        //        try
        //        {
        //            var obj = db.Tickets.Where(t => t.ReservationId == t.ReservationId);


        //            db.SubmitChanges();
        //        }
        //        catch (Exception ex)
        //        {
        //            message = "An error has occured: " + ex.Message;
        //        }
        //        return message;
        //    }
        //}
        #endregion

    }
}
