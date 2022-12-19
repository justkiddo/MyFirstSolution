﻿using Homework_1._9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_1._9.Classes
{
    internal class Cat : Animal, ICarnivore
    {
        string sound;
        string colour;
        public string typeC { get; set; } = "some carnivore type";
        public string foodC { get; set; } = "some carnivore food";

        public Cat(string sound, string colour)
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

    }
}
