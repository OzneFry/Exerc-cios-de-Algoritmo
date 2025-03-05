using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1142 : IExercicio
    {
        public void Executar()
        {
            int N = int.Parse(Console.ReadLine());
            int cont = 0;
            int linhas = N * 4;

            for (int i = 1; i <= linhas; i++)
            {
                cont++;
                if (cont % 4 != 0)
                {
                    Console.Write(cont + " ");
                }
                else
                {
                    Console.WriteLine("PUM");
                }
                Console.WriteLine("Tecle enter para fechar ...");
                Console.ReadLine();
            }
        }
    }
}
