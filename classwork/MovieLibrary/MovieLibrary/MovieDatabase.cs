using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary
{
    public class MovieDatabase
    {
        public MovieDatabase ()
        {
            // Collection initializer syntax
            var items = new [] { // new Movie[]
                new Movie() {
                    Name = "Jaws",
                    ReleaseYear = 1977,
                    RunLength = 199,
                    Description = "Shark movie",
                    IsClassic = true,
                    Rating = "PG",  // Can have a comma at end
                },
                new Movie() {
                    Name = "Jaws 2",
                    ReleaseYear = 1979,
                    RunLength = 195,
                    Description = "Shark movie",
                    IsClassic = true,
                    Rating = "PG-13",
                },
                new Movie() {
                Name = "Dune",
                ReleaseYear = 1985,
                RunLength = 220,
                Description = "Based on book",
                IsClassic = true,
                Rating = "PG",
                }
            };
            foreach (var item in items)
                Add(item, out var error);

            // Not needed here - clears all items from list
            //_movies.Clear();

            // Seed database
            // Object initializer - only usable on new operator
            //  Limitations:
            //      1. Can only set properties with setters
            //      2. Can set properties that are themselves new'ed up but cannot set child properites
            //          ex. Position = new Position() { Name = "Boss" };    // Allowed
            //              Position.Title = "Boss";    // Not allowed
            //      3. Properties cannot rely on other properties
            //              Description = "blah",
            //              FullDescription = Description
            //var movie = new Movie();
            //movie.Name = "Jaws";
            //movie.ReleaseYear = 1977;
            //movie.RunLength = 199;
            //movie.Description = "Shark movie";
            //movie.IsClassic = true;
            //movie.Rating = "PG";
            //var movie = new Movie() {
            //    Name = "Jaws",
            //    ReleaseYear = 1977,
            //    RunLength = 199,
            //    Description = "Shark movie",
            //    IsClassic = true,
            //    Rating = "PG",  // Can have a comma at end
            //};

            //Add(movie, out var error);

            //movie = new Movie() {
            //    Name = "Jaws 2",
            //    ReleaseYear = 1979,
            //    RunLength = 195,
            //    Description = "Shark movie",
            //    IsClassic = true,
            //    Rating = "PG-13",
            //};
            //Add(movie, out error);

            //movie = new Movie() {
            //    Name = "Dune",
            //    ReleaseYear = 1985,
            //    RunLength = 220,
            //    Description = "Based on book",
            //    IsClassic = true,
            //    Rating = "PG",
            //};
            //Add(movie, out error);
        }
        // Array - T[]
        //public Movie[] Items { get; set; }

        public Movie Add ( Movie movie, out string error )
        {
            //TODO: Movie is valid
            // Movie name is unique
            error = "";

            var item = CloneMovie(movie);

            // Set a unique ID
            item.Id = _id++;

            // Add movie to array
            //_movies[index] = movie;     // Movie is a ref type thus movie and _movies[index] reference the same instance
            _movies.Add(item);

            // Set ID on original object and return
            movie.Id = item.Id;
            return movie;

            // Find first empty spot in array
            // for ( EI; EC; EU ) S;
            //      EI ::= initializer expression of loop variant (runs once before loop executes)
            //      EC ::= conditional expression => boolean (executes before loop statement is run, aborts if condition is false)
            //      EU ::= update expression (runs at end of current iteration)
            // Length -> int (# of rows in the array)
            //for (var index = 0; index < _movies.Length; ++index)
            //for (var index = 0; index < _movies.Count; ++index)
            //{
            //    // Array element access ::= V[int]
            //    //if (_movies[index] == null)
            //    {
            //        var item = CloneMovie(movie);

            //        // Set a unique ID
            //        item.Id = _id++;

            //        // Add movie to array
            //        //_movies[index] = movie;     // Movie is a ref type thus movie and _movies[index] reference the same instance
            //        _movies.Add(item);

            //        // Set ID on original object and return
            //        movie.Id = item.Id;
            //        return movie;
            //    };
            //}

            //error = "No more room";
            //return null;
        }

        public void Delete ( int id )
        {
            //TODO: Validate id

            var movie = GetById(id);
            if (movie != null)
            {
                _movies.Remove(movie);
            };
                    
            #region For Arrays
            //for (var index = 0; index < _movies.Length; ++index)
            //{
            //    // Array element access ::= V[int]
            //    //if (_movies[index] != null && _movies[index].Id == id)
            //    if (_movies[index]?.Id == id)   // null conditional ?. if instance != null, access the member
            //    {
            //        _movies[index] = null;
            //        return;
            //    };
            //}
            #endregion
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
            CopyMovie(existing, movie);

            //for (var index = 0; index < _movies.Length; ++index)
            //{
            //    if (_movies[index]?.Id == id)
            //    {
            //        // Clone it so we separate our value from argument
            //        var item = CloneMovie(movie);

            //        item.Id = id;
            //        _movies[index] = item;
            //        return "";

            //        // Just because we are doing this in memory
            //        //movie.Id = id;
            //        //_movies[index] = movie;
            //        //return;
            //    };
            //}

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
            //return _movies;
            var items = new Movie[_movies.Count];
            var index = 0;
            foreach (var movie in _movies)
                items[index++] = CloneMovie(movie);

            return items;
        }

        public Movie Get ( int id )
        {
            var movie = GetById(id);

            // Clone movie if we found it
            return (movie != null) ? CloneMovie(movie) : null;
        }

        private Movie GetById ( int id )
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
                    return movie;
            };

            return null;
        }

        private Movie CloneMovie ( Movie movie )
        {
            var item = new Movie();
            item.Id = movie.Id;

            CopyMovie(item, movie);
            
            return item;
        }

        private void CopyMovie ( Movie target, Movie source )
        {
            target.Name = source.Name;
            target.Rating = source.Rating;
            target.ReleaseYear = source.ReleaseYear;
            target.IsClassic = source.IsClassic;
            target.Description = source.Description;
        }

        // Only store cloned copies of movies here!!
        //private Movie[] _movies = new Movie[100];   // 0..99
        private List<Movie> _movies = new List<Movie>();    // Generic list of Movies, use for fields
        //private Collection<Movie> _temp;                    // Public read-writable lists
        private int _id = 1;

        // Non-generic
        //      ArrayList - list of objects
        // Generic Types
        //      List<T> where T is any type
    }
}
