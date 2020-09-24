using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, sum, sum1, r;
            Console.WriteLine("Введите a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = Convert.ToDouble(Console.ReadLine());
            if ((b <= a) || (b >= c) || (a >= c))
            {
                Console.WriteLine(" А не может быть > или = B");
                Console.WriteLine(" B не может быть > или = C");
                Console.WriteLine(" C не может быть < или = A");
                Environment.Exit(0);
            }
            sum = (c - b);
            sum1 = (c - a);
            r = sum + sum1;
            Console.WriteLine("расстояние между точками b и c =" + sum);
            Console.WriteLine("расстояние между точками a и c =" + sum1);
            Console.WriteLine("Сумма расстояний = " + r);
            Console.ReadKey();
        }
    }
}
