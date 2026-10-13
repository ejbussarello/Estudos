using System;

namespace Estudos.Praticos;

public static class OperacoesEmMatrizes
{
    public static void MetodoSortedArray()
    {
        string[] pallets = [ "B14", "A11", "B12", "A13" ];

        Console.WriteLine("Crescente...");
        Array.Sort(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Console.WriteLine("Decrescente...");
        Array.Reverse(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }

    public static void MetodoClearArray()
    {
        string[] pallets = [ "B14", "A11", "B12", "A13" ];
        Console.WriteLine("");

        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }

    public static void VerificarClear()
    {
        string[] pallets = [ "B14", "A11", "B12", "A13" ];
        Console.WriteLine("");

        Console.WriteLine($"Before: {pallets[0].ToLower()}");
        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"After: {pallets[0].ToLower()}");

        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        //System.NullReferenceException: Object reference not set to an instance of an object.
    }

    public static void RedimensionarMatrizAddElementos()
    {
        string[] pallets =  ["B14", "A11", "B12", "A13" ];
        Console.WriteLine("");

        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }

    public static void RedimencionarMatrizRemovElementos()
    {
        string[] pallets = [ "B14", "A11", "B12", "A13" ];
        Console.WriteLine("");

        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 3);
        Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }

    public static void ToCharArray()
    {
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        string result = new string(valueArray);
        Console.WriteLine(result);
    }

    public static void MetodoJoinESplit()
    {
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);

        string result = String.Join(",", valueArray);
        Console.WriteLine(result);

        string[] itens = result.Split(",");
        foreach (string item in itens)
        {
            Console.WriteLine(item);
        }
    }

/*

Temos uma variável do tipo String, com várias palavras separadas por espaço.

- Criar uma Lista para armazenar cada palavra separadamente;
- percorrer a lista e reverter cada item da lista;
- Criar uma variável string para armazenar os itens da lista.

*/

    public static void TrocarPalavras()
    {
        string pangram = "The quick brown fox jumps over the lazy dog";
        
        // 1. Divide a frase em um array de palavras
        string[] palavras = pangram.Split(' ');
        string[] novoTexto = new string[palavras.Length];

        // 2. Percorre cada palavra
        for (int i = 0; i < palavras.Length; i++)
        {
            // Converte a palavra atual em array de caracteres e inverte
            char[] valorTexto = palavras[i].ToCharArray();
            Array.Reverse(valorTexto);
            
            // Salva a palavra invertida no novo array
            novoTexto[i] = new string(valorTexto);

        } 
        string resultadoFinal = string.Join(" ", novoTexto);
        Console.WriteLine("\nFrase completa:");
        Console.WriteLine(resultadoFinal);
    }

    public static void VerificarPedidos()
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] items = orderStream.Split(',');
        Array.Sort(items);

        foreach (var item in items)
        {
            if (item.Length == 4)
            {
                Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine(item + "\t- Erro");
            }
        }
    }

    public static void Exemplo()
    {
        Console.WriteLine("C110".PadLeft(6, '0'));
    }

}
