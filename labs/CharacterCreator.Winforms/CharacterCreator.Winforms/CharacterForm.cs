using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        private const int StartingAttributePoints = 30;

        public CharacterForm ()
        {
            InitializeComponent();

            attributeControlList = new NumericUpDown[]{_numUpDownAgility, _numUpDownCharisma, _numUpDownConstitution,
                                                       _numUpDownForceAbility, _numUpDownIntelligence, _numUpDownStrength};

            foreach (var attributeControl in attributeControlList)
            {
                attributeControl.ValueChanged += UpdateRemainingPoints;
                attributeControl.Validating += OnValidateAttribute;
            }
        }

        public CharacterForm (Character character, string title) : this()
        {
            Character = character;
            Text = title ?? "Create New Character";
        }

        public Character Character { get; set; }

        private readonly NumericUpDown[] attributeControlList;

        private void UpdateRemainingPoints ( object sender, EventArgs e )
        {
            RemainingPoints();
        }

        private void RemainingPoints ()
        {
            decimal remainingPoints = StartingAttributePoints;
 
            foreach (var attributeControl in attributeControlList)
            {
                remainingPoints -= attributeControl.Value;
            }

            _lblRemainingPoints.Text = remainingPoints.ToString();

        }

        protected override void OnLoad ( EventArgs e)
        {
            base.OnLoad(e);

            _comboProfession.Items.AddRange(Character.ProfessionArray);
            _comboRace.Items.AddRange(Character.RaceArray);

            if (Character != null)
            {
                // Setup for just updating Character Form
                _txtName.Text = Character.Name;
                _comboProfession.Text = Character.Profession;
                _comboRace.Text = Character.Race;

                _numUpDownAgility.Value = Character.Attributes[(int)Character.Attribute.Agility];
                _numUpDownCharisma.Value = Character.Attributes[(int)Character.Attribute.Charisma];
                _numUpDownConstitution.Value = Character.Attributes[(int)Character.Attribute.Constitution];
                _numUpDownForceAbility.Value = Character.Attributes[(int)Character.Attribute.ForceAbility];
                _numUpDownIntelligence.Value = Character.Attributes[(int)Character.Attribute.Intelligence];
                _numUpDownStrength.Value = Character.Attributes[(int)Character.Attribute.Strength];

                _txtDescription.Text = Character.Description;
            }

            // Setup for adding and updating Character Form
            RemainingPoints();

            ValidateChildren();
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnSave ( object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            }

            var character = new Character();

            character.Name = _txtName.Text;
            character.Profession = _comboProfession.SelectedItem.ToString();
            character.Race = _comboRace.SelectedItem.ToString();
            character.Attributes[(int)Character.Attribute.Agility] = Convert.ToInt32(_numUpDownAgility.Value);
            character.Attributes[(int)Character.Attribute.Charisma] = Convert.ToInt32(_numUpDownCharisma.Value);
            character.Attributes[(int)Character.Attribute.Constitution] = Convert.ToInt32(_numUpDownConstitution.Value);
            character.Attributes[(int)Character.Attribute.ForceAbility] = Convert.ToInt32(_numUpDownForceAbility.Value);
            character.Attributes[(int)Character.Attribute.Intelligence] = Convert.ToInt32(_numUpDownIntelligence.Value);
            character.Attributes[(int)Character.Attribute.Strength] = Convert.ToInt32(_numUpDownStrength.Value);
            character.Description = _txtDescription.Text;

            var error = character.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(this, error, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            Character = character;
            Close();
        }

        private void OnValidateName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "Character Name is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            }
        }

        private void OnValidateProfession ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (control.SelectedItem == null)
            {
                _errors.SetError(control, "Character Profession is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            }
        }

        private void OnValidateRace ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (control.SelectedItem == null)
            {
                _errors.SetError(control, "Character Race is required");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            }
        }

        private void OnValidateAttribute ( object sender, CancelEventArgs e )
        {
            var control = sender as NumericUpDown;

            var attributeIntValue = Convert.ToInt32(control.Value);
            if (attributeIntValue < 1 || attributeIntValue > 100)
            {
                _errors.SetError(control, "Character Attribute must be between 1 and 100");
                e.Cancel = true;
            } else
            {
                _errors.SetError(control, "");
            }
        }

    }
}
