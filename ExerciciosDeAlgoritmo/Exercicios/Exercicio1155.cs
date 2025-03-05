using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1155 : IExercicio
    {
        public void Executar()
        {
            double S = 1;

            for (int i = 2; i <= 100; i++)
            {
                S += (double)1 / i;
            }
            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
