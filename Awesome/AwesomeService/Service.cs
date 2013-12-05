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
    public class Service : IService
    {
        Server server = new Server();

        #region create
        public string createReservation(string name, bool taken, DateTime dateOfReserve, int seatCount)
        {
            return server.createReservation(name, taken, dateOfReserve,seatCount);
        }
        public string createMovie(string title, DateTime dateAndTime, TimeSpan Duration, int roomId)
        {

            return server.createMovie(title, dateAndTime, Duration, roomId);
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
        public string updateReservation(int reservationId, string name, bool taken, DateTime dateOfReserve, int seatCount)
        {

            return server.updateReservation(reservationId, name, taken, dateOfReserve , seatCount);
        }

        public string updateMovie(int movieId, string title, DateTime dateAndTime, TimeSpan Duration, int roomId)
        {
            return server.updateMovie(movieId, title, dateAndTime, Duration, roomId);
        }

        public string updateRoom(int roomId, int cols, int rows)
        {
            return server.updateRoom(roomId, cols, rows);
        }

        public string updateTicket(int ticketId, decimal standard, int reservationId, int discountId)
        {
            return server.updateTicket(ticketId, standard, reservationId, discountId);
        }

        public string updateSeat(int seatId, int col, int row, bool usable, DateTime dateAndTime, int roomId)
        {
            return server.updateSeat(seatId, col, row, usable, dateAndTime, roomId);
        }

        public string updateDiscount(int discountId, decimal dPercent)
        {
            return server.updateDiscount(discountId, dPercent);
        }
        #endregion

        #region read
        public IList<Reservation> getReservation(int reservationId, string name)
        {
            return server.getReservation(reservationId, name);
        }
        public IList<Movie> getMovie(int movieId, string title, int roomId)
        {
            return server.getMovie(movieId, title, roomId);
        }
        public Room getRoom(int roomId)
        {
            return server.getRoom(roomId);

        }

        public IList<Room> getAllRooms()
        {
            return server.getAllRooms();
        }
        public IList<Ticket> getTicket(int ticketId, int reservationId)
        {
            return server.getTicket(ticketId, reservationId);

        }
        public IList<Seat> getSeat(int seatId, int roomId, int col, int row, int movieId)
        {
            return server.getSeat(seatId, roomId, col, row, movieId);

        }
        public Discount getDiscount(int? discountId, decimal dPercent)
        {
            return server.getDiscount(discountId, dPercent);
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
        //public IList<Seat> getAdjSeatSingleThread(int noOfSeats, int roomId)
        //{
        //    return server.getAdjSeatSingleThread(noOfSeats, roomId);
        //}
        //public IList<Seat> getAdjSeatMultiThread(int noOfSeats, int roomId)
        //{
        //    return server.getAdjSeatMultiThread(noOfSeats, roomId);
        //}

        //public IList<Seat> getAdjSeatParallel(int noOfSeats, int roomId)
        //{
        //    return server.getAdjSeatParallel(noOfSeats, roomId);
        //}
        //public IList<string> adj2(int noOfSeats, int roomId) 
        //{ 
        //    return server.adj2(noOfSeats, roomId); 
        //}
        //public IList<Seat> getAdjSeatSingleThreadV2(int noOfSeats, int roomId)
        //{
        //    return server.getAdjSeatSingleThreadV2(noOfSeats, roomId);
        //}

        //public IList<Seat> getAdjSeatMultiThreadV2(int noOfSeats, int roomId)
        //{
        //    return server.getAdjSeatSingleThreadV2(noOfSeats, roomId);
        //}

        //public bool emptyRoom(int roomId)
        //{
        //    return server.emptyRoom(roomId);
        //}
        #endregion
    }
}
