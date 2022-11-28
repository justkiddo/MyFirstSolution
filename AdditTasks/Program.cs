
//  3

//Console.WriteLine("Enter number \n");

//int num1 = Convert.ToInt32(Console.ReadLine());
//int[] numArray = new int[num1];
//int index;

//for (int i =0 ;i<numArray.Length ; i++ )
//{
//    numArray[i] = (i + 1);

//}

//for (int i = 2; i < numArray.Length; i++)
//{
//    if (numArray[i]%2 ==0) // 2 del
//    {
//        index = i;

//        for (int j = index; j < numArray.Length - 1; j++)
//        {
//            numArray[j] = numArray[j + 1];

//        }
//        Array.Resize(ref numArray, numArray.Length - 1);
//    }
//    else
//    {

//    }

//}

//for (int i = 3; i < numArray.Length; i++)
//{
//    if ( numArray[i] % 3 == 0 )   //3 del
//    {
//        index = i;

//        for (int j = index; j < numArray.Length - 1; j++)
//        {
//            numArray[j] = numArray[j + 1];

//        }
//        Array.Resize(ref numArray, numArray.Length - 1);
//    }
//    else
//    {

//    }



//}

//for (int i = 5; i < numArray.Length; i++)
//{
//    if (numArray[i] % 5 == 0)   //5 del
//    {
//        index = i;

//        for (int j = index; j < numArray.Length - 1; j++)
//        {
//            numArray[j] = numArray[j + 1];

//        }
//        Array.Resize(ref numArray, numArray.Length - 1);
//    }
//    else
//    {

//    }
//}

//for (int i = 7; i < numArray.Length; i++)
//{
//    if (numArray[i] % 7 == 0)   //7 del
//    {
//        index = i;

//        for (int j = index; j < numArray.Length - 1; j++)
//        {
//            numArray[j] = numArray[j + 1];

//        }
//        Array.Resize(ref numArray, numArray.Length - 1);
//    }
//    else
//    {

//    }

//}

//for (int i =1; i<numArray.Length; i++)
//{
//    Console.WriteLine(numArray[i]);   // DONE
//}

//  4


Console.WriteLine("Enter number");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = n; i > 0; i--)
{
    int start = 1;
    int sum = 0;
    while (start != i)
    {
        if (i % start == 0) 
        sum += start;
        start++;
    }
    if (sum == i) Console.WriteLine(i+ " is perfect number");
}


//  6


//    Console.WriteLine("Enter count of numbers");

//    int count = Convert.ToInt32(Console.ReadLine());
//    int[] numsAr = new int[count];

//    for (int i = 0 ; i<count ; i++ )
//    {
//    Console.WriteLine("Enter " + (i + 1) + " number");
//    numsAr[i] = Convert.ToInt32(Console.ReadLine());

//    }

//for (int i = 0; i<numsAr.Length; i++)
//{

//    Console.WriteLine((i + 1) + " number is - " + numsAr[i]);
//}