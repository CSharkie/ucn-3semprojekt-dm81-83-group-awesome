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
            
            return server.createTicket(standard, reservationId, discountId);
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

        public Reservation getReservation(int reservationId, string name, int movieId)
        {
            
            var res = server.getReservation(reservationId, name, movieId);
            Reservation reserv = new Reservation(
                res.Id,
                res.Name,
                res.Taken,
                res.DateReserved,
                res.MovieId,
                res.SeatCount);
            return reserv;

        }

        //public Movie getMovie(Movie movie)
        //{
        //    return server.get(movie);
        //}

        public Room getRoom(int roomId)
        {
            
            var room = server.getRoom(roomId);
            Room obj = new Room();
            obj.Id = room.Id;
            obj.Cols = room.Cols;
            obj.Rows = room.Rows;
            
            return obj;
        }

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
