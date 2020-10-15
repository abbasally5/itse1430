using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary
{
    public class MovieDatabase
    {
        // Array - T[]
        //public Movie[] Items { get; set; }

        public Movie Add ( Movie movie, out string error )
        {
            //TODO: Movie is valid
            // Movie name is unique
            error = "";

            // Find first empty spot in array
            // for ( EI; EC; EU ) S;
            //      EI ::= initializer expression of loop variant (runs once before loop executes)
            //      EC ::= conditional expression => boolean (executes before loop statement is run, aborts if condition is false)
            //      EU ::= update expression (runs at end of current iteration)
            // Length -> int (# of rows in the array)
            for (var index = 0; index < _movies.Length; ++index)
            {
                // Array element access ::= V[int]
                if (_movies[index] == null)
                {
                    var item = CloneMovie(movie);

                    // Set a unique ID
                    item.Id = _id++;

                    // Add movie to array
                    _movies[index] = movie;     // Movie is a ref type thus movie and _movies[index] reference the same instance

                    // Set ID on original object and return
                    movie.Id = item.Id;
                    return movie;
                };
            }

            error = "No more room";
            return null;
        }

        public void Delete ( int id )
        {
            //TODO: Validate id
            for (var index = 0; index < _movies.Length; ++index)
            {
                // Array element access ::= V[int]
                //if (_movies[index] != null && _movies[index].Id == id)
                if (_movies[index]?.Id == id)   // null conditional ?. if instance != null, access the member
                {
                    _movies[index] = null;
                    return;
                };
            }
        }

        public string Update ( int id, Movie movie )
        {
            //TODO: Validate id
            // Movie exists
            var existing = Get(id);
            if (existing == null)
                return "Movie not found";

            // updated movie is valid
            // updated movie name is unique

            for (var index = 0; index < _movies.Length; ++index)
            {
                if (_movies[index]?.Id == id)
                {
                    // Clone it so we separate our value from argument
                    var item = CloneMovie(movie);

                    item.Id = id;
                    _movies[index] = item;
                    return "";

                    // Just because we are doing this in memory
                    //movie.Id = id;
                    //_movies[index] = movie;
                    //return;
                };
            }

            return "";
        }

        public Movie[] GetAll ()
        {
            // DONT DO THIS
            //  1. Expose underlying movie items
            //  2. Callers add/remove movies
            //return _movies;

            //TODO: Determine how many movies we're storing
            // For each one create a cloned copy
            return _movies;
        }

        public Movie Get ( int id )
        {
            // foreach (var id in array) S;
            //for (var index = 0; index < _movies.Length; ++index)
            foreach (var movie in _movies)
            {
                //movie == _movies[index]
                // Restrictions:
                //  1. movie is readonly  //movie = new Movie(); // < NOT VALID
                //  2. _movies cannot change, immutable (not an issue with arrays)
                if (movie?.Id == id)
                    return CloneMovie(movie);
            };

            return null;
        }

        private Movie CloneMovie ( Movie movie )
        {
            var item = new Movie();
            item.Id = movie.Id;
            item.Name = movie.Name;
            item.Rating = movie.Rating;
            item.ReleaseYear = movie.ReleaseYear;
            item.IsClassic = movie.IsClassic;
            item.Description = movie.Description;

            return item;
        }

        // Only store cloned copies of movies here!!
        private Movie[] _movies = new Movie[100];   // 0..99
        private int _id = 1;
    }
}
