// Aaron Whitaker
// Winter 2022
// CIS 207
// GUI Assignment 2: Class used for list

using System;
using System.Collections.Generic;
using System.Text;

namespace GUIAssignment2
{
    // class 'Movie' is used by list 'movieList' in classes 'Form1' and 'MovieEditor'
    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string runtime { get; set; }
        public string genre { get; set; }
    }
}
