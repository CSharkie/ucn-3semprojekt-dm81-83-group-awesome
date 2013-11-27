using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeServer
{
    interface IServer
    {
        string create(Reservation reservation);
        string create(Movie movie);
        string create(Room room);
        string create(Ticket ticket);
        string update(Reservation reservation, Reservation newReservation);
        string update(Movie movie, Movie newMovie);
        string update(Room room, Room newRoom);
        string update(Ticket ticket, Ticket newTicket);
        string update(Seat seat, Seat newSeat);
        Reservation get(Reservation reservation);
        Movie get(Movie movie);
        Room get(Room room);
        Ticket get(Ticket ticket);
        Seat get(Seat seat);
        string remove(Reservation reservation);
        string remove(Movie movie);
        string remove(Room room);
        string remove(Ticket ticket);
        IList<Seat> getAdjSeat(int noOfSeats);
        string addMovieToRoom(int noOfSeats);
    }
}
