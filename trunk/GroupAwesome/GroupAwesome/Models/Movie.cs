using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupAwesome.Models
{
    class Movie
    {
        
        private int _id;
        private String _title;
        private DateTime _dateAndTime;
        private int _roomId;
        private MovieCollection _movieCollection;
        /// <summary>
        /// Creates an instance of class Movie
        /// </summary>
        /// <param name="title">The title of the movie</param>
        /// <param name="dateAndTime">The date and time when it rolls</param>
        /// <param name="roomId">The room id where the movie will be rolled</param>
        public Movie(String title, DateTime dateAndTime, int roomId)
        {
            this._id = _movieCollection.getNextId();
            this._title = title;
            this._dateAndTime = dateAndTime;
            this._roomId = roomId;
        }
        public Movie()
        {
            this._id = _movieCollection.getNextId();
            this._title = "";
            this._dateAndTime = new DateTime(0);
            this._roomId = -1;
        }
        /// <summary>
        /// Represents the unique ID assigned to the room that the movie plays in
        /// </summary>
        public int RoomID
        {
            get { return _roomId; }
            set { _roomId = value; }
        }
        /// <summary>
        /// The date and time when the movie rolls
        /// </summary>
        public DateTime DateAndTime
        {
            get { return _dateAndTime; }
            set { _dateAndTime = value; }
        }
        /// <summary>
        /// The title of the movie
        /// </summary>
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }
        /// <summary>
        /// The unique ID assigned to the movie
        /// </summary>
        public int ID
        {
            get { return _id; }
        }
    }
}
