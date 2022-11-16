using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1017
    {
    internal class Program
        {
        static void Main(string [] args)
            {
            int horas, km, distanciaPercorrida ;
            double litrosGasolina;

            horas = int.Parse(Console.ReadLine());
            km = int.Parse(Console.ReadLine());

            distanciaPercorrida = horas * km;

            litrosGasolina = (double)distanciaPercorrida / 12;

            Console.WriteLine(litrosGasolina.ToString("F3"));
            Console.ReadLine();
            }
        }
    }
