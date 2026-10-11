using System;

namespace Estudos.Praticos;

public static class IteracaoNumeroValido
{
    public static void VerificaNumeroValido()
    {
        string? numeroLido;
        int numero;
        bool entradaValida = false;
        bool isNumero = false;

        Console.WriteLine("Digite um numero entre 5 e 10:");
        do
        {
            numeroLido = Console.ReadLine();

            if (int.TryParse(numeroLido, out numero) ? isNumero = true : isNumero = false);

            if (numero != null)
            {
                if (numero > 5 && numero < 10)
                {
                    entradaValida = true;
                }
                else if (!isNumero) Console.WriteLine("Você não digitou um número, por favor, tente novamente."); 
                {
                    Console.WriteLine($"Você digitou o número {numero}. Por favor, digite algo entre 5 e 10!");
                }
            }
        } while (entradaValida == false);
    }
}
