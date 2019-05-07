using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, string Category, int RunTime, List<string> Scene) : base(Title, Category, RunTime, Scene)
        {
            CurrentTime = 0;
        }

        public override void Play()
        {

            string sc = Scenes[CurrentTime];

            Console.WriteLine(sc);
            CurrentTime++;                
        }
        public override void Rewind()
        {
            CurrentTime = 0;
            
        }




        //A property called CurrentTime
        //A method called Play that plays the scene at the current time and then increments CurrentTime.
        //A method called Rewind that returns nothing and sets CurrentTime to 0. 
    }
}


