using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1156 : IExercicio
    {
        public void Executar()
        {
            double S = 0;
            double par = 1;
            double impar = 1;

            while (impar != 39)
            {
                S += impar / par;
                impar += 2;
                par += par;
            }

            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
