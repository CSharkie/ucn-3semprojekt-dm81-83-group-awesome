using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GroupAwesomeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGACinemaService
    {
        #region create
        [OperationContract]
        string create(Reservation reservation);

        [OperationContract]
        string create(Movie movie);

        [OperationContract]
        string create(Room room);

        [OperationContract]
        string create(Ticket ticket);
        #endregion

        #region update
        [OperationContract]
        string update(Reservation reservation, Reservation newReservation);

        [OperationContract]
        string update(Movie movie, Movie newMovie);

        [OperationContract]
        string update(Room room, Room newRoom);

        [OperationContract]
        string update(Ticket ticket, Ticket newTicket);

        [OperationContract]
        string update(Seat seat);
        #endregion

        #region read
        [OperationContract]
        Reservation get(Reservation reservation);

        [OperationContract]
        Movie get(Movie movie);

        [OperationContract]
        Room get(Room room);

        [OperationContract]
        Ticket get(Ticket ticket);

        [OperationContract]
        Seat get(Seat seat);
        #endregion

        #region delete
        [OperationContract]
        string remove(Reservation reservation);

        [OperationContract]
        string remove(Movie movie);

        [OperationContract]
        string remove(Room room);

        [OperationContract]
        string remove(Ticket ticket);
        #endregion

        #region methods
        [OperationContract]
        IList<Seat> getAdjSeat(int noOfSeats);

        [OperationContract]
        string addMovieToRoom(int noOfSeats);
        #endregion
    }
}
