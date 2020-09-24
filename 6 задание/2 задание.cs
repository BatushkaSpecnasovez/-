using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
			double a, b, c, d, y, x;
			Console.WriteLine("Введите значение А:");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите значение B:");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите значение C:");
			c = Convert.ToDouble(Console.ReadLine());
			d = a;
			y = b;
			x = c;
			b = d;
			c = y;
			a = x;
			Console.WriteLine("Значение А:" + a);
			Console.WriteLine("Значение B:" + b);
			Console.WriteLine("Значение C:" + c);
		}
    }
}
