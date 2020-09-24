using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Условие = "Даны два числа a и b. Найти их среднее арифметическое";
            Console.WriteLine(Условие);
            int a, b, z;
            a = 5;
            b = 10;
            z = (a + b) / 2;
            Console.WriteLine($"Среднее арифметическое = {z}");

        }
    }
}
