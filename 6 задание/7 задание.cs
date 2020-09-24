using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, y, x;
            Console.WriteLine("Введите значение A:");
            a = Convert.ToDouble(Console.ReadLine());
            y = a;
            x = Math.Pow(y, 9);
            a = y * y * y * y * y * y * x;
            Console.WriteLine("Значение A^15:" + a);
        }
    }
}
