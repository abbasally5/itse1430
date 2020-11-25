/*
 * ITSE 1430
 * Character Creator
 * 
 * Sample implementation.
 */
using System;
using System.Windows.Forms;

using CharacterCreator.Professions;

namespace CharacterCreator.Winforms
{
    /// <summary>Provides a UI for creating a character.</summary>
    public partial class CharacterForm : Form
    {
        #region Construction

        /// <summary>Initializes an instance of the <see cref="CharacterForm"/> class.</summary>
        public CharacterForm ()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>Gets or sets the selected character.</summary>
        public Character SelectedCharacter { get; set; }

        //Called when the form loads
        protected override void OnLoad ( EventArgs e )
        {
            //Load the UI
            LoadUI();
        }

        #region Event Handlers

        //Called when the Save button is clicked
        private void OnSave ( object sender, EventArgs e )
        {            
            //Save the changes
            var character = SaveCharacter();            
            if (!character.Validate(out var error))
            {
                MessageBox.Show(this, error, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            //Close the form
            SelectedCharacter = character;
            DialogResult = DialogResult.OK;
            Close();
        }
        #endregion

        #region Private Members

        private void LoadUI ()
        {
            LoadProfessions();
            LoadRaces();

            if (SelectedCharacter != null)
            {
                Text = "Edit Character";
                LoadCharacter(SelectedCharacter);
            };
        }

        private void LoadProfessions ()
        {
            //Bind to the standard professions 
            _cbProfession.DataSource = StandardProfessions.Professions;

            //Don't select anything by default
            _cbProfession.SelectedIndex = -1;
        }

        private void LoadRaces ()
        {
            //Bind to the standard races
            _cbRace.DataSource = StandardRaces.Races;

            //Don't select anything by default
            _cbRace.SelectedIndex = -1;
        }

        private void LoadCharacter ( Character character )
        {
            _txtName.Text = character.Name;
            SelectProfession(character.Profession);
            SelectRace(character.Race);
            _txtBiography.Text = character.Biography;

            _txtStrength.Value = character.Strength;
            _txtIntelligence.Value = character.Intelligence;
            _txtAgility.Value = character.Agility;
            _txtConstitution.Value = character.Constitution;
            _txtCharisma.Value = character.Charisma;
        }

        private Character SaveCharacter ( )
        {
            var character = new Character();
            character.Name = _txtName.Text;
            character.Profession = _cbProfession.SelectedItem as Profession;
            character.Race = _cbRace.SelectedItem as Race;
            character.Biography = _txtBiography.Text;

            character.Strength = (int)_txtStrength.Value;
            character.Intelligence = (int)_txtIntelligence.Value;
            character.Agility = (int)_txtAgility.Value;
            character.Constitution = (int)_txtConstitution.Value;
            character.Charisma = (int)_txtCharisma.Value;

            return character;
        }

        private void SelectProfession ( Profession desiredItem )
        {
            foreach (var item in _cbProfession.Items)
            {
                if ((item as Profession).Name == desiredItem.Name)
                {
                    _cbProfession.SelectedItem = item;
                    return;
                };
            };
        }

        private void SelectRace ( Race desiredItem )
        {
            foreach (var item in _cbRace.Items)
            {
                if ((item as Race).Name == desiredItem.Name)
                {
                    _cbRace.SelectedItem = item;
                    return;
                };
            };
        }
        #endregion
    }
}
