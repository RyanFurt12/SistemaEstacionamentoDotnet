﻿using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.Clear();


Console.WriteLine("--------------------------------------------\n"+
                  "Seja bem vindo ao sistema de estacionamento!\n");


//Recebe valores de preço e verifica se são validos
try{
    Console.WriteLine("Digite o preço inicial:");
    precoInicial = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Agora digite o preço por hora:");
    precoPorHora = Convert.ToDecimal(Console.ReadLine());

}catch{
    throw new ArgumentException("Valor invalido, somente valores numericos positivos");
}

if (precoInicial < 0 || precoPorHora < 0) throw new ArgumentException("Valor negativo não permitido");


// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
