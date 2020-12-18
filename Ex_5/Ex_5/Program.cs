using System;
using System.Globalization;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int codPeca, numPeca;
            float valUniP, total = 0;
            int i = 0;

            while (i < 2)
            {
                Console.WriteLine("Digite o código da peça");
                codPeca = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o quantidade da peça");
                numPeca = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor unitário da peça");
                valUniP = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                total += valUniP * numPeca;
                i++;
            }


            Console.WriteLine("O total é de R${0}", total.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
