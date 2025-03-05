using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1144 : IExercicio
    {
        public void Executar()
        {
            int m1,
                m2;
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                m1 = (int)Math.Pow(i, 2);
                m2 = m1 * i;
                Console.Write(i + " ");
                Console.Write(m1 + " ");
                Console.WriteLine(m2);
                Console.Write(i + " ");
                m1++;
                m2++;
                Console.Write(m1 + " ");
                Console.WriteLine(m2);
            }
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
