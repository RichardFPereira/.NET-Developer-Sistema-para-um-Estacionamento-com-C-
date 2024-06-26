﻿using ProjetoEstacionamento.Models;

decimal precoInicial = 0;
decimal precoPorHora = 0;
Estacionamento smartPark = new Estacionamento(precoInicial, precoPorHora);

Console.WriteLine("\nBem vindo ao Smart Park!\n");

Console.WriteLine("Digite o preço inicial: ");
precoInicial = smartPark.ValidaValor();

Console.WriteLine("Digite o preço por hora: ");
precoPorHora = smartPark.ValidaValor();

string escolha = "";
bool menu = true;

while (menu)
{
    Console.Clear();
    Console.WriteLine("Sistema Smart Park - Escolha uma das opções abaixo: ");
    Console.WriteLine("1 - Cadastrar veículo;");
    Console.WriteLine("2 - Remover veículo;");
    Console.WriteLine("3 - Listar veículo;");
    Console.WriteLine("4 - Encerrar;");

    switch (Console.ReadLine())
    {
        case "1":
            smartPark.AdicionarVeiculo();
            break;
        
        case "2":
            smartPark.RemoverVeiculo();
            smartPark.CalcularValor(precoInicial, precoPorHora);
            break;
        
        case "3":
            smartPark.ListarVeiculos();
            break;

        case "4":
            menu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione ENTER para continuar.");
    Console.ReadLine();

}

Console.WriteLine("\nAté a próxima!");