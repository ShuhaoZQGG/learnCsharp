using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCsharp
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating; // private means only code inside movie class can access this property

        // public means this variable is open to everybody, so technically it is subjected to
        // be changed outside of the class
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        // Getter and Setter
        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                // value is what ever passed into the rating
                // The reason we make this getter and setter because we make the rating Private
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
