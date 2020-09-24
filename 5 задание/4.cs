using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, Perimeter;
            Console.WriteLine("Введите x1:");
            Double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2:");
            Double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            Double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            Double y2 = double.Parse(Console.ReadLine());
            a = Math.Abs(x2 - x1);
            b = Math.Abs(y2 - y1);
            Perimeter = 2 * (a + b);
            Console.WriteLine("Периметр =" + Perimeter);
            double S;
            double a1 = Math.Abs(x2 - x1);
            double b1 = Math.Abs(y2 - y1);
            S = a1 * b1;
            Console.WriteLine("Площадь =" + S);
            Console.ReadKey();
        }
    }
}
