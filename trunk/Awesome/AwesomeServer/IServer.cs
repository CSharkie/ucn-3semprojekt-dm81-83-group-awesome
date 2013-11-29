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
        string createReservation(string name, bool taken, DateTime dateReserved, int movieId, int seatCount);
        string createMovie(string title, DateTime dateAndTime, int roomId);
        string createRoom(int cols, int rows);
        string createTicket(decimal standard, int reservationId, int discountId);
        string createDiscount(decimal dPercent);
        string updateReservation(int reservationId, string name, bool taken, int movieId, int seatCount);
        //string updateMovie(int movieId, string title, DateTime dateAndTime, int roomId);
        //string updateRoom(int roomId, int cols, int rows);
        //string updateTicket(int ticketId, decimal standard, int reservationId, int discountId);
        //string updateSeat(int seatId, int col, int row, bool usable, int roomId, int reservationId);
        IList<Reservation> getReservation(int reservationId, string name, int movieId);
        //ICollection<Movie> getMovie(int movieId, string title, int roomId);
        Room getRoom(int roomId);
        //IList<Room> getAllRooms();
        IList<Ticket> getTicket(int ticketId, int reservationId);
        IList<Seat> getSeat(int seatId, int roomId, int col, int row);
        //string removeReservation(int reservationId, string name);
        //string removeMovie(int movieId, string title, DateTime dateAndTime, int roomId);
        //string removeRoom(int roomId);
        //string removeTicket(int ticketId, int reservationId);
        //IList<Seat> getAdjSeat(int noOfSeats);
    }
}
