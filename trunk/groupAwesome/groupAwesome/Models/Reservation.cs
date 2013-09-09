using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupAwesome.Models
{
    class Reservation
    {
        private int _id;
        private int _movieId;
        private LinkedList<Seat> _seats;
        private bool _taken;
        private string _name;
        public Reservation(String name = "", int movieId = -1, LinkedList<Seat> seats = null)
        {
            this._id = ReservationCollection.getNextId();
            this._name = name;
            this._movieId = movieId;
            this._seats = seats;
            this._taken = false;
        }
        /// <summary>
        /// The unique ID of the Reservation
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// The name of the person who did the reservation
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// Specifies if the tickets have been taken from the cashier
        /// </summary>
        public bool Taken
        {
            get { return _taken; }
            set { _taken = value; }
        }
        /// <summary>
        /// The list of seats that have been reserved on this name and movie
        /// </summary>
        public LinkedList<Seat> Seats
        {
            get { return _seats; }
            set { _seats = value; }
        }
        /// <summary>
        /// The ID of the movie on which the reservation was made
        /// </summary>
        public int MovieID
        {
            get { return _movieId; }
            set { _movieId = value; }
        }
        
    }
}
