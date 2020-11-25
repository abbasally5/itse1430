/*
 * ITSE 1430
 * Character Creator
 * 
 * Sample implementation.
 */
using System;

namespace CharacterCreator.Professions
{
    /// <summary>Provides access to the standard professions.</summary>
    public static class StandardProfessions
    {
        /// <summary>Gets the standard professions.</summary>
        public static Profession[] Professions
        {
            get { return s_professions;  }
        }

        #region Private Members

        private static readonly Profession[] s_professions = new Profession[]
        {
            new Fighter(),
            new Hunter(),
            new Priest(),
            new Rogue(),
            new Wizard()
        };
        #endregion
    }
}
