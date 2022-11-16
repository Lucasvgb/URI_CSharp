using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1009
    {
    internal class Program
        {
        static void Main(string [] args)
            {
            
            double porcentagem = 0.15;
            string nome = string.Concat(Console.ReadLine());
            Console.WriteLine("Esse é o nome = " + nome);

            double salarioFixo = double.Parse(Console.ReadLine());
            Console.WriteLine("Salário do vendedor = R$ " + salarioFixo.ToString("F2"));

            double totalDeVendas = double.Parse(Console.ReadLine());
            Console.WriteLine("Total de vendas = R$ " + totalDeVendas.ToString("F2"));

            double comisao = porcentagem * totalDeVendas + salarioFixo;
            Console.WriteLine("TOTAL = R$ " + comisao.ToString("F2"));

            Console.ReadLine();
            


            }
        }
    }
