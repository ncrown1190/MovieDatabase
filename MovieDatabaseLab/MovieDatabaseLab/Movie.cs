using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    internal class Movie
    {
        /* ild Specifications:
        Build a Movie class with two member variables:  title and category. 
        Both of these should be strings. The class should also provide a constructor 
        that accepts a title and category as parameters and uses the values passed 
        in to initialize the member variables.
        - Class has member variables of the correct type —2  points total
        - Class has constructor—1 point
         */
        public string Title;
        public string Category;

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
