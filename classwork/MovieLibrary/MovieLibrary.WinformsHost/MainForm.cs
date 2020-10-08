using System;       // DO NOT DELETE
using System.Windows.Forms;

// Hierarchical namespaces
//namespace MovieLibrary
//{
//    namespace WinformsHost
//    {
//    }
//}

//namespace Company.Product.<area>
//namespace Microsoft.Office.Word
//namespace Microsoft.Office.Excel

namespace MovieLibrary.WinformsHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Type = Movie
            // Variable = movie
            // Value = instance (or an object)
            Movie movie;
            movie = new Movie();    // Create an instance ::= new T()

            //label1.Text = "A label";
            //var movie2 = new Movie(); // New instance

            // member access operator ::= E . M
            movie.Name = "Jaws";
            movie.Description = "Shark movie";
            //var str = movie.description;

            // Hooks up an event handler to an event
            // Event += method
            // Can have multiple methods respond to an event
            // Event -= method
            _miMovieAdd.Click += OnMovieAdd;
            _miMovieEdit.Click += OnMovieEdit;
            _miMovieDelete.Click += OnMovieDelete;
            _miHelpAbout.Click += OnHelpAbout;

        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox();

            about.ShowDialog(this);
        }

        // Event - a notification to interested parties that something has happened
        private Movie _movie;

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var form = new MovieForm();

            // Show Dialog - modal ::= use must interact with child form, cannot access parent
            // Show - modeless ::= multiple window open and accessible at same time
            var result = form.ShowDialog(); // Blocks until form is dismissed

            if (result == DialogResult.Cancel)
                return;

            // After form is gone
            // TODO: Save movie
            _movie = form.Movie;

            MessageBox.Show("Save successful");
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            if (_movie == null)
                return;

            // Object creation
            //  1. Allocate memory for instance, zero initialized
            //  2. Initialize fields
            //  3. Constructor (finish initialization)
            //  4. Return new instance                                                                                                                                 
            var form = new MovieForm(_movie, "Edit Movie");
            //form.Movie = _movie;

            var result = form.ShowDialog(); // Blocks until form is dismissed
            if (result == DialogResult.Cancel)
                return;

            // TODO: Update movie
            _movie = form.Movie;

            MessageBox.Show("Save successful");
        }

        private void OnMovieDelete (object sender, EventArgs e )
        {
            // Verify movie exists
            if (_movie == null)
                return;

            // DialogResult - the button the user clicked
            switch (MessageBox.Show(this, "Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes: break;
                case DialogResult.No: return;
            };

            // TODO: Delete movie
            _movie = null;
        }
    }
}

//namespace OtherNamespace
//{
//    public class MainForm
//    {
//    }
//}
