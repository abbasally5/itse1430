namespace CharacterCreator.Winforms
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this._lblRemainingPoints = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._comboProfession = new System.Windows.Forms.ComboBox();
            this._comboRace = new System.Windows.Forms.ComboBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._numUpDownStrength = new System.Windows.Forms.NumericUpDown();
            this._numUpDownAgility = new System.Windows.Forms.NumericUpDown();
            this._numUpDownCharisma = new System.Windows.Forms.NumericUpDown();
            this._numUpDownIntelligence = new System.Windows.Forms.NumericUpDown();
            this._numUpDownConstitution = new System.Windows.Forms.NumericUpDown();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            this._numUpDownForceAbility = new System.Windows.Forms.NumericUpDown();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownForceAbility)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Profession";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Attributes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Strength";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Intelligence";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Agility";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Constitution";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Charisma";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "Force Ability";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(114, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Points Remaining:";
            // 
            // _lblRemainingPoints
            // 
            this._lblRemainingPoints.AutoSize = true;
            this._lblRemainingPoints.Location = new System.Drawing.Point(223, 119);
            this._lblRemainingPoints.Name = "_lblRemainingPoints";
            this._lblRemainingPoints.Size = new System.Drawing.Size(174, 15);
            this._lblRemainingPoints.TabIndex = 30;
            this._lblRemainingPoints.Text = "# of Attribute Points Remaining";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(114, 6);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(200, 23);
            this._txtName.TabIndex = 0;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // _comboProfession
            // 
            this._comboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboProfession.FormattingEnabled = true;
            this._comboProfession.Location = new System.Drawing.Point(114, 35);
            this._comboProfession.Name = "_comboProfession";
            this._comboProfession.Size = new System.Drawing.Size(199, 23);
            this._comboProfession.TabIndex = 1;
            this._comboProfession.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateProfession);
            // 
            // _comboRace
            // 
            this._comboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboRace.FormattingEnabled = true;
            this._comboRace.Location = new System.Drawing.Point(114, 64);
            this._comboRace.Name = "_comboRace";
            this._comboRace.Size = new System.Drawing.Size(200, 23);
            this._comboRace.TabIndex = 2;
            this._comboRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateRace);
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(114, 248);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(200, 100);
            this._txtDescription.TabIndex = 9;
            // 
            // _numUpDownStrength
            // 
            this._numUpDownStrength.Location = new System.Drawing.Point(172, 147);
            this._numUpDownStrength.Name = "_numUpDownStrength";
            this._numUpDownStrength.Size = new System.Drawing.Size(54, 23);
            this._numUpDownStrength.TabIndex = 3;
            // 
            // _numUpDownAgility
            // 
            this._numUpDownAgility.Location = new System.Drawing.Point(172, 176);
            this._numUpDownAgility.Name = "_numUpDownAgility";
            this._numUpDownAgility.Size = new System.Drawing.Size(54, 23);
            this._numUpDownAgility.TabIndex = 5;
            // 
            // _numUpDownCharisma
            // 
            this._numUpDownCharisma.Location = new System.Drawing.Point(172, 205);
            this._numUpDownCharisma.Name = "_numUpDownCharisma";
            this._numUpDownCharisma.Size = new System.Drawing.Size(54, 23);
            this._numUpDownCharisma.TabIndex = 7;
            // 
            // _numUpDownIntelligence
            // 
            this._numUpDownIntelligence.Location = new System.Drawing.Point(319, 147);
            this._numUpDownIntelligence.Name = "_numUpDownIntelligence";
            this._numUpDownIntelligence.Size = new System.Drawing.Size(54, 23);
            this._numUpDownIntelligence.TabIndex = 4;
            // 
            // _numUpDownConstitution
            // 
            this._numUpDownConstitution.Location = new System.Drawing.Point(319, 176);
            this._numUpDownConstitution.Name = "_numUpDownConstitution";
            this._numUpDownConstitution.Size = new System.Drawing.Size(54, 23);
            this._numUpDownConstitution.TabIndex = 6;
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // _numUpDownForceAbility
            // 
            this._numUpDownForceAbility.Location = new System.Drawing.Point(319, 207);
            this._numUpDownForceAbility.Name = "_numUpDownForceAbility";
            this._numUpDownForceAbility.Size = new System.Drawing.Size(54, 23);
            this._numUpDownForceAbility.TabIndex = 8;
            // 
            // _btnSave
            // 
            this._btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnSave.Location = new System.Drawing.Point(217, 374);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 10;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _btnCancel
            // 
            this._btnCancel.CausesValidation = false;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(298, 374);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 11;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._numUpDownForceAbility);
            this.Controls.Add(this._numUpDownConstitution);
            this.Controls.Add(this._numUpDownIntelligence);
            this.Controls.Add(this._numUpDownCharisma);
            this.Controls.Add(this._numUpDownAgility);
            this.Controls.Add(this._numUpDownStrength);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._comboRace);
            this.Controls.Add(this._comboProfession);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this._lblRemainingPoints);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numUpDownForceAbility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label _lblRemainingPoints;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.ComboBox _comboProfession;
        private System.Windows.Forms.ComboBox _comboRace;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.NumericUpDown _numUpDownStrength;
        private System.Windows.Forms.NumericUpDown _numUpDownAgility;
        private System.Windows.Forms.NumericUpDown _numUpDownCharisma;
        private System.Windows.Forms.NumericUpDown _numUpDownIntelligence;
        private System.Windows.Forms.NumericUpDown _numUpDownConstitution;
        private System.Windows.Forms.ErrorProvider _errors;
        private System.Windows.Forms.NumericUpDown _numUpDownForceAbility;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
    }
}