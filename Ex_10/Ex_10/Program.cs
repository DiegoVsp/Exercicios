using System;

namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaIni, horaFinal;
            Console.WriteLine("Digite a hora inicial");
            horaIni = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora final do jogo");
            horaFinal = int.Parse(Console.ReadLine());

            if(horaIni < horaFinal)
            {
                Console.WriteLine("O jogo durou {0} horas", horaFinal - horaIni);
            }
            else
            {
                Console.WriteLine("O jogo durou {0} horas", (24 - horaIni) + horaFinal);
            }
        }
    }
}
