using Homework_1._6.Classes;

//  1

ArrayWorker aw = new ArrayWorker();
int[] ar = new int[] { 12, 3, 11, 64, 2, 5 };

for (int i = 0; i < ar.Length; i++)
{
    Console.WriteLine($"{ar[i]} {i}");
}
Console.WriteLine();
aw.InverseMass(ar);
for (int i = 0; i < ar.Length; i++)
{
    Console.WriteLine($"{ar[i]} {i}");
}
Console.WriteLine();

//  2

Cone cn = new Cone(5, 15);
cn.Area();
Console.WriteLine();
// 3
