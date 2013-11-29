using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AwesomeServer;

namespace AwesomeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IService
    {
        Server server = new Server();

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
            return server.createTicket(standard,reservationId,discountId);
        }

        public string updateReservation(int reservationId, string name, bool taken, int movieId, int seatCount)
        {
            return server.updateReservation(reservationId, name, taken, movieId, seatCount);
        }

        //public string updateMovie(Movie movie, Movie newMovie)
        //{
        //    return server.update(movie, newMovie);
        //}

        //public string updateRoom(Room room, Room newRoom)
        //{
        //    return server.update(room, newRoom);
        //}

        //public string updateTicket(Ticket ticket, Ticket newTicket)
        //{
        //    return server.update(ticket, newTicket);
        //}

        //public string updateSeat(Seat seat, Seat newSeat)
        //{
        //    return server.update(seat, newSeat);
        //}

        public ICollection<Reservation> getReservation(int reservationId, string name, int movieId)
        {
            return server.getReservation(reservationId, name, movieId);
        }

        //public Movie getMovie(Movie movie)
        //{
        //    return server.get(movie);
        //}

        //public Room getRoom(Room room)
        //{
        //    return server.get(room);
        //}

        //public Ticket getTicket(Ticket ticket)
        //{
        //    return server.get(ticket);
        //}

        //public Seat getSeat(Seat seat)
        //{
        //    return server.get(seat);
        //}

        //public string removeReservation(Reservation reservation)
        //{
        //    return server.remove(reservation);
        //}

        //public string removeMovie(Movie movie)
        //{
        //    return server.remove(movie);
        //}

        //public string removeRoom(Room room)
        //{
        //    return server.remove(room);
        //}

        //public string removeTicket(Ticket ticket)
        //{
        //    return server.remove(ticket);
        //}

        //public IList<Seat> getAdjSeat(int noOfSeats)
        //{
        //    return server.getAdjSeat(noOfSeats);
        //}
    }
}
