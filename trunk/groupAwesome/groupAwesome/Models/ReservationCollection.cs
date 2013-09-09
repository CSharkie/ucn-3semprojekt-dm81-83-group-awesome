using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupAwesome.Models
{
    class ReservationCollection
    {
        private static int _count;
        private List<Reservation> _collection;

        /// <summary>
        /// Returns the count of the reservation collection
        /// </summary>
        public int Count
        {
            get { return _count; }
        }
        /// <summary>
        /// The next ID available for the Reservation
        /// </summary>
        /// <returns>The next ID available</returns>
        public static int getNextId()
        {
            return _count + 1;
        }
        /// <summary>
        /// Returns the Reservation collection
        /// </summary>
        public List<Reservation> Collection
        {
            get { return _collection; }
        }
        /// <summary>
        /// Inserts a Reservation into the collection
        /// </summary>
        /// <param name="movie">The Reservation object to be added</param>
        public void addReservation(Reservation reservation)
        {
            this._collection.Add(reservation);
            _count += 1;
        }
        /// <summary>
        /// Returns a specific Reservation from the collection by the Reservation ID
        /// </summary>
        /// <param name="id">The ID of the Reservation you want returned</param>
        /// <returns>Returns an object of type Reservation</returns>
        public Reservation getReservation(int id)
        {
            Reservation result = new Reservation();
            foreach (Reservation reservation in _collection)
            {
                if (reservation.ID == id)
                {
                    result = reservation;
                    break;
                }
            }
            return result;
        }
    }
}
