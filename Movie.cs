using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        // first step is to create all properties
        
        public List<string> Scenes { get; set; }

        public string Title { get; set; }
        
        public string Category { get; set; }

        public int RunTime { get; set; }

        

        public Movie(string Title, string Category,int RunTime, List<string> Scenes) // so console can display all info
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }
        
        public virtual void PrintInfo()
        {
            Console.WriteLine("Movie info: ");
            Console.WriteLine(Title);
            Console.WriteLine(Category);
            Console.WriteLine(RunTime);
            PrintScenes();
        }
        public void PrintScenes()
        {
            for(int i =0; i< Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i} :{Scenes [i]}");
            }
        }
        public virtual void Play()
        {
            Console.WriteLine("The play method only works on physical media");
        }
        public virtual void Time()
        {

        }
      
        public virtual void Rewind()
        {
            
        }
        public virtual void BlockBuster()
        {

        }

        public virtual void Checkout()
        {

        }
           
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

    }
}
