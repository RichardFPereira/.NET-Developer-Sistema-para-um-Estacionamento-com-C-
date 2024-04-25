using ProjetoEstacionamento.Models;

decimal precoInicial = 0;
decimal precoPorHora = 0;
Estacionamento smartPark = new Estacionamento(precoInicial, precoPorHora);

Console.WriteLine("\nBem vindo ao Smart Park!\n");

Console.WriteLine("Digite o preço inicial: ");
precoInicial = smartPark.ValidaValor();

Console.WriteLine("Digite o preço por hora: ");
precoPorHora = smartPark.ValidaValor();

Console.WriteLine("Preço inicial: " + precoInicial);
Console.WriteLine("Preço por hora: " + precoPorHora);

