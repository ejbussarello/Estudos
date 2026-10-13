using System;
using System.Globalization;

namespace Estudos.Praticos;

public static class TryParse
{
    public static void ExercicioTryParse()
    {
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        string message = "";
        decimal total = 0.0m;

        // 1. Estrutura de loop para iterar por cada valor na matriz
        foreach (string value in values)
        {
            // 2. Tenta converter para decimal
            if (decimal.TryParse(value.Replace('.', ','), out decimal number))
            {
                // Regra 2: se for numérico, adiciona ao total
                total += number;
            }
            else
            {
                // Regra 1: se for alfabético, concatena para formar a mensagem
                message += value;
            }
        }

        // 3. Exibe os resultados formatados com ponto fixo (Invariant Culture)
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}");

    }

    public static void ExercicioTryParse2()
    {
        int value1 = 11;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

        int result1 = Convert.ToInt32(value1 / value2);
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

        decimal result2 = value2 / (decimal)value3;
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

        float result3 = value3 / value1;
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
    }

}
