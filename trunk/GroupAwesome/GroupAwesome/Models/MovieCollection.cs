using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupAwesome.Models
{
    class MovieCollection
    {
        private int _count;
        private List<Movie> _collection;

        /// <summary>
        /// Returns the count of the movie collection
        /// </summary>
        public int Count
        {
            get { return _count; }
        }
        /// <summary>
        /// The next ID available for the movie
        /// </summary>
        /// <returns>The next ID available</returns>
        public int getNextId()
        {
            return _count + 1;
        }
        /// <summary>
        /// Returns the movie collection
        /// </summary>
        public List<Movie> Collection
        {
            get { return _collection; }
        }
        /// <summary>
        /// Inserts a movie into the collection
        /// </summary>
        /// <param name="movie">The movie object to be added</param>
        public void addMovie(Movie movie)
        {
            this._collection.Add(movie);
            _count += 1;
        }
        /// <summary>
        /// Returns a specific movie from the collection by the movie id
        /// </summary>
        /// <param name="id">The ID of the movie you want returned</param>
        /// <returns>Returns an object of type Movie</returns>
        public Movie getMovie(int id)
        {
            Movie result = new Movie();
            foreach (Movie movie in _collection)
            {
                if (movie.ID == id)
                {
                    result = movie;
                    break;
                }
            }
            return result;
        }

        
    }
}
