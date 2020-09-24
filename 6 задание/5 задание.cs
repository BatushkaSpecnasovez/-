using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            y = 4 * (Math.Pow(x - 3, 6)) - 7 * (Math.Pow(x - 3, 3)) + 2;
            Console.WriteLine("Значение Y:" + y);
        }
    }
}
