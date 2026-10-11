using System;

namespace Estudos.Praticos;

public static class IteracaoFizzBuzz
{
    public static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            int Fizz = i%3;
            int Buzz = i%5;

            if (Fizz == 0 && Buzz == 0) Console.WriteLine($"{i} - FizzBuzz");
            else if (Fizz == 0) Console.WriteLine($"{i} - Fizz");
            else if (Buzz == 0) Console.WriteLine($"{i} - Buzz");
            else Console.WriteLine($"{i}");

        }

    }

}
