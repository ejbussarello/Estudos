using System;

namespace Estudos.Praticos;

public class ArmazenarDados
{
    public static void Executar()
    {
        string nome = "Alice";
        int idade = 30;
        decimal altura = 1.65m;
        bool isEstudante = true;

        string greeting = "Hello";
        Console.WriteLine(greeting);           // Output: Hello

        int messageCount = 5;
        Console.WriteLine(messageCount + 1);   // Output: 6

        var name = "Alice";           // C# sees a string, so name is string
        var age = 25;                 // C# sees a whole number, so age is int
        var price = 19.99;            // C# sees a decimal, so price is double

        Console.WriteLine(34.40M);

        //Pós-incremento (value++): usa primeiro o valor atual e, em seguida, incrementa
        //Pré-incremento (++value): incrementa primeiro e, em seguida, usa o novo valor

        int a = 5;
        Console.WriteLine(a++);   // Output: 5 (uses old value, then increments)
        Console.WriteLine(a);     // Output: 6 (a was incremented)

        int b = 5;
        Console.WriteLine(++b);   // Output: 6 (increments first, then uses new value)
        Console.WriteLine(b);     // Output: 6

        // Converter string
        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();
        int idade2 = Convert.ToInt32(ageInput);
        int nextYear = idade2 + 1;
        Console.WriteLine($"Next year you'll be {nextYear}");
    }

}
