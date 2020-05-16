using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            Console.WriteLine("Enter a category: ");
            input = Console.ReadLine().ToLower();

            List<Movie> movieList = new List<Movie>
              {
                  new Movie("Soylent Green", "scifi"),
                  new Movie("Star Trek II : The Wrath of Khan", "scifi"),
                  new Movie("Shrek", "animated"),
                  new Movie("Frozen", "animated"),
                  new Movie("Finding Nemo", "animated"),
                  new Movie("Moonlight", "drama"),
                  new Movie("A Marriage Story", "drama"),
                  new Movie("The Omen", "horror"),
                  new Movie("Holloween", "horror"),
                  new Movie("The Exorcist", "horror")
                  
              };

            int index = movieList.FindIndex(item => item.Category == input);
            if (index >= 0)
            {
                movieList[index].GetMovieName();
               
            }

            //for(int i=0; i < movieList.Count; i++)
            //{
            //    movieList[i].GetMovieName();
            //}

            //Console.WriteLine("Welcome to the Movie List!");
            //string input;

            //do
            //{
            //    Console.WriteLine("Please pick from the following categories: animated, scifi, drama, horror");
            //    input = Console.ReadLine().ToLower();
            //} while (input != validInput);








            //foreach(var film in movieList)
            //{
            //    if( string ==)
            //}




            //string input;

            //do
            //{
            //Console.WriteLine("");
            //input = Console.ReadLine();
        }
    }
}
