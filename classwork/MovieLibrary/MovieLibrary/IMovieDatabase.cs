using System;
using System.Collections.Generic;

namespace MovieLibrary
{
    // Interface
    //    interface declaration ::= [access] interface identifier { interface-member* }
    //    interface-member ::= property | method | event
    //          1. No access modifiers ( always public)
    //          2. No implementation of anything
    //    Cannot instantiate an interface

    // Common interfaces
    //      IEnumerable<T>, IEnumerator<T>
    //      IList<T>, IReadOnlyList<T>
    //      ICompare<T> - relational comparison
    public interface IMovieDatabase
    {
        Movie Add ( Movie movie, out string error );
        void Delete ( int id );
        Movie Get ( int id );
        IEnumerable<Movie> GetAll ();
        string Update ( int id, Movie movie );
    }
}