using System;

double Pi = 3.141592653;
const double e = 1.414213562373095048;

Console.WriteLine(Pi + "\n");
Console.WriteLine(e + "\n");

int a = 3;
byte b = (byte)a;

int[] array = new int[3];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("\nEnter " + (i+1) + " number \n");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
double midA = ((double)array[0] + (double)array[1] + (double)array[2]) / array.Length ;

Console.WriteLine("\n" + midA);

Console.WriteLine("\nEnter your name\n");
String yName = "\nHi, " + Console.ReadLine();

Console.WriteLine(yName);
