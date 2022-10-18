// Aaron Whitaker
// Winter 2022
// CIS 207
// GUI Assignment 2: Main program that opens main window

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIAssignment2
{
    // main class that runs the program // calls run for class 'Form1'
    static class Program
    {      
        [STAThread]
        // 'Main' method // calls run for class 'Form1'
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // calls run for class 'Form1'
            Application.Run(new Form1());
        }
    }
}
