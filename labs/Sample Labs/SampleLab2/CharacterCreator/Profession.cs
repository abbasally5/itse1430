/*
 * ITSE 1430
 * Character Creator
 * 
 * Sample implementation.
 */
using System;

namespace CharacterCreator
{
    /// <summary>Represents a profession/career in the game.</summary>
    public abstract class Profession
    {
        #region Construction

        /// <summary>Initializes an instance of the <see cref="Profession"/> class.</summary>
        /// <param name="name">The name of the profession.</param>
        protected Profession ( string name )
        {
            Name = name ?? "";
        }
        #endregion

        /// <summary>Gets the profession name.</summary>
        public string Name { get; }
    }
}
