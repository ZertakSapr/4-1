using System;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            OneDim<int> arrayint = new OneDim<int>();

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                arrayint.Add(rnd.Next(0, 101));
            }
            arrayint.Print();

            Console.WriteLine("Максимальное значение");
            Console.WriteLine(arrayint.Max());
            Console.WriteLine("Минимальное значение");
            Console.WriteLine(arrayint.Min());
            arrayint.Sort();
            arrayint.Print();
            Console.WriteLine("Перевернутый");
            arrayint.Reverse();
            arrayint.Print();

            OneDim<double> arrayfl = new OneDim<double>();

            for(int i = 0; i < 10; i++)
            {
                arrayfl.Add(rnd.NextDouble() * (200) - 100);
            }
            arrayfl.Print();

            Console.WriteLine("Максимальное значение");
            Console.WriteLine(arrayfl.Max());
            Console.WriteLine("Минимальное значение");
            Console.WriteLine(arrayfl.Min());
            arrayfl.Sort();
            arrayfl.Print();
            Console.WriteLine("Перевернутый");
            arrayfl.Reverse();
            arrayfl.Print();
        }
    }
}

