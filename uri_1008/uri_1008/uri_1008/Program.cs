using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1008
    {
    internal class Program
        {
        static void Main(string [] args)
            {
            int numeroFuncionario;
            numeroFuncionario = int.Parse(Console.ReadLine());

            double horasTrabalhadas, valorHora, salario;
            horasTrabalhadas = double.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine());

            salario = horasTrabalhadas * valorHora;
            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));

            Console.ReadLine();

            }
        }
    }
