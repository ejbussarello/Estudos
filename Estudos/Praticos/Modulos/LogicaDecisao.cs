using System;

namespace Estudos.Praticos;

public class LogicaDecisao
{
    public static void Executar()
    {
        // Adicionando um caminho alternativo com outro
        int total = 12;
        if (total >= 15) Console.WriteLine("You win!");
        else Console.WriteLine("Sorry, you lose.");

        // Encadeando condições com else if
        int total2 = 12;
        if (total2 >= 16) Console.WriteLine("You win a new car!");
        else if (total2 >= 10) Console.WriteLine("You win a new laptop!");
        else if (total2 == 7) Console.WriteLine("You win a trip for two!");
        else Console.WriteLine("You win a kitten!");

        // Aninhando instruções `if`
        bool hasIngresso = true;
        int age = 16;
        if (hasIngresso)
        {
            if (age >= 18) Console.WriteLine("Entry granted.");
            else Console.WriteLine("Minors must be accompanied by an adult.");
        }

        // Usando && (todas as condições devem ser atendidas)
        int idade = 20;
        bool hasTicket = true;
        if (idade >= 18 && hasTicket) Console.WriteLine("Entry granted.");
        else Console.WriteLine("Entry denied.");

        // Usando || (pelo menos uma das condições deve ser atendida)
        bool isWeekend = false;
        bool isHoliday = true;
        if (isWeekend || isHoliday) Console.WriteLine("The office is closed.");

        // Usando ! (inverter uma condição)
        bool isLoggedIn = false;
        if (!isLoggedIn)
        {
            Console.WriteLine("Please log in to continue.");
        }

        // Combinar operadores
        int roll1 = 6, roll2 = 6, roll3 = 5;
        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            Console.WriteLine("You rolled doubles!");
        }
    }

}
