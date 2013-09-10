using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupAwesome.Models
{
    class Seat
    {
        private bool _reserved;
        private bool _usable;
        private int _number;

        public Seat()
        {
            _reserved = false;
            _usable = true; //initially all seats are usable, when there are stairs in the room, this seats are turned false;
            _number = -1;
        }
        /// <summary>
        /// Returns true if the seat is already reserved; false otherwise
        /// </summary>
        public bool Reserved
        {
            set { this._reserved = value; }
            get { return this._reserved; }
        }
        /// <summary>
        /// Returns true if the seat is usable; false otherwise
        /// </summary>
        public bool Usable
        {
            set { this._usable = value; }
            get { return this._usable; }
        }
        /// <summary>
        /// Represents the number assigned to that seat;
        /// The value -1 is assigned to a chair that is not set up.
        /// </summary>
        public int Number
        {
            set { this._number = value; }
            get { return this._number; }
        }
        /// <summary>
        /// Disposes the instance of this object, frees the space in memory asigned to to this object.
        /// </summary>
        public void dispose()
        {
            this.dispose();
        }
    }
}
