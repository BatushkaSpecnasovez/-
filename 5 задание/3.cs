using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, sum, sum1, r;
            Console.WriteLine("Введите a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToDouble(Console.ReadLine());
            if ((c <= a) || (c >= b) || (a >= b))
            {
                Console.WriteLine(" А не может быть > или = C");
                Console.WriteLine(" B не может быть > или = C");
                Console.WriteLine(" B не может быть < или = A");
                Environment.Exit(0);
            }
            sum = (b - c);
            sum1 = (b - a);
            r = sum * sum1;
            Console.WriteLine("расстояние между точками b и c =" + sum);
            Console.WriteLine("расстояние между точками a и c =" + sum1);
            Console.WriteLine("Произведение расстояний " + r);
            Console.ReadKey();
        }
    }
}
