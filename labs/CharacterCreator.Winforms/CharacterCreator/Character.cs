using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreator
{

    public class Character
    {
        /// <summary>
        /// Makes the Attributes array easier to work with by using the attribute name rather than the attribute index
        /// Essentially makes the Attributes array into a faux dictionary
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

        //public int this[Attribute attr]
        //{
        //    get { return Attributes[(int)attr]; }
        //}

        public int GetAttributeIndex ( Attribute _attr)
        {
            return (int)_attr;
        }

        /// <summary>The number of attributes that will be stored for each character</summary>
        private const int NumAttributes = 6;
        //private readonly int NumAttributes = Enum.GetValues(typeof(Attribute)).Length;

        /// <summary>The minimum Attribute level a character can have</summary>
        private const int MinAttributeLevel = 1;

        /// <summary>The maximum Attribute level a character can have</summary>
        private const int MaxAttributeLevel = 100;

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
        public string Profession 
        {
            get { return _profession ?? ""; }
            set { _profession = value; } 
        }
        private string _profession = "";
        
        /// <summary>
        /// Array of the possible professions
        /// </summary>
        public static string[] ProfessionArray = { "Smuggler", "Bounty Hunter", "Politician", "Spy", "Technician" };

        /// <summary>
        /// Gets or sets the character race
        /// </summary>
        public string Race 
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }
        private string _race = "";

        /// <summary>
        /// The possible races include Human, Wookie, Bothan, Mon Calimari, Genosion, Kaminoan, Gungan 
        /// </summary>
        public static string[] RaceArray = { "Human", "Wookie", "Bothan", "Mon Calimari", "Genosian", "Kaminoan", "Gungan" }; 

        /// <summary>
        /// Gets or sets the character attributes
        /// </summary>
        /// <value>
        /// The possible attributes are listed under the Attribute enum
        /// </value>
        public int[] Attributes = new int[NumAttributes];

        /// <summary>
        /// Gets or sets the character description
        /// </summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description = "";

        public string Validate ()
        {
            if (String.IsNullOrEmpty(Name))
                return "Character Name is required";

            if (String.IsNullOrEmpty(Profession))
                return "Character Profession is required";

            if (String.IsNullOrEmpty(Race))
                return "Character Race is required";

            if (!IsAttributeValid(Attributes[(int)Attribute.Agility]))
                return AttributeErrorMessage("Agility");

            if (!IsAttributeValid(Attributes[(int)Attribute.Charisma]))
                return AttributeErrorMessage("Charisma");

            if (!IsAttributeValid(Attributes[(int)Attribute.Constitution]))
                return AttributeErrorMessage("Constitution");

            if (!IsAttributeValid(Attributes[(int)Attribute.ForceAbility]))
                return AttributeErrorMessage("Force Ability");

            if (!IsAttributeValid(Attributes[(int)Attribute.Intelligence]))
                return AttributeErrorMessage("Intelligence");

            if (!IsAttributeValid(Attributes[(int)Attribute.Strength]))
                return AttributeErrorMessage("Strength");

            return null;
        }

        private string AttributeErrorMessage (string attributeName)
        {
            return $"The {attributeName} attribute must be between 1 and 100";
        }

        private bool IsAttributeValid ( int attributeValue )
        {
            return (attributeValue >= 1 && attributeValue <= 100);
        }

        public override string ToString ()
        {
            return Name;
        }
    }
}
