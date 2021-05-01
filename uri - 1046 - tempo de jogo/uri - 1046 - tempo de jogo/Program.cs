﻿/*Leia a hora inicial e a hora final de um jogo.
A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro,
tendo uma duração mínima de 1 hora e máxima de 24 horas. */

using System;

namespace uri___1046___tempo_de_jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim, duracao;
            string[] vet = Console.ReadLine().Split(' ');

            inicio = int.Parse(vet[0]);
            fim = int.Parse(vet[1]);

           if (inicio < fim) {
                duracao = fim - inicio; 
           }
           else {
                duracao = 24 - inicio + fim;
           }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}
