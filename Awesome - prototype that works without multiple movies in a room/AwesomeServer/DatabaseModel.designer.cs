﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AwesomeServer
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="groupAwesomeDb_tmp")]
	public partial class DatabaseModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDiscount(Discount instance);
    partial void UpdateDiscount(Discount instance);
    partial void DeleteDiscount(Discount instance);
    partial void InsertTicket(Ticket instance);
    partial void UpdateTicket(Ticket instance);
    partial void DeleteTicket(Ticket instance);
    partial void InsertMovie(Movie instance);
    partial void UpdateMovie(Movie instance);
    partial void DeleteMovie(Movie instance);
    partial void InsertReservation(Reservation instance);
    partial void UpdateReservation(Reservation instance);
    partial void DeleteReservation(Reservation instance);
    partial void InsertRoom(Room instance);
    partial void UpdateRoom(Room instance);
    partial void DeleteRoom(Room instance);
    partial void InsertSeat(Seat instance);
    partial void UpdateSeat(Seat instance);
    partial void DeleteSeat(Seat instance);
    #endregion
		
		public DatabaseModelDataContext() : 
				base(global::AwesomeServer.Properties.Settings.Default.groupAwesomeDb_tmpConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Discount> Discounts
		{
			get
			{
				return this.GetTable<Discount>();
			}
		}
		
		public System.Data.Linq.Table<Ticket> Tickets
		{
			get
			{
				return this.GetTable<Ticket>();
			}
		}
		
		public System.Data.Linq.Table<Movie> Movies
		{
			get
			{
				return this.GetTable<Movie>();
			}
		}
		
		public System.Data.Linq.Table<Reservation> Reservations
		{
			get
			{
				return this.GetTable<Reservation>();
			}
		}
		
		public System.Data.Linq.Table<Room> Rooms
		{
			get
			{
				return this.GetTable<Room>();
			}
		}
		
		public System.Data.Linq.Table<Seat> Seats
		{
			get
			{
				return this.GetTable<Seat>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Discounts")]
	public partial class Discount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private decimal _DPercent;
		
		private EntitySet<Ticket> _Tickets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDPercentChanging(decimal value);
    partial void OnDPercentChanged();
    #endregion
		
		public Discount()
		{
			this._Tickets = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Tickets), new Action<Ticket>(this.detach_Tickets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DPercent", DbType="Decimal(18,2) NOT NULL")]
		public decimal DPercent
		{
			get
			{
				return this._DPercent;
			}
			set
			{
				if ((this._DPercent != value))
				{
					this.OnDPercentChanging(value);
					this.SendPropertyChanging();
					this._DPercent = value;
					this.SendPropertyChanged("DPercent");
					this.OnDPercentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Discount_Ticket", Storage="_Tickets", ThisKey="Id", OtherKey="DiscountId")]
		public EntitySet<Ticket> Tickets
		{
			get
			{
				return this._Tickets;
			}
			set
			{
				this._Tickets.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Discount = this;
		}
		
		private void detach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Discount = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tickets")]
	public partial class Ticket : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private decimal _Standard;
		
		private System.Nullable<decimal> _Price;
		
		private System.Nullable<decimal> _PaidAmount;
		
		private int _ReservationId;
		
		private System.Nullable<int> _DiscountId;
		
		private int _Col;
		
		private int _Row;
		
		private EntityRef<Discount> _Discount;
		
		private EntityRef<Reservation> _Reservation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnStandardChanging(decimal value);
    partial void OnStandardChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnPaidAmountChanging(System.Nullable<decimal> value);
    partial void OnPaidAmountChanged();
    partial void OnReservationIdChanging(int value);
    partial void OnReservationIdChanged();
    partial void OnDiscountIdChanging(System.Nullable<int> value);
    partial void OnDiscountIdChanged();
    partial void OnColChanging(int value);
    partial void OnColChanged();
    partial void OnRowChanging(int value);
    partial void OnRowChanged();
    #endregion
		
		public Ticket()
		{
			this._Discount = default(EntityRef<Discount>);
			this._Reservation = default(EntityRef<Reservation>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Standard", DbType="Decimal(18,2) NOT NULL")]
		public decimal Standard
		{
			get
			{
				return this._Standard;
			}
			set
			{
				if ((this._Standard != value))
				{
					this.OnStandardChanging(value);
					this.SendPropertyChanging();
					this._Standard = value;
					this.SendPropertyChanged("Standard");
					this.OnStandardChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", AutoSync=AutoSync.Always, DbType="Decimal(18,0)", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaidAmount", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> PaidAmount
		{
			get
			{
				return this._PaidAmount;
			}
			set
			{
				if ((this._PaidAmount != value))
				{
					this.OnPaidAmountChanging(value);
					this.SendPropertyChanging();
					this._PaidAmount = value;
					this.SendPropertyChanged("PaidAmount");
					this.OnPaidAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationId", DbType="Int NOT NULL")]
		public int ReservationId
		{
			get
			{
				return this._ReservationId;
			}
			set
			{
				if ((this._ReservationId != value))
				{
					if (this._Reservation.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnReservationIdChanging(value);
					this.SendPropertyChanging();
					this._ReservationId = value;
					this.SendPropertyChanged("ReservationId");
					this.OnReservationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiscountId", DbType="Int")]
		public System.Nullable<int> DiscountId
		{
			get
			{
				return this._DiscountId;
			}
			set
			{
				if ((this._DiscountId != value))
				{
					if (this._Discount.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDiscountIdChanging(value);
					this.SendPropertyChanging();
					this._DiscountId = value;
					this.SendPropertyChanged("DiscountId");
					this.OnDiscountIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Col", DbType="Int NOT NULL")]
		public int Col
		{
			get
			{
				return this._Col;
			}
			set
			{
				if ((this._Col != value))
				{
					this.OnColChanging(value);
					this.SendPropertyChanging();
					this._Col = value;
					this.SendPropertyChanged("Col");
					this.OnColChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Row", DbType="Int NOT NULL")]
		public int Row
		{
			get
			{
				return this._Row;
			}
			set
			{
				if ((this._Row != value))
				{
					this.OnRowChanging(value);
					this.SendPropertyChanging();
					this._Row = value;
					this.SendPropertyChanged("Row");
					this.OnRowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Discount_Ticket", Storage="_Discount", ThisKey="DiscountId", OtherKey="Id", IsForeignKey=true)]
		public Discount Discount
		{
			get
			{
				return this._Discount.Entity;
			}
			set
			{
				Discount previousValue = this._Discount.Entity;
				if (((previousValue != value) 
							|| (this._Discount.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Discount.Entity = null;
						previousValue.Tickets.Remove(this);
					}
					this._Discount.Entity = value;
					if ((value != null))
					{
						value.Tickets.Add(this);
						this._DiscountId = value.Id;
					}
					else
					{
						this._DiscountId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Discount");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Reservation_Ticket", Storage="_Reservation", ThisKey="ReservationId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Reservation Reservation
		{
			get
			{
				return this._Reservation.Entity;
			}
			set
			{
				Reservation previousValue = this._Reservation.Entity;
				if (((previousValue != value) 
							|| (this._Reservation.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Reservation.Entity = null;
						previousValue.Tickets.Remove(this);
					}
					this._Reservation.Entity = value;
					if ((value != null))
					{
						value.Tickets.Add(this);
						this._ReservationId = value.Id;
					}
					else
					{
						this._ReservationId = default(int);
					}
					this.SendPropertyChanged("Reservation");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Movies")]
	public partial class Movie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private System.DateTime _DateAndTime;
		
		private int _RoomId;
		
		private EntitySet<Reservation> _Reservations;
		
		private EntityRef<Room> _Room;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDateAndTimeChanging(System.DateTime value);
    partial void OnDateAndTimeChanged();
    partial void OnRoomIdChanging(int value);
    partial void OnRoomIdChanged();
    #endregion
		
		public Movie()
		{
			this._Reservations = new EntitySet<Reservation>(new Action<Reservation>(this.attach_Reservations), new Action<Reservation>(this.detach_Reservations));
			this._Room = default(EntityRef<Room>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateAndTime", DbType="DateTime NOT NULL")]
		public System.DateTime DateAndTime
		{
			get
			{
				return this._DateAndTime;
			}
			set
			{
				if ((this._DateAndTime != value))
				{
					this.OnDateAndTimeChanging(value);
					this.SendPropertyChanging();
					this._DateAndTime = value;
					this.SendPropertyChanged("DateAndTime");
					this.OnDateAndTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomId", DbType="Int NOT NULL")]
		public int RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				if ((this._RoomId != value))
				{
					if (this._Room.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoomIdChanging(value);
					this.SendPropertyChanging();
					this._RoomId = value;
					this.SendPropertyChanged("RoomId");
					this.OnRoomIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movy_Reservation", Storage="_Reservations", ThisKey="Id", OtherKey="MovieId")]
		public EntitySet<Reservation> Reservations
		{
			get
			{
				return this._Reservations;
			}
			set
			{
				this._Reservations.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_Movy", Storage="_Room", ThisKey="RoomId", OtherKey="Id", IsForeignKey=true)]
		public Room Room
		{
			get
			{
				return this._Room.Entity;
			}
			set
			{
				Room previousValue = this._Room.Entity;
				if (((previousValue != value) 
							|| (this._Room.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Room.Entity = null;
						previousValue.Movies.Remove(this);
					}
					this._Room.Entity = value;
					if ((value != null))
					{
						value.Movies.Add(this);
						this._RoomId = value.Id;
					}
					else
					{
						this._RoomId = default(int);
					}
					this.SendPropertyChanged("Room");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Movie = this;
		}
		
		private void detach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Movie = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reservations")]
	public partial class Reservation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private bool _Taken;
		
		private System.DateTime _DateReserved;
		
		private int _MovieId;
		
		private int _SeatCount;
		
		private EntitySet<Ticket> _Tickets;
		
		private EntitySet<Seat> _Seats;
		
		private EntityRef<Movie> _Movie;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTakenChanging(bool value);
    partial void OnTakenChanged();
    partial void OnDateReservedChanging(System.DateTime value);
    partial void OnDateReservedChanged();
    partial void OnMovieIdChanging(int value);
    partial void OnMovieIdChanged();
    partial void OnSeatCountChanging(int value);
    partial void OnSeatCountChanged();
    #endregion
		
		public Reservation()
		{
			this._Tickets = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Tickets), new Action<Ticket>(this.detach_Tickets));
			this._Seats = new EntitySet<Seat>(new Action<Seat>(this.attach_Seats), new Action<Seat>(this.detach_Seats));
			this._Movie = default(EntityRef<Movie>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Taken", DbType="Bit NOT NULL")]
		public bool Taken
		{
			get
			{
				return this._Taken;
			}
			set
			{
				if ((this._Taken != value))
				{
					this.OnTakenChanging(value);
					this.SendPropertyChanging();
					this._Taken = value;
					this.SendPropertyChanged("Taken");
					this.OnTakenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateReserved", DbType="DateTime NOT NULL")]
		public System.DateTime DateReserved
		{
			get
			{
				return this._DateReserved;
			}
			set
			{
				if ((this._DateReserved != value))
				{
					this.OnDateReservedChanging(value);
					this.SendPropertyChanging();
					this._DateReserved = value;
					this.SendPropertyChanged("DateReserved");
					this.OnDateReservedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieId", DbType="Int NOT NULL")]
		public int MovieId
		{
			get
			{
				return this._MovieId;
			}
			set
			{
				if ((this._MovieId != value))
				{
					if (this._Movie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMovieIdChanging(value);
					this.SendPropertyChanging();
					this._MovieId = value;
					this.SendPropertyChanged("MovieId");
					this.OnMovieIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SeatCount", DbType="Int NOT NULL")]
		public int SeatCount
		{
			get
			{
				return this._SeatCount;
			}
			set
			{
				if ((this._SeatCount != value))
				{
					this.OnSeatCountChanging(value);
					this.SendPropertyChanging();
					this._SeatCount = value;
					this.SendPropertyChanged("SeatCount");
					this.OnSeatCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Reservation_Ticket", Storage="_Tickets", ThisKey="Id", OtherKey="ReservationId")]
		public EntitySet<Ticket> Tickets
		{
			get
			{
				return this._Tickets;
			}
			set
			{
				this._Tickets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Reservation_Seat", Storage="_Seats", ThisKey="Id", OtherKey="ReservationId")]
		public EntitySet<Seat> Seats
		{
			get
			{
				return this._Seats;
			}
			set
			{
				this._Seats.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movy_Reservation", Storage="_Movie", ThisKey="MovieId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Movie Movie
		{
			get
			{
				return this._Movie.Entity;
			}
			set
			{
				Movie previousValue = this._Movie.Entity;
				if (((previousValue != value) 
							|| (this._Movie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movie.Entity = null;
						previousValue.Reservations.Remove(this);
					}
					this._Movie.Entity = value;
					if ((value != null))
					{
						value.Reservations.Add(this);
						this._MovieId = value.Id;
					}
					else
					{
						this._MovieId = default(int);
					}
					this.SendPropertyChanged("Movie");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Reservation = this;
		}
		
		private void detach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Reservation = null;
		}
		
		private void attach_Seats(Seat entity)
		{
			this.SendPropertyChanging();
			entity.Reservation = this;
		}
		
		private void detach_Seats(Seat entity)
		{
			this.SendPropertyChanging();
			entity.Reservation = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rooms")]
	public partial class Room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Cols;
		
		private int _Rows;
		
		private EntitySet<Movie> _Movies;
		
		private EntitySet<Seat> _Seats;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnColsChanging(int value);
    partial void OnColsChanged();
    partial void OnRowsChanging(int value);
    partial void OnRowsChanged();
    #endregion
		
		public Room()
		{
			this._Movies = new EntitySet<Movie>(new Action<Movie>(this.attach_Movies), new Action<Movie>(this.detach_Movies));
			this._Seats = new EntitySet<Seat>(new Action<Seat>(this.attach_Seats), new Action<Seat>(this.detach_Seats));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cols", DbType="Int NOT NULL")]
		public int Cols
		{
			get
			{
				return this._Cols;
			}
			set
			{
				if ((this._Cols != value))
				{
					this.OnColsChanging(value);
					this.SendPropertyChanging();
					this._Cols = value;
					this.SendPropertyChanged("Cols");
					this.OnColsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rows", DbType="Int NOT NULL")]
		public int Rows
		{
			get
			{
				return this._Rows;
			}
			set
			{
				if ((this._Rows != value))
				{
					this.OnRowsChanging(value);
					this.SendPropertyChanging();
					this._Rows = value;
					this.SendPropertyChanged("Rows");
					this.OnRowsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_Movy", Storage="_Movies", ThisKey="Id", OtherKey="RoomId")]
		public EntitySet<Movie> Movies
		{
			get
			{
				return this._Movies;
			}
			set
			{
				this._Movies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_Seat", Storage="_Seats", ThisKey="Id", OtherKey="RoomId")]
		public EntitySet<Seat> Seats
		{
			get
			{
				return this._Seats;
			}
			set
			{
				this._Seats.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Movies(Movie entity)
		{
			this.SendPropertyChanging();
			entity.Room = this;
		}
		
		private void detach_Movies(Movie entity)
		{
			this.SendPropertyChanging();
			entity.Room = null;
		}
		
		private void attach_Seats(Seat entity)
		{
			this.SendPropertyChanging();
			entity.Room = this;
		}
		
		private void detach_Seats(Seat entity)
		{
			this.SendPropertyChanging();
			entity.Room = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Seats")]
	public partial class Seat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Col;
		
		private int _Row;
		
		private bool _Usable;
		
		private int _RoomId;
		
		private System.Nullable<int> _ReservationId;
		
		private EntityRef<Reservation> _Reservation;
		
		private EntityRef<Room> _Room;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnColChanging(int value);
    partial void OnColChanged();
    partial void OnRowChanging(int value);
    partial void OnRowChanged();
    partial void OnUsableChanging(bool value);
    partial void OnUsableChanged();
    partial void OnRoomIdChanging(int value);
    partial void OnRoomIdChanged();
    partial void OnReservationIdChanging(System.Nullable<int> value);
    partial void OnReservationIdChanged();
    #endregion
		
		public Seat()
		{
			this._Reservation = default(EntityRef<Reservation>);
			this._Room = default(EntityRef<Room>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Col", DbType="Int NOT NULL")]
		public int Col
		{
			get
			{
				return this._Col;
			}
			set
			{
				if ((this._Col != value))
				{
					this.OnColChanging(value);
					this.SendPropertyChanging();
					this._Col = value;
					this.SendPropertyChanged("Col");
					this.OnColChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Row", DbType="Int NOT NULL")]
		public int Row
		{
			get
			{
				return this._Row;
			}
			set
			{
				if ((this._Row != value))
				{
					this.OnRowChanging(value);
					this.SendPropertyChanging();
					this._Row = value;
					this.SendPropertyChanged("Row");
					this.OnRowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usable", DbType="Bit NOT NULL")]
		public bool Usable
		{
			get
			{
				return this._Usable;
			}
			set
			{
				if ((this._Usable != value))
				{
					this.OnUsableChanging(value);
					this.SendPropertyChanging();
					this._Usable = value;
					this.SendPropertyChanged("Usable");
					this.OnUsableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomId", DbType="Int NOT NULL")]
		public int RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				if ((this._RoomId != value))
				{
					if (this._Room.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoomIdChanging(value);
					this.SendPropertyChanging();
					this._RoomId = value;
					this.SendPropertyChanged("RoomId");
					this.OnRoomIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReservationId", DbType="Int")]
		public System.Nullable<int> ReservationId
		{
			get
			{
				return this._ReservationId;
			}
			set
			{
				if ((this._ReservationId != value))
				{
					if (this._Reservation.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnReservationIdChanging(value);
					this.SendPropertyChanging();
					this._ReservationId = value;
					this.SendPropertyChanged("ReservationId");
					this.OnReservationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Reservation_Seat", Storage="_Reservation", ThisKey="ReservationId", OtherKey="Id", IsForeignKey=true)]
		public Reservation Reservation
		{
			get
			{
				return this._Reservation.Entity;
			}
			set
			{
				Reservation previousValue = this._Reservation.Entity;
				if (((previousValue != value) 
							|| (this._Reservation.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Reservation.Entity = null;
						previousValue.Seats.Remove(this);
					}
					this._Reservation.Entity = value;
					if ((value != null))
					{
						value.Seats.Add(this);
						this._ReservationId = value.Id;
					}
					else
					{
						this._ReservationId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Reservation");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_Seat", Storage="_Room", ThisKey="RoomId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Room Room
		{
			get
			{
				return this._Room.Entity;
			}
			set
			{
				Room previousValue = this._Room.Entity;
				if (((previousValue != value) 
							|| (this._Room.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Room.Entity = null;
						previousValue.Seats.Remove(this);
					}
					this._Room.Entity = value;
					if ((value != null))
					{
						value.Seats.Add(this);
						this._RoomId = value.Id;
					}
					else
					{
						this._RoomId = default(int);
					}
					this.SendPropertyChanged("Room");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
