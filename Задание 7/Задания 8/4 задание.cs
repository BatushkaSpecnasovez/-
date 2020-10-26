using System;
using System.Threading.Channels;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,x,z,t,T,y;
            Console.WriteLine("Введите целое двухзначное положительное число А");
            a = int.Parse(Console.ReadLine());
            x = a / 10;
            x = x * 10;
            z = a - x;
            t = x / 10;
            T = z * 10;
            y = t + T;
            
            
            
        
          
            Console.WriteLine("Число после перестановки" + y);
           
        }
        
    }
}
