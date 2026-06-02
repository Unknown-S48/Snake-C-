using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Snake_2D
{
    internal class Settings
    {
        // Declaring the variables for the width and height of the items
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string Directions;
        
        //Creating the constructor for the class
        public Settings ()
        {
            //Setting the default values
            Width = 16;
            Height = 16;
            // This is the direction the snake moves in
            Directions = "left";
        }
    }
}
