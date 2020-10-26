using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;
            ;
            Console.WriteLine("Введите размер файла в байтах");
            A = int.Parse(Console.ReadLine());
            B = A / 1024;
                Console.WriteLine("Количество килобайт=" + B);

        }
    }
}
