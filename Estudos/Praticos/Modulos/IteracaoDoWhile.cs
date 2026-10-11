using System;

namespace Estudos.Praticos.Modulos;

public static class IteracaoDoWhile
{
    public static void DoWhile()
    {
        Random random = new Random();
        int current = 0;

        do
        {
            current = random.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7);
    }

    public static void While()
    {
        Random random = new Random();
        int current = random.Next(1, 11);

        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Último número: {current}");
    }

    public static void DoWhileContinue()
    {
        Random random = new Random();
        int current = random.Next(1, 11);

        do
        {
            current = random.Next(1, 11);

            if (current >= 8) continue;

            Console.WriteLine(current);
        } while (current != 7);
    }

    public static void WhileEntradaUsuario()
    {
        string? readResult;
        Console.WriteLine("Digite qualquer coisa:");
        do
        {
            readResult = Console.ReadLine();
        } while (readResult == null);
    }

    public static void WhileEntradaMaior3Letras()
    {
        string? readResult;
        bool validEntry = false;
        Console.WriteLine("Enter a string containing at least three characters:");
        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                if (readResult.Length >= 3)
                {
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("Your input is invalid, please try again.");
                }
            }
        } while (validEntry == false);
    }

}
