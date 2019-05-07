using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> Scenes = new List<string>() { "Capture Leia", "Blow up deathstar", "Pizza" };
            Movie m = new Movie("Space Balls", "Comedy", 120, Scenes);
            m.PrintInfo();
            m.Play();

            List<string> Scenes2 = new List<string>() { "Cantina Scene", "Jeffereson Starship", " Bob" };
            DVD d = new DVD("Star Wars Holiday Special", "Hot Mess", 90, Scenes2);

            d.Play();

            List<string> Scenes3 = new List<string>() { "Arial rescues Eric", "Loose voice", "Boat ride", "Kill Urcela" };
            VHS v = new VHS("The little Mermaid", "Disney", 60, Scenes3);

            v.PrintInfo();
            v.Play();
            Blockbuster b = new Blockbuster();

            b.PrintMovies();
            b.CheckOut();
            Console.Read();

            //        Task: Create your own blockbuster video.Movies will come in 2 different formats: VHS and DVD.

            //What will the application do?
            //Create a Movie class with the following: 
            //A property for Title that’s a string
            //A property for Category that’s a string
            //An int property for RunTime(in minutes)
            //A list of strings called Scenes
            //A virtual method called PrintInfo that prints all properties in the class to the console.
            //A method called PrintScenes() that prints all the scenes in the list along with their index. 
            //Next Create a Child class of movie called VHS and code the following:
            //A property called CurrentTime
            //A method called Play that plays the scene at the current time and then increments CurrentTime.
            //A method called Rewind that returns nothing and sets CurrentTime to 0. 
            //Last create a child of movie named DVD with the following code: 
            //A method called Play that takes no parameters and is void that will ask the user what scene they’d like to watch, print all the available scenes, and allow the user to select a movie from the list.
            //Lastly, create a class named Blockbuster that contains the following code: 
            //List<Movie> Movies - this should contain at least 6 movies, 3 DVDs, 3 VHS all your choice
            //PrintMovies() - this will print all the movie titles in the Movies list along with their indexes.
            //CheckOut() - this will call PrintMovies and ask the user which movie they’d like to check out, get an index from the user, select a movie from the list and PrintInfo on that movie.


            //Extended Exercise: 
            //Create a PlayWholeMovie in both VHS and DVDs to play each scene from start to finish.


        }
}
}
