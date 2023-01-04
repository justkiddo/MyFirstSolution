using Homework_1._14.Classes;



Kindergarten kindergarten= new Kindergarten();
School school = new School(kindergarten);

Students st1 = new Students("name1", 6);
Students st2 = new Students("name2", 7);
Students st3 = new Students("name3", 8);
Students st4 = new Students("name4", 9);
Students st5 = new Students("name5", 5);

kindergarten.AddToList(st1);
kindergarten.AddToList(st2);
kindergarten.AddToList(st3);
kindergarten.AddToList(st4);
kindergarten.AddToList(st5);


Console.WriteLine();

kindergarten.GrowUp(Kindergarten.kindList, School.schoolStud);
kindergarten.GrowUp(Kindergarten.kindList, School.schoolStud);
kindergarten.GrowUp(Kindergarten.kindList, School.schoolStud);
kindergarten.GrowUp(Kindergarten.kindList, School.schoolStud);