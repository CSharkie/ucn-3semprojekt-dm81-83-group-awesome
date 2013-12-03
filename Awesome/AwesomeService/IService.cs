using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AwesomeService
{
    [ServiceContract]
    public interface IService
    {
        #region create
        [OperationContract]
        string createReservation(string name, bool taken, DateTime dateReserved, int movieId, IList<int> seats);
        [OperationContract]
        string createMovie(string title, DateTime dateAndTime, int roomId);
        [OperationContract]
        string createRoom(int cols, int rows);
        [OperationContract]
        string createTicket(decimal standard, int reservationId, int discountId, int col, int row);
        [OperationContract]
        string createDiscount(decimal dPercent);
        #endregion

        #region update
        [OperationContract]
        string updateReservation(int reservationId, string name, bool taken, int movieId, int seatCount);

        [OperationContract]
        string updateMovie(int movieId, string title, DateTime dateAndTime, int roomId);
        [OperationContract]
        string updateRoom(int roomId, int cols, int rows);
        [OperationContract]
        string updateTicket(int ticketId, decimal standard, int reservationId, int discountId);
        [OperationContract]
        string updateSeat(int seatId, int col, int row, bool usable, int roomId, int reservationId);
        [OperationContract]
        string updateDiscount(int discountId, decimal dPercent);
        #endregion

        #region read
        [OperationContract]
        IList<Reservation> getReservation(int reservationId, string name, int movieId);
        [OperationContract]
        IList<Movie> getMovie(int movieId, string title, int roomId);
        [OperationContract]
        Room getRoom(int roomId);
        [OperationContract]
        IList<Room> getAllRooms();
        [OperationContract]
        IList<Ticket> getTicket(int ticketId, int reservationId);
        [OperationContract]
        IList<Seat> getSeat(int seatId, int roomId, int col, int row, int reservationId);
        [OperationContract]
        Discount getDiscount(int? discountId, decimal dPercent);
        #endregion

        #region remove
        [OperationContract]
        string removeReservation(int reservationId);
        [OperationContract]
        string removeMovie(int movieId);
        [OperationContract]
        string removeRoom(int roomId);
        [OperationContract]
        string removeTicket(int ticketId);
        [OperationContract]
        string removeDiscount(int discountId);
        #endregion

        #region methods
        [OperationContract]
        IList<Seat> getAdjSeatSingleThread(int noOfSeats, int roomId);
        [OperationContract]
        IList<Seat> getAdjSeatMultiThread(int noOfSeats, int roomId);
        [OperationContract]
        IList<Seat> getAdjSeatSingleThreadV2(int noOfSeats, int roomId);
        [OperationContract]
        string adj2(int noOfSeats, int roomId);
        [OperationContract]
        bool emptyRoom(int roomId);
        #endregion
    }
    #region contracts
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
        [DataMember]
        public Movie Movie { get; set; }
        [DataMember]
        public IList<Seat> Seats { get; set; }
        [DataMember]
        public IList<Ticket> Tickets { get; set; }
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
        [DataMember]
        public Room Room { get; set; }
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
        [DataMember]
        public IList<Seat> Seats { get; set; }
    }
    [DataContract]
    public class Seat
    {
        public Seat(int id, int col, int row, bool usable, int roomId, int? reservationId)
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
        public int? ReservationId { get; set; }
    }
    [DataContract]
    public class Ticket
    {
        public Ticket(int id, decimal standard, decimal? price, decimal? paidAmmount, int reservationId, int? discountId, int col, int row)
        {
            this.Id = id;
            this.Standard = standard;
            this.Price = price;
            this.PaidAmount = paidAmmount;
            this.ReservationId = reservationId;
            this.DiscountId = discountId;
            this.Col = col;
            this.Row = row;
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public decimal Standard { get; set; }
        [DataMember]
        public decimal? Price { get; set; }
        [DataMember]
        public decimal? PaidAmount { get; set; }
        [DataMember]
        public int ReservationId { get; set; }
        [DataMember]
        public int? DiscountId { get; set; }
        [DataMember]
        public int Col { get; set; }
        [DataMember]
        public int Row { get; set; }
        [DataMember]
        public Reservation Reservation { get; set; }
        [DataMember]
        public Discount Discount { get; set; }
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
    #endregion
}
