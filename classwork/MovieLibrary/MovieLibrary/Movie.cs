﻿/*
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
        //  Should always be private
        //  Named using camel case and start with underscore
        //string name;
        // Fields work identically to variables
        // Named as nouns, no abbreviations and no generic names

        // Only time public fields allowed - read only data
        // Constants
        //  [access] const T identifier = E;
        //      1. Must be a primitive type
        //      2. Must have an initializer expression
        //      3. Must recompile all code if value changed
        public const int MaximumNameLength = 50;

        // Read Only
        // [access] readonly T identifier;
        //      1. Any type
        //      2. Must be initialized once either in initializer expression or at instance creation
        //      3. Allowed to have different "readonly" values for each instance
        //      4. Is not baked into source code
        public readonly int MaximumDescriptionLength = 200;

        // Not a field. because:
        //  1. Can not write 
        //  2. Calculated
        //public int Age;

        // Not a method either, because:
        // 1. Get age is Not functinality, is data
        // 2. Complex syntax compared to fields
        // 3. Get/Set is in name
        //public int GetAge () { }
        public int Age
        {
            // Read only property
            // Calculated property
            get { return DateTime.Now.Year - ReleaseYear; }
            //set {  }
        }

        // Mixed accessibility - using a different access on either getter or setter
        //  1. Only 1 method can have access modifier
        //  2. Always more restrictive
        public int Id { get; private set; } // Public read, private write

        // Properties - Methods that have field like syntax
        //  full-property ::= [access] T identifier { getter setter }
        //  getter ::= get { S* }
        //  setter ::= set { S* }
        //  auto-property ::= [access] T identifier { get; set; }
        // Properties returning arrays or strings should not return null
        public string Name
        {
            // getter: T get_Name ()
            get 
            {
                // Coalesce - scanning a series of expression looking for nul-NULL
                //     E1 ?? E2
                //        if E1 is not null the nreturn E1
                //        else return E2
                
                // if (_name == null)
                //      return "";

                //return _name;
                return _name ?? "";
            }

            // setter: void set_Name ( T value )
            set 
            {
                _name = value;
            }
        }
        private string _name = "";

        /// <summary>Gets or sets the movie description </summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value;  }
        }
        private string _description = "";

        public string Rating
        {
            get { return _rating ?? ""; }
            set { _rating = value; }
        }
        private string _rating;

        /// <summary>Gets or sets the run length in minutes.</summary>
        public int RunLength { get; set; }
        //public int RunLength
        //{
        //    get { return _runLength; }
        //    set { _runLength = value; }
        //}
        //private int _runLength;// = 0;


        /// <summary>Gets or sets the release year.</summary>
        /// <value>Default value is 1900.</value>
        public int ReleaseYear { get; set; } = 1900;
        //public int ReleaseYear
        //{
        //    get { return _releaseYear; }
        //    set { _releaseYear = value; }
        //}
        //private int _releaseYear = 1900;


        public bool IsClassic { get; set; }
        //public bool IsClassic
        //{
        //    get { return _isClassic; }
        //    set { _isClassic = value; }
        //}
        //private bool _isClassic; // = false;


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
