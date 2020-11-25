/*
 * ITSE 1430
 * Character Creator
 * 
 * Sample implementation.
 */
using System;

namespace CharacterCreator.Professions
{
    /// <summary>Provides access to the standard races.</summary>
    public static class StandardRaces
    {
        /// <summary>Gets the standard races.</summary>
        public static Race[] Races
        {
            get { return s_races; }
        }

        #region Private Members

        private static readonly Race[] s_races = new Race[]
        {
            new Dwarf(),
            new Elf(),
            new Gnome(),
            new HalfElf(),
            new Human()
        };
        #endregion
    }
}
