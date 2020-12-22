using System;

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Digite um número");
                n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Número negativo");
            }else
            {
                Console.WriteLine("Número Positivo");
            }
        }
    }
}
