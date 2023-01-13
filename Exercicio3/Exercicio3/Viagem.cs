using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz
//12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.
//Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
//Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
//fórmula: LITROS_USADOS = DISTANCIA / 12.O programa deve apresentar os valores da velocidade média,
//tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.
namespace Exercicio3
{
    public class Viagem
    {
        private double _horaformatada = 0 ;
        private int horas = 0;
        private int minutos = 0;
        public double LitrosGastos { get; set; }
        public double RendimentoKmL { get; set; }
        public string[] TempoViagemH { get; set; }
        public int VelocidadeMediaKmH { get; set; }
        public double DistanciaKm { get; set; }

        public Viagem(double rendimento)
        {
            this.RendimentoKmL = rendimento;
        }
        public void CalculaLitrosViagem()
        {
            Console.WriteLine("Vamos descobrir quantos litros você gastou na viagem!!");
            Console.WriteLine("Informe o tempo de viagem (em horas| Ex: 3 horas e 45 minutos: 3,45 ou 3 horas : 3,00): ");
            TempoViagemH = Console.ReadLine().Split(",");
            horas = int.Parse(TempoViagemH[0]);
            minutos = int.Parse(TempoViagemH[1]);
            _horaformatada = (horas + minutos*0.0166666667) ;
            Console.WriteLine("Informe a velocidade média da sua viagem(em Km/h): ");
            VelocidadeMediaKmH = int.Parse(Console.ReadLine()) ;
            DistanciaKm = VelocidadeMediaKmH * _horaformatada;
            LitrosGastos = DistanciaKm / RendimentoKmL;
            Console.WriteLine($"Você gastou {LitrosGastos.ToString("F2")} Litros");
        }
        public void InfoViagem()
        {
            Console.WriteLine("\nInformções da sua viagem! ");
            Console.WriteLine($"\nDistância: {DistanciaKm.ToString("F2")} Km" +
                $"\nTempo: {TempoViagemH[0]}:{TempoViagemH[1]} horas" +
                $"\nVelocidade Média: {VelocidadeMediaKmH} Km/h" +
                $"\nRendimento do Carro: {RendimentoKmL.ToString("F2")} Km/L" +
                $"\nLitros Gastos: {LitrosGastos.ToString("F2")} Litros");
        }
    }
}
