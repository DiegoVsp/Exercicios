using System;

namespace Ex_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite o n1");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o n2");
            n2 = int.Parse(Console.ReadLine());

            if (n1 % n2 == 0 || n2%n1==0)
            {
                Console.WriteLine("São Multiplos");
            }else
            {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}
