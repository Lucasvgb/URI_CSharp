using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
A seguir mostre a variável PROD com mensagem correspondente.
# Entrada
O arquivo de entrada contém 2 valores inteiros.
# Saída 
Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
*/

namespace URI1004
    {
    internal class Program
        {
        static void Main(string [] args)
            {
            int n1, n2, PROD;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            PROD = n1 * n2;

            Console.WriteLine("PROD = " + PROD);
            Console.ReadLine();
            }
        }
    }
