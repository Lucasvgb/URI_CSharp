using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1113 {
   internal class Program {
      static void Main(string[] args) {

      int x, y;

      string[] valores = Console.ReadLine().Split(' ');
      x = int.Parse(valores[0]);
      y = int.Parse(valores[1]);

      while(x != y) {
      if(x < y) {
      Console.WriteLine("Crescente");
         }

      else {
      Console.WriteLine("Decrescente");
         }
      valores = Console.ReadLine().Split(' ');
      x = int.Parse(valores[0]);
      y = int.Parse(valores[1]);
      
         }
         }
      }
   }
