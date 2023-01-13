//Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de
//temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
//Fahrenheit e a variável C representa é a temperatura em graus Celsius. 

using Exercicio4;

Console.WriteLine($"insira um temperatura em graus Cº para converter em Fº");
int celsius = int.Parse(Console.ReadLine());
Console.WriteLine($"{Conversao.ConverteGrauCpF(celsius)} Fº");