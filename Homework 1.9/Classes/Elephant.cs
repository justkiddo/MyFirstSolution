using Homework_1._9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._9.Classes
{
    internal class Elephant: Animal, IHerbivore, IEquatable<Elephant>
    {
        string sound;
        string colour;
        public string typeH { get; set; } = "some herbivore food";
        public string foodH { get; set; } = "some herbivore food";

        public int size;

        public Elephant(string sound, string colour, int size)
        {
            this.sound = sound;
            this.colour = colour;
            this.size = size;
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

        public bool Equals(Elephant? eleph)
        {
            if (eleph == null) return false;
            if(this.GetType() != eleph.GetType()) return false;
            Elephant other = (Elephant)eleph;

            if (this.size > other.size)
            {
                Console.WriteLine(this.GetName());
                return true;
            }else {
                Console.WriteLine(other.GetName());
                return false;
            }
        }
    }
}
