using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace uri_1014
    {
    internal class Program
        {
        static void Main(string [] args)
            {

            int X;
            double Y, ConsumoMedio;
             
            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            ConsumoMedio =(double)  X / Y;
            Console.WriteLine(ConsumoMedio.ToString("F3") + " km/l");
            Console.ReadLine();
            }
        }
    }
