using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AwesomeServer;

namespace AwesomeService
{
    [ServiceContract]
    public interface IService
    {
        #region create
        [OperationContract]
        string createReservation(string name, bool taken, DateTime dateOfReserve, int seatCounts);
        [OperationContract]
        string createMovie(string title, DateTime dateAndTime, TimeSpan Duration, int roomId);
        [OperationContract]
        string createRoom(int cols, int rows);
        [OperationContract]
        string createTicket(decimal standard, int reservationId, int discountId, int col, int row);
        [OperationContract]
        string createDiscount(decimal dPercent);
        #endregion

        #region update
        [OperationContract]
        string updateReservation(int reservationId, string name, bool taken, DateTime dateOfReserve, int seatCount);

        [OperationContract]
        string updateMovie(int movieId, string title, DateTime dateAndTime, TimeSpan Duration, int roomId);
        [OperationContract]
        string updateRoom(int roomId, int cols, int rows);
        [OperationContract]
        string updateTicket(int ticketId, decimal standard, int reservationId, int discountId);
        [OperationContract]
        string updateSeat(int seatId, int col, int row, bool usable, DateTime dateAndTime, int roomId);
        [OperationContract]
        string updateDiscount(int discountId, decimal dPercent);
        #endregion

        #region read
        [OperationContract]
        IList<Reservation> getReservation(int reservationId, string name);
        [OperationContract]
        IList<Movie> getMovie(int movieId, string title, int roomId);
        [OperationContract]
        Room getRoom(int roomId);
        [OperationContract]
        IList<Room> getAllRooms();
        [OperationContract]
        IList<Ticket> getTicket(int ticketId, int reservationId);
        [OperationContract]
        IList<Seat> getSeat(int seatId, int roomId, int col, int row, int movieId);
        [OperationContract]
        Discount getDiscount(int? discountId, decimal dPercent);
        #endregion

        #region remove
        [OperationContract]
        string removeReservation(int reservationId);
        [OperationContract]
        string removeMovie(int movieId);
        [OperationContract]
        string removeRoom(int roomId);
        [OperationContract]
        string removeTicket(int ticketId);
        [OperationContract]
        string removeDiscount(int discountId);
        #endregion

        #region methods
        //[OperationContract]
        //IList<Seat> getAdjSeatSingleThread(int noOfSeats, int roomId);
        //[OperationContract]
        //IList<Seat> getAdjSeatMultiThread(int noOfSeats, int roomId);
        //[OperationContract]
        //IList<Seat> getAdjSeatParallel(int noOfSeats, int roomId);
        //[OperationContract]
        //IList<Seat> getAdjSeatSingleThreadV2(int noOfSeats, int roomId);
        //[OperationContract]
        //IList<Seat> getAdjSeatMultiThreadV2(int noOfSeats, int roomId);
        //[OperationContract]
        //IList<string> adj2(int noOfSeats, int roomId);
        //[OperationContract]
        //bool emptyRoom(int roomId);
        #endregion
    }
  
}
