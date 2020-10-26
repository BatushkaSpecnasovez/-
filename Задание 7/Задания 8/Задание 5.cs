using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, x, z, t, T, y;
            Console.WriteLine("Введите целое трехзначное положительное число А");
            a = int.Parse(Console.ReadLine());
            x = a / 100;
            z = x * 100;
            t = a - z;
            T = t * 10;
            y = T + x;
            Console.WriteLine("Число после перестановки" + y);
        }
    }
}
