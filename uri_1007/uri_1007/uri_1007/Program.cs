using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Leia quatro valores inteiros A, B, C e D. A seguir,
calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
# Entrada
O arquivo de entrada contém 4 valores inteiros.
# Saída
Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
*/

namespace uri_1007
    {
    internal class Program
        {
        static void Main(string [] args)
            {
                int A, B, C, D, diferenca;
                
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                C = int.Parse(Console.ReadLine());
                D = int.Parse(Console.ReadLine());

                diferenca = (A * B - C * D);

                Console.WriteLine("DIFERENCA = " + diferenca);
                Console.ReadLine();
            }
        }
    }
