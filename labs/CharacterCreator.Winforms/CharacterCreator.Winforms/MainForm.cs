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

        //private const int StartingAttributePoints = 30;

        //private int RemainingPoints ( Character _character )
        //{
        //    int remaingingPoints = StartingAttributePoints;
        //    foreach (var attributeCount in _character.Attributes)
        //        remaingingPoints -= attributeCount;

        //    return remaingingPoints;
        //}

        public MainForm()
        {
            InitializeComponent();

            _miFileExit.Click += OnFileExit;
            _miHelpAbout.Click += OnHelpAbout;
            _miCharacterNew.Click += OnCharacterNew;
            _miCharacterEdit.Click += OnCharacterEdit;
        }

        private Character character;

        private Character[] characterList = new Character[1];

        private Character GetSelectedCharacter ()
        {
            return _lstCharacters.SelectedItem as Character;
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

            character = form.Character;
            characterList[0] = character;
            RefreshUI();
        }

        private void OnCharacterEdit ( object sender, EventArgs e)
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var form = new CharacterForm(character, "Edit Character");

            var result = form.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            characterList[0] = form.Character;
            RefreshUI();

        }

        private void RefreshUI ()
        {
            _lstCharacters.DataSource = null;
            _lstCharacters.DataSource = characterList;
        }
    }
}
