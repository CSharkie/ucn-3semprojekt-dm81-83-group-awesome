using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AwesomeServer;

namespace AwesomeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string createReservation(Reservation reservation);
        [OperationContract]
        string createMovie(Movie movie);
        [OperationContract]
        string createRoom(Room room);
        [OperationContract]
        string createTicket(Ticket ticket);
        [OperationContract]
        string updateReservation(Reservation reservation, Reservation newReservation);
        [OperationContract]
        string updateMovie(Movie movie, Movie newMovie);
        [OperationContract]
        string updateRoom(Room room, Room newRoom);
        [OperationContract]
        string updateTicket(Ticket ticket, Ticket newTicket);
        [OperationContract]
        string updateSeat(Seat seat, Seat newSeat);
        [OperationContract]
        Reservation getReservation(Reservation reservation);
        [OperationContract]
        Movie getMovie(Movie movie);
        [OperationContract]
        Room getRoom(Room room);
        [OperationContract]
        Ticket getTicket(Ticket ticket);
        [OperationContract]
        Seat getSeat(Seat seat);
        [OperationContract]
        string removeReservation(Reservation reservation);
        [OperationContract]
        string removeMovie(Movie movie);
        [OperationContract]
        string removeRoom(Room room);
        [OperationContract]
        string removeTicket(Ticket ticket);
        [OperationContract]
        IList<Seat> getAdjSeat(int noOfSeats);
    }
}
