using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, a, b, c, p, S;
            Console.WriteLine("Введите x1:");
             x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2:");
             x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x3:");
            x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y3:");
            y3 = double.Parse(Console.ReadLine());
            a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            c = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            p = (a + b + c);
            double P = p / 2;
            Console.WriteLine("Периметр =" +p);
            double a1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double b1 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double c1 = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            S = Math.Sqrt(P * (P - a1)) * (P - b1) * (P - c1);
            Console.WriteLine("Площадь =" + S);
            Console.ReadKey();
        }
    }
}
