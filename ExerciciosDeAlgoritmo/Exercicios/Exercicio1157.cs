using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1157 : IExercicio
    {
        public void Executar()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Tecle enter para fechar ...");
                Console.ReadLine();
            }
        }
    }
}
