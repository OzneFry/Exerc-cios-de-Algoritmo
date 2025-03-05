using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1074 : IExercicio
    {
        public void Executar()
        {
            int N = int.Parse(Console.ReadLine());
            int X;

            for (int e = 0; e < N; e++)
            {
                X = int.Parse(Console.ReadLine());
                if (X == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (X < 0)
                {
                    if (X % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
                else
                {
                    if (X % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
            }
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
