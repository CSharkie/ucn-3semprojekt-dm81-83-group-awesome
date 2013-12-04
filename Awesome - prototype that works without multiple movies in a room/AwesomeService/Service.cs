using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AwesomeServer;
using System.Collections.ObjectModel;
using System.Runtime.Remoting.Messaging;
namespace AwesomeService
{
    public delegate IList<Seat> getSeatDelegate(int seatId, int roomId, int col, int row, int reservationId);
    public class Service : IService
    {
        Server server = new Server();

        #region create
        public string createReservation(string name, bool taken, DateTime dateReserved, int movieId, IList<int> seatIds)
        {
            return server.createReservation(name, taken, dateReserved, movieId, seatIds);
        }
        public string createMovie(string title, DateTime dateAndTime, int roomId)
        {

            return server.createMovie(title, dateAndTime, roomId);
        }
        public string createRoom(int cols, int rows)
        {

            return server.createRoom(cols, rows);
        }
        public string createTicket(decimal standard, int reservationId, int discountId, int col, int row)
        {
            return server.createTicket(standard, reservationId, discountId, col, row);
        }
        public string createDiscount(decimal dPercent)
        {
            return server.createDiscount(dPercent);
        }

        #endregion

        #region update
        public string updateReservation(int reservationId, string name, bool taken, int movieId, int seatCount)
        {

            return server.updateReservation(reservationId, name, taken, movieId, seatCount);
        }

        public string updateMovie(int movieId, string title, DateTime dateAndTime, int roomId)
        {
            return server.updateMovie(movieId, title, dateAndTime, roomId);
        }

        public string updateRoom(int roomId, int cols, int rows)
        {
            return server.updateRoom(roomId, cols, rows);
        }

        public string updateTicket(int ticketId, decimal standard, int reservationId, int discountId)
        {
            return server.updateTicket(ticketId, standard, reservationId, discountId);
        }

        public string updateSeat(int seatId, int col, int row, bool usable, int roomId, int reservationId)
        {
            return server.updateSeat(seatId, col, row, usable, roomId, reservationId);
        }

        public string updateDiscount(int discountId, decimal dPercent)
        {
            return server.updateDiscount(discountId, dPercent);
        }
        #endregion

        #region read
        public IList<Reservation> getReservation(int reservationId, string name, int movieId)
        {
            try
            {
                var reservationList = server.getReservation(reservationId, name, movieId);
                List<Reservation> returnObj = new List<Reservation>();
                foreach (var item in reservationList)
                {
                    Reservation r = new Reservation(
                            item.Id,
                            item.Name,
                            item.Taken,
                            item.DateReserved,
                            item.MovieId,
                            item.SeatCount);
                    r.Movie = getMovie(item.MovieId, "", 0).First();
                    r.Seats = getSeat(0, 0, 0, 0, reservationId);
                    r.Tickets = getTicket(0, item.Id);
                    returnObj.Add(r);
                }
                return returnObj;
            }
            catch (Exception)
            {

                return null;
            }


        }
        public IList<Movie> getMovie(int movieId, string title, int roomId)
        {
            try
            {
                var movieList = server.getMovie(movieId, title, roomId);
                List<Movie> returnObj = new List<Movie>();
                foreach (var item in movieList)
                {
                    Movie m = new Movie(item.Id, item.Title, item.DateAndTime, item.RoomId);
                    m.Room = getRoom(item.RoomId);
                    returnObj.Add(m);
                }
                return returnObj;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public Room getRoom(int roomId)
        {
            try
            {
                var room = server.getRoom(roomId);
                Room returnObj = new Room(room.Id, room.Cols, room.Rows);

                getSeatDelegate del = new getSeatDelegate(getSeat);

                IAsyncResult result = del.BeginInvoke(0, roomId, 0, 0, 0, new AsyncCallback((IAsyncResult async) =>
                {
                    AsyncResult ar = (AsyncResult)async;
                    getSeatDelegate del2 = (getSeatDelegate)ar.AsyncDelegate;
                    IList<Seat> x = del2.EndInvoke(async);
                }), "Success");

                returnObj.Seats = getSeat(0, roomId, 0, 0, 0);
                return returnObj;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public IList<Room> getAllRooms()
        {
            try
            {
                var roomList = server.getAllRooms();
                IList<Room> returnObj = new List<Room>();
                foreach (var item in roomList)
                {
                    var room = server.getRoom(item.Id);
                    Room r = new Room(room.Id, room.Cols, room.Rows);
                    r.Seats = getSeat(0, item.Id, 0, 0, 0);
                    returnObj.Add(r);
                }
                return returnObj;
            }
            catch (Exception)
            {
                return null;   
            }
        }
        public IList<Ticket> getTicket(int ticketId, int reservationId)
        {
            try
            {
                var ticketList = server.getTicket(ticketId, reservationId);
                IList<Ticket> returnObj = new List<Ticket>();
                foreach (var item in ticketList)
                {
                    Ticket ticket = new Ticket(
                        item.Id,
                        item.Standard,
                        item.Price,
                        item.PaidAmount,
                        item.ReservationId,
                        item.DiscountId,
                        item.Col,
                        item.Row);
                    ticket.Discount = getDiscount(item.DiscountId, 0);
                    ticket.Reservation = getReservation(item.ReservationId, "", 0).First();
                    returnObj.Add(ticket);
                }
                return returnObj;
            }
            catch (Exception)
            {
                return null;   
            }

        }
        public IList<Seat> getSeat(int seatId, int roomId, int col, int row, int reservationId)
        {
            try
            {
                var seatList = server.getSeat(seatId, roomId, col, row, reservationId);
                IList<Seat> returnObj = new List<Seat>();
                foreach (var item in seatList)
                {
                    returnObj.Add(new Seat(
                        item.Id,
                        item.Col,
                        item.Row,
                        item.Usable,
                        item.RoomId,
                        item.ReservationId
                        ));
                }
                return returnObj;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public Discount getDiscount(int? discountId, decimal dPercent)
        {
            try
            {
                var discount = server.getDiscount(discountId, dPercent);
                Discount returnObj = new Discount(discount.Id, discount.DPercent);
                return returnObj;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region remove
        public string removeReservation(int reservationId)
        {
            return server.removeReservation(reservationId);
        }
        public string removeMovie(int movieId)
        {
            return server.removeMovie(movieId);
        }
        public string removeRoom(int roomId)
        {
            return server.removeRoom(roomId);
        }
        public string removeTicket(int ticketId)
        {
            return server.removeTicket(ticketId);
        }
        public string removeDiscount(int discountId)
        {
            return server.removeDiscount(discountId);
        }
        #endregion

        #region methods
        public IList<Seat> getAdjSeatSingleThread(int noOfSeats, int roomId)
        {
            var seatList = server.getAdjSeatSingleThread(noOfSeats, roomId);
            IList<Seat> returnObj = new List<Seat>();
            foreach (var item in seatList)
            {
                returnObj.Add(new Seat(
                    item.Id,
                    item.Col,
                    item.Row,
                    item.Usable,
                    item.RoomId,
                    item.ReservationId
                    ));
            }
            return returnObj;
            //return server.getAdjSeat(noOfSeats, roomId);
        }
        public IList<Seat> getAdjSeatMultiThread(int noOfSeats, int roomId)
        {
            var seatList = server.getAdjSeatMultiThread(noOfSeats, roomId);
            IList<Seat> returnObj = new List<Seat>();
            foreach (var item in seatList)
            {
                returnObj.Add(new Seat(
                    item.Id,
                    item.Col,
                    item.Row,
                    item.Usable,
                    item.RoomId,
                    item.ReservationId
                    ));
            }
            return returnObj;
            //return server.getAdjSeat(noOfSeats, roomId);
        }

        public IList<Seat> getAdjSeatParallel(int noOfSeats, int roomId)
        {
            var seatList = server.getAdjSeatParallel(noOfSeats, roomId);
            IList<Seat> returnObj = new List<Seat>();
            foreach (var item in seatList)
            {
                returnObj.Add(new Seat(
                    item.Id,
                    item.Col,
                    item.Row,
                    item.Usable,
                    item.RoomId,
                    item.ReservationId
                    ));
            }
            return returnObj;
            //return server.getAdjSeat(noOfSeats, roomId);
        }
        public IList<string> adj2(int noOfSeats, int roomId) { return server.adj2(noOfSeats, roomId); }
        public IList<Seat> getAdjSeatSingleThreadV2(int noOfSeats, int roomId)
        {
            var seatList = server.getAdjSeatSingleThreadV2(noOfSeats, roomId);
            IList<Seat> returnObj = new List<Seat>();
            foreach (var item in seatList)
            {
                returnObj.Add(new Seat(
                    item.Id,
                    item.Col,
                    item.Row,
                    item.Usable,
                    item.RoomId,
                    item.ReservationId
                    ));
            }
            return returnObj;
            //return server.getAdjSeat(noOfSeats, roomId);
        }

        public IList<Seat> getAdjSeatMultiThreadV2(int noOfSeats, int roomId)
        {
            var seatList = server.getAdjSeatMultiThreadV2(noOfSeats, roomId);
            IList<Seat> returnObj = new List<Seat>();
            foreach (var item in seatList)
            {
                returnObj.Add(new Seat(
                    item.Id,
                    item.Col,
                    item.Row,
                    item.Usable,
                    item.RoomId,
                    item.ReservationId
                    ));
            }
            return returnObj;
            //return server.getAdjSeat(noOfSeats, roomId);
        }

        public bool emptyRoom(int roomId)
        {
            return server.emptyRoom(roomId);
        }
        #endregion
    }
}
