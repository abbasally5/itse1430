using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{
        
    public class Character
    {
        /// <summary>The number of attributes that will be stored for each character</summary>
        private const int NumAttributes = 6;

        /// <summary>The minimum Attribute level a character can have</summary>
        private const int MinAttributeLevel = 1;

        /// <summary>The maximum Attribute level a character can have</summary>
        private const int MaxAttributeLevel = 100;

        /// <summary>
        /// Makes the Attributes array easier to work with by using the attribute name rather than the attribute index
        /// </summary> 
        public enum Attribute
        {
            Strength,
            Intelligence,
            Agility,
            Constitution,
            Charisma,
            ForceAbility
        }

        /// <summary>
        /// Gets or sets the character name
        /// </summary>
        public string Name 
        { 
            get { return _name ?? ""; }
            set { _name = value; }
        }
        private string _name = "";

        /// <summary>
        /// Gets or sets the character profession
        /// </summary>
        /// <value>
        /// The possible professions include "Smuggler", "Bounty Hunter", "Politician", "Spy", "Scientist", "Technician"
        /// </value>
        public string Profession 
        {
            get { return _profession ?? ""; }
            set { _profession = value; } 
        }
        private string _profession = "";

        /// <summary>
        /// Gets or sets the character race
        /// </summary>
        /// <value>
        /// The possible races include Human, Wookie, Bothan, Mon Calimari, Genosion, Kaminoan, Gungan 
        /// </value>
        public string Race 
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }
        private string _race = "";

        /// <summary>
        /// Gets or sets the character attributes
        /// </summary>
        /// <value>
        /// The possible attributes are listed under the Attribute enum
        /// </value>
        public int[] Attributes { get; set; } = new int[NumAttributes];

        /// <summary>
        /// Gets or sets the character description
        /// </summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description = "";
    }
}
