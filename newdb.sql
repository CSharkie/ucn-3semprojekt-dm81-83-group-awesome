use groupAwesomeDb_tmp
GO
CREATE FUNCTION [dbo].CalculatePrice(@ReservationId INT, @StandardPrice DECIMAL, @DiscountId INT)
RETURNS DECIMAL 
AS BEGIN
    DECLARE @Price DECIMAL
	DECLARE @SeatCount INT
	DECLARE @Discount DECIMAL
	SELECT @Discount = DPercent FROM Discounts WHERE Id=@DiscountId
	SELECT @SeatCount = SeatCount FROM Reservations WHERE Id = @ReservationId
	SELECT @Price = (@StandardPrice * @SeatCount)
	if(@DiscountId!=null)
	BEGIN
    SELECT @Price = (@StandardPrice * @SeatCount) - (@StandardPrice * @SeatCount)*(@Discount/100)
	END
    RETURN @Price
END
GO
CREATE TABLE [dbo].[Discounts]
(
	[Id] int NOT NULL IDENTITY(1,1),
	[DPercent] decimal(18,2) NOT NULL DEFAULT(0),
	PRIMARY KEY (Id)
)

CREATE TABLE [dbo].[Rooms]
(
	[Id] int NOT NULL IDENTITY(1,1),
	[Cols] int NOT NULL,
	[Rows] int NOT NULL,
	PRIMARY KEY(Id)
)
CREATE TABLE [dbo].[Movies]
(
	[Id] int NOT NULL IDENTITY(1,1),
	[Title] varchar(100) NOT NULL,
	[DateAndTime] datetime NOT NULL,
	[Duration] time NOT NULL,
	[RoomId] int NOT NULL,
	FOREIGN KEY (RoomId) REFERENCES Rooms(Id) ON UPDATE CASCADE,
	PRIMARY KEY(Id)
)
CREATE TABLE [dbo].[Reservations]
(
	[Id] int NOT NULL IDENTITY(1,1),
	[Name] varchar(50) NULL,
	[Taken] bit NOT NULL DEFAULT(0),
	[DateReserved] datetime NOT NULL DEFAULT(GETDATE()),
	[MovieId] int NOT NULL,
	[SeatCount] int NOT NULL,
	FOREIGN KEY (MovieId) REFERENCES Movies(Id) ON DELETE CASCADE,
	PRIMARY KEY (Id)
)
CREATE TABLE [dbo].[Seats]
(
	[Id] int NOT NULL IDENTITY(1,1),
	[Col] int NOT NULL,
	[Row] int NOT NULL,
	[Usable] bit NOT NULL DEFAULT(0),
	[DateAndTime] datetime NULL,
	[RoomId] int NOT NULL,
	FOREIGN KEY (RoomId) REFERENCES Rooms(Id) ON DELETE CASCADE,
	PRIMARY KEY (Id)
)
CREATE TABLE [dbo].[ReservedSeats]
(
	[ReservationId] int NOT NULL,
	[SeatId] int NOT NULL,
	[MovieId] int NOT NULL,
	FOREIGN KEY (ReservationId) REFERENCES Reservations(Id) ON DELETE CASCADE,
	FOREIGN KEY (SeatId) REFERENCES Seats(Id) ON DELETE CASCADE,
	FOREIGN KEY (MovieId) REFERENCES Movies(Id) ON DELETE CASCADE
)
CREATE TABLE [dbo].[Tickets]
(
	[Id] int NOT NULL IDENTITY(1,1),
	[Standard] decimal(18,2) NOT NULL,
	[Price] AS dbo.CalculatePrice([ReservationId], [Standard], [DiscountId]),
	[PaidAmount] decimal(18,2) NULL,
	[ReservationId] int NOT NULL,
	[DiscountId] int NULL,
	[Col] int NOT NULL,
	[Row] int NOT NULL,
	FOREIGN KEY(ReservationId) References Reservations(Id) ON DELETE CASCADE,
	FOREIGN KEY(DiscountId) References Discounts(Id) ON UPDATE CASCADE,
	PRIMARY KEY(Id)
)

