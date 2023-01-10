using Homework_1._14.Classes;



Kindergarten kindergarten= new Kindergarten();
School school = new School(kindergarten);

Student st1 = new Student("name1", 6);
Student st2 = new Student("name2", 7);
Student st3 = new Student("name3", 8);
Student st4 = new Student("name4", 9);
Student st5 = new Student("name5", 5);

kindergarten.AddToList(st1);
kindergarten.AddToList(st2);
kindergarten.AddToList(st3);
kindergarten.AddToList(st4);
kindergarten.AddToList(st5);


Console.WriteLine();

kindergarten.GrowUp(Kindergarten.GetList(), School.GetList());
kindergarten.GrowUp(Kindergarten.GetList(), School.GetList());
kindergarten.GrowUp(Kindergarten.GetList(), School.GetList());
kindergarten.GrowUp(Kindergarten.GetList(), School.GetList());