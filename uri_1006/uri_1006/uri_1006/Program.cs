using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1006
    {
    internal class Program
        {
        static void Main(string [] args)
            {
            double A, B, C, media;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            media = ( A * 2 + B * 3 + C * 5 ) / 10;
            Console.WriteLine("MEDIA = " + media.ToString("F1"));
            Console.ReadLine();

            }
        }
    }
