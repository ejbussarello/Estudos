using System;

namespace Estudos.Praticos;

public static class LacosRepeticao
{

    public static void LacosDeRepeticao()
    {
        // Exemplo de laço de repetição for
        Console.WriteLine("Exemplo de laço for:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iteração {i + 1}");
        }

        // Exemplo de laço de repetição while
        Console.WriteLine("\nExemplo de laço while:");
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine($"Iteração {j + 1}");
            j++;
        }

        // Exemplo de laço de repetição do-while
        Console.WriteLine("\nExemplo de laço do-while:");
        int k = 0;
        do
        {
            Console.WriteLine($"Iteração {k + 1}");
            k++;
        } while (k < 5);
    }

    public static void InterrupcaoEContinuacao()
    {
        // Interrupção: sair do loop antecipadamente
        for (int count = 0; count < 10; count++)
        {
            if (count == 5)
            {
                break;
            }
            Console.WriteLine(count);
        }

        Console.WriteLine("Loop ended.");

        // Continuar: pular para a próxima iteração
        for (int count = 0; count < 6; count++)
        {
            if (count == 3)
            {
                continue;
            }
            Console.WriteLine(count);
        }
    }
    public static void GerenciandoLoopsWhile()
    {
        // Gerenciando loops while com break
        while (true)
        {
            Console.Write("Escreva 'sair' para parar o loop: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "sair")
            {
                break;
            }

            Console.WriteLine($"Digite: {userInput}");
        }

        Console.WriteLine("Tchau!");

        // Utilizando o comando continue em loops while
        int currentSlot = 0;

        while (currentSlot < 5)
        {
            currentSlot++; // Crucial: a atualização do currentSlot deve ocorrer antes da verificação do continue

            if (currentSlot == 3)
            {
                Console.WriteLine($"Pulando slot {currentSlot}.");
                continue;
            }

            Console.WriteLine($"Slot do item processado com sucesso para o slot {currentSlot}.");
        }

        Console.WriteLine("Scan do inventário completo!");
    }

}
