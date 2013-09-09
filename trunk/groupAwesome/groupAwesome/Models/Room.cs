using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace groupAwesome.Models
{
    class Room
    {
        private int _id;
        private int _rows;
        private int _cols;
        private List<List<Seat>> _seats;
        /// <summary>
        /// Creates an object of type Room
        /// </summary>
        /// <param name="rows">Represents the number of rows in the Rooms matrix </param>
        /// <param name="cols">Represents the number of colums in the Rooms matrix (+2 if the stairs are outside the chairs)</param>
        /// <param name="stairCol">Represents the column number where the stairs are positioned (The stair will be positioned on 2 columns, stairCol will be the one on the left)</param>
        public Room(int rows, int cols, int stairCol)
        {
            //this._id = RoomCollection.getNextId();
            resetRoomStructure(rows, cols, stairCol);
        }
        /// <summary>
        /// Resets the structure of the room, all the seats are usable again.
        /// </summary>
        /// <param name="rows">The new number of rows assigned to this room</param>
        /// <param name="cols">The new number of columns assigned to this room</param>
        /// <param name="stairRow">The row number where the stairs are. e.g. If stairCol is 1 than the colums 1 and 2 will be unusable, exception the last row in the back.</param>
        public void resetRoomStructure(int rows, int cols, int stairCol)
        {
            // dynamicaly disposing of all seats in the room
            foreach (List<Seat> seatRow in _seats)
            {
                foreach (Seat seat in seatRow)
                {
                    seat.dispose();
                }
            }
            //setting the new specified values
            this._rows = rows;
            this._cols = cols;
            this._seats = new List<List<Seat>>();

            //creating all seats in the room
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    _seats[i][j] = new Seat();
                }
            }
            //setting the stairs in the room
            for (int i = 0; i < this._rows-1; i++)
            {
                _seats[i][stairCol].Usable = false;
                _seats[i][stairCol + 1].Usable = false;
            }
        }
        /// <summary>
        /// Represents the number of rows in the Room
        /// </summary>
        public int Rows
        {
            set { this._rows = value; }
            get { return this._rows; }
        }
        /// <summary>
        /// Represents the number of columns in the Room
        /// </summary>
        public int Cols
        {
            set { this._cols = value; }
            get { return this._cols; }
        }
        /// <summary>
        /// Represents the unique ID assigned to the room
        /// </summary>
        public int ID
        {
            get { return _id; }
        }
    }
}
