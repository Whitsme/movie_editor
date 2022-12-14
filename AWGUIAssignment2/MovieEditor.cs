// Aaron Whitaker
// Winter 2022
// CIS 207
// GUI Assignment 2: 'MovieEditor' window for user selection movie file from JSON folder selected, and for editing + saving title, year, runtime, and genre of said movies

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace GUIAssignment2
{
    // class 'MovieEditor' is called by class 'Form1' and is a new form when that is generated by user action event method 'buttonOpenEditor_Click' in class 'Form1'
    public partial class MovieEditor : Form
    {
        // calls: list 'theMovies' and variables 'imagePath' and 'jsonPath' from class 'Form1' for use below
        List<Movie> theMovies;
        string imagePath;
        string jsonPath;

        // method 'MovieEditor' calls list 'importedMovieList' and variables 'importedImageFolderPath' and 'importedJsonFolderPAth' from method 'buttonOpenEditor_Click' in class 'Form1' // passes title and year from list 'movieList' using class 'Movie' into form 'comboBoxMovies' for user movie selection
        public MovieEditor(List<Movie> importedMovieList, string importedImageFolderPath, string importedJsonFolderPAth)
        {            
            InitializeComponent();

            theMovies = importedMovieList;
            imagePath = importedImageFolderPath;
            jsonPath = importedJsonFolderPAth;

            foreach (var aMovie in theMovies)
            {
                comboBoxMovies.Items.Add(aMovie.title + " (" + aMovie.year + ")");
            }                      
        }
        // method 'comboBoxMovies_SelectedIndexChanged' is called when user selects movie in form 'comboBoxMovies' // resets 'textBox[Title, Year, Runtime, and Genre]' to white (due to textBox color change upon user edited data save indication below) // passes user section through list 'theMovies' and class 'Movie' to display movie info 'aMovie[.title, .year, .runtime, .genre]' // displays movie info 'aMovie[.title, .year, .runtime, .genre]' in 'textBox[Title, Year, Runtime, and Genre]', respectively // displays image with matching 'aMovie.id' file name from user selected folder 'imagePath' (passed from class 'Form1') 
        private void comboBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // resets 'textBox[Title, Year, Runtime, and Genre]' to white (due to textBox color change upon user edited data save indication below) 
            textBoxYear.BackColor = Color.White;
            textBoxRuntime.BackColor = Color.White;
            textBoxGenre.BackColor = Color.White;
            textBoxTitle.BackColor = Color.White;

            // passes user section through list 'theMovies' and class 'Movie' to display movie info 'aMovie[.title, .year, .runtime, .genre]' 
            Movie selectedMovie = theMovies[comboBoxMovies.SelectedIndex];

            // displays movie info 'aMovie[.title, .year, .runtime, .genre]' in 'textBox[Title, Year, Runtime, and Genre]', respectively  
            textBoxTitle.Text = selectedMovie.title;
            textBoxYear.Text = selectedMovie.year;
            textBoxRuntime.Text = selectedMovie.runtime;
            textBoxGenre.Text = selectedMovie.genre;

            // displays image with matching 'aMovie.id' file name from user selected folder 'imagePath' (passed from class 'Form1')
            pictureBoxMovie.Image = Image.FromFile(imagePath + "/" + selectedMovie.id + ".jpg");
        }
        // method is for event from user click 'buttonSave_Click' // passes user section through list 'theMovies' and class 'Movie' to save movie info 'aMovie[.title, .year, .runtime, .genre]' // checks to see if user updated 'textBox[Title, Year (additional check for valid year input) , Runtime, or Genre]' and changes 'textBox[Title, Year, Runtime, and Genre]' color to LightSteelBlue if user updated respective textBox // adds text in 'textBox[Title, Year, Runtime, and Genre]' to list 'aMovie' // writes movie info 'aMovie[.title, .year, .runtime, .genre]' in 'textBox[Title, Year, Runtime, and Genre]' to corresponding ('aMovie.id' = JSON file name), using user input folder 'jsonPath' // closes writer
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // passes user section through list 'theMovies' and class 'Movie' to save movie info 'aMovie[.title, .year, .runtime, .genre]' 
            Movie selectedMovie = theMovies[comboBoxMovies.SelectedIndex];
            // checks to see if user updated 'textBox[Title, Year (additional check for valid year input) , Runtime, or Genre]' 
            if (textBoxTitle.Text == selectedMovie.title)
            {
            }
            else
            {
                // changes 'textBox[Title, Year, Runtime, and Genre]' color to LightSteelBlue if user updated respective textBox 
                textBoxTitle.BackColor = Color.LightSteelBlue;
            }
            // adds text in 'textBox[Title, Year, Runtime, and Genre]' to list 'aMovie'
            theMovies[comboBoxMovies.SelectedIndex].title = textBoxTitle.Text;

            // checks to see if user updated 'textBox[Title, Year (additional check for valid year input) , Runtime, or Genre]' 
            if (textBoxYear.Text == selectedMovie.year)
            {
            }
            else
            {
                // changes 'textBox[Title, Year, Runtime, and Genre]' color to LightSteelBlue if user updated respective textBox
                textBoxYear.BackColor = Color.LightSteelBlue;
            }
            // adds text in 'textBox[Title, Year, Runtime, and Genre]' to list 'aMovie'
            theMovies[comboBoxMovies.SelectedIndex].year = textBoxYear.Text;

            try
            {
                // additional check for valid year input
                int Year = Int32.Parse(textBoxYear.Text);
                // first movie was made in 1895
                if ((Year) <= 9999 & (Year) >= 1895) 
                {
                }
                // prints error message and ends program
                else
                {
                    // prints error
                    MessageBox.Show("Invalid year input. Please enter a valid year ~ >= 1895 next time");
                }
            }
            catch (Exception ex)
            {
                // prints error
                MessageBox.Show("Please enter a valid year", ex.Message);
            }

            // checks to see if user updated 'textBox[Title, Year (additional check for valid year input) , Runtime, or Genre]'
            if (textBoxRuntime.Text == selectedMovie.runtime)
            {
            }
            else
            {
                // changes 'textBox[Title, Year, Runtime, and Genre]' color to LightSteelBlue if user updated respective textBox
                textBoxRuntime.BackColor = Color.LightSteelBlue;
            }
            // adds text in 'textBox[Title, Year, Runtime, and Genre]' to list 'aMovie'
            theMovies[comboBoxMovies.SelectedIndex].runtime = textBoxRuntime.Text;

            // checks to see if user updated 'textBox[Title, Year (additional check for valid year input) , Runtime, or Genre]'
            if (textBoxGenre.Text == selectedMovie.genre)
            {
            }
            else
            {
                // changes 'textBox[Title, Year, Runtime, and Genre]' color to LightSteelBlue if user updated respective textBox
                textBoxGenre.BackColor = Color.LightSteelBlue;
            }
            // adds text in 'textBox[Title, Year, Runtime, and Genre]' to list 'aMovie'
            theMovies[comboBoxMovies.SelectedIndex].genre = textBoxGenre.Text;

            // writes movie info 'aMovie[.title, .year, .runtime, .genre]' in 'textBox[Title, Year, Runtime, and Genre]' to corresponding ('aMovie.id' = JSON file name), using user input folder 'jsonPath' 
            var jsonObjects = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(theMovies[comboBoxMovies.SelectedIndex], jsonObjects);
            string jsonFile = jsonPath + "/" + theMovies[comboBoxMovies.SelectedIndex].id + ".json";
            StreamWriter jsonWriter = new StreamWriter(jsonFile); 
            jsonWriter.Write(jsonData);
            // closes writer
            jsonWriter.Close(); 
        }
    }
}
