using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri_1013
    {
    internal class Program
        {
        static void Main(string [] args)
            {
            int A, B, C, maiorAB, maior;

            string [] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet [ 0 ]);
            B = int.Parse(vet [ 1 ]);
            C = int.Parse(vet [ 2 ]);

            maiorAB = ( A + B + Math.Abs(A - B) ) / 2;

            maior = ( maiorAB + C + Math.Abs(maiorAB - C) ) / 2;

            Console.WriteLine(maior +  " eh o maior");
            Console.ReadLine();

           

            }
        }
    }
