using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1153 : IExercicio
    {
        public void Executar()
        {
            int N = int.Parse(Console.ReadLine());
            long fatorial;
            int cont;

            fatorial = N;
            cont = N;
            for (int i = 1; i < cont; i++)
            {
                N--;
                fatorial *= N;
            }

            Console.WriteLine(fatorial);
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
