using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoEsteban.Exercícios
{
    public class Exercicio1067 : IExercicio
    {
        public void Executar()
        {
            int X = int.Parse(Console.ReadLine());
            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
