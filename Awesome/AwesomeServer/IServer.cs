using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeServer
{
    interface IServer
    {
        #region create
        string createReservation(string name, bool taken, int seatCount, int movieId, IList<int> seatIds);
        string createMovie(string title, DateTime dateAndTime, TimeSpan Duration, int roomId);
        string createRoom(int cols, int rows);
        string createTicket(decimal standard, int reservationId, int discountId, int col, int row);
        string createDiscount(decimal dPercent);
        #endregion

        #region update
        string updateReservation(int reservationId, string name, bool taken, DateTime dateOfReserve, int seatCount);
        string updateMovie(int movieId, string title, DateTime dateAndTime, TimeSpan Duration, int roomId);
        string updateRoom(int roomId, int cols, int rows);
        string updateTicket(int ticketId, decimal standard, int reservationId, int discountId);
        string updateSeat(int seatId, int col, int row, bool usable, DateTime dateAndTime, int roomId);
        string updateDiscount(int discountId, decimal dPercent);
        #endregion

        #region read
        IList<Reservation> getReservation(int reservationId, string name);
        IList<Movie> getMovie(int movieId, string title, int roomId);
        Room getRoom(int roomId);
        IList<Room> getAllRooms();
        IList<Ticket> getTicket(int ticketId, int reservationId);
        IList<Seat> getSeat(int seatId, int roomId, int col, int row, int movieId);
        Discount getDiscount(int? discountId, decimal dPercent);
        #endregion

        #region remove
        string removeReservation(int reservationId);
        string removeMovie(int movieId);
        string removeRoom(int roomId);
        string removeTicket(int ticketId);
        string removeDiscount(int discountId);
        string removeSeat(int seatId);
        #endregion

        #region methods
        //IList<Seat> getAdjSeatSingleThread(int noOfSeats, int roomId);
        //IList<Seat> getAdjSeatMultiThread(int noOfSeats, int roomId);
        //IList<string> adj2(int noOfSeats, int roomId);
        //IList<Seat> getAdjSeatSingleThreadV2(int noOfSeats, int roomId);
        //IList<Seat> getAdjSeatParallel(int noOfSeats, int roomId);
        //IList<Seat> getAdjSeatMultiThreadV2(int noOfSeats, int roomId);
        //bool emptyRoom(int roomId);
        //string takeTickets(int reservationId);
        #endregion
        
    }
}
