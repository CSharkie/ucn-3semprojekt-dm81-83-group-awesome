﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
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
    partial void InsertRoomMovie(RoomMovie instance);
    partial void UpdateRoomMovie(RoomMovie instance);
    partial void DeleteRoomMovie(RoomMovie instance);
    partial void InsertRoom(Room instance);
    partial void UpdateRoom(Room instance);
    partial void DeleteRoom(Room instance);
    partial void InsertRoomSeat(RoomSeat instance);
    partial void UpdateRoomSeat(RoomSeat instance);
    partial void DeleteRoomSeat(RoomSeat instance);
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
		
		public System.Data.Linq.Table<ReservationSeat> ReservationSeats
		{
			get
			{
				return this.GetTable<ReservationSeat>();
			}
		}
		
		public System.Data.Linq.Table<RoomMovie> RoomMovies
		{
			get
			{
				return this.GetTable<RoomMovie>();
			}
		}
		
		public System.Data.Linq.Table<Room> Rooms
		{
			get
			{
				return this.GetTable<Room>();
			}
		}
		
		public System.Data.Linq.Table<RoomSeat> RoomSeats
		{
			get
			{
				return this.GetTable<RoomSeat>();
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
		
		private System.Nullable<int> _DPercent;
		
		private EntitySet<Ticket> _Tickets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDPercentChanging(System.Nullable<int> value);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DPercent", DbType="Int")]
		public System.Nullable<int> DPercent
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
		
		private decimal _Price;
		
		private int _ReservationId;
		
		private int _DiscountId;
		
		private System.Nullable<decimal> _PaidAmount;
		
		private EntityRef<Discount> _Discount;
		
		private EntityRef<Reservation> _Reservation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnReservationIdChanging(int value);
    partial void OnReservationIdChanged();
    partial void OnDiscountIdChanging(int value);
    partial void OnDiscountIdChanged();
    partial void OnPaidAmountChanging(System.Nullable<decimal> value);
    partial void OnPaidAmountChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,2) NOT NULL")]
		public decimal Price
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiscountId", DbType="Int NOT NULL")]
		public int DiscountId
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
						this._DiscountId = default(int);
					}
					this.SendPropertyChanged("Discount");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Reservation_Ticket", Storage="_Reservation", ThisKey="ReservationId", OtherKey="Id", IsForeignKey=true)]
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
		
		private EntitySet<RoomMovie> _RoomMovies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    #endregion
		
		public Movie()
		{
			this._RoomMovies = new EntitySet<RoomMovie>(new Action<RoomMovie>(this.attach_RoomMovies), new Action<RoomMovie>(this.detach_RoomMovies));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movy_RoomMovy", Storage="_RoomMovies", ThisKey="Id", OtherKey="MovieId")]
		public EntitySet<RoomMovie> RoomMovies
		{
			get
			{
				return this._RoomMovies;
			}
			set
			{
				this._RoomMovies.Assign(value);
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
		
		private void attach_RoomMovies(RoomMovie entity)
		{
			this.SendPropertyChanging();
			entity.Movie = this;
		}
		
		private void detach_RoomMovies(RoomMovie entity)
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
		
		private int _RMId;
		
		private string _Name;
		
		private byte _Taken;
		
		private EntitySet<Ticket> _Tickets;
		
		private EntityRef<RoomMovie> _RoomMovie;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRMIdChanging(int value);
    partial void OnRMIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTakenChanging(byte value);
    partial void OnTakenChanged();
    #endregion
		
		public Reservation()
		{
			this._Tickets = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Tickets), new Action<Ticket>(this.detach_Tickets));
			this._RoomMovie = default(EntityRef<RoomMovie>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RMId", DbType="Int NOT NULL")]
		public int RMId
		{
			get
			{
				return this._RMId;
			}
			set
			{
				if ((this._RMId != value))
				{
					if (this._RoomMovie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRMIdChanging(value);
					this.SendPropertyChanging();
					this._RMId = value;
					this.SendPropertyChanged("RMId");
					this.OnRMIdChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Taken", DbType="TinyInt NOT NULL")]
		public byte Taken
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RoomMovy_Reservation", Storage="_RoomMovie", ThisKey="RMId", OtherKey="Id", IsForeignKey=true)]
		public RoomMovie RoomMovie
		{
			get
			{
				return this._RoomMovie.Entity;
			}
			set
			{
				RoomMovie previousValue = this._RoomMovie.Entity;
				if (((previousValue != value) 
							|| (this._RoomMovie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RoomMovie.Entity = null;
						previousValue.Reservations.Remove(this);
					}
					this._RoomMovie.Entity = value;
					if ((value != null))
					{
						value.Reservations.Add(this);
						this._RMId = value.Id;
					}
					else
					{
						this._RMId = default(int);
					}
					this.SendPropertyChanged("RoomMovie");
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ReservationSeats")]
	public partial class ReservationSeat
	{
		
		private int _ReservationId;
		
		private int _SeatId;
		
		public ReservationSeat()
		{
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
					this._ReservationId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SeatId", DbType="Int NOT NULL")]
		public int SeatId
		{
			get
			{
				return this._SeatId;
			}
			set
			{
				if ((this._SeatId != value))
				{
					this._SeatId = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RoomMovies")]
	public partial class RoomMovie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _RoomId;
		
		private int _MovieId;
		
		private System.DateTime _DateAndTime;
		
		private EntitySet<Reservation> _Reservations;
		
		private EntityRef<Movie> _Movie;
		
		private EntityRef<Room> _Room;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRoomIdChanging(int value);
    partial void OnRoomIdChanged();
    partial void OnMovieIdChanging(int value);
    partial void OnMovieIdChanged();
    partial void OnDateAndTimeChanging(System.DateTime value);
    partial void OnDateAndTimeChanged();
    #endregion
		
		public RoomMovie()
		{
			this._Reservations = new EntitySet<Reservation>(new Action<Reservation>(this.attach_Reservations), new Action<Reservation>(this.detach_Reservations));
			this._Movie = default(EntityRef<Movie>);
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RoomMovy_Reservation", Storage="_Reservations", ThisKey="Id", OtherKey="RMId")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movy_RoomMovy", Storage="_Movie", ThisKey="MovieId", OtherKey="Id", IsForeignKey=true)]
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
						previousValue.RoomMovies.Remove(this);
					}
					this._Movie.Entity = value;
					if ((value != null))
					{
						value.RoomMovies.Add(this);
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_RoomMovy", Storage="_Room", ThisKey="RoomId", OtherKey="Id", IsForeignKey=true)]
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
						previousValue.RoomMovies.Remove(this);
					}
					this._Room.Entity = value;
					if ((value != null))
					{
						value.RoomMovies.Add(this);
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
			entity.RoomMovie = this;
		}
		
		private void detach_Reservations(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.RoomMovie = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rooms")]
	public partial class Room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _Cols;
		
		private int _Rows;
		
		private EntitySet<RoomMovie> _RoomMovies;
		
		private EntitySet<RoomSeat> _RoomSeats;
		
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
			this._RoomMovies = new EntitySet<RoomMovie>(new Action<RoomMovie>(this.attach_RoomMovies), new Action<RoomMovie>(this.detach_RoomMovies));
			this._RoomSeats = new EntitySet<RoomSeat>(new Action<RoomSeat>(this.attach_RoomSeats), new Action<RoomSeat>(this.detach_RoomSeats));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_RoomMovy", Storage="_RoomMovies", ThisKey="Id", OtherKey="RoomId")]
		public EntitySet<RoomMovie> RoomMovies
		{
			get
			{
				return this._RoomMovies;
			}
			set
			{
				this._RoomMovies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_RoomSeat", Storage="_RoomSeats", ThisKey="Id", OtherKey="RoomId")]
		public EntitySet<RoomSeat> RoomSeats
		{
			get
			{
				return this._RoomSeats;
			}
			set
			{
				this._RoomSeats.Assign(value);
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
		
		private void attach_RoomMovies(RoomMovie entity)
		{
			this.SendPropertyChanging();
			entity.Room = this;
		}
		
		private void detach_RoomMovies(RoomMovie entity)
		{
			this.SendPropertyChanging();
			entity.Room = null;
		}
		
		private void attach_RoomSeats(RoomSeat entity)
		{
			this.SendPropertyChanging();
			entity.Room = this;
		}
		
		private void detach_RoomSeats(RoomSeat entity)
		{
			this.SendPropertyChanging();
			entity.Room = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RoomSeats")]
	public partial class RoomSeat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _RoomId;
		
		private int _SeatId;
		
		private int _ColNo;
		
		private int _RowNo;
		
		private EntityRef<Room> _Room;
		
		private EntityRef<Seat> _Seat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRoomIdChanging(int value);
    partial void OnRoomIdChanged();
    partial void OnSeatIdChanging(int value);
    partial void OnSeatIdChanged();
    partial void OnColNoChanging(int value);
    partial void OnColNoChanged();
    partial void OnRowNoChanging(int value);
    partial void OnRowNoChanged();
    #endregion
		
		public RoomSeat()
		{
			this._Room = default(EntityRef<Room>);
			this._Seat = default(EntityRef<Seat>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SeatId", DbType="Int NOT NULL")]
		public int SeatId
		{
			get
			{
				return this._SeatId;
			}
			set
			{
				if ((this._SeatId != value))
				{
					if (this._Seat.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSeatIdChanging(value);
					this.SendPropertyChanging();
					this._SeatId = value;
					this.SendPropertyChanged("SeatId");
					this.OnSeatIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ColNo", DbType="Int NOT NULL")]
		public int ColNo
		{
			get
			{
				return this._ColNo;
			}
			set
			{
				if ((this._ColNo != value))
				{
					this.OnColNoChanging(value);
					this.SendPropertyChanging();
					this._ColNo = value;
					this.SendPropertyChanged("ColNo");
					this.OnColNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RowNo", DbType="Int NOT NULL")]
		public int RowNo
		{
			get
			{
				return this._RowNo;
			}
			set
			{
				if ((this._RowNo != value))
				{
					this.OnRowNoChanging(value);
					this.SendPropertyChanging();
					this._RowNo = value;
					this.SendPropertyChanged("RowNo");
					this.OnRowNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Room_RoomSeat", Storage="_Room", ThisKey="RoomId", OtherKey="Id", IsForeignKey=true)]
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
						previousValue.RoomSeats.Remove(this);
					}
					this._Room.Entity = value;
					if ((value != null))
					{
						value.RoomSeats.Add(this);
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Seat_RoomSeat", Storage="_Seat", ThisKey="SeatId", OtherKey="Id", IsForeignKey=true)]
		public Seat Seat
		{
			get
			{
				return this._Seat.Entity;
			}
			set
			{
				Seat previousValue = this._Seat.Entity;
				if (((previousValue != value) 
							|| (this._Seat.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Seat.Entity = null;
						previousValue.RoomSeats.Remove(this);
					}
					this._Seat.Entity = value;
					if ((value != null))
					{
						value.RoomSeats.Add(this);
						this._SeatId = value.Id;
					}
					else
					{
						this._SeatId = default(int);
					}
					this.SendPropertyChanged("Seat");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Seats")]
	public partial class Seat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _No;
		
		private byte _Usable;
		
		private EntitySet<RoomSeat> _RoomSeats;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNoChanging(int value);
    partial void OnNoChanged();
    partial void OnUsableChanging(byte value);
    partial void OnUsableChanged();
    #endregion
		
		public Seat()
		{
			this._RoomSeats = new EntitySet<RoomSeat>(new Action<RoomSeat>(this.attach_RoomSeats), new Action<RoomSeat>(this.detach_RoomSeats));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_No", DbType="Int NOT NULL")]
		public int No
		{
			get
			{
				return this._No;
			}
			set
			{
				if ((this._No != value))
				{
					this.OnNoChanging(value);
					this.SendPropertyChanging();
					this._No = value;
					this.SendPropertyChanged("No");
					this.OnNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usable", DbType="TinyInt NOT NULL")]
		public byte Usable
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Seat_RoomSeat", Storage="_RoomSeats", ThisKey="Id", OtherKey="SeatId")]
		public EntitySet<RoomSeat> RoomSeats
		{
			get
			{
				return this._RoomSeats;
			}
			set
			{
				this._RoomSeats.Assign(value);
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
		
		private void attach_RoomSeats(RoomSeat entity)
		{
			this.SendPropertyChanging();
			entity.Seat = this;
		}
		
		private void detach_RoomSeats(RoomSeat entity)
		{
			this.SendPropertyChanging();
			entity.Seat = null;
		}
	}
}
#pragma warning restore 1591