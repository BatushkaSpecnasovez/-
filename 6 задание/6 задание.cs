using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, y;
            Console.WriteLine("Введите значение A:");
            a = Convert.ToDouble(Console.ReadLine());
            y = a;
            a = (Math.Pow(y, 5))*y*y*y;
            Console.WriteLine("Значение A^8:" + a);
        }
    }
}
