using System;
using System.Collections.Generic;
using TrabalhoEsteban;
using TrabalhoEsteban.Exercícios;
using TrabalhoEsteban1071.Exercícios;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, IExercicio> exercicios = new Dictionary<int, IExercicio>
        {
            { 1067, new Exercicio1067() },
            { 1071, new Exercicio1071() },
            { 1072, new Exercicio1072() },
            { 1073, new Exercicio1073() },
            { 1074, new Exercicio1074() },
            { 1075, new Exercicio1075() },
            { 1079, new Exercicio1079() },
            { 1080, new Exercicio1080() },
            { 1094, new Exercicio1094() },
            { 1096, new Exercicio1096() },
            { 1097, new Exercicio1097() },
            { 1116, new Exercicio1116() },
            { 1132, new Exercicio1132() },
            { 1133, new Exercicio1133() },
            { 1142, new Exercicio1142() },
            { 1143, new Exercicio1143() },
            { 1144, new Exercicio1144() },
            { 1151, new Exercicio1151() },
            { 1153, new Exercicio1153() },
            { 1155, new Exercicio1155() },
            { 1156, new Exercicio1156() },
            { 1157, new Exercicio1157() },
        };

        Console.WriteLine("Digite o número do exercício que deseja executar (ex: 1071):");
        int numeroExercicio = int.Parse(Console.ReadLine());

        if (exercicios.ContainsKey(numeroExercicio))
        {
            exercicios[numeroExercicio].Executar();
        }
        else
        {
            Console.WriteLine("Exercício não encontrado.");
        }
    }
}
