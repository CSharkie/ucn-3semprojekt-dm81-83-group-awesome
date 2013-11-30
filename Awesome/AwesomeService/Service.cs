using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AwesomeServer;
using System.Collections.ObjectModel;
namespace AwesomeService
{
    public class Service : IService
    {
        Server server = new Server();

        #region create
        public string createReservation(string name, bool taken, DateTime dateReserved, int movieId, int seatCount)
        {

            return server.createReservation(name, taken, dateReserved, movieId, seatCount);
        }
        public string createMovie(string title, DateTime dateAndTime, int roomId)
        {

            return server.createMovie(title, dateAndTime, roomId);
        }
        public string createRoom(int cols, int rows)
        {

            return server.createRoom(cols, rows);
        }
        public string createTicket(decimal standard, int reservationId, int discountId)
        {

            return server.createTicket(standard, reservationId, discountId);
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
            var reservationList = server.getReservation(reservationId, name, movieId);
            List<Reservation> returnObj = new List<Reservation>();
            foreach (var item in reservationList)
            {
                returnObj.Add(new Reservation(
                        item.Id,
                        item.Name,
                        item.Taken,
                        item.DateReserved,
                        item.MovieId,
                        item.SeatCount));
            }
            return returnObj;


        }
        public IList<Movie> getMovie(int movieId, string title, int roomId)
        {
            var movieList = server.getMovie(movieId, title, roomId);
            List<Movie> returnObj = new List<Movie>();
            foreach (var item in movieList)
            {
                returnObj.Add(new Movie(
                    item.Id,
                    item.Title,
                    item.DateAndTime,
                    item.RoomId
                    ));
            }
            return returnObj;
        }
        public Room getRoom(int roomId)
        {

            var room = server.getRoom(roomId);
            Room returnObj = new Room(room.Id, room.Cols, room.Rows);

            return returnObj;
        }
        public IList<Room> getAllRooms()
        {
            var roomList = server.getAllRooms();
            IList<Room> returnObj = new List<Room>();
            foreach (var item in roomList)
            {
                returnObj.Add(new Room(
                    item.Id,
                    item.Cols,
                    item.Rows
                    ));
            }
            return returnObj;
        }
        public IList<Ticket> getTicket(int ticketId, int reservationId)
        {
            var ticketList = server.getTicket(ticketId, reservationId);
            IList<Ticket> returnObj = new List<Ticket>();
            foreach (var item in ticketList)
            {
                returnObj.Add(new Ticket(
                    item.Id,
                    item.Standard,
                    item.Price,
                    item.PaidAmount,
                    item.ReservationId,
                    item.DiscountId
                    ));
            }
            return returnObj;

        }
        public IList<Seat> getSeat(int seatId, int roomId, int col, int row)
        {
            var seatList = server.getSeat(seatId, roomId, col, row);
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
        public Discount getDiscount(int discountId, decimal dPercent)
        {
            var discount = server.getDiscount(discountId, dPercent);
            Discount returnObj = new Discount(discount.Id, discount.DPercent);
            return returnObj;
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
        //public IList<Seat> getAdjSeat(int noOfSeats)
        //{
        //    return server.getAdjSeat(noOfSeats);
        //}
        #endregion
    }
}
