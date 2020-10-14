using System;

namespace Visual__сырая_
{
    class Program
    {
        static void Main(string[] args)
        {
            double V1, V2, S, T, z;
            Console.WriteLine("Стоимость конфет в рублях");
            V1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Вес конфет в кг");
            V2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес Y конфет в кг, чтобы узнать ее стоимость");
            S = double.Parse(Console.ReadLine());
            T = V1 / V2;
            z = T * S;
    
            Console.WriteLine("Стоиомть 1 кг" + T);
            Console.WriteLine("Стоимость Y кг" + z);
        }
    }
}
