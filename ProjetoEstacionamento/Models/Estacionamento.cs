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

        //Adiciona novo veículo
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
                Console.Clear();
                Console.WriteLine("A placa é inválida!");                
                AdicionarVeiculo();
            }
        }

        //Remove veículo já existente
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover: ");
            string placa = Console.ReadLine();
            
            if (ValidaPlaca(placa))
            {
                if (veiculos.Contains(placa))
                {
                    veiculos.Remove(placa);            
                    Console.WriteLine($"Veículo de placa {placa} removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("O veículo com a placa especificada não está estacionado.");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("A placa é inválida!");
                RemoverVeiculo();
            }       
        }

        //Lista veículos existentes
        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
            else
            {
                Console.WriteLine("Veículos estacionados:");
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
        }

        //Verifica se a placa é válida
        static bool ValidaPlaca(string placa)
        {
            string regexPlaca = @"^([A-Za-z]{3}-\d{4}|[A-Za-z]{3}\d[A-Za-z]\d{2})$";

            return Regex.IsMatch(placa, regexPlaca);

        }

        //Verifica se o valor digitado é válido
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

        public void CalcularValor(decimal valorInicial, decimal valorPorHora)
        {
            Console.WriteLine("Digite quantas horas o veículo ficou estacionado.");
            decimal horas = Convert.ToDecimal(Console.ReadLine());
            decimal valorFinal = (valorInicial + (valorPorHora * horas));
            Console.WriteLine($"O valor total foi de: R$ {valorFinal:F2}.");
        }
    }
}