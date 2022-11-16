using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1041 {
   internal class Program {
      static void Main(string[] args) {

      float X, Y;
      string[] valores = Console.ReadLine().Split(' ');
      X = float.Parse(valores[0]);
      Y = float.Parse(valores[1]);

      if(X == 0 && Y == 0) {
      Console.WriteLine("Origem");
      }

      else if(X == 0) {
      Console.WriteLine("Eixo Y");
      }
      else if(Y == 0) {
      Console.WriteLine("Eixo X");
      }

      else if(X > 0 && Y > 0) {
      Console.WriteLine("Q1");
      }
      else if(X < 0 && Y > 0) {
      Console.WriteLine("Q2");
      }
      else if(X < 0 && Y < 0) {
      Console.WriteLine("Q3");
      }
      else{
      Console.WriteLine("Q4");
      }
      Console.ReadLine();
      }
   }
}

