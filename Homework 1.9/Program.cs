using Homework_1._9.Classes;
using Homework_1._9.Interfaces;



Cat cat = new Cat("meow", "black");
Bear bear = new Bear("rrrrraaarrr", "brown");
Elephant elephant = new Elephant("Pawoooo", "grey");

cat.SetName("kitty");
cat.SetNumOfLegs(4);
cat.typeC = "some carnivore type";
cat.foodC = "some carnivore food";
cat.DisplayAnimal();
cat.DisplayEatC();
Console.WriteLine();

bear.SetName("boris");
bear.SetNumOfLegs(4);
bear.typeC = "some carnivore type";
bear.foodC = "some carnivore food";
bear.foodH = "some herbivore food";
bear.typeH = "some hearbivore type";
bear.DisplayAnimal();
bear.DisplayEatC();
bear.DisplayEatH();
Console.WriteLine();

elephant.SetName("igor");
elephant.SetNumOfLegs(4);
elephant.foodH = "some herbivore food";
elephant.typeH = "some hearbivore type";
elephant.DisplayAnimal();
elephant.DisplayEatH();
