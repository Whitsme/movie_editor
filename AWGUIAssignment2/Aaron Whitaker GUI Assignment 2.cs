// Aaron Whitaker
// Winter 2022
// CIS 207
// GUI Assignment 2: Main window for user selection of JSON and Image folders, and to open 'MovieEditor' window

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIAssignment2
{   
    // sets class 
    public partial class Form1 : Form
    {
        // Random for use with scrolling text and images below
        Random rnd = new Random();
        // place holder for 'jsonFolderPath'
        string jsonFolderPath;
        // place holder for 'imageFolderPath'
        string imageFolderPath;
        // sets .lenght count start point for scrolling vertical text below
        int scrollCountSlow = 20;
        int scrollCountFast = 20;
        int scrollCountMedium = 20;

        
        // initialized the form
        public Form1()
        {
            InitializeComponent();
        }
        // method is for event from user click 'buttonJSON_Click' // opens computer folder browser for folder selection // sets 'jsonFolderPath' to user selected folder // starts timers for vertical scrolling texts for random file path of files in user selected folder // calls 'TextBoxJsonSlow', 'TextBoxJsonFast', 'TextBoxJsonMedium' methods for scrolling vertical text when timer intervals are reached
        private void buttonJSON_Click(object sender, EventArgs e)
        {
            // opens computer folder browser for folder selection 
            folderBrowserDialogJSON.ShowDialog();
            // sets 'jsonFolderPath' to user selected folder 
            jsonFolderPath = folderBrowserDialogJSON.SelectedPath;
            // starts timers for vertical scrolling texts for random file path of files in user selected folder
            timerJsonSlow.Start();
            timerJsonFast.Start();
            timerJsonMedium.Start();
            // calls 'TextBoxJsonSlow' method for scrolling vertical text when timer interval is reached
            timerJsonSlow.Tick += new EventHandler(TextBoxJsonSlow);
            // calls 'TextBoxJsonFast' method for scrolling vertical text when timer interval is reached
            timerJsonFast.Tick += new EventHandler(TextBoxJsonFast);
            // calls 'TextBoxJsonMedium' method for scrolling vertical text when timer interval is reached
            timerJsonMedium.Tick += new EventHandler(TextBoxJsonMedium);
        }
        // Method 'TextBoxJsonSlow' for control over the slowly scrolling vertical text // stops 'timerJsonSlow' // passes files in user selected folder to string array // selects random file path in user selected folder // selects next character in file path and scrolls to that selection for vertical scrolling affect // increases scroll count by one // checks to see if the entire file path has been displayed and resets 'textBox1', 'textBox6', 'textBox8', and 'scrollCountSlow' if it is // sets 'timerJsonSlow' to 300 and starts 'timerJsonSlow'
        private void TextBoxJsonSlow(object sender, EventArgs e)
        {
            // stops 'timerJsonSlow'
            timerJsonSlow.Stop();                    
            try
            {
                // passes files in user selected folder to string array
                string[] files = Directory.GetFiles(jsonFolderPath);
                // selects random file path in user selected folder
                textBox1.Text = files[rnd.Next(files.Length)];
                // selects next character in file path 
                textBox1.SelectionStart = scrollCountSlow;
                // scrolls to above selection for vertical scrolling affect
                textBox1.ScrollToCaret();

                // selects random file path in user selected folder
                textBox6.Text = files[rnd.Next(files.Length)];
                // selects next character in file path 
                textBox6.SelectionStart = scrollCountSlow;
                // scrolls to above selection for vertical scrolling affect
                textBox6.ScrollToCaret();

                // selects random file path in user selected folder
                textBox8.Text = files[rnd.Next(files.Length)];
                // selects next character in file path 
                textBox8.SelectionStart = scrollCountSlow;
                // scrolls to above selection for vertical scrolling affect
                textBox8.ScrollToCaret();
            }
            catch (Exception ex)
            {                    
                MessageBox.Show(ex.Message);                    
            }
            // increases scroll count by one 
            scrollCountSlow += 1;
            // checks to see if the entire file path has been displayed 
            if (scrollCountSlow <= jsonFolderPath.Length)
            {
            }
            else
            {
                // resets 'textBox1'
                textBox1.ResetText();
                // resets 'textBox6'
                textBox6.ResetText();
                // resets 'textBox8'
                textBox8.ResetText();
                // resets 'scrollCountSlow'
                scrollCountSlow = 20;
            }
            // sets 'timerJsonSlow' to 300
            timerJsonSlow.Interval = 300;
            // starts 'timerJsonSlow'
            timerJsonSlow.Start();               
        }
        // Method 'TextBoxJsonFast' for control over the quickly scrolling vertical text // stops 'TextBoxJsonFast' // passes files in user selected folder to string array // selects random file path in user selected folder // selects next character in file path and scrolls to that selection for vertical scrolling affect // increases scroll count by one // checks to see if the entire file path has been displayed and resets 'textBox2', 'textBox4', 'textBox7', 'textBox10', and 'scrollCountFast' if it is // sets 'TextBoxJsonFast' to 300 and starts 'timerJsonFast'
        private void TextBoxJsonFast(object sender, EventArgs e)
        {
            // stops 'TextBoxJsonFast' 
            timerJsonFast.Stop();
            // passes files in user selected folder to string array 
            string[] files = Directory.GetFiles(jsonFolderPath);

            try
            {
                // selects random file path in user selected folder 
                textBox2.Text = files[rnd.Next(files.Length)];
                // selects next character in file path 
                textBox2.SelectionStart = scrollCountFast;
                // scrolls to above selection for vertical scrolling affect
                textBox2.ScrollToCaret();

                // selects random file path in user selected folder
                textBox4.Text = files[rnd.Next(files.Length)];
                // selects next character in file path
                textBox4.SelectionStart = scrollCountFast;
                // scrolls to above selection for vertical scrolling affect
                textBox4.ScrollToCaret();

                // selects random file path in user selected folder
                textBox7.Text = files[rnd.Next(files.Length)];
                // selects next character in file path
                textBox7.SelectionStart = scrollCountFast;
                // scrolls to above selection for vertical scrolling affect
                textBox7.ScrollToCaret();

                // selects random file path in user selected folder
                textBox10.Text = files[rnd.Next(files.Length)];
                // selects next character in file path
                textBox10.SelectionStart = scrollCountFast;
                // scrolls to above selection for vertical scrolling affect
                textBox10.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // increases scroll count by one 
            scrollCountFast += 1;
            // checks to see if the entire file path has been displayed  
            if (scrollCountFast <= jsonFolderPath.Length)
            {
            }
            else
            {
                // resets 'textBox2'
                textBox2.ResetText();
                // resets 'textBox4'
                textBox4.ResetText();
                // resets 'textBox7'
                textBox7.ResetText();
                // resets 'textBox10'
                textBox10.ResetText();
                // resets 'scrollCountFast' 
                scrollCountFast = 20;
            }
            // sets 'TextBoxJsonFast' to 100 
            timerJsonFast.Interval = 100;
            // starts 'timerJsonFast'
            timerJsonFast.Start();
        }
        // Method 'TextBoxJsonMedium' for control over the median scrolling vertical text // stops 'timerJsonMedium' // passes files in user selected folder to string array // selects random file path in user selected folder // selects next character in file path and scrolls to that selection for vertical scrolling affect // increases scroll count by one // checks to see if the entire file path has been displayed and resets 'textBox3', 'textBox5', 'textBox9', and 'scrollCountMedium' if it is // sets 'timerJsonMedium' to 300 and starts 'timerJsonMedium'
        private void TextBoxJsonMedium(object sender, EventArgs e)
        {
            // stops 'timerJsonMedium' 
            timerJsonMedium.Stop();
            // passes files in user selected folder to string array 
            string[] files = Directory.GetFiles(jsonFolderPath);

            try
            {
                // selects random file path in user selected folder 
                textBox3.Text = files[rnd.Next(files.Length)];
                // selects next character in file path  
                textBox3.SelectionStart = scrollCountMedium;
                // scrolls to above selection for vertical scrolling affect
                textBox3.ScrollToCaret();

                // selects random file path in user selected folder
                textBox5.Text = files[rnd.Next(files.Length)];
                // selects next character in file path 
                textBox5.SelectionStart = scrollCountMedium;
                // scrolls to above selection for vertical scrolling affect
                textBox5.ScrollToCaret();

                // selects random file path in user selected folder
                textBox9.Text = files[rnd.Next(files.Length)];
                // selects next character in file path 
                textBox9.SelectionStart = scrollCountMedium;
                // scrolls to above selection for vertical scrolling affect
                textBox9.ScrollToCaret();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // increases scroll count by one 
            scrollCountMedium += 1;
            // checks to see if the entire file path has been displayed 
            if (scrollCountMedium <= jsonFolderPath.Length)
            {
            }
            else
            {
                // resets 'textBox3'
                textBox3.ResetText();
                // resets 'textBox5'
                textBox4.ResetText();
                // resets 'textBox9'
                textBox9.ResetText();
                // resets 'scrollCountMedium'
                scrollCountMedium = 20;
            }
            // sets 'timerJsonMedium' to 300 
            timerJsonMedium.Interval = 200;
            // starts 'timerJsonMedium'
            timerJsonMedium.Start();
        }

        // method 'PictureBoxTop' for horizontal scrolling effect, right to left, of images located in user selected folder // passes files in user selected folder to string array // suspends form layout // moves pictureBox[1-6] to the right by 1 and checks to see if they have reached 386 (right side under a blank textBox, located over 386 and 16 so that it is not visible to user when images disappear on the right side and reappear on the left side of the form) // if so the pictureBox is moved to 16 (see previous note) and a new random image is placed in said pictureBox // resumes form layout
        private void PictureBoxTop(object sender, EventArgs e)
        {
            // passes files in user selected folder to string array 
            string[] files = Directory.GetFiles(imageFolderPath);

            try
            {
                // suspends form layout 
                SuspendLayout();
                // moves pictureBox to the right by 1  
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                // checks to see if they have reached 386 (right side under a blank textBox, located over 386 and 16 so that it is not visible to user when images disappear on the right side and reappear on the left side of the form)
                if (pictureBox1.Location.X >= 386)
                {
                    // pictureBox is moved to 16 (see previous note above) 
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 370, pictureBox1.Location.Y);
                    // new random image is placed in said pictureBox
                    pictureBox1.ImageLocation = files[rnd.Next(files.Length)];
                }
                // moves pictureBox to the right by 1 
                pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y);
                // checks to see if they have reached 386 (see previous note above)
                if (pictureBox2.Location.X >= 386)
                {
                    // pictureBox is moved to 16 (see previous note above) 
                    pictureBox2.Location = new Point(pictureBox2.Location.X - 370, pictureBox2.Location.Y);
                    // new random image is placed in said pictureBox
                    pictureBox2.ImageLocation = files[rnd.Next(files.Length)];
                }
                // moves pictureBox to the right by 1
                pictureBox3.Location = new Point(pictureBox3.Location.X + 1, pictureBox3.Location.Y);
                // checks to see if they have reached 386 (see previous note above)
                if (pictureBox3.Location.X >= 386)
                {
                    // pictureBox is moved to 16 (see previous note above) 
                    pictureBox3.Location = new Point(pictureBox3.Location.X - 370, pictureBox3.Location.Y);
                    // new random image is placed in said pictureBox
                    pictureBox3.ImageLocation = files[rnd.Next(files.Length)];
                }
                // moves pictureBox to the right by 1 
                pictureBox4.Location = new Point(pictureBox4.Location.X + 1, pictureBox4.Location.Y);
                // checks to see if they have reached 386 (see previous note above)
                if (pictureBox4.Location.X >= 386)
                {
                    // pictureBox is moved to 16 (see previous note above) 
                    pictureBox4.Location = new Point(pictureBox4.Location.X - 370, pictureBox4.Location.Y);
                    // new random image is placed in said pictureBox
                    pictureBox4.ImageLocation = files[rnd.Next(files.Length)];
                }
                // moves pictureBox to the right by 1 
                pictureBox5.Location = new Point(pictureBox5.Location.X + 1, pictureBox5.Location.Y);
                // checks to see if they have reached 386 (see previous note above)
                if (pictureBox5.Location.X >= 386)
                {
                    // pictureBox is moved to 16 (see previous note above) 
                    pictureBox5.Location = new Point(pictureBox5.Location.X - 370, pictureBox5.Location.Y);
                    // new random image is placed in said pictureBox
                    pictureBox5.ImageLocation = files[rnd.Next(files.Length)];
                }
                // moves pictureBox to the right by 1  
                pictureBox6.Location = new Point(pictureBox6.Location.X + 1, pictureBox6.Location.Y);
                // checks to see if they have reached 386(see previous note above)
                if (pictureBox6.Location.X >= 386)
                {
                    // pictureBox is moved to 16 (see previous note above) 
                    pictureBox6.Location = new Point(pictureBox6.Location.X - 370, pictureBox6.Location.Y);
                    // new random image is placed in said pictureBox
                    pictureBox6.ImageLocation = files[rnd.Next(files.Length)];
                }
                // resumes form layout
                ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // method 'PictureBoxBottom' for horizontal scrolling effect, left to right, of images located in user selected folder // passes files in user selected folder to string array // suspends form layout // moves pictureBox[7-12] to the left by 1 and checks to see if they have reached 16 (right side under a blank textBox, located over 16 and 386 so that it is not visible to user when images disappear on the right side and reappear on the left side of the form) // if so the pictureBox is moved to 386 (see previous note) and a new random image is placed in said pictureBox // resumes form layout
        private void PictureBoxBottom(object sender, EventArgs e)
        {
            // passes files in user selected folder to string array 
            string[] files = Directory.GetFiles(imageFolderPath);

            try
            {
                // suspends form layout 
                SuspendLayout();
                // moves pictureBox to the left by 1   
                pictureBox7.Location = new Point(pictureBox7.Location.X - 1, pictureBox7.Location.Y);
                // checks to see if they have reached 16 (right side under a blank textBox, located over 16 and 386 so that it is not visible to user when images disappear on the right side and reappear on the left side of the form)
                if (pictureBox7.Location.X <= 16)
                {
                    // pictureBox is moved to 386 (see previous note) 
                    pictureBox7.Location = new Point(pictureBox7.Location.X + 370, pictureBox7.Location.Y);
                    // new random image is placed in said pictureBox 
                    pictureBox7.ImageLocation = files[rnd.Next(files.Length)];
                }
                // moves pictureBox to the left by 1  
                pictureBox8.Location = new Point(pictureBox8.Location.X - 1, pictureBox8.Location.Y);
                // checks to see if they have reached 16 (see previous note)
                if (pictureBox8.Location.X <= 16)
                {
                    // pictureBox is moved to 386 (see previous note) 
                    pictureBox8.Location = new Point(pictureBox8.Location.X + 370, pictureBox8.Location.Y);
                    // new random image is placed in said pictureBox
                    pictureBox8.ImageLocation = files[rnd.Next(files.Length)];
                }
                // moves pictureBox to the left by 1  
                pictureBox9.Location = new Point(pictureBox9.Location.X - 1, pictureBox9.Location.Y);
                if (pictureBox9.Location.X <= 16)
                {
                    // pictureBox is moved to 386 (see previous note) 
                    pictureBox9.Location = new Point(pictureBox9.Location.X + 370, pictureBox9.Location.Y);
                    // new random image is placed in said pictureBox
                    pictureBox9.ImageLocation = files[rnd.Next(files.Length)];
                }
                // moves pictureBox to the left by 1  
                pictureBox10.Location = new Point(pictureBox10.Location.X - 1, pictureBox10.Location.Y);
                if (pictureBox10.Location.X <= 16)
                {
                    // pictureBox is moved to 386 (see previous note) 
                    pictureBox10.Location = new Point(pictureBox10.Location.X + 370, pictureBox10.Location.Y);
                    // new random image is placed in said pictureBox
                    pictureBox10.ImageLocation = files[rnd.Next(files.Length)];
                }
                // moves pictureBox to the left by 1  
                pictureBox11.Location = new Point(pictureBox11.Location.X - 1, pictureBox11.Location.Y);
                if (pictureBox11.Location.X <= 16)
                {
                    // pictureBox is moved to 386 (see previous note) 
                    pictureBox11.Location = new Point(pictureBox11.Location.X + 370, pictureBox11.Location.Y);
                    // new random image is placed in said pictureBox
                    pictureBox11.ImageLocation = files[rnd.Next(files.Length)];
                }
                // moves pictureBox to the left by 1  
                pictureBox12.Location = new Point(pictureBox12.Location.X - 1, pictureBox12.Location.Y);
                if (pictureBox12.Location.X <= 16)
                {
                    // pictureBox is moved to 386 (see previous note) 
                    pictureBox12.Location = new Point(pictureBox12.Location.X + 370, pictureBox12.Location.Y);
                    // new random image is placed in said pictureBox
                    pictureBox12.ImageLocation = files[rnd.Next(files.Length)];
                }
                // resumes form layout
                ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // method is for event from user click 'buttonImages_Click' // opens computer folder browser for folder selection // sets 'imageFolderPath' to user selected folder // passes files in user selected folder to string array // sets random image from user selected folder to pictureBox[1-12] // starts timer and sets timer to 100 for horizontal scrolling texts for random image in user selected folder // calls 'PictureBoxTop' and 'PictureBoxBottom' methods for scrolling horizontal text when timer intervals are reached
        private void buttonImages_Click(object sender, EventArgs e)
        {
            // opens computer folder browser for folder selection 
            folderBrowserDialogImages.ShowDialog();
            // sets 'imageFolderPath' to user selected folder 
            imageFolderPath = folderBrowserDialogImages.SelectedPath;
            // passes files in user selected folder to string array 
            string[] files = Directory.GetFiles(imageFolderPath);
            try
            {
                // sets random image from user selected folder to pictureBox[1-12]
                pictureBox1.ImageLocation = files[rnd.Next(files.Length)];
                pictureBox2.ImageLocation = files[rnd.Next(files.Length)];
                pictureBox4.ImageLocation = files[rnd.Next(files.Length)];
                pictureBox3.ImageLocation = files[rnd.Next(files.Length)];
                pictureBox8.ImageLocation = files[rnd.Next(files.Length)];
                pictureBox7.ImageLocation = files[rnd.Next(files.Length)];
                pictureBox6.ImageLocation = files[rnd.Next(files.Length)];
                pictureBox5.ImageLocation = files[rnd.Next(files.Length)];
                pictureBox9.ImageLocation = files[rnd.Next(files.Length)];
                pictureBox10.ImageLocation = files[rnd.Next(files.Length)];
                pictureBox11.ImageLocation = files[rnd.Next(files.Length)];
                pictureBox12.ImageLocation = files[rnd.Next(files.Length)];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // starts timer 
            timerImage.Start();
            // sets timer to 100
            timerImage.Interval = 100;
            // calls 'PictureBoxTop' method for scrolling horizontal images when timer intervals are reached
            timerImage.Tick += new EventHandler(PictureBoxTop);
            // calls 'PictureBoxBottom' method for scrolling horizontal images when timer intervals are reached
            timerImage.Tick += new EventHandler(PictureBoxBottom);
        }
        // method is for event from user click 'buttonOpenEditor_Click' // stops timers: 'timerImage',  'timerJsonSlow', 'timerJsonFast', and 'timerJsonMedium' // creates new list 'movieList' using class 'Movie' // makes new 'movieList' equal to passed list from method 'GetCarJSONFromFolder' // checks to see if passed list (from method 'GetCarJSONFromFolder') contains items // if so passes 'movieList', 'imageFolderPath', and 'jsonFolderPath' to class 'MovieEditor' // opens class form window 'MovieEditor'
        private void buttonOpenEditor_Click(object sender, EventArgs e)
        {
            // stops 'timerImage' 
            timerImage.Stop();
            // stops 'timerJsonSlow'
            timerJsonSlow.Stop();
            // stops 'timerJsonFast'
            timerJsonFast.Stop();
            // stops  'timerJsonMedium'
            timerJsonMedium.Stop();
            // creates new list 'movieList' using class 'Movie' 
            List<Movie> movieList = new List<Movie> { };
            // makes new 'movieList' equal to passed list from method 'GetCarJSONFromFolder' 
            movieList = GetCarJSONFromFolder(jsonFolderPath);
            // checks to see if passed list (from method 'GetCarJSONFromFolder') contains items 
            if (movieList.Count > 0)
            {
                // passes 'movieList', 'imageFolderPath', and 'jsonFolderPath' to class 'MovieEditor' 
                MovieEditor openEditor = new MovieEditor(movieList, imageFolderPath, jsonFolderPath);
                // opens class form window 'MovieEditor'
                openEditor.Show();
            }
            else
            {
                // closes program
                Close();   
            }
        }
        // method 'GetCarJSONFromFolder' is for creating and returning a list from JSON files in user selected folder // passes files in user selected folder to string array // creates new list 'movieList' using class 'Movie' // sets item prefix in class 'Movie' to 'oneMovie' // sets place holder for 'jsonData' // loop to add all files in user selected folder to 'movieList' // adds files 'oneMovie' (per 'Movie' class: oneMovie[.id, .title, .year, .runtime, .genre]) from user selected folder to list 'movieList' // returns movieList (called by method 'buttonOpenEditor_Click') 
        static List<Movie> GetCarJSONFromFolder(string jsonDirectory)
        {
            try
            {
                // passes files in user selected folder to string array 
                string[] jsonFiles = Directory.GetFiles(jsonDirectory);
                // creates new list 'movieList' using class 'Movie' 
                List<Movie> movieList = new List<Movie> { };
                // sets item prefix in class 'Movie' to 'oneMovie' 
                Movie oneMovie = new Movie();
                // sets place holder for 'jsonData' 
                string jsonData = "";

                // loop to add all files in user selected folder to 'movieList' 
                foreach (var jsonFile in jsonFiles)
                {
                    // adds files 'oneMovie' (per 'Movie' class: oneMovie[.id, .title, .year, .runtime, .genre]) from user selected folder to list 'movieList'  
                    jsonData = File.ReadAllText(jsonFile);
                    oneMovie = JsonSerializer.Deserialize<Movie>(jsonData);
                    movieList.Add(oneMovie);
                }
                // returns movieList (called by method 'buttonOpenEditor_Click')
                return movieList;
            }
            catch (Exception ex)
            {
                // prints error and returns blank list 'movieList' // when list 'movieList' is called by 'buttonOpenEditor_Click' method there is a check for a blank list that will close the program
                MessageBox.Show("Please select a folder with only JSON files", ex.Message);
                List<Movie> movieList = new List<Movie> { };
                return movieList;
            }
        }
    }
}
