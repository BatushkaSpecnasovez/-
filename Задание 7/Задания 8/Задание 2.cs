using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;
            ;
            Console.WriteLine("Введите целое положительное число А");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое положительное число  Б");
            B = int.Parse(Console.ReadLine());
            if ((A > 0 && B > 0 && A > B))
            {
                X = A / B;
                Console.WriteLine("Количество отрезков Б=" + X);

            }
            Environment.Exit(0);
        }
    }
}
