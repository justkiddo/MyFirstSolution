

//1.Дана целочисленная последовательность.Извлечь из нее все четные 
//    отрицательные числа, поменяв порядок извлеченных чисел на обратный.


using Homework_1._15;
using System;

var intArr = new int[] {-5,-6,-8,-4,4,6,8,9,5,3,1,7,11,-29,-34};


IEnumerable<int> intFilter = intArr.Where(w => w < 0 && w % 2 == 0).Reverse();

foreach (int num in intFilter)
{
    Console.WriteLine(num);
}

//2.Дана последовательность непустых строк A. Получить последовательность символов, каждый элемент 
//    которой является начальным символом соответствующей строки
//из A. Порядок символов должен быть обратным по отношению к порядку элементов исходной последовательности.




var stringArr = new string[] {"first", "second", "third", "forth", "fifth", "etc" };

IEnumerable<string> sFilter = stringArr.Select(w => w.First().ToString()).Reverse();


foreach (string s in sFilter)
{
    Console.WriteLine(s);
}

//3.Исходная последовательность содержит сведения о
//клиентах фитнес-центра. Каждый элемент последовательности включает следующие целочисленные поля:
//< Год > < Номер месяца > < Продолжительность
//занятий(в часах) > < Код клиента >
//Определить год, в котором суммарная продолжительность
//занятий всех клиентов была наибольшей, и вывести этот год
//и наибольшую суммарную продолжительность. Если таких
//годов было несколько, то вывести наименьший из них. 



List<Clients> clients = new List<Clients>() { new (11, 2015, 12, 45),
                                              new (13, 2015, 5, 45),
                                              new (51, 2016, 6, 46),
                                              new (61, 2017, 7, 47),
                                              new (11, 2016, 3, 48),
                                              new (15, 2016, 5, 55)
};



var groupedCl = clients.GroupBy(y => y.year).Select(group => new Clients
{
    year = group.Key,
    duration = group.Sum(d => d.duration)
});

var folteredCl = groupedCl.Where(d => d.duration == groupedCl.Max(d => d.duration));

foreach (Clients c in folteredCl)
{
    Console.WriteLine(c.ToString());
}
