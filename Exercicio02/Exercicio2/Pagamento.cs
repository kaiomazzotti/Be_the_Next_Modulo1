using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Pagamento
    {
        public int IdVendedor { get;private set; }
        private int CodigoPeca { get; set; }
        private decimal Precopeca { get; set; }
        private int QuantidadeVendida { get; set; }
        public decimal Salario { get; private set; }
        public decimal Comissao { get; set; }
        private decimal PercentualComissao = 0.05M ;
        public Pagamento(int idVendador)
        {
            IdVendedor = idVendador;
            CodigoPeca = 0;
            Precopeca = 0;
            QuantidadeVendida = 0;
            Salario = 0;
        }
        public void RegistrandoComissãoPorVenda()
        {
            string continua;
            Console.WriteLine("Olá, seja bem vindo ao registro de comissão por venda!");
            do
            {
                Console.WriteLine("Escaneie o código de barras ou digite o código da peça: ");
                CodigoPeca = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite qual o preço da peça: ");
                Precopeca = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade vendida: ");
                QuantidadeVendida = int.Parse(Console.ReadLine());
                Comissao = QuantidadeVendida * Precopeca * PercentualComissao;
                Salario += Comissao;
                Console.WriteLine($"Comissão de {Comissao.ToString("C")} adicionado com sucesso");
                do
                {
                    Console.WriteLine("Deseja fazer mais algum registro? (S) para sim e (N) para não");
                    continua = Console.ReadLine();
                } while (continua.ToLower() != "s" && continua.ToLower() != "n");

            } while (continua.ToLower() == "s");
        }
    }
}
