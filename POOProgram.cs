using POO;
using System;
using System.Security.Cryptography.X509Certificates;

public class Class1
{
    public static void Main(string[] args)
    {
        Pessoa rodrigo = new Pessoa();
        rodrigo.nome = "Rodrigo";
        rodrigo.idade = 18;
        rodrigo.sexo = "Masculino";
        rodrigo.altura = 1.82f;

        Console.WriteLine(rodrigo.nome);
        rodrigo.falar();
        rodrigo.somar();

    }
}
