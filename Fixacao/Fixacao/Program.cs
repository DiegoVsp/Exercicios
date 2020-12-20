using System;
using System.Globalization;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto, ultNome;
            int nQuarto, idade;
            double precoProd, altura;

            Console.WriteLine("Entre com seu nome completo: ");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            nQuarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preco de um produto");
            precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string[] vetor = Console.ReadLine().Split(' ');

            ultNome = vetor[0];
            idade = int.Parse(vetor[1]);
            altura = double.Parse(vetor[2],CultureInfo.InvariantCulture);

            Console.WriteLine($"nome completo {nomeCompleto}");
            Console.WriteLine($"número de quartos {nQuarto}");
            Console.WriteLine($"preco Produto {precoProd.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{ultNome} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
