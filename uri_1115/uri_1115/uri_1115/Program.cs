using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1115 {
   internal class Program {
      static void Main(string[] args) {

      
      string[] cordenadas = Console.ReadLine().Split(' ');
      int x = int.Parse(cordenadas[0]);
      int y = int.Parse(cordenadas[1]);

      while(x != 0 && y != 0) {
      if(x > 0 && y > 0) {
      Console.WriteLine("primeiro");
         }
      else if(x < 0 && y > 0) {
      Console.WriteLine("segundo");
         }
      else if(x < 0 && y < 0) {
      Console.WriteLine("terceiro");
         }
      else {
      Console.WriteLine("quarto");
         }
      cordenadas = Console.ReadLine().Split(' ');
      x = int.Parse(cordenadas[0]);
      y = int.Parse(cordenadas[1]);
         }

         }
      }
   }
