using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1096 : IExercicio
    {
        public void Executar()
        {
            int I,
                J;
            I = 1;

            while (I <= 9)
            {
                J = 7;
                for (int e = 0; e < 3; e++)
                {
                    Console.WriteLine("I=" + I + " J=" + J);
                    J--;
                }
                I += 2;
                Console.WriteLine("Tecle enter para fechar ...");
                Console.ReadLine();
            }
        }
    }
}
