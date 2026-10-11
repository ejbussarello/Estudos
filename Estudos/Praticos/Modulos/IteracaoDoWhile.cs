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

}
