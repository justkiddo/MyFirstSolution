using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_1._9.Interfaces;

namespace Homework_1._9.Classes
{
    internal class Bear : Animal, ICarnivore, IHerbivore
    {
        string sound;
        string colour;
        public string typeC { get; set; } = "default";
        public string foodC { get; set; } = "default";

        public string typeH { get; set; } = "default";
        public string foodH { get; set; } = "default";

        public Bear(string sound, string colour)
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

        public void DisplayEatC()
        {
            Console.WriteLine($"this carnivore eats - {foodC}");
            Console.WriteLine($"type of carnivore is - {typeC}");
        }
        public void DisplayEatH()
        {
            Console.WriteLine($"this herbivore eats - {foodH}");
            Console.WriteLine($"type of herbivore is - {typeH}");
        }
    }
}
