using Homework_1._9.Classes;
using Homework_1._9.Interfaces;

Cat cat = new Cat("meow", "black");
Bear bear = new Bear("rrrrraaarrr", "brown");
Elephant elephant = new Elephant("Pawoooo", "grey");

cat.SetName("kitty");
cat.SetNumOfLegs(4);
cat.DisplayAnimal();
cat.DisplayEatC();
Console.WriteLine();

bear.SetName("boris");
bear.SetNumOfLegs(4);
bear.DisplayAnimal();
bear.DisplayEatC();
bear.DisplayEatH();
Console.WriteLine();

elephant.SetName("igor");
elephant.SetNumOfLegs(4);
elephant.DisplayAnimal();
elephant.DisplayEatH();
Console.WriteLine();

Zoo<ICarnivore> zooCar = new Zoo<ICarnivore>();
Zoo<IHerbivore> zooHerb = new Zoo<IHerbivore>();

zooCar.zooAdd(cat);
zooCar.zooAdd(bear);
zooHerb.zooAdd(elephant);