using System;
using System.Globalization;

namespace uri___1011___esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R).
            //A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

            double R, volume, pi = 3.14159; 

            R = double.Parse(Console.ReadLine());

            volume = (4.0 / 3.0) * pi * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
