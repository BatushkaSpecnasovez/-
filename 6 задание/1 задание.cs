using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			double a, b, c, d;
			Console.WriteLine("Введите значение А:");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите значение B:");
			b = Convert.ToDouble(Console.ReadLine());
			c = a;
			d = b;
			a = d;
			b = c;
			Console.WriteLine("Значение А:" + a);
			Console.WriteLine("Значение B:" + b);
		}
	}
}
