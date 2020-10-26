using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            float X;
            ;
            Console.WriteLine("Введите целое положительное число А");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое положительное число  Б");
            B = int.Parse(Console.ReadLine());
            if ((A > 0 && B > 0 && A > B))
            {
                X = A;
                while (X > B)
                { 
                  X=X - B;
                   
                }
                Console.WriteLine("Длина незанятой части отрезка =" + X);

            }
            Environment.Exit(0);
        }
    }
}
