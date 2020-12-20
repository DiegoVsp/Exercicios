using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            string[] v = Console.ReadLine().Split(' ');

            string nome = v[0];
            char sexo = char.Parse(v[1]);
            double idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);


            Console.WriteLine($"Você digitou: Int {n1}");
            Console.WriteLine($"Você digitou: Char {ch}");
            Console.WriteLine($"Você digitou: Double {n2.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Você digitou: String {nome} {sexo} {idade} {altura.ToString("F2" ,CultureInfo.InvariantCulture)}");
        }
    }
}
