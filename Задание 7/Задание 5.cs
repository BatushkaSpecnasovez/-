using System;

namespace VISIO
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, S;
            Console.WriteLine("Решить линейное уравнение A·x + B = 0");
            Console.WriteLine("Введите A");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B");
            B = double.Parse(Console.ReadLine());
            B = B * -1;
            S = B / A;
            Console.WriteLine("X равен=" + S);
        }
    }
}
