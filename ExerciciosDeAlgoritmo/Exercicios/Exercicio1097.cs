using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1097 : IExercicio
    {
        public void Executar()
        {
            int I,
                J;
            I = 1;
            J = 7;

            do
            {
                for (int e = 0; e < 3; e++)
                {
                    Console.WriteLine("I=" + I.ToString() + " J=" + J.ToString());
                    J--;
                }
                I += 2;
                J += 5;
            } while (J <= 15);
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
