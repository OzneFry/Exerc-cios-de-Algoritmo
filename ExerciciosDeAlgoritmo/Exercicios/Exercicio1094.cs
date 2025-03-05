using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban1071.Exercícios
{
    public class Exercicio1094 : IExercicio
    {
        public void Executar()
        {
            int N = int.Parse(Console.ReadLine());

            int rato = 0;
            int sapo = 0;
            int coelho = 0;

            int total = 0;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int Quantia = int.Parse(vet[0]);
                char Tipo = char.Parse(vet[1]);

                total += Quantia;

                if (Tipo == 'R')
                {
                    rato += Quantia;
                }
                else if (Tipo == 'S')
                {
                    sapo += Quantia;
                }
                else
                {
                    coelho += Quantia;
                }
            }

            double porcentagemRato = (rato * 100.00) / total;
            double porcentagemSapo = (sapo * 100.00) / total;
            double porcentagemCoelho = (coelho * 100.00) / total;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine(
                "Percentual de coelhos: "
                    + porcentagemCoelho.ToString("F2", CultureInfo.InvariantCulture)
                    + " %"
            );
            Console.WriteLine(
                "Percentual de ratos: "
                    + porcentagemRato.ToString("F2", CultureInfo.InvariantCulture)
                    + " %"
            );
            Console.WriteLine(
                "Percentual de sapos: "
                    + porcentagemSapo.ToString("F2", CultureInfo.InvariantCulture)
                    + " %"
            );
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
