using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace uri_1010
    {
    internal class Program
        {
        static void Main(string [] args)
            {

            string [] compra = Console.ReadLine().Split(' ');
                int codigoPeca_1 = int.Parse(compra[0]);
                int numeroPeca1 = int.Parse(compra[1]);
                double valorPeca_1 = double.Parse(compra[2],CultureInfo.InvariantCulture);

            string [] compra1 = Console.ReadLine().Split(' ');
                int codigoPeca_2 = int.Parse(compra1 [ 0 ]);
                int numeroPeca2 = int.Parse(compra1 [ 1 ]);
                double valorPeca_2 = double.Parse(compra1 [ 2 ], CultureInfo.InvariantCulture);

            double Total = ( numeroPeca1 * valorPeca_1 ) + ( numeroPeca2 * valorPeca_2 );

            Console.WriteLine("VALOR A PAGAR: R$ {0}", Total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

            }
        }
    }
