using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoEsteban.Exercícios
{
    public class Exercicio1071 : IExercicio
    {
        public void Executar()
        {
            int X,
                Y,
                min,
                max,
                soma;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                min = X;
                max = Y;
            }
            else
            {
                min = Y;
                max = X;
            }

            soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
