using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            double A1, B1, C1, A2, B2, C2, X,Y;
            Console.WriteLine("Решить линейное уравнение ");
            Console.WriteLine("Введите A1");
            A1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B1");
            B1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите C1");
            C1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите A2");
            A2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B2");
            B2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите C2");
            C2 = double.Parse(Console.ReadLine());
            X = (B1 * C2 - B2 * C1) / (A2 * B1 - A1 * B2);

            Y = (A2 * C1 - A1 * C2) / (A2 * B1 - A1 * B2);

            Console.WriteLine("X равен=" + X);
            Console.WriteLine("Y равен=" + Y);
        }
    }
}
