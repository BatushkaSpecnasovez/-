using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double T;
                Console.WriteLine("Введите значение угла α в градусах (0 < α < 360):");
                T = double.Parse(Console.ReadLine());
                if ((T>0) || (T<360))
                {
                    T = T / 180;
                    Console.WriteLine("Значение в радианах=" + T);
                }
                Environment.Exit(0);
                



            }
        }
    }
}
