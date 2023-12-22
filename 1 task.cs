using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();

        int lastPosition = FindLastPositionOfLetterI(input);

        if (lastPosition != -1)
        {
            Console.WriteLine($"Остання позиція букви 'і' у рядку: {lastPosition}");
        }
        else
        {
            Console.WriteLine("Буква 'і' не знайдена у введеному рядку.");
        }
    }

    static int FindLastPositionOfLetterI(string str)
    {
        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (str[i] == 'і' || str[i] == 'І')
            {
                return i + 1; // Позиція починається з 1, а не з 0
            }
        }

        return -1; // Буква 'і' не знайдена
    }
}
