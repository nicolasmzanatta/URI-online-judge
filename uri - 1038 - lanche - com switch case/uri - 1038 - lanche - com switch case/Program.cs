using System;
using System.Globalization;

namespace uri___1038___lanche___com_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double precoItem = 0, total;

            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    precoItem = 4.00;
                    break;
                case 2:
                    precoItem = 4.50;
                    break;
                case 3:
                    precoItem = 5.00;
                    break;
                case 4:
                    precoItem = 2.00;
                    break;
                case 5:
                    precoItem = 1.50;
                    break;
                default:   //essa parte nao pede no URI
                    Console.WriteLine("codigo invalido");
                    break;

            }

            total = precoItem * quantidade;

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
