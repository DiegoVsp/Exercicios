using System;

namespace EstruturaCond
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            Console.WriteLine("Qual a hora atual? ");
            hora = int.Parse(Console.ReadLine());

            if(hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }else if(hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }else
            {
                Console.WriteLine("Boa Noite!");
            }

        }
    }
}
