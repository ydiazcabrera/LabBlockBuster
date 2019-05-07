using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class DVD : Movie
    {
        public DVD (string Title, string Category, int RunTime, List<string> Scenes): base(Title, Category,RunTime, Scenes)
        {

        }
        public override void Play()
        {
            PrintScenes();
            Console.WriteLine("What scene would you like to see?");
            string input=Console.ReadLine();
            int index = int.Parse(input);

            string scene = Scenes[index];
            Console.WriteLine(scene);
        }
    }
}
