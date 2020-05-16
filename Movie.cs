using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class Movie
    {
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public string Title { get; set; }
        public string Category { get; set;  }

        public virtual void GetMovieName()
        {
            Console.WriteLine($"{Title}");
        }
    }
}
