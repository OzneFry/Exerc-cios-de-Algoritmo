using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1116 : IExercicio
    {
        public void Executar()
        {
            int N = int.Parse(Console.ReadLine());

            int cont = 0;

            double soma;

            while (cont < N)
            {
                string[] valores = Console.ReadLine().Split();

                int X = int.Parse(valores[0]);
                int Y = int.Parse(valores[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    soma = 0;
                    soma = (double)X / Y;
                    Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
                }
                cont++;
                Console.WriteLine("Tecle enter para fechar ...");
                Console.ReadLine();
            }
        }
    }
}
