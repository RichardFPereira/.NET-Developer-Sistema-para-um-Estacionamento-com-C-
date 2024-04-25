using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Estacionamento.Models
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
                Console.WriteLine("A placa é válida!");
            }
            else
            {
                Console.WriteLine("A placa é inválida!")
            }
        }

        static bool ValidaPlaca(string placa)
        {
            string regexPlaca = @"^([A-Za-z]{3}-\d{4}|[A-Za-z]{3}\d[A-Za-z]\d{2})$";

            return Regex.IsMatch(placa, regexPlaca);

        }
    }
}