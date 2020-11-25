/*
 * ITSE 1430
 * Character Creator
 * 
 * Sample implementation.
 */
using System;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm ()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnCharacterNew ( object sender, EventArgs e )
        {
            var form = new CharacterForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            //Add the character
            _character = form.SelectedCharacter;
            RefreshRoster();
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            if (MessageBox.Show(this, $"Are you sure you want to delete {character.Name}?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _character = null;
            RefreshRoster();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var form = new CharacterForm();
            form.SelectedCharacter = character;

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _character = form.SelectedCharacter;
            RefreshRoster();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm();
            form.ShowDialog(this);
        }        
        #endregion

        #region Private Members

        // Gets the selected character, if any
        private Character GetSelectedCharacter ()
        {
            return _character;
        }

        private void RefreshRoster()
        {
            _lstCharacters.Items.Clear();

            if (_character == null)
                return;

            var roster = new Character[1];
            roster[0] = _character;
            
            _lstCharacters.Items.AddRange(roster);
            _lstCharacters.DisplayMember = nameof(Character.Name);
        }

        private Character _character;
        #endregion
    }
}
