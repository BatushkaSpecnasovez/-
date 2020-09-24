using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Условие = "Даны два числа a и b. Найти их сумму, разность, произведение и частное их модулей";
            Console.WriteLine(Условие);
            int a, b, z, t, q, i;
            a = 5;
            b = 10;
            z = a + b;
            t = a - b;
            q = a * b;
            i = Math.Abs(z) / Math.Abs(t) / Math.Abs(q);
            Console.WriteLine($"Сумма = {z} Разность = {t} Произведение =  {q} Частное их модулей = {i}");
        }
    }
}
