using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1080 : IExercicio
    {
        public void Executar()
        {
            int numero,
                maior,
                posicao;

            maior = 0;
            posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero > maior)
                {
                    maior = numero;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
