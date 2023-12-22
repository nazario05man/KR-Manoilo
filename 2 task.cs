

using System;
class Square
    {
        // Координати точки
        public int X { get; set; }
        public int Y { get; set; }

        // Сторона квадрата
        public int Side { get; set; }

        // Конструктор для класу Square
        public Square(int x, int y, int side)
        {
            X = x;
            Y = y;
            Side = side;
        }

        // Метод для збільшення сторони квадрата
        public void IncreaseSide(int increaseBy)
        {
            Side += increaseBy;
        }
    }

    class Cub : Square
    {
        // Висота куба
        public int Height { get; set; }

        // Конструктор для класу Cub
        public Cub(int x, int y, int side, int height) : base(x, y, side)
        {
            Height = height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створюємо об'єкт класу Square
            Square square = new Square(1, 2, 3);

            // Виводимо початкові дані про квадрат
            Console.WriteLine("Квадрат:");
            PrintSquareInfo(square);

            // Збільшуємо сторону квадрата
            square.IncreaseSide(2);

            // Виводимо дані після збільшення сторони
            Console.WriteLine("\nКвадрат після збільшення сторони:");
            PrintSquareInfo(square);

            // Створюємо об'єкт класу Cub
            Cub cub = new Cub(1, 2, 3, 4);

            // Виводимо початкові дані про куб
            Console.WriteLine("\nКуб:");
            PrintCubInfo(cub);

            // Збільшуємо сторону куба за допомогою методу збільшення сторони з класу Square
            cub.IncreaseSide(2);

            // Виводимо дані після збільшення сторони куба
            Console.WriteLine("\nКуб після збільшення сторони:");
            PrintCubInfo(cub);
        }

        // Допоміжна функція для виведення інформації про квадрат
        static void PrintSquareInfo(Square square)
        {
            Console.WriteLine($"Координати: ({square.X}, {square.Y})");
            Console.WriteLine($"Сторона: {square.Side}");
        }

        // Допоміжна функція для виведення інформації про куб
        static void PrintCubInfo(Cub cub)
        {
            PrintSquareInfo(cub); // Викликаємо метод для виведення інформації про квадрат
            Console.WriteLine($"Висота куба: {cub.Height}");
        }
    }
