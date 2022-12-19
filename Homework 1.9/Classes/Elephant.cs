using Homework_1._9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._9.Classes
{
    internal class Elephant: Animal, IHerbivore
    {
        string sound;
        string colour;
        public string typeH { get; set; } = "some herbivore food";
        public string foodH { get; set; } = "some herbivore food";


        public Elephant(string sound, string colour)
        {
            this.sound = sound;
            this.colour = colour;
        }

        public override void DisplayAnimal()
        {
            Console.WriteLine($"name - {base.GetName()}");
            Console.WriteLine($"number of legs - {base.GetNumOfLegs()}");
            Console.WriteLine($"sound - {sound}");
            Console.WriteLine($"colour - {colour}");
        }

        public void DisplayEatH()
        {
            Console.WriteLine($"this herbivore eats - {foodH}");
            Console.WriteLine($"type of herbivore is - {typeH}");
        }
    }
}
