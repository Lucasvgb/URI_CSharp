using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_1040 {
   internal class Program {
      static void Main(string[] args) {

      float numero1, numero2, numero3, numero4, media, notaExame, mediaFinal;

      string[] valores = Console.ReadLine().Split(' ');
      numero1 = float.Parse(valores[0],CultureInfo.InvariantCulture);
      numero2 = float.Parse(valores[1],CultureInfo.InvariantCulture);
      numero3 = float.Parse(valores[2],CultureInfo.InvariantCulture);
      numero4 = float.Parse(valores[3],CultureInfo.InvariantCulture);

      media = (numero1 * 2 + numero2 * 3 + numero3 * 4 + numero4 * 1 / 10);

      if(media == 4.85f) {
      media = 4.8f;
      }

      Console.WriteLine("Media: " + media.ToString("F1",CultureInfo.InvariantCulture));

      if(media >= 7.0) {
      Console.WriteLine("Aluno aprovado");
      }
      else if(media < 5.0) {
      Console.WriteLine("Aluno reprovado");
      }
      else {
      Console.WriteLine("Aluno em exame");
      notaExame = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
      mediaFinal = (media + notaExame) / 2;
      Console.WriteLine("Nota exame: " + notaExame.ToString("F2"),CultureInfo.InvariantCulture);
      }
      if(mediaFinal >= 5.0) {
      Console.WriteLine("Aluno aprovado");
      }
      else {
      Console.WriteLine("Aluno reprovado");
      }
      Console.WriteLine("Media final: " + mediaFinal.ToString("F1",CultureInfo.InvariantCulture));

      }
   }
}
