using System;
using System.ComponentModel.Design.Serialization;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Условие = "Даны стороны прямоугольника. Найти его площадь";
            int a, b, S, P;
            a = 10;
            b = 15;
            S = a * b;
                P = 2 * (a + b);
            Console.WriteLine($"Площадь прямоугольника = {S} Периметр прямоугольника = {P}");
            Console.ReadKey();
        }
    }
}
