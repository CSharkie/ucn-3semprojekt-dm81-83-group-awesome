using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AwesomeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]

    public interface IService
    {
        [OperationContract]
        string createReservation(string name, bool taken, DateTime dateReserved, int movieId, int seatCount);
        [OperationContract]
        string createMovie(string title, DateTime dateAndTime, int roomId);
        [OperationContract]
        string createRoom(int cols, int rows);
        [OperationContract]
        string createTicket(decimal standard, int reservationId, int discountId);
        [OperationContract]
        string updateReservation(int reservationId, string name, bool taken, int movieId, int seatCount);
        //[OperationContract]
        //string updateMovie(Movie movie, Movie newMovie);
        //[OperationContract]
        //string updateRoom(Room room, Room newRoom);
        //[OperationContract]
        //string updateTicket(Ticket ticket, Ticket newTicket);
        //[OperationContract]
        //string updateSeat(Seat seat, Seat newSeat);
        [OperationContract]
        Reservation getReservation(int reservationId, string name, int movieId);
        //[OperationContract]
        //Movie getMovie(Movie movie);
        [OperationContract]
        Room getRoom(int roomId);
        //[OperationContract]
        //Ticket getTicket(Ticket ticket);
        //[OperationContract]
        //Seat getSeat(Seat seat);
        //[OperationContract]
        //string removeReservation(Reservation reservation);
        //[OperationContract]
        //string removeMovie(Movie movie);
        //[OperationContract]
        //string removeRoom(Room room);
        //[OperationContract]
        //string removeTicket(Ticket ticket);
        //[OperationContract]
        //IList<Seat> getAdjSeat(int noOfSeats);
    }
    [DataContract]
    public class Reservation
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool Taken { get; set; }
        [DataMember]
        public DateTime DateReserved { get; set; }
        [DataMember]
        public int MovieId { get; set; }
        [DataMember]
        public int SeatCount { get; set; }
        //[DataMember]
        //public Movie Movie {get;set;}
        //[DataMember]
        //public EntitySet<Seat> Seats { get; set; }
        //[DataMember]
        //public EntitySet<Ticket> Tickets { get; set; }
    }
    [DataContract]
    public class Movie
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public DateTime DateAndTime { get; set; }
        [DataMember]
        public int RoomId { get; set; }
        //[DataMember]
        //public EntitySet<Reservation> Reservations { get; set; }
        //[DataMember]
        //public Room Room { get; set; }
    }
    [DataContract]
    public class Room
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Cols { get; set; }
        [DataMember]
        public int Rows { get; set; }
    //    [DataMember]
    //    public EntitySet<Movie> Movies { get; set; }
    //    [DataMember]
    //    public EntitySet<Seat> Seats { get; set; }
    }
    [DataContract]
    public class Seat
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Col { get; set; }
        [DataMember]
        public int Row { get; set; }
        [DataMember]
        public bool Usable { get; set; }
        [DataMember]
        public int RoomId { get; set; }
        [DataMember]
        public int ReservationId { get; set; }
        //[DataMember]
        //public Room Room { get; set; }
        //[DataMember]
        //public Reservation Reservation { get; set; }
    }
    [DataContract]
    public class Ticket
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public decimal Standard { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public decimal PaidAmount { get; set; }
        [DataMember]
        public int ReservationId { get; set; }
        [DataMember]
        public int DiscountId { get; set; }
        //[DataMember]
        //public Reservation Reservation { get; set; }
        //[DataMember]
        //public Discount Discount { get; set; }
    }
    [DataContract]
    public class Discount
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public decimal Dpercent { get; set; }
    }
}
