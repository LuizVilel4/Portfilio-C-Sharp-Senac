using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Pessoa
    {
        //Atributos
        public string nome;
        public string cor;
        public int idade;
        public float altura;
        public string profissao;
        public string sexo;

        //Metodos
        public void falar()
        {
            Console.WriteLine("Olá meu nome é " +  nome);
        }

        public void somar()
        {
            int a = 1;
            int b = 2;
            int soma = a + b;

            Console.WriteLine(soma);
        }
    }
}
