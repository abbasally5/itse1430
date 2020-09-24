namespace MovieLibrary.WinformsHost
{
    partial class MovieForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._txtRunLength = new System.Windows.Forms.TextBox();
            this._chkClassic = new System.Windows.Forms.CheckBox();
            this._comboRating = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnCacnel = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Run Length";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(181, 45);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(212, 23);
            this._txtName.TabIndex = 3;
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(181, 113);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(212, 103);
            this._txtDescription.TabIndex = 4;
            // 
            // _txtRunLength
            // 
            this._txtRunLength.Location = new System.Drawing.Point(180, 238);
            this._txtRunLength.Name = "_txtRunLength";
            this._txtRunLength.Size = new System.Drawing.Size(100, 23);
            this._txtRunLength.TabIndex = 5;
            // 
            // _chkClassic
            // 
            this._chkClassic.AutoSize = true;
            this._chkClassic.Location = new System.Drawing.Point(180, 290);
            this._chkClassic.Name = "_chkClassic";
            this._chkClassic.Size = new System.Drawing.Size(78, 19);
            this._chkClassic.TabIndex = 6;
            this._chkClassic.Text = "Is Classic?";
            this._chkClassic.UseVisualStyleBackColor = true;
            // 
            // _comboRating
            // 
            this._comboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboRating.FormattingEnabled = true;
            this._comboRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this._comboRating.Location = new System.Drawing.Point(180, 340);
            this._comboRating.Name = "_comboRating";
            this._comboRating.Size = new System.Drawing.Size(121, 23);
            this._comboRating.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rating";
            // 
            // _btnCacnel
            // 
            this._btnCacnel.Location = new System.Drawing.Point(676, 392);
            this._btnCacnel.Name = "_btnCacnel";
            this._btnCacnel.Size = new System.Drawing.Size(75, 23);
            this._btnCacnel.TabIndex = 9;
            this._btnCacnel.Text = "Cancel";
            this._btnCacnel.UseVisualStyleBackColor = true;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(561, 392);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 10;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnCacnel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._comboRating);
            this.Controls.Add(this._chkClassic);
            this.Controls.Add(this._txtRunLength);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.TextBox _txtRunLength;
        private System.Windows.Forms.CheckBox _chkClassic;
        private System.Windows.Forms.ComboBox _comboRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnCacnel;
        private System.Windows.Forms.Button _btnSave;
    }
}