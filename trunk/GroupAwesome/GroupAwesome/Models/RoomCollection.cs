using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupAwesome.Models
{
    class RoomCollection 
    {
        private int _count;
        private List<Room> _collection;

        /// <summary>
        /// Returns the count of the Room collection
        /// </summary>
        public int Count
        {
            get { return _count; }
        }
        /// <summary>
        /// The next ID available for the Room
        /// </summary>
        /// <returns>The next ID available</returns>
        public int getNextId()
        {
            return _count + 1;
        }
        /// <summary>
        /// Returns the movie collection
        /// </summary>
        public List<Room> Collection
        {
            get { return _collection; }
        }
        /// <summary>
        /// Inserts a Room into the collection
        /// </summary>
        /// <param name="movie">The Room object to be added</param>
        public void addRoom(Room room)
        {
            this._collection.Add(room);
            _count += 1;
        }
        /// <summary>
        /// Returns a specific Room from the collection by the Room ID
        /// </summary>
        /// <param name="id">The ID of the Room you want returned</param>
        /// <returns>Returns an object of type Room</returns>
        public Room getRoom(int id)
        {
            Room result = new Room();
            foreach (Room room in _collection)
            {
                if (room.ID == id)
                {
                    result = room;
                    break;
                }
            }
            return result;
        }
    }
}
