using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Условие = "Дан диаметр окружности. Найти ее длину";
            Console.WriteLine(Условие);
            double L, pi, d;
            d = 5;
            pi = 3.14;
            L = pi * d;
            Console.WriteLine($"Диаметр окружности = {L}");
        }
    }
}
