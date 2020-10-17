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
        }

        private Character character;

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

            //TODO: Add Movie
            character = form.Character;
        }
    }
}
