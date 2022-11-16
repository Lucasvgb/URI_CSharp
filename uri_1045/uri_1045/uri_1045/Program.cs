using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1045 {
   internal class Program {
      static void Main(string[] args) {
         
         double A,B,C;

         string[] valores = Console.ReadLine().Split(' ');
         A = double.Parse(valores[0],CultureInfo.InvariantCulture);
         B = double.Parse(valores[1],CultureInfo.InvariantCulture);
         C = double.Parse(valores[2],CultureInfo.InvariantCulture);
         
         if(A >= B + C) {
            Console.WriteLine("NAO FORMA TRIANGULO");
         }

         else { 
         (Math.Pow(A,2.0) == Math.Pow(B,2.0) + Math.Pow(C,2.0)) 
            Console.WriteLine("TRIANGULO RETANGULO");
         }
         else if (Math.Pow(A,2.0) > Math.Pow(B,2.0) + Math.Pow(C,2.0)) {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
         }
         else if (Math.Pow(A,2.0) < Math.Pow(B,2.0) + Math.Pow(C,2.0)) {
            Console.WriteLine("TRIANGULO ACUTANGULO");
         }


         if (A == B && B == C){
            Console.WriteLine("TRIANGULO EQUILATERO");
         }
         else if (A == B || A == C || B == C){
            Console.WriteLine("TRIANGULO ISOSCELES");
         }
      
         }
      }
   }
}
