using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1132 : IExercicio
    {
        public void Executar()
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int soma = 0;
            int maior,
                menor;

            if (X >= Y)
            {
                maior = X;
                menor = Y;
            }
            else
            {
                maior = Y;
                menor = X;
            }

            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
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
