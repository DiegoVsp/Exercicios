using System;
using System.Globalization;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, areaTri, areaCirc, areaQ, areaR, areaTra, pi = 3.14159;            


            Console.WriteLine("Digite um valor para A");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para B");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para c");
            c = float.Parse(Console.ReadLine());

            areaTri = a * c / 2;
            areaCirc = pi * (c * c);
            areaQ = b * b;
            areaR = a * b;
            areaTra = (a + b) / 2.0 * c;

            Console.WriteLine("Área Triângulo: {0}",areaTri.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área Circulo: {0}", areaCirc.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área Quadrado: {0}", areaQ.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área Retângulo: {0}", areaR.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Área Trapézio: {0}", areaTra.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
