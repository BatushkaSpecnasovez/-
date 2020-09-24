using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string Условие = "Даны два числа a и b. Найти их среднее арифметическое";
            Console.WriteLine(Условие);
            int a, b, z, t, q, i;
            a = 5;
            b = 10;
            z = a + b;
            t = a - b;
            q = a * b;
            i = z ^ 2 / t ^ 2 / q ^ 2;
            Console.WriteLine($"Сумма = {z} Разность = {t} Произведение = {q} Частное их квадратов = {i}");
            Console.ReadKey();
    }
 }
}
