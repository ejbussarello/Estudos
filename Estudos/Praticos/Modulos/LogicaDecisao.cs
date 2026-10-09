using System;

namespace Estudos.Praticos;

public class LogicaDecisao
{
    public static void AdicionandoCaminhoAlternativo()
    {
        int total = 12;
        if (total >= 15) Console.WriteLine("Você venceu!");
        else Console.WriteLine("Desculpe, você perdeu.");
    }

    public static void EncadeandoCondicoes()
    {
        int total2 = 12;
        if (total2 >= 16) Console.WriteLine("Você venceu um novo carro!");
        else if (total2 >= 10) Console.WriteLine("Você venceu um novo laptop!");
        else if (total2 == 7) Console.WriteLine("Você venceu uma viagem para dois!");
        else Console.WriteLine("Você venceu um gato!");
    }

    public static void AninhandoInstrucoesIf()
    {
        bool hasIngresso = true;
        int age = 16;
        if (hasIngresso)
        {
            if (age >= 18) Console.WriteLine("Entrada Garantida.");
            else Console.WriteLine("Menores de idade devem ser acompanhados por um adulto.");
        }
    }

    public static void UsandoOperadoresLogicos()
    {
        // Usando && (todas as condições devem ser atendidas)
        int idade = 20;
        bool hasTicket = true;
        if (idade >= 18 && hasTicket) Console.WriteLine("Entrada Garantida.");
        else Console.WriteLine("Entrada Negada.");

        // Usando || (pelo menos uma das condições deve ser atendida)
        bool isWeekend = false;
        bool isHoliday = true;
        if (isWeekend || isHoliday) Console.WriteLine("O escritório está fechado.");

        // Usando ! (inverter uma condição)
        bool isLoggedIn = false;
        if (!isLoggedIn)
        {
            Console.WriteLine("Por favor, faça o login para continuar.");
        }

        // Combinar operadores
        int roll1 = 6, roll2 = 6, roll3 = 5;
        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            Console.WriteLine("Você obteve dobros!");
        }
    }

}
