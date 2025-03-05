using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1073 : IExercicio
    {
        public void Executar()
        {
            int N = int.Parse(Console.ReadLine());
            int numerador = 2;

            while (N >= numerador)
            {
                Console.WriteLine(numerador + "^2 = " + Math.Pow(numerador, 2));
                numerador += 2;
            }
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
