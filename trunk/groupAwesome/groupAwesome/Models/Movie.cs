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
        /// <summary>
        /// Creates an instance of class Movie
        /// </summary>
        /// <param name="title">The title of the movie</param>
        /// <param name="dateAndTime">The date and time when it rolls</param>
        /// <param name="roomId">The room id where the movie will be rolled</param>
        public Movie(String title, DateTime dateAndTime, int roomId)
        {
            //this._id = MovieCollection.getNextId()
            this._title = title;
            this._dateAndTime = dateAndTime;
            this._roomId = roomId;

        }
        public int RoomID
        {
            get { return _roomId; }
            set { _roomId = value; }
        }
        
        public DateTime DateAndTime
        {
            get { return _dateAndTime; }
            set { _dateAndTime = value; }
        }
        
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
