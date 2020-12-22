using System;

namespace Ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um´número");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("PAR");
            }else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
