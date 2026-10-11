using System;

namespace Estudos.Praticos.Modulos;

public static class Iteracao
{
    public static void ForCrescente()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void ForDescrescente()
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }

    public static void ForComBreak()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 7) break;
        }
    }

    public static void ForEmMatriz()
    {
       string[] nomes = { "Eduardo", "Carol", "Martina", "Giovane" };
        for (int i = nomes.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(nomes[i]);
        } 
    }

    public static void ForComAlteracao()
    {
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        foreach (var name in names)
        {
            // Impossível alterar a variável de iteração
            //if (name == "David") name = "Sammy";
        }
    }

    public static void ForSemChaves()
    {
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = 0; i < names.Length; i++)
            if (names[i] == "David") names[i] = "Sammy";

        foreach (var name in names) Console.WriteLine(name);
    }

    public static void ForComChaves()
    {
        string[] names = { "Alex", "Eddie", "David", "Michael" };

        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "David")
            {
                names[i] = "Sammy";
            }
        }

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

}
