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
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._cbRace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._cbProfession = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtCharisma = new System.Windows.Forms.NumericUpDown();
            this._txtConstitution = new System.Windows.Forms.NumericUpDown();
            this._txtAgility = new System.Windows.Forms.NumericUpDown();
            this._txtIntelligence = new System.Windows.Forms.NumericUpDown();
            this._txtStrength = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._txtBiography = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtCharisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtStrength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(75, 19);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(179, 20);
            this._txtName.TabIndex = 0;
            // 
            // _cbRace
            // 
            this._cbRace.DisplayMember = "Name";
            this._cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbRace.FormattingEnabled = true;
            this._cbRace.Location = new System.Drawing.Point(75, 50);
            this._cbRace.Name = "_cbRace";
            this._cbRace.Size = new System.Drawing.Size(121, 21);
            this._cbRace.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Profession";
            // 
            // _cbProfession
            // 
            this._cbProfession.DisplayMember = "Name";
            this._cbProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProfession.FormattingEnabled = true;
            this._cbProfession.Location = new System.Drawing.Point(75, 82);
            this._cbProfession.Name = "_cbProfession";
            this._cbProfession.Size = new System.Drawing.Size(121, 21);
            this._cbProfession.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtCharisma);
            this.groupBox1.Controls.Add(this._txtConstitution);
            this.groupBox1.Controls.Add(this._txtAgility);
            this.groupBox1.Controls.Add(this._txtIntelligence);
            this.groupBox1.Controls.Add(this._txtStrength);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes";
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(85, 125);
            this._txtCharisma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(42, 20);
            this._txtCharisma.TabIndex = 4;
            this._txtCharisma.Tag = "Charisma";
            this._txtCharisma.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Location = new System.Drawing.Point(85, 99);
            this._txtConstitution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(42, 20);
            this._txtConstitution.TabIndex = 3;
            this._txtConstitution.Tag = "Constitution";
            this._txtConstitution.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtAgility
            // 
            this._txtAgility.Location = new System.Drawing.Point(85, 73);
            this._txtAgility.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(42, 20);
            this._txtAgility.TabIndex = 2;
            this._txtAgility.Tag = "Agility";
            this._txtAgility.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtIntelligence
            // 
            this._txtIntelligence.Location = new System.Drawing.Point(85, 47);
            this._txtIntelligence.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtIntelligence.Name = "_txtIntelligence";
            this._txtIntelligence.Size = new System.Drawing.Size(42, 20);
            this._txtIntelligence.TabIndex = 1;
            this._txtIntelligence.Tag = "Intelligence";
            this._txtIntelligence.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(85, 21);
            this._txtStrength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(42, 20);
            this._txtStrength.TabIndex = 0;
            this._txtStrength.Tag = "Strength";
            this._txtStrength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Charisma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Constitution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Agility";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Intelligence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Strength";
            // 
            // _txtBiography
            // 
            this._txtBiography.Location = new System.Drawing.Point(271, 39);
            this._txtBiography.Multiline = true;
            this._txtBiography.Name = "_txtBiography";
            this._txtBiography.Size = new System.Drawing.Size(295, 250);
            this._txtBiography.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Biography";
            // 
            // _btnCancel
            // 
            this._btnCancel.CausesValidation = false;
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(503, 311);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(422, 311);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 4;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(590, 346);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtBiography);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._cbProfession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cbRace);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtCharisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._txtStrength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.ComboBox _cbRace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbProfession;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown _txtCharisma;
        private System.Windows.Forms.NumericUpDown _txtConstitution;
        private System.Windows.Forms.NumericUpDown _txtAgility;
        private System.Windows.Forms.NumericUpDown _txtIntelligence;
        private System.Windows.Forms.NumericUpDown _txtStrength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtBiography;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
    }
}