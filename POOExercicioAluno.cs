using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Aluno
    {
        public string nome;
        public int matricula;
        


        public void media(int nota1, int nota2)
        {
            int media;
            int somaNota = nota1+nota2;
            media = somaNota/2;

            if (media >= 7)
            {
                Console.WriteLine($"sua nota foi:{media} Parabens voce foi aprovado!");
            }
            if (media >= 5 && media <7)
            {
                Console.WriteLine($"sua nota foi:{media} Parabens você esta reptovado!");
            }else
            {
                Console.WriteLine($"sua nota foi:{media}  Você foi reprovado!");
            }
        }

    }
}
