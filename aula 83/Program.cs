using System;
using System.Collections.Generic;

namespace aula_83
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            HashSet<int> Controle = new HashSet<int>();
            Console.Write("O curso A possui quantos alunos? ");
            int resp = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 0; i < resp; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos? ");
            resp = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int i = 0; i < resp; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos? ");
            resp = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < resp; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }
            Controle.UnionWith(A);
            Controle.UnionWith(B);
            Controle.UnionWith(C);
            Console.WriteLine("O total de alunos é {0}", Controle.Count);
        }
    }
}
