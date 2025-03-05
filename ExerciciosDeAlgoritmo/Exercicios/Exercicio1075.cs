using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1075 : IExercicio
    {
        public void Executar()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % N == 2)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Tecle enter para fechar ...");
                Console.ReadLine();
            }
        }
    }
}
