/*
 * ITSE 1430
 * Abbas Ally
 * Classwork
 */
using System;

// StringBuilder, Reqular expressions, Encoding
//using System.Text;

namespace MovieLibrary
{
    // Type 
    // Pascal cased
    // Noun or noun-like objects
    // Singular unless they represent a collection of things
    // [access] class identifier { }

    /// doctags
    /// <summary>Represents a movie.</summary>
    /// <remarks>
    /// A paragraph of information.
    /// Another set of information.
    /// </remarks>
    public class Movie
    {
        // Data - data to store

        // Fields - where the data is stored
        //string name;
        // Fields work identically to variables
        // Named as nouns, no abbreviations and no generic names
        public string Name = "";

        public string Description = "";
        public string Rating;
        public int RunLength;// = 0;
        public bool IsClassic; // = false;

        // Functionality - functions you want to expose
    }

    // Accessibility = the visibility of an identifier to other code, compile time only, determines who can see what at compilation
    //  public - everyone has access
    //  private - only the owning type has access
}
