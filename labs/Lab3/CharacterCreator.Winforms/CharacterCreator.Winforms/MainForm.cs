/*
 * Abbas Ally
 * ITSE 1430
 * Lab 3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            _miFileExit.Click += OnFileExit;
            _miHelpAbout.Click += OnHelpAbout;
            _miCharacterNew.Click += OnCharacterNew;
            _miCharacterEdit.Click += OnCharacterEdit;
            _miCharacterDelete.Click += OnCharacterDelete;
        }

        private Character _character;

        private Character[] characterList = new Character[1];

        private Character GetSelectedCharacter ()
        {
            return _lstCharacters.SelectedItem as Character;
        }

        private int GetCharacterIndex ()
        {
            return _lstCharacters.SelectedIndex;
        }

        private void OnFileExit ( object sender, EventArgs e)
        {
            Close();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox();

            about.ShowDialog(this);
        }

        private void OnCharacterNew ( object sender, EventArgs e)
        {
            var form = new CharacterForm();

            var result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            _character = form.Character;
            characterList[0] = _character;
            RefreshUI();
        }

        private void OnCharacterEdit ( object sender, EventArgs e)
        {
            var character = GetSelectedCharacter();
            var characterIndex = GetCharacterIndex();
            if (character == null)
                return;

            var form = new CharacterForm(character, "Edit Character");

            var result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            characterList[characterIndex] = form.Character;
            RefreshUI();

        }

        private void OnCharacterDelete (object sender, EventArgs e)
        {
            var character = GetSelectedCharacter();
            var characterIndex = GetCharacterIndex();
            if (character == null)
                return;

            switch (MessageBox.Show(this, $"Are you sure you want to delete `{character.Name}`?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes: break;
                case DialogResult.No: return;
            }

            characterList[characterIndex] = null;
            RefreshUI();
        }

        private void RefreshUI ()
        {
            _lstCharacters.DataSource = null;
            _lstCharacters.DataSource = characterList;
        }
    }
}
