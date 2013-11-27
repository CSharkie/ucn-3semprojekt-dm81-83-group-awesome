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

        public string createReservation(Reservation reservation)
        {
            return server.create(reservation);
        }

        public string createMovie(Movie movie)
        {
            return server.create(movie);
        }

        public string createRoom(Room room)
        {
            return server.create(room);
        }

        public string createTicket(Ticket ticket)
        {
            return server.create(ticket);
        }

        public string updateReservation(Reservation reservation, Reservation newReservation)
        {
            return server.update(reservation, newReservation);
        }

        public string updateMovie(Movie movie, Movie newMovie)
        {
            throw new NotImplementedException();
        }

        public string updateRoom(Room room, Room newRoom)
        {
            throw new NotImplementedException();
        }

        public string updateTicket(Ticket ticket, Ticket newTicket)
        {
            throw new NotImplementedException();
        }

        public string updateSeat(Seat seat, Seat newSeat)
        {
            throw new NotImplementedException();
        }

        public Reservation getReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public Movie getMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Room getRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public Ticket getTicket(Ticket ticket)
        {
            return server.get(ticket);
        }

        public Seat getSeat(Seat seat)
        {
            return server.get(seat);
        }

        public string removeReservation(Reservation reservation)
        {
            return server.remove(reservation);
        }

        public string removeMovie(Movie movie)
        {
            return server.remove(movie);
        }

        public string removeRoom(Room room)
        {
            return server.remove(room);
        }

        public string removeTicket(Ticket ticket)
        {
            return server.remove(ticket);
        }

        public IList<Seat> getAdjSeat(int noOfSeats)
        {
            return server.getAdjSeat(noOfSeats);
        }

        public string addMovieToRoom(int noOfSeats)
        {
            return server.addMovieToRoom(noOfSeats);
        }
    }
}
