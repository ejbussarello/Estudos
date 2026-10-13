using System;
using System.Security.Cryptography.X509Certificates;

namespace Estudos.Praticos;

public static class FormatacaoDados
{
    public static void FormatacaoComposta()
    {
        string first = "Hello";
        string second = "World!";
        string result = string.Format("{0} {1}!", first, second);
        Console.WriteLine(result);

        Console.WriteLine("{1} {0}!", first, second);     //World Hello!
        Console.WriteLine("{0} {0} {0}!", first, second); //Hello Hello Hello!

    }

    public static void InterpolacaoCaracteres()
    {
        string first = "Hello";
        string second = "World";
        Console.WriteLine($"{first} {second}!");
        Console.WriteLine($"{second} {first}!");
        Console.WriteLine($"{first} {first} {first}!");
    }

    public static void FormatacaoMoeda()
    {
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");
    }

    public static void FormatarNumeros()
    {
        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N} units");

        decimal medida = 123456.78912m;
        Console.WriteLine($"medida: {medida:N4} units");

    }

    public static void FormatarPercentuais()
    {
        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P2}");
    }

    public static void CombinarFormatacao()
    {
        decimal price = 67.55m;
        decimal salePrice = 59.99m;

        string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

        Console.WriteLine(yourDiscount);

        decimal preco = 67.55m;
        decimal precoCusto = 59.99m;

        string seuDesconto = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (preco - precoCusto), preco);

        seuDesconto += $"A discount of {((preco - precoCusto)/preco):P2}!"; //inserted
        Console.WriteLine(seuDesconto);
    }

    public static void Padding()
    {
        string input = "Pad this";
        Console.WriteLine(input.PadLeft(12));
    }

    public static void ExercicioPaddin()
    {
        string paymentId = "769C";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";

        var formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadLeft(10);

        Console.WriteLine("1234567890123456789012345678901234567890");
        Console.WriteLine(formattedLine);
    }

    public static void Indexadores()
    {
        string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        Console.WriteLine(openingPosition);
        Console.WriteLine(closingPosition);
    }

    public static void IndexOf()
    {
        string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        openingPosition += 1;

        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }

    public static void IndexOf2()
    {
        string message = "What is the value <span>between the tags</span>?";

        int openingPosition = message.IndexOf("<span>");
        int closingPosition = message.IndexOf("</span>");

        openingPosition += 6;
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }

    public static void EvitarValoresMagicos()
    {
        string message = "What is the value <span>between the tags</span>?";

        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int openingPosition = message.IndexOf(openSpan);
        int closingPosition = message.IndexOf(closeSpan);

        openingPosition += openSpan.Length;
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }

    public static void LocalizarPosicao()
    {
        string message = "hello there!";

        int first_h = message.IndexOf('h');
        int last_h = message.LastIndexOf('h');

        Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
    }

    public static void LocalizarPosicaoAvancado()
    {
        string message = "(What if) I am (only interested) in the last (set of parentheses)?";
        int openingPosition = message.LastIndexOf('(');

        openingPosition += 1;
        int closingPosition = message.LastIndexOf(')');
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }

    public static void RecuperarTodosOsParenteses()
    {
        string message = "(What if) there are (more than) one (set of parentheses)?";
        while (true)
        {
            int openingPosition = message.IndexOf('(');
            if (openingPosition == -1) break;

            openingPosition += 1;
            int closingPosition = message.IndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            // Note the overload of the Substring to return only the remaining 
            // unprocessed message:
            message = message.Substring(closingPosition + 1);
        }
    }

    public static void IndexOfAny()
    {
        string message = "Hello, world!";
        char[] charsToFind = { 'a', 'e', 'i' };

        int index = message.IndexOfAny(charsToFind);

        Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");
    }

    public static void IndexofAny2()
    {
        string message = "Help (find) the {opening symbols}";
        Console.WriteLine($"Searching THIS Message: {message}");
        char[] openSymbols = { '[', '{', '(' };
        int startPosition = 5;
        int openingPosition = message.IndexOfAny(openSymbols);
        Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

        openingPosition = message.IndexOfAny(openSymbols, startPosition);
        Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
    }
    /*
    Aqui estão dois pontos importantes a serem lembrados:

    LastIndexOf() retorna a última posição de um caractere ou uma cadeia de caracteres dentro de outra cadeia de caracteres.
    IndexOfAny() retorna a primeira posição de uma matriz de char que ocorre dentro de outra cadeia de caracteres.
    */
    public static void IndexOfAny3()
    {
        string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

        // The IndexOfAny() helper method requires a char array of characters. 
        // You want to look for:

        char[] openSymbols = { '[', '{', '(' };

        // You'll use a slightly different technique for iterating through 
        // the characters in the string. This time, use the closing 
        // position of the previous iteration as the starting index for the 
        //next open symbol. So, you need to initialize the closingPosition 
        // variable to zero:

        int closingPosition = 0;

        while (true)
        {
            int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

            if (openingPosition == -1) break;

            string currentSymbol = message.Substring(openingPosition, 1);

            // Now  find the matching closing symbol
            char matchingSymbol = ' ';

            switch (currentSymbol)
            {
                case "[":
                    matchingSymbol = ']';
                    break;
                case "{":
                    matchingSymbol = '}';
                    break;
                case "(":
                    matchingSymbol = ')';
                    break;
            }

            // To find the closingPosition, use an overload of the IndexOf method to specify 
            // that the search for the matchingSymbol should start at the openingPosition in the string. 

            openingPosition += 1;
            closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            // Finally, use the techniques you've already learned to display the sub-string:

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }

    public static void RemoveMetodo()
    {
        string data = "12345John Smith          5000  3  ";
        string updatedData = data.Remove(5, 20);
        Console.WriteLine(updatedData);
    }

    public static void ReplaceMetodo()
    {
        string message = "This--is--ex-amp-le--da-ta";
        message = message.Replace("--", " ");
        message = message.Replace("-", "");
        Console.WriteLine(message);
    }

    public static void Exercicio()
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        // Extract the "quantity"
        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
        int quantityEnd= input.IndexOf(closeSpan);
        int quantityLength = quantityEnd - quantityStart;
        quantity = input.Substring(quantityStart, quantityLength);
        quantity = $"Quantity: {quantity}";

        // Set output to input, replacing the trademark symbol with the registered trademark symbol
        const string tradeSymbol = "&trade;";
        const string regSymbol = "&reg;";
        output = input.Replace(tradeSymbol, regSymbol);

        // Remove the opening <div> tag
        const string openDiv = "<div>";
        int divStart = output.IndexOf(openDiv);
        output = output.Remove(divStart, openDiv.Length);

        // Remove the closing </div> tag and add "Output:" to the beginning
        const string closeDiv = "</div>";
        int divCloseStart = output.IndexOf(closeDiv);
        output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

        Console.WriteLine(quantity);
        Console.WriteLine(output);

        

    }
}
