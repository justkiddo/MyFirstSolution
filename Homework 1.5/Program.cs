
//1

//int[] newArr = new int[6];      //A
//Console.WriteLine($"Enter numbers {Environment.NewLine}");    



//for (int i = 0; i<newArr.Length; i++)        //Б
//{
//    newArr[i] = Convert.ToInt32(Console.ReadLine());
//}


//for(int i=0; i < newArr.Length; i++)
//{
//    for (int j= i+1 ;j<newArr.Length; j++)
//    {
//        int tempNum;
//        if (newArr[i] < newArr[j])
//        {
//            tempNum = newArr[i];
//            newArr[i] = newArr[j];
//            newArr[j] = tempNum;
//        }

//    }
//}


//for (int i = 0; i < newArr.Length; i++)     //B
//{
//    Console.WriteLine($"{Environment.NewLine}{newArr[i]}");
//}

//2

//Random rnd = new Random();

int[,] newArr2 = new int[,] { { 1, 2, 3 },{ 4, 5, 6 } }; //A

//int[,] newArr2 = new int[3,3];
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        newArr2[i, j] = rnd.Next(4, 500);
//    }
//}

int rows = newArr2.GetUpperBound(0) + 1; //2
Console.WriteLine($"{rows} rows");
int columns = newArr2.Length / rows; //3
Console.WriteLine($"{columns} columns");
int max1 = newArr2[0,0], max2 = newArr2[1, 0];



for (int i = 0; i < rows; i++)
{

    for(int j = 0; j < columns; j++)
    {
        Console.WriteLine(newArr2[i, j]);
        Console.WriteLine();
        if (newArr2[0, j] > max1)
        {
            max1 = newArr2[0, j];
        }else if (newArr2[1, j] > max2)
        {
            max2 = newArr2[1, j];
        }

    }

}

Console.WriteLine($" { max1}  { max2}"); //Б