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
        public int ReleaseYear = 1900;

        // Functionality - functions you want to expose

        /// <summary>Validated the movie instance </summary>
        /// <returns>The error message, if any.</returns>
        public string Validate ( /* Movie this */ )
        {
            // this is reference to current instance
            // rarely needed
            //var name = this.Name;

            // Only 2 cases where `this` is needed
            // 1. scoping issue -> fix the issue
            //      fields are _id
            //      locals are id
            //    ex:
            //      var Name = "";
            //      Name = Name;    // WRONG
            //      this.Name = Name; // CORRECT
            // 2. passing the entire object to another method (only really valid case)

            // Name is required
            if (String.IsNullOrEmpty(Name)) // this.name
                return "Name is required";

            // Run length must be >= 0
            if (RunLength < 0)
                return "Run Length must be greater than or equal to 0";

            // Release year must be >= 1900
            if (ReleaseYear < 1900)
                return "Release Year must be at least 1900";

            return null;
            // Safe pattern - when you create a function, you should make sure 
            // - assume inputs are invalid
        }
    }

    // Accessibility = the visibility of an identifier to other code, compile time only, determines who can see what at compilation
    //  public - everyone has access
    //  private - only the owning type has access
}
