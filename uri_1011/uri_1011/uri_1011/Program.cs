using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1011
    {
    internal class Program
        {
        static void Main(string [] args)
            {
            double raio,volume, pi =  3.14159;
            raio = double.Parse(Console.ReadLine());
            volume = (( 4 / 3.0 ) * pi *  (raio * raio * raio)) ;
            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
            Console.ReadLine();
            }
        }
    }
