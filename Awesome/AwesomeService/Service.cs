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
            return server.update(movie, newMovie);
        }

        public string updateRoom(Room room, Room newRoom)
        {
            return server.update(room, newRoom);
        }

        public string updateTicket(Ticket ticket, Ticket newTicket)
        {
            return server.update(ticket, newTicket);
        }

        public string updateSeat(Seat seat, Seat newSeat)
        {
            return server.update(seat, newSeat);
        }

        public Reservation getReservation(Reservation reservation)
        {
            return server.get(reservation);
        }

        public Movie getMovie(Movie movie)
        {
            return server.get(movie);
        }

        public Room getRoom(Room room)
        {
            return server.get(room);
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
    }
}
