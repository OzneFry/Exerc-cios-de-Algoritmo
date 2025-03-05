using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1079 : IExercicio
    {
        public void Executar()
        {
            int N = int.Parse(Console.ReadLine());
            float v1,
                v2,
                v3;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                v1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
                v2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
                v3 = float.Parse(vet[2], CultureInfo.InvariantCulture);

                float m1 = (v1 * 2) / 10;
                float m2 = (v2 * 3) / 10;
                float m3 = (v3 * 5) / 10;

                float mediaFinal = m1 + m2 + m3;

                Console.WriteLine(mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Tecle enter para fechar ...");
                Console.ReadLine();
            }
        }
    }
}
