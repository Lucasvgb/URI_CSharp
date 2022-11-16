using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1046 {
   internal class Program {
      static void Main(string[] args) {

      string[] vetor = Console.ReadLine().Split(' ');
      int inicialHora = int.Parse(vetor[0]);
      int finalHora = int.Parse(vetor[1]);
      int duracao;

      if(inicialHora < finalHora) {
      duracao = finalHora - inicialHora;
      }
      else {
      duracao = 24 - inicialHora + finalHora;
      }
      Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
      }
   }
}
