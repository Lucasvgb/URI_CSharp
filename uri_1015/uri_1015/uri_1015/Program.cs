using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1015
    {
    internal class Program
        {
        static void Main(string [] args)
            {
            
            string [] vet = Console.ReadLine().Split(' ');
                double x1 = double.Parse(vet [ 0 ]);
                double y1 = double.Parse(vet [ 1 ]);

            vet = Console.ReadLine().Split(' ');
                double x2 = double.Parse(vet[ 0 ]);
                double y2 = double.Parse(vet [ 1 ]);

            double Distancia = Math.Sqrt(Math.Pow(x2 - x1,2.0) + Math.Pow(y2 - y1,2.0));
            Console.WriteLine(Distancia.ToString("F4"));
            Console.ReadLine();
            }
        }
    }
