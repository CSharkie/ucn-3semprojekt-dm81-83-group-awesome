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
        
        public Reservation(int id, string name, bool taken, DateTime dateReserved, int movieId, int seatCount)
        {
            this.Id = id;
            this.Name = name;
            this.Taken = taken;
            this.DateReserved = dateReserved;
            this.MovieId = movieId;
            this.SeatCount = seatCount;
        }
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
        public Movie(int id, string title, DateTime dateAndTime, int roomId)
        {
            this.Id = id;
            this.Title = title;
            this.DateAndTime = dateAndTime;
            this.RoomId = roomId;
        }
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
        public Room(int id, int cols, int rows)
        {
            this.Id = id;
            this.Cols = cols;
            this.Rows = rows;
        }
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
        public Seat(int id, int col, int row, bool usable, int roomId, int reservationId)
        {
            this.Id = id;
            this.Col = col;
            this.Row = row;
            this.Usable = usable;
            this.RoomId = roomId;
            this.ReservationId = reservationId;
        }
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
        public Ticket(int id, decimal standard, decimal price, decimal paidAmmount, int reservationId, int discountId)
        {
            this.Id = id;
            this.Standard = standard;
            this.Price = price;
            this.PaidAmount = paidAmmount;
            this.ReservationId = reservationId;
            this.DiscountId = discountId;
        }
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
        public Discount(int id, decimal DPercent)
        {
            this.Id = id;
            this.DPercent = DPercent;
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public decimal DPercent { get; set; }
    }
}
