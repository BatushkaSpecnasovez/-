using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            double V1,V2,S,T,z;
            Console.WriteLine("Скорость первого автомобиля V1");
            V1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Скорость второго автомобиля V2");
            V2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите расстояние между ними S км");
            S = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите время T");
            T = double.Parse(Console.ReadLine());
            z = (S - ((V1 + V2) * T)* -1);
            Console.WriteLine("Расстояния между машинами" + z); 
          
            
          
        }
    }
}
