using System;

namespace Estudos.Praticos;

public static class CalculadoraGorjetas
{
    public static void Executar()
    {
        //Solicita ao usuário para informar o valor da conta
        Console.WriteLine("Insira o valor da conta:");
        string valorContaInput = Console.ReadLine();

        //Converte o valor da conta para decimal
        decimal valorConta = decimal.Parse(valorContaInput);

        //Solicita ao usuário para informar a porcentagem da gorjeta
        Console.WriteLine("Insira a porcentagem da gorjeta (ex: 15 para 15%):");
        string porcentagemGorjetaInput = Console.ReadLine();

        //Converte a porcentagem da gorjeta para decimal
        decimal porcentagemGorjeta = decimal.Parse(porcentagemGorjetaInput);

        //Calcula o valor da gorjeta
        decimal valorGorjeta = valorConta * (porcentagemGorjeta / 100);

        //Exibe o valor da gorjeta e o valor total da conta
        Console.WriteLine($"Valor da Gorjeta foi de {valorGorjeta:C} e o valor total da conta foi de {valorConta + valorGorjeta:C}");
    }

}
