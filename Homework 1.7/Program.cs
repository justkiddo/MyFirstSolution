using Homework_1._7.Classes;
using Homework_1._7.Classes._3;



// 1 ___________________________________________
Item it1 = new Item();
it1.GetName();
it1.SetName("печенье");
it1.GetName();
Console.WriteLine();

// 2 _____________________________________________________


Transport car = new Car(40);
Transport plane = new Plane(15);
car.Move();
Console.WriteLine();
plane.Move();
Console.WriteLine();

// 3 ______________________________________________________ 
Bag bag = new Bag();
bag.OpenClose();
Item it2 = new Item();
it2.SetName("ключи");
Item it3 = new Item();
it3.SetName("бумажник");
Item it4 = new Item();
it4.SetName("еще чето");
bag.AddItem(it1);
bag.AddItem(it2);
bag.AddItem(it3);
bag.AddItem(it4);

bag.ShowItems();