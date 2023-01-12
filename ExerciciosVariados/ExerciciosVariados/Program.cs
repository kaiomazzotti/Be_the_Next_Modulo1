//Faça um programa que:
//- Leia a cotação do dólar
//- Leia um valor em dólares
//- Converta esse valor para Real
//- Mostre o resultado 

Console.WriteLine("Qual a cotação do dolar? ");
decimal cotacao = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite um valor em dólares: ");
decimal dolar = decimal.Parse(Console.ReadLine());
decimal real = cotacao * dolar;
Console.WriteLine($"Convertendo para Real : {real.ToString("C")}");



