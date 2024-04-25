using System;
using System.Text.RegularExpressions;

namespace ProjetoEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja estacionar: ");
            string placa = Console.ReadLine();
            if (ValidaPlaca(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo Adicionado!");
            }
            else
            {
                Console.WriteLine("A placa é inválida!");
                AdicionarVeiculo();
            }
        }

        static bool ValidaPlaca(string placa)
        {
            string regexPlaca = @"^([A-Za-z]{3}-\d{4}|[A-Za-z]{3}\d[A-Za-z]\d{2})$";

            return Regex.IsMatch(placa, regexPlaca);

        }
        public decimal ValidaValor()
        {
            decimal valor = 0;
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out valor) && valor >= 0)
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido! \nDigite novamente o valor inicial: ");                    
                }
            }
        }
    }
}