using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1042 {
   internal class Program {
      static void Main(string[] args) {

      int valor1, valor2, valor3, menor, maior, meio;

      string[] valores = Console.ReadLine().Split(' ');
      valor1 = int.Parse(valores[0]);
      valor2 = int.Parse(valores[1]);
      valor3 = int.Parse(valores[2]);

      if(valor1 < valor2 && valor1 < valor3) {
      menor = valor1;
      if(valor2 < valor3) {
      meio = valor2;
      maior = valor3;
      }
      else {
      meio = valor3;
      maior = valor2;
      }
      }
      
      else if (valor2 < valor3) {
      menor = valor2;
      if(valor1 < valor3) {
      meio = valor1;
      maior = valor3;
      }
      else {
      meio = valor3;
      maior = valor1;
      }
      }

      Console.WriteLine(valor3);
      Console.WriteLine(valor2);
      Console.WriteLine(valor1);
      Console.WriteLine();
      Console.WriteLine(valor1);
      Console.WriteLine(valor3);
      Console.WriteLine(valor2);
      }
      Console.ReadLine();
      }
   }
}
