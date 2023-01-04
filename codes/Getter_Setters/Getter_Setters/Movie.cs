using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_Setters
{
    public class Movie
    {
        //public can be accessed by everyone
        public string title;
        public string director;
        private string rating;   //only code that is contain in the movie class can use

        //creating a constructor
        public Movie(string aTitle, string aDirector, string aRating) //(string title, string driector, rating) olarak da yazılabilirdi
        {
            title = aTitle;          //this.title = title;
            director = aDirector;    //this.director = director;
            Rating = aRating;        //this.rating = rating;
            //We changed the rating to Rating to set the rating through setter.
        }

        public string Rating
        {
            get { return rating; }    //allows us to get the rating attributes
            set
            {
                if (value == "G" || value == "PG-13" || value == "R" || value == "R")  //value represents whatevet got passed in
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }

        }
    }
}

