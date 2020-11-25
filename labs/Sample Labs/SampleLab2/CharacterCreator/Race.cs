/*
 * ITSE 1430
 * Character Creator
 * 
 * Sample implementation.
 */
using System;

namespace CharacterCreator
{
    /// <summary>Represents a race/species in the game.</summary>
    public abstract class Race
    {
        #region Construction

        /// <summary>Initializes an instance of the <see cref="Race"/> class.</summary>
        /// <param name="name">The name of the race.</param>
        protected Race ( string name )
        {
            Name = name ?? "";
        }
        #endregion

        /// <summary>Gets the race name.</summary>
        public string Name { get; }
    }
}
