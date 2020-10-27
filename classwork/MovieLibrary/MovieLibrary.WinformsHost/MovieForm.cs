using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieLibrary.WinformsHost
{
    // class-declaration ::= [access] [modifiers] class identifier [ : T]
    public partial class MovieForm : Form
    {
        // Access:
        //  - Public - accessible in derived type
        //  - Protected - accessible in owning type and derived types
        //  - Private - only owning type

        // Members : properties, methods (constructors cannot be inherited)
        //  Virtual - Base type provides the base implementation but a derived type may override it
        //  Abstract - Base type defines it but does not implement, derived types must override it

        // Syntax
        // ctor-declaration ::= [access] T () { S* }
        // Can call base constructor if needed, base default constructor called if not specified
        public MovieForm ()// : base()
        {
            // DO NOT CALL virtual members inside of constructors
            InitializeComponent();
        }

        public MovieForm ( Movie movie ) : this(movie, null)
        {
            //Movie = movie;
        }

        // Constructor chaining - calling one constructor from another
        public MovieForm ( Movie movie, string title ) : this()
        {
           //InitializeComponent();

            Movie = movie;
            Text = title ?? "Add Movie";
        }
        // Properties can be virtual if needed but generally does not make sense
        public Movie Movie { get; set; }

        //public virtual void OnLoad ( EventArgs e ) { }
        // Override indicates to compiler that you are overriding a virtual method
        protected override void OnLoad ( EventArgs e )
        {
            // Call the base member
            base.OnLoad(e);

            if (Movie != null)
            {
                _txtName.Text = Movie.Name;
                _txtDescription.Text = Movie.Description;
                _comboRating.SelectedText = Movie.Rating;
                _chkClassic.Checked = Movie.IsClassic;
                _txtRunLength.Text = Movie.RunLength.ToString();
                _txtReleaseYear.Text = Movie.ReleaseYear.ToString();
            };

            // Go ahead and show validation errors
            ValidateChildren();
        }

        // Method - function inside a class
        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
        }

        // Event handler - handles an event
        // This method is handling the button's Click event
        //      void identifier ( object sender, EventArgs e )
        private void OnSave ( object sender, EventArgs e )
        {
            // Force validation of all controls
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            }
            // I want the button that was clicked
            // Type casting
            // WRONG: var button = (Button)sender; // C-style cast - crashes if wrong
            //var str = (string)10;
            // CORRECT: var button = sender as Button; // as operator - always safe returns typed version or null
            var button = sender as Button;
            if (button == null)
                return;

            var movie = new Movie();
            movie.Name = _txtName.Text;
            movie.Description = _txtDescription.Text;
            movie.Rating = _comboRating.SelectedText;
            movie.IsClassic = _chkClassic.Checked;

            movie.RunLength = ReadAsInt32(_txtRunLength);   // this.ReadAdInt32
            movie.ReleaseYear = ReadAsInt32(_txtReleaseYear);

            var nameLength = Movie.MaximumNameLength; // 50
            //var nameLength = 50;

            var descriptionLength = movie.MaximumDescriptionLength;


            // Validate
            var validationResults = new ObjectValidator().TryValidateFullObject(movie);
            if (validationResults.Count() > 0) 
            {
                // TODO: Fix this later using String.Join
                var builder = new System.Text.StringBuilder();
                foreach (var result in validationResults)
                {
                    builder.AppendLine(result.ErrorMessage);
                };

                // Show error messae
                MessageBox.Show(this, builder.ToString(), "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            };           

            // TODO: Return movie
            Movie = movie;
            Close();
        }

        private int ReadAsInt32 ( Control control )
        {
            var text = control.Text;

            if (Int32.TryParse(text, out var result))
                return result;

            return -1;
        }

        private void PlayWithObjects( object value )
        {
            // Common Type System (CTS) - there is 1 base type from which all other types derive
            //  System.Object -> object
            //      string ToString() ::= Converts a value to a string
            //      bool Equals ( object ) ::= Determines if the current instance equals another value
            //      int GethashCode () ::= Returns an integral value representing the object
            var str = 10.ToString(); // "10"
            var form = new Form();
            form.ToString(); // System.Windows.Forms.Form

            // Type checking or casting
            //4 ways
            // 1. C-style casy ::= (T)E
            //      Runtime attempts to convert value to T and if successful returns value as T else crashes
            //      Must be compile validated
            string stringValue = (string)value; // Value type must be base type of cast type

            // 2. as-operator ::= E as T
            // preferred approach historically
            //      Runtime attempts to convert value to T and if successful retuns value as T else returns null
            stringValue = value as string;
            if (stringValue != null)
            { /* dealing with string */ }

            // 3. is-operator ::= E is T
            //      Runtime verifies value is of given T and returns true if successful or false otherwise
            var isString = value is string;   // true
            if (isString)
            {
                stringValue = (string)value;
            }
            // ^ this code would actually be checking type twice at runtime

            // 4. pattern-matching ::= E is T identifier
            //      Runtime attempts to convert E to T and if successful stores in identifier else stores default(T)
            if (value is string sValue) 
            {
                // equivalent to 
                //string svalue = value as string
                //if (sValue != null)
            }

            // Dealing with null
            //      1. Let it fail - instance.ToString() // errors if null
            //      2. null coalescing-operator ::= E1 ?? E2
            //          if E1 is not null return E1 else return E2
            stringValue = stringValue ?? "";

            //      3. null-conditional-operator ::= E?.M
            //          E is an instance, M is any member; if E is not null, then call M else skip it
            //          .ToString() -> string
            //          ?.toString() -> string | null
            stringValue = stringValue?.ToString() ?? "";
            // equivalent to
            // if (stringValue != null)
            //      if (temp != null) return ""
            //  return ""

            //      4. null reference types
            //          c# is trying to get rid of the need to use null at all

            //int x - null;
            string x = null;

        }

        private void OnValidateName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            // Name is required
            if (String.IsNullOrEmpty(control.Text))
            {
                // Set error using ErrorProvider
                _errors.SetError(control, "Name is required");
                e.Cancel = true;    // Not validate
            } else
            {
                // Clear error from provider
                _errors.SetError(control, "");
            }
        }

        private void OnValidateRunLength ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = ReadAsInt32(control);

            // Run length >= 0
            if (value < 0)
            {
                // Set error using ErrorProvider
                _errors.SetError(control, "Run length must be >= 0");
                e.Cancel = true;    // Not validate
            } else
            {
                // Clear error from provider
                _errors.SetError(control, "");
            }
        }

        private void OnValidateReleaseYear ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = ReadAsInt32(control);

            // Run length >= 0
            if (value < 1900)
            {
                // Set error using ErrorProvider
                _errors.SetError(control, "Release year must be >= 1900");
                e.Cancel = true;    // Not validate
            } else
            {
                // Clear error from provider
                _errors.SetError(control, "");
            }
        }
    }
}
