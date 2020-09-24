using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
			double x, y;
			Console.WriteLine("Введите значение X:");
			x = Convert.ToDouble(Console.ReadLine());
			y = (Math.Pow(3 * x, 6)) - (Math.Pow(6 * x, 2)) - 7;
			Console.WriteLine("Значение Y:" + y);
		}
    }
}
