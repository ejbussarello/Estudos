using System;

namespace Estudos.Praticos;

public class ConversorCelsius
{
    public static void Executar()
    {
        
        //Solicita ao usuário para informar a temperatura em Fahrenheit
        Console.WriteLine("Insira a temperatura em Fahrenheit:");
        string temperaturaFahrenheitInput = Console.ReadLine();

        //Converte a temperatura de Fahrenheit para Celsius
        double temperaturaFahrenheit = double.Parse(temperaturaFahrenheitInput);
        double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

        //Exibe a temperatura em Celsius
        Console.WriteLine($"{temperaturaFahrenheit}ºF é equivalente a {temperaturaCelsius:F2}");        
    }

}

