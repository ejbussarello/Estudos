using System;

namespace Estudos.Praticos;

public static class InteracaoComUsuario
{
    
    public static void SolicitarInformacoes()
    {
        // Solicita ao usuário que insira seu nome
        Console.WriteLine("Por favor, insira seu nome:");
        string nome = Console.ReadLine() ?? string.Empty;

        // Solicita ao usuário que insira sua idade
        Console.WriteLine("Por favor, insira sua idade:");
        string idadeInput = Console.ReadLine() ?? string.Empty;
        
        int idade;
        if (!int.TryParse(idadeInput, out idade))
        {
            Console.WriteLine("Idade inválida. Por favor, insira um número inteiro.");
            return;
        }

        // Exibe uma mensagem de boas-vindas personalizada
        Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");
    }

}
