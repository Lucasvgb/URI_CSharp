using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1044 {
   internal class Program {
      static void Main(string[] args) {

      string[] valores = Console.ReadLine().Split(' ');
      int primeiroValor = int.Parse(valores[0]);
      int segundoValor = int.Parse(valores[1]);

      if(primeiroValor % segundoValor == 0 || segundoValor % primeiroValor == 0) {
      Console.WriteLine("Sao Multiplos");
      }
      else {
      Console.WriteLine("Nao sao multiplos");
      }
      }
   }
}