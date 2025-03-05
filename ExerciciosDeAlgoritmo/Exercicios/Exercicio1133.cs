using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1133 : IExercicio
    {
        public void Executar()
        {
            int X,
                Y;
            int maior,
                menor,
                total;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X > Y)
            {
                maior = X;
                menor = Y;
            }
            else
            {
                maior = Y;
                menor = X;
            }

            total = maior - menor - 1;

            for (int i = 0; i < total; i++)
            {
                menor++;
                if (menor % 5 == 2 || menor % 5 == 3)
                {
                    Console.WriteLine(menor);
                }
                Console.WriteLine("Tecle enter para fechar ...");
                Console.ReadLine();
            }
        }
    }
}
