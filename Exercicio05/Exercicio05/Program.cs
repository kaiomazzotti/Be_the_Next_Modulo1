//Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
//V = 3.14159 * R * R * A
//Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura. 

using Exercicio05;

Console.WriteLine("Calculando volume de uma lata de óleo!");
Console.WriteLine("Digite o raio(em cm) :");
int raio = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura(em cm) :");
int altura = int.Parse(Console.ReadLine());
Console.WriteLine($"O volume da sua lata de óleo é: {CalculaVolume.CalculaVolumeLataOleo(raio,altura)} Litros");
