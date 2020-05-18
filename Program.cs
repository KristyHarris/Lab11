using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {

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


            Console.WriteLine("Welcome to the Movie List!");
            Console.WriteLine($"There are {movieList.Count} movies in this list.\n");
            string input;
            string searchAgain;

            do
            {
                Console.WriteLine("Please enter a choice from one of the following categories - animated, drama, horror, scifi: ");
                input = Console.ReadLine().ToLower();

                if ((input != "animated") && (input != "drama") && (input != "horror") && (input != "scifi"))
                {
                    Console.WriteLine("That is not a valid option.");
                }
                else
                {
                    foreach (var film in movieList)
                        if (film.Category == input)
                        {
                            film.GetMovieName();
                        }
                };

                Console.WriteLine("Would you like to search again? y/n");
                searchAgain = Console.ReadLine().ToLower();
            } while (searchAgain == "y");

            Console.WriteLine("Goodbye!");
            

            
        }
    }
}
