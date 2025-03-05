using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1072 : IExercicio
    {
        public void Executar()
        {
            int N = int.Parse(Console.ReadLine());
            int X = 0;
            int contIn = 0,
                contOut = 0;
            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    contIn++;
                }
                else
                {
                    contOut++;
                }
            }

            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
