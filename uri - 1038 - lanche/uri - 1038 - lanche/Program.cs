using System;
using System.Globalization;

namespace uri___1038___lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double precoItem, total;

            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1) {
                precoItem = 4.00;
            }
            else if (codigo == 2) {
                precoItem = 4.50;
            }
            else if (codigo == 3) {
                precoItem = 5.00;
            }
            else if (codigo == 4) {
                precoItem = 2.00;
            }
            else {
                precoItem = 1.50;
            }

            total = precoItem * quantidade;

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
