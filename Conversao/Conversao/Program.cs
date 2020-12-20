using System;

namespace Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Digite três Palavras: ");
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            */

            Console.WriteLine("Digite três Palavras: ");
            string[] vet = Console.ReadLine().Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

        }
    }
}
