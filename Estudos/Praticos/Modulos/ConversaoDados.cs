using System;

namespace Estudos.Praticos;

public static class ConversaoDados
{
    public static void VerificarTipoDados()
    {
        int myInt = 3;
        Console.WriteLine($"int: {myInt}");

        decimal myDecimal = myInt;
        Console.WriteLine($"decimal: {myDecimal}"); 
    }

    public static void VerificarTipoDadosInverso()
    {
        decimal myDecimal = 3.14m;
        Console.WriteLine($"decimal: {myDecimal}");

        int myInt = (int)myDecimal; //com correção
        Console.WriteLine($"int: {myInt}");
    }

    public static void ConversaoRestricaoExpansao()
    {
        // Conversao de Restricao
        decimal myDecimal = 1.23456789m;
        float myFloat = (float)myDecimal;

        Console.WriteLine($"Decimal: {myDecimal}");
        Console.WriteLine($"Float  : {myFloat}");
    }

    public static void MetodoAuxiliarToString()
    {
        int first = 5;
        int second = 7;
        string message = first.ToString() + second.ToString();

        Console.WriteLine(message);
    }

    public static void MetodoAuxiliarParse()
    {
        string first = "5";
        string second = "7";
        int sum = int.Parse(first) + int.Parse(second);
        Console.WriteLine(sum);
    }

    public static void ClasseConvert()
    {
        string value1 = "5";
        string value2 = "7";
        int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
        Console.WriteLine(result);

        /*
        Por que o nome do método é ToInt32()? Por que não ToInt()? 
        System.Int32 é o nome do tipo de dados subjacente na Biblioteca de Classes do .NET 
        que a linguagem de programação C# mapeia para a palavra-chave int. 
        Como a classe Convert também faz parte da Biblioteca de Classes do .NET, 
        ela é chamada por seu nome completo, não pelo seu nome em C#. 
        Definindo tipos de dados como parte da Biblioteca de Classes do .NET, 
        várias linguagens .NET como Visual Basic, F#, IronPython e outras podem 
        compartilhar os mesmos tipos de dados e as mesmas classes na Biblioteca 
        de Classes do .NET.
        */
    }

    public static void CoercaoConversaoDecToInt()
    {
        int value = (int)1.5m; // casting truncado
        Console.WriteLine(value);

        int value2 = Convert.ToInt32(1.5m); // Convertendo e arredondanto para cima
        Console.WriteLine(value2);

        // A coerção resulta em truncamentos e a conversão resulta em valores arredondados
    }

    public static void ConversaoSemTryParse()
    {
        string name = "Bob";
        
        // Ocorrerá erro de execução: 
        // System.FormatException: 'Input string was not in a correct format.'
        Console.WriteLine(int.Parse(name)); 
    }

    public static void ConversaoComTryParse()
    {
        string value = "102";
        int result = 0;
        
        if (int.TryParse(value, out result))
        {
        Console.WriteLine($"Measurement: {result}");
        }
        else
        {
        Console.WriteLine("Unable to report the measurement.");
        }
        Console.WriteLine($"Measurement (w/ offset): {50 + result}");
    }

    public static void ConversaoTryParseErrado()
    {
        string value = "bad";
        int result = 0;
        if (int.TryParse(value, out result))
        {
        Console.WriteLine($"Measurement: {result}");
        }
        else
        {
        Console.WriteLine("Unable to report the measurement.");
        }

        if (result > 0)
        Console.WriteLine($"Measurement (w/ offset): {50 + result}");
    }



}
