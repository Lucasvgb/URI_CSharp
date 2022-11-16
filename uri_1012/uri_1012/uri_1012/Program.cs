using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri_1012
    {
    internal class Program
        {
        static void Main(string [] args)
            {
            double A, B, C, AreaTrianguloRetangulo, AreaDoCirculo, AreaDoTrapezio, AreaDoQuadrado, AreaDoRetangulo;
            
            string [] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet [ 0 ], CultureInfo.InvariantCulture);
            B = double.Parse(vet [ 1 ], CultureInfo.InvariantCulture);
            C = double.Parse(vet [ 2 ], CultureInfo.InvariantCulture);

            AreaTrianguloRetangulo = A * C / 2.0;
            Console.WriteLine("TRIANGULO: " + AreaTrianguloRetangulo.ToString("F3"));

            AreaDoCirculo = 3.14159 * C * C;
            Console.WriteLine("CIRCULO: " + AreaDoCirculo.ToString("F3"));

            AreaDoTrapezio = ( A + B ) / 2.0 * C;
            Console.WriteLine("TRAPEZIO: " + AreaDoTrapezio.ToString("F3"));

            AreaDoQuadrado = B * B;
            Console.WriteLine("QUADRADO: " + AreaDoQuadrado.ToString("F3"));

            AreaDoRetangulo = A * B;
            Console.WriteLine("RETANGULO: " + AreaDoRetangulo.ToString("F3"));
            Console.ReadLine();
            
            }
        }
    }
