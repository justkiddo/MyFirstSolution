


//1
//Console.WriteLine("Enter number");
//int number = Convert.ToInt32(Console.ReadLine());

//if(number>=0 && number <= 30)
//{
//    Console.WriteLine("From 0 to 30");
//}else if (number>=31 && number<=60)
//{
//    Console.WriteLine("From 30 to 60");
//}else if (number >= 61 && number <= 100)
//{
//    Console.WriteLine("From 60 to 100");
//}
//else
//{
//    Console.WriteLine("Я такого числа не знаю");
//}

//2

int i = 200;
string res = "";
do
{
    if (i % 17 == 0)
    {
        res += i+"," ;
    }
    i++;
} while (i<500);
Console.WriteLine(res);


//3

