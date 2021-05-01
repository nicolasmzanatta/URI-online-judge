using System;
using System.Globalization;

namespace uri___1017___gasto_de_combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, vMed, distancia;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            vMed = int.Parse(Console.ReadLine());

            distancia = tempo * vMed;
            litros = (double) distancia / 12;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
