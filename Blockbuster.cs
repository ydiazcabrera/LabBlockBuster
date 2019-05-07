using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Blockbuster
    {
        public List<Movie> movies = new List<Movie>();
        

        public Blockbuster()
        {
            List<string> Scene = new List<string> (){ "Meet", "Fall in love", "Move"};
            DVD firstdvd = new DVD("The NoteBook","Romance",90, Scene);
            movies.Add(firstdvd);

            List<string> Scene1 = new List<string>() { "Get Fired", "Fall in love", "Wedding","Mexican wresttling" };
            DVD seconddvd = new DVD("What is your Number?", "Comedy", 90, Scene);
            movies.Add(seconddvd);

            List<string> Scene3 = new List<string>() { "Jump", "Play and kiss", "Cancer" };
            DVD thirddvd = new DVD("A Walk to Remember", "Romance", 120, Scene);
            movies.Add(thirddvd);

            List<string> Scene_a = new List<string>() { "Max gets lost", "Bridget befiends hauk", "Viper gets quished", "Bunny finds the key" };
            VHS firstvsh = new VHS("Secret Life of Pets", "Comedy", 70, Scene_a);
            movies.Add(firstvsh);

            List<string> Scene_b = new List<string>() { "Cinderella makes breakfast", "Fairygodmother gives wish", "Cinderella meets prince", "Glass Slipper" };
            VHS secondvsh = new VHS("Cinderalla", "Disney", 50, Scene_b);
            movies.Add(secondvsh);

            List<string> Scene_c = new List<string>() { "Jasmine and Aladdin meet in the market", "Cave of Wonders", "Prince Aladdin's entrance ", "Carpet ride" };
            VHS thirdvsh = new VHS("Aladdin", "Disney", 70, Scene_c);
            movies.Add(thirdvsh);
        }
        public void PrintMovies()
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"Movie {i} :{movies[i].Title}" );
            }
        }
        public void CheckOut()
        {
            PrintMovies();
            Console.WriteLine("Which move would you like to check out? Please select index.");
            int answer = int.Parse(Console.ReadLine());

           
             movies[answer].PrintInfo();
            
        }
    }
}

//Lastly, create a class named Blockbuster that contains the following code: 
//List<Movie> Movies - this should contain at least 6 movies, 3 DVDs, 3 VHS all your choice
//PrintMovies() - this will print all the movie titles in the Movies list along with their indexes.
//CheckOut() - this will call PrintMovies and ask the user which movie they’d like to check out, get an index from the user, select a movie from the list and PrintInfo on that movie.

