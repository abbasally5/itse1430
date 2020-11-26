using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
    public interface ICharacterRoster
    {
        /// <summary>
        /// Adds a Character to the database.
        /// </summary>
        /// <param name="character">The character to add.</param>
        /// <returns>The new character.</returns>
        /// <exception cref="ValidationException"><paramref name="character"/> is not valid.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="character"/>A character with the same name already exists.</exception>
        Character Add ( Character character );

        /// <summary>
        /// Deletes a character from the database.
        /// </summary>
        /// <param name="id">The character to delete.</param>
        /// error: id is less than zero.
        void Delete ( int id );

        /// <summary>
        /// Gets a character from the database.
        /// </summary>
        /// <param name="id">The character to retrieve.</param>
        /// <returns>The retrieved character.</returns>
        /// error: id is less than zero.
        Character Get ( int id );

        /// <summary>
        /// Gets all the characters.
        /// </summary>
        /// <returns>The characters.</returns>
        Character[] GetAll ();

        /// <summary>
        /// Updates an existing character in the database.
        /// </summary>
        /// <param name="id">The character to update.</param>
        /// <param name="character">The character information.</param>
        /// <exception cref="ValidationException"><paramref name="character"/> is not valid.</exception>
        /// <exception cref="InvalidOperationException"><paramref name="character"/>A character with the same name already exists.</exception>
        /// error: Id is less than zero.
        /// error: Character does not exist.
        void Update ( int id, Character character );
    }
}
