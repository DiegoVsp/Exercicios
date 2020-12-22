using System;
using System.Globalization;

namespace Ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            double preco = 0;

            Console.WriteLine("Digite o código do item ");
            cod = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade desse item");
            qtd = int.Parse(Console.ReadLine());

            switch (cod)
            {
                case 1:
                    preco = 4 * qtd;
                    break;
                case 2:
                    preco = 4.5 * qtd;
                    break;
                case 3:
                    preco = 5 * qtd;
                    break;
                case 4:
                    preco = 2 * qtd;
                    break;
                case 5:
                    preco = 1.5 * qtd;
                    break;
            }
            Console.WriteLine("Total é R$ {0}", preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
