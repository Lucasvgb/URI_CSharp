using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1116 {
   internal class Program {
      static void Main(string[] args) {

      int divisao;
      string[] valores = Console.ReadLine().Split(' ');
      int x = int.Parse(valores[0]);
      int y = int.Parse(valores[1]);

      while(x == 0 && y == 0) {
      if(x > 0 && y == 0) {
      divisao = x / y;
         }
      else if(x > 0 && y < 0) {
      Console.WriteLine("divisao impossivel");
         }
      else if(x < 0 && y == 0) {
      divisao = x / y;
         }
      else if(x < 0 && y > 0) {
      Console.WriteLine("");
         }
      else {
      Console.WriteLine("erro");
         }
      valores = Console.ReadLine().Split(' ');
      x = int.Parse(valores[0]);
      y = int.Parse(valores[1]);
         }
         }
         }
      }
   
