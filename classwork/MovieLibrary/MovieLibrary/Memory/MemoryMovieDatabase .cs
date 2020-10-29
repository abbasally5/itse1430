using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary.Memory
{
    public class MemoryMovieDatabase : MovieDatabase
    {
        //public Movie Add ( Movie movie, out string error )
        protected override Movie AddCore ( Movie movie )
        {
            // Clone so argument can be modified without impacting our array
            var item = CloneMovie(movie);

            // Set a unique ID
            item.Id = _id++;

            // Add movie to array
            //_movies[index] = movie;     // Movie is a ref type thus movie and _movies[index] reference the same instance
            _movies.Add(item);

            // Set ID on original object and return
            movie.Id = item.Id;
            return movie;

            #region Array Code
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
            #endregion
        }

        //public void Delete ( int id )
        protected override void DeleteCore ( int id )
        {
            var movie = FindById(id);
            if (movie != null)
            {
                // Must use the same instance that is stored in the list so ref equality works
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

        protected override void UpdateCore ( int id, Movie movie )
        {
            var existing = FindById(id);
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
        }

        // Use IEnumerable<T> for readonly lists of items
        // public Movie[] GetAll()
        protected override IEnumerable<Movie> GetAllCore ()
        {
            // DONT DO THIS
            //  1. Expose underlying movie items
            //  2. Callers add/remove movies
            //return _movies;

            //var items = new Movie[_movies.Count];
            //var index = 0;

            // Foreach equivalent
            // var enumerator = _movies.GetEnumerator();
            // while (enumerator.Next(0)
            // { 
            //      var movie = enumerator.Current;
            //      S* 
            // }
            
            // iterator IEnumerable<T>
            //  yield return T
            // makes GetAll() into a reentrant function
            foreach (var movie in _movies)  // relies on IEnumerator<T>
                //items[index++] = CloneMovie(movie);
                yield return CloneMovie(movie);

            //return items;
        }

        protected override Movie GetByIdCore ( int id )
        {
            var movie = FindById(id);

            // Clone movie if we found it
            return (movie != null) ? CloneMovie(movie) : null;
        }

        private Movie FindById ( int id )
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

        protected override Movie GetByName ( string name )
        {
            foreach (var movie in _movies)
            {
                if (String.Compare(movie.Name, name, true) == 0)
                    return CloneMovie(movie);
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


        private List<Movie> _movies = new List<Movie>();    // Generic list of Movies, use for fields
        private int _id = 1;

        // Non-generic
        //      ArrayList - list of objects
        // Generic Types
        //      List<T> where T is any type
    }
}
