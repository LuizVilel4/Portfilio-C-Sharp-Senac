using System;

class Program {
  public static void Main (string[] args) {
    
    console.WriteLine("Digite o Tempo de viagem");
    int tempo = int.Parse(Console.ReadLine());

    console.WriteLine("digite a velocidade media")
    float velocidade = float.Parse(Console.ReadLine());

    float distancia = tempo * velocidade;

    float litros = distancia / 12;
  }
}
