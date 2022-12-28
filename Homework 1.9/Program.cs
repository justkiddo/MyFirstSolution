using Homework_1._9.Classes;
using Homework_1._9.Interfaces;

Cat cat = new Cat("meow", "black");
Bear bear = new Bear("rrrrraaarrr", "brown");
Elephant elephant1 = new Elephant("Pawoooo", "grey",23);
Elephant elephant2 = new Elephant("Pawoooo", "light-grey", 23);

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

elephant1.SetName("igor1");
elephant2.SetName("igor2");
elephant1.SetNumOfLegs(4);
elephant1.DisplayAnimal();
elephant1.DisplayEatH();
Console.WriteLine();


// 2 (?)

Zoo<ICarnivore> zooCar = new Zoo<ICarnivore>();
Zoo<IHerbivore> zooHerb = new Zoo<IHerbivore>();

zooCar.zooAdd(cat);
zooCar.zooAdd(bear);
zooHerb.zooAdd(elephant1);



//  3
elephant1.Equals(elephant2);
