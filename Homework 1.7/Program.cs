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

Bag bag= new Bag();

Console.WriteLine("Введите кол-во обьектов");
int numberOf = Convert.ToInt32(Console.ReadLine());
Item[] items = new Item[numberOf];
for (int i=0; i<numberOf;i++)
{
      items[i] = new Item();
      Console.WriteLine("Введите имя предмета");
      string name = Console.ReadLine();
      items[i].SetName(name);
}
Console.WriteLine();

bag.AddItem(items);
Console.WriteLine();

bag.ShowItems();