//Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua
//comissão será de 5% do total da venda e que você tem os seguintes dados:
//- Identificação do vendedor
//- Código da peça
//- Preço unitário da peça
//- Quantidade vendida

using Exercicio2;

Pagamento vendedor = new Pagamento(1234);
vendedor.RegistrandoComissãoPorVenda();
Console.WriteLine($"O salário do vendedor ID({vendedor.IdVendedor}) fico em {vendedor.Salario.ToString("C")}");