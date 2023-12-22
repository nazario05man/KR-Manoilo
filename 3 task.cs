using System;
class HelloWorld {
  static void Main() {
    int arraySize = 20;

    Random random = new Random();

    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = random.Next(1, 101); 
    }

    int minIndex = 0;
    int maxIndex = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minIndex])
        {
            minIndex = i;
        }
        else if (array[i] > array[maxIndex])
        {
            maxIndex = i;
        }
    }

    Console.WriteLine("Start array:");
    PrintArray(array);

    int temp = array[minIndex];
    array[minIndex] = array[maxIndex];
    array[maxIndex] = temp;

    Console.WriteLine("\nFinal  array:");
    PrintArray(array);
}

static void PrintArray(int[] arr)
{
    foreach (var element in arr)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}
  
}
