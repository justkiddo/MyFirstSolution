


int[] source = { 5, 4, 7, 2, 9 };
int index = 0;

for (int i = 0; i< source.Length; i++)
{
    Console.WriteLine(source[i]);
}

for (int i = index; i < source.Length - 1; i++)
{
    source[i] = source[i + 1];
}
Array.Resize(ref source, source.Length - 1);


Console.WriteLine(String.Join(", ", source));



//int[] array = new int[3];
//for (int i = 0; i < array.Length; i++)
//{
//    Console.WriteLine("Введите " + i + " число");
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
