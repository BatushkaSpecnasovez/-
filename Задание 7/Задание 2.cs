using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double T;
            Console.WriteLine("Дано значение угла α в радианах (0 < α < 2·π");
            T = double.Parse(Console.ReadLine());
            if ((T > 0) && (T < 360))
            {
                T = T * 180;

                while ((T > 360))
                {
                    T = T - 360;
                }
                Console.WriteLine("Значение в градусах=" + T);
            }
            Environment.Exit(0);
        }
    }
}