﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AwesomeClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/createReservation", ReplyAction="http://tempuri.org/IService/createReservationResponse")]
        string createReservation(AwesomeServer.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/createReservation", ReplyAction="http://tempuri.org/IService/createReservationResponse")]
        System.Threading.Tasks.Task<string> createReservationAsync(AwesomeServer.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/createMovie", ReplyAction="http://tempuri.org/IService/createMovieResponse")]
        string createMovie(AwesomeServer.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/createMovie", ReplyAction="http://tempuri.org/IService/createMovieResponse")]
        System.Threading.Tasks.Task<string> createMovieAsync(AwesomeServer.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/createRoom", ReplyAction="http://tempuri.org/IService/createRoomResponse")]
        string createRoom(AwesomeServer.Room room);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/createRoom", ReplyAction="http://tempuri.org/IService/createRoomResponse")]
        System.Threading.Tasks.Task<string> createRoomAsync(AwesomeServer.Room room);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/createTicket", ReplyAction="http://tempuri.org/IService/createTicketResponse")]
        string createTicket(AwesomeServer.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/createTicket", ReplyAction="http://tempuri.org/IService/createTicketResponse")]
        System.Threading.Tasks.Task<string> createTicketAsync(AwesomeServer.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateReservation", ReplyAction="http://tempuri.org/IService/updateReservationResponse")]
        string updateReservation(AwesomeServer.Reservation reservation, AwesomeServer.Reservation newReservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateReservation", ReplyAction="http://tempuri.org/IService/updateReservationResponse")]
        System.Threading.Tasks.Task<string> updateReservationAsync(AwesomeServer.Reservation reservation, AwesomeServer.Reservation newReservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateMovie", ReplyAction="http://tempuri.org/IService/updateMovieResponse")]
        string updateMovie(AwesomeServer.Movie movie, AwesomeServer.Movie newMovie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateMovie", ReplyAction="http://tempuri.org/IService/updateMovieResponse")]
        System.Threading.Tasks.Task<string> updateMovieAsync(AwesomeServer.Movie movie, AwesomeServer.Movie newMovie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateRoom", ReplyAction="http://tempuri.org/IService/updateRoomResponse")]
        string updateRoom(AwesomeServer.Room room, AwesomeServer.Room newRoom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateRoom", ReplyAction="http://tempuri.org/IService/updateRoomResponse")]
        System.Threading.Tasks.Task<string> updateRoomAsync(AwesomeServer.Room room, AwesomeServer.Room newRoom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateTicket", ReplyAction="http://tempuri.org/IService/updateTicketResponse")]
        string updateTicket(AwesomeServer.Ticket ticket, AwesomeServer.Ticket newTicket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateTicket", ReplyAction="http://tempuri.org/IService/updateTicketResponse")]
        System.Threading.Tasks.Task<string> updateTicketAsync(AwesomeServer.Ticket ticket, AwesomeServer.Ticket newTicket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateSeat", ReplyAction="http://tempuri.org/IService/updateSeatResponse")]
        string updateSeat(AwesomeServer.Seat seat, AwesomeServer.Seat newSeat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/updateSeat", ReplyAction="http://tempuri.org/IService/updateSeatResponse")]
        System.Threading.Tasks.Task<string> updateSeatAsync(AwesomeServer.Seat seat, AwesomeServer.Seat newSeat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getReservation", ReplyAction="http://tempuri.org/IService/getReservationResponse")]
        AwesomeServer.Reservation getReservation(AwesomeServer.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getReservation", ReplyAction="http://tempuri.org/IService/getReservationResponse")]
        System.Threading.Tasks.Task<AwesomeServer.Reservation> getReservationAsync(AwesomeServer.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getMovie", ReplyAction="http://tempuri.org/IService/getMovieResponse")]
        AwesomeServer.Movie getMovie(AwesomeServer.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getMovie", ReplyAction="http://tempuri.org/IService/getMovieResponse")]
        System.Threading.Tasks.Task<AwesomeServer.Movie> getMovieAsync(AwesomeServer.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getRoom", ReplyAction="http://tempuri.org/IService/getRoomResponse")]
        AwesomeServer.Room getRoom(AwesomeServer.Room room);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getRoom", ReplyAction="http://tempuri.org/IService/getRoomResponse")]
        System.Threading.Tasks.Task<AwesomeServer.Room> getRoomAsync(AwesomeServer.Room room);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getTicket", ReplyAction="http://tempuri.org/IService/getTicketResponse")]
        AwesomeServer.Ticket getTicket(AwesomeServer.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getTicket", ReplyAction="http://tempuri.org/IService/getTicketResponse")]
        System.Threading.Tasks.Task<AwesomeServer.Ticket> getTicketAsync(AwesomeServer.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getSeat", ReplyAction="http://tempuri.org/IService/getSeatResponse")]
        AwesomeServer.Seat getSeat(AwesomeServer.Seat seat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getSeat", ReplyAction="http://tempuri.org/IService/getSeatResponse")]
        System.Threading.Tasks.Task<AwesomeServer.Seat> getSeatAsync(AwesomeServer.Seat seat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeReservation", ReplyAction="http://tempuri.org/IService/removeReservationResponse")]
        string removeReservation(AwesomeServer.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeReservation", ReplyAction="http://tempuri.org/IService/removeReservationResponse")]
        System.Threading.Tasks.Task<string> removeReservationAsync(AwesomeServer.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeMovie", ReplyAction="http://tempuri.org/IService/removeMovieResponse")]
        string removeMovie(AwesomeServer.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeMovie", ReplyAction="http://tempuri.org/IService/removeMovieResponse")]
        System.Threading.Tasks.Task<string> removeMovieAsync(AwesomeServer.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeRoom", ReplyAction="http://tempuri.org/IService/removeRoomResponse")]
        string removeRoom(AwesomeServer.Room room);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeRoom", ReplyAction="http://tempuri.org/IService/removeRoomResponse")]
        System.Threading.Tasks.Task<string> removeRoomAsync(AwesomeServer.Room room);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeTicket", ReplyAction="http://tempuri.org/IService/removeTicketResponse")]
        string removeTicket(AwesomeServer.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/removeTicket", ReplyAction="http://tempuri.org/IService/removeTicketResponse")]
        System.Threading.Tasks.Task<string> removeTicketAsync(AwesomeServer.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getAdjSeat", ReplyAction="http://tempuri.org/IService/getAdjSeatResponse")]
        AwesomeServer.Seat[] getAdjSeat(int noOfSeats);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getAdjSeat", ReplyAction="http://tempuri.org/IService/getAdjSeatResponse")]
        System.Threading.Tasks.Task<AwesomeServer.Seat[]> getAdjSeatAsync(int noOfSeats);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : AwesomeClient.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<AwesomeClient.ServiceReference.IService>, AwesomeClient.ServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string createReservation(AwesomeServer.Reservation reservation) {
            return base.Channel.createReservation(reservation);
        }
        
        public System.Threading.Tasks.Task<string> createReservationAsync(AwesomeServer.Reservation reservation) {
            return base.Channel.createReservationAsync(reservation);
        }
        
        public string createMovie(AwesomeServer.Movie movie) {
            return base.Channel.createMovie(movie);
        }
        
        public System.Threading.Tasks.Task<string> createMovieAsync(AwesomeServer.Movie movie) {
            return base.Channel.createMovieAsync(movie);
        }
        
        public string createRoom(AwesomeServer.Room room) {
            return base.Channel.createRoom(room);
        }
        
        public System.Threading.Tasks.Task<string> createRoomAsync(AwesomeServer.Room room) {
            return base.Channel.createRoomAsync(room);
        }
        
        public string createTicket(AwesomeServer.Ticket ticket) {
            return base.Channel.createTicket(ticket);
        }
        
        public System.Threading.Tasks.Task<string> createTicketAsync(AwesomeServer.Ticket ticket) {
            return base.Channel.createTicketAsync(ticket);
        }
        
        public string updateReservation(AwesomeServer.Reservation reservation, AwesomeServer.Reservation newReservation) {
            return base.Channel.updateReservation(reservation, newReservation);
        }
        
        public System.Threading.Tasks.Task<string> updateReservationAsync(AwesomeServer.Reservation reservation, AwesomeServer.Reservation newReservation) {
            return base.Channel.updateReservationAsync(reservation, newReservation);
        }
        
        public string updateMovie(AwesomeServer.Movie movie, AwesomeServer.Movie newMovie) {
            return base.Channel.updateMovie(movie, newMovie);
        }
        
        public System.Threading.Tasks.Task<string> updateMovieAsync(AwesomeServer.Movie movie, AwesomeServer.Movie newMovie) {
            return base.Channel.updateMovieAsync(movie, newMovie);
        }
        
        public string updateRoom(AwesomeServer.Room room, AwesomeServer.Room newRoom) {
            return base.Channel.updateRoom(room, newRoom);
        }
        
        public System.Threading.Tasks.Task<string> updateRoomAsync(AwesomeServer.Room room, AwesomeServer.Room newRoom) {
            return base.Channel.updateRoomAsync(room, newRoom);
        }
        
        public string updateTicket(AwesomeServer.Ticket ticket, AwesomeServer.Ticket newTicket) {
            return base.Channel.updateTicket(ticket, newTicket);
        }
        
        public System.Threading.Tasks.Task<string> updateTicketAsync(AwesomeServer.Ticket ticket, AwesomeServer.Ticket newTicket) {
            return base.Channel.updateTicketAsync(ticket, newTicket);
        }
        
        public string updateSeat(AwesomeServer.Seat seat, AwesomeServer.Seat newSeat) {
            return base.Channel.updateSeat(seat, newSeat);
        }
        
        public System.Threading.Tasks.Task<string> updateSeatAsync(AwesomeServer.Seat seat, AwesomeServer.Seat newSeat) {
            return base.Channel.updateSeatAsync(seat, newSeat);
        }
        
        public AwesomeServer.Reservation getReservation(AwesomeServer.Reservation reservation) {
            return base.Channel.getReservation(reservation);
        }
        
        public System.Threading.Tasks.Task<AwesomeServer.Reservation> getReservationAsync(AwesomeServer.Reservation reservation) {
            return base.Channel.getReservationAsync(reservation);
        }
        
        public AwesomeServer.Movie getMovie(AwesomeServer.Movie movie) {
            return base.Channel.getMovie(movie);
        }
        
        public System.Threading.Tasks.Task<AwesomeServer.Movie> getMovieAsync(AwesomeServer.Movie movie) {
            return base.Channel.getMovieAsync(movie);
        }
        
        public AwesomeServer.Room getRoom(AwesomeServer.Room room) {
            return base.Channel.getRoom(room);
        }
        
        public System.Threading.Tasks.Task<AwesomeServer.Room> getRoomAsync(AwesomeServer.Room room) {
            return base.Channel.getRoomAsync(room);
        }
        
        public AwesomeServer.Ticket getTicket(AwesomeServer.Ticket ticket) {
            return base.Channel.getTicket(ticket);
        }
        
        public System.Threading.Tasks.Task<AwesomeServer.Ticket> getTicketAsync(AwesomeServer.Ticket ticket) {
            return base.Channel.getTicketAsync(ticket);
        }
        
        public AwesomeServer.Seat getSeat(AwesomeServer.Seat seat) {
            return base.Channel.getSeat(seat);
        }
        
        public System.Threading.Tasks.Task<AwesomeServer.Seat> getSeatAsync(AwesomeServer.Seat seat) {
            return base.Channel.getSeatAsync(seat);
        }
        
        public string removeReservation(AwesomeServer.Reservation reservation) {
            return base.Channel.removeReservation(reservation);
        }
        
        public System.Threading.Tasks.Task<string> removeReservationAsync(AwesomeServer.Reservation reservation) {
            return base.Channel.removeReservationAsync(reservation);
        }
        
        public string removeMovie(AwesomeServer.Movie movie) {
            return base.Channel.removeMovie(movie);
        }
        
        public System.Threading.Tasks.Task<string> removeMovieAsync(AwesomeServer.Movie movie) {
            return base.Channel.removeMovieAsync(movie);
        }
        
        public string removeRoom(AwesomeServer.Room room) {
            return base.Channel.removeRoom(room);
        }
        
        public System.Threading.Tasks.Task<string> removeRoomAsync(AwesomeServer.Room room) {
            return base.Channel.removeRoomAsync(room);
        }
        
        public string removeTicket(AwesomeServer.Ticket ticket) {
            return base.Channel.removeTicket(ticket);
        }
        
        public System.Threading.Tasks.Task<string> removeTicketAsync(AwesomeServer.Ticket ticket) {
            return base.Channel.removeTicketAsync(ticket);
        }
        
        public AwesomeServer.Seat[] getAdjSeat(int noOfSeats) {
            return base.Channel.getAdjSeat(noOfSeats);
        }
        
        public System.Threading.Tasks.Task<AwesomeServer.Seat[]> getAdjSeatAsync(int noOfSeats) {
            return base.Channel.getAdjSeatAsync(noOfSeats);
        }
    }
}