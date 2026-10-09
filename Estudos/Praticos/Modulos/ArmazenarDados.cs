using System;

namespace Estudos.Praticos;

public class ArmazenarDados
{
    public static void Variaveis()
    {
        // Declaração de variáveis
        string nome = "Alice";
        int idade = 30;
        decimal altura = 1.65m;
        bool isEstudante = true;

        // Exemplo de uso das variáveis
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"É estudante? {isEstudante}");
    }

    public static void TiposDeDados()
    {
        // Tipos de dados em C#
        string texto = "Olá, mundo!";
        int numeroInteiro = 42;
        double numeroDecimal = 3.14;
        bool valorBooleano = true;

        // Exemplo de uso dos tipos de dados
        Console.WriteLine($"Texto: {texto}");
        Console.WriteLine($"Número inteiro: {numeroInteiro}");
        Console.WriteLine($"Número decimal: {numeroDecimal}");
        Console.WriteLine($"Valor booleano: {valorBooleano}");
    }

    public static void ConversaoDeTipos()
    {
        // Conversão de tipos
        string numeroComoTexto = "123";
        int numeroConvertido = Convert.ToInt32(numeroComoTexto);

        // Exemplo de uso da conversão
        Console.WriteLine($"Número convertido: {numeroConvertido}");
    }

    public static void Operadores()
    {
        // Operadores aritméticos
        int a = 10;
        int b = 5;

        int soma = a + b;
        int subtracao = a - b;
        int multiplicacao = a * b;
        int divisao = a / b;

        // Exemplo de uso dos operadores
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {divisao}");
    }

    public static void IncrementoEDecrescimento()
    {
        // Incremento e decremento
        int x = 5;

        // Pós-incremento (x++): usa primeiro o valor atual e, em seguida, incrementa
        Console.WriteLine($"Pós-incremento: {x++}"); // Output: 5
        Console.WriteLine($"Valor após pós-incremento: {x}"); // Output: 6

        // Pré-incremento (++x): incrementa primeiro e, em seguida, usa o novo valor
        Console.WriteLine($"Pré-incremento: {++x}"); // Output: 7
        Console.WriteLine($"Valor após pré-incremento: {x}"); // Output: 7

        // Pós-decremento (x--): usa primeiro o valor atual e, em seguida, decrementa
        Console.WriteLine($"Pós-decremento: {x--}"); // Output: 7
        Console.WriteLine($"Valor após pós-decremento: {x}"); // Output: 6

        // Pré-decremento (--x): decrementa primeiro e, em seguida, usa o novo valor
        Console.WriteLine($"Pré-decremento: {--x}"); // Output: 5
        Console.WriteLine($"Valor após pré-decremento: {x}"); // Output: 5
    }

    public static void ConversaoDeStringParaInt()
    {
        // Converter string para int
        Console.Write("Digite sua idade: ");
        string idadeInput = Console.ReadLine() ?? string.Empty;
        int idadeConvertida = Convert.ToInt32(idadeInput);
        int proximoAno = idadeConvertida + 1;
        Console.WriteLine($"No próximo ano você terá {proximoAno} anos.");
    }

    public static void ConversaoDeStringParaDouble()
    {
        // Converter string para double
        Console.Write("Digite um número decimal: ");
        string numeroInput = Console.ReadLine() ?? string.Empty;
        double numeroConvertido = Convert.ToDouble(numeroInput);
        double resultado = numeroConvertido * 2;
        Console.WriteLine($"O dobro do número digitado é: {resultado}");
    }

    public static void ConversaoDeStringParaDecimal()
    {
        // Converter string para decimal
        Console.Write("Digite um valor monetário: ");
        string valorInput = Console.ReadLine() ?? string.Empty;
        decimal valorConvertido = Convert.ToDecimal(valorInput);
        decimal resultado = valorConvertido + 10.50m;
        Console.WriteLine($"O valor somado a 10,50 é: {resultado}");
    }

    public static void ConversaoDeStringParaBool()
    {
        // Converter string para bool
        Console.Write("Digite 'true' ou 'false': ");
        string boolInput = Console.ReadLine() ?? string.Empty;
        bool boolConvertido = Convert.ToBoolean(boolInput);
        Console.WriteLine($"O valor booleano digitado é: {boolConvertido}");
    }

    public static void ConversaoDeIntParaString()
    {
        // Converter int para string
        int numero = 42;
        string numeroComoTexto = numero.ToString();
        Console.WriteLine($"O número como texto é: {numeroComoTexto}");
    }

    public static void ConversaoDeDoubleParaString()
    {
        // Converter double para string
        double numeroDecimal = 3.14;
        string numeroDecimalComoTexto = numeroDecimal.ToString();
        Console.WriteLine($"O número decimal como texto é: {numeroDecimalComoTexto}");
    }

    public static void ConversaoDeDecimalParaString()
    {
        // Converter decimal para string
        decimal valorMonetario = 19.99m;
        string valorMonetarioComoTexto = valorMonetario.ToString();
        Console.WriteLine($"O valor monetário como texto é: {valorMonetarioComoTexto}");
    }

    public static void ConversaoDeBoolParaString()
    {
        // Converter bool para string
        bool valorBooleano = true;
        string valorBooleanoComoTexto = valorBooleano.ToString();
        Console.WriteLine($"O valor booleano como texto é: {valorBooleanoComoTexto}");
    }

    public static void ConversaoDeTiposComTryParse()
    {
        // Conversão de tipos com TryParse
        Console.Write("Digite um número inteiro: ");
        string numeroInput = Console.ReadLine() ?? string.Empty;
        if (int.TryParse(numeroInput, out int numeroConvertido))
        {
            Console.WriteLine($"O número digitado é: {numeroConvertido}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
        }
    }

    public static void ConversaoDeTiposComTryParseDouble()
    {
        // Conversão de tipos com TryParse para double
        Console.Write("Digite um número decimal: ");
        string numeroInput = Console.ReadLine() ?? string.Empty;
        if (double.TryParse(numeroInput, out double numeroConvertido))
        {
            Console.WriteLine($"O número decimal digitado é: {numeroConvertido}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número decimal válido.");
        }
    }

    public static void ConversaoDeTiposComTryParseDecimal()
    {
        // Conversão de tipos com TryParse para decimal
        Console.Write("Digite um valor monetário: ");
        string valorInput = Console.ReadLine() ?? string.Empty;
        if (decimal.TryParse(valorInput, out decimal valorConvertido))
        {
            Console.WriteLine($"O valor monetário digitado é: {valorConvertido}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um valor monetário válido.");
        }
    }

    public static void ConversaoDeTiposComTryParseBool()
    {
        // Conversão de tipos com TryParse para bool
        Console.Write("Digite 'true' ou 'false': ");
        string boolInput = Console.ReadLine() ?? string.Empty;
        if (bool.TryParse(boolInput, out bool boolConvertido))
        {
            Console.WriteLine($"O valor booleano digitado é: {boolConvertido}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite 'true' ou 'false'.");
        }
    }

    public static void ConversaoDeTiposComTryParseIntParaString()
    {
        // Conversão de int para string com TryParse
        Console.Write("Digite um número inteiro: ");
        string numeroInput = Console.ReadLine() ?? string.Empty;
        if (int.TryParse(numeroInput, out int numeroConvertido))
        {
            string numeroComoTexto = numeroConvertido.ToString();
            Console.WriteLine($"O número como texto é: {numeroComoTexto}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
        }
    }

    public static void ConversaoDeTiposComTryParseDoubleParaString()
    {
        // Conversão de double para string com TryParse
        Console.Write("Digite um número decimal: ");
        string numeroInput = Console.ReadLine() ?? string.Empty;
        if (double.TryParse(numeroInput, out double numeroConvertido))
        {
            string numeroDecimalComoTexto = numeroConvertido.ToString();
            Console.WriteLine($"O número decimal como texto é: {numeroDecimalComoTexto}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número decimal válido.");
        }
    }

    public static void ConversaoDeTiposComTryParseDecimalParaString()
    {
        // Conversão de decimal para string com TryParse
        Console.Write("Digite um valor monetário: ");
        string valorInput = Console.ReadLine() ?? string.Empty;
        if (decimal.TryParse(valorInput, out decimal valorConvertido))
        {
            string valorMonetarioComoTexto = valorConvertido.ToString();
            Console.WriteLine($"O valor monetário como texto é: {valorMonetarioComoTexto}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um valor monetário válido.");
        }
    }
    
    public static void ConversaoDeTiposComTryParseBoolParaString()
    {
        // Conversão de bool para string com TryParse
        Console.Write("Digite 'true' ou 'false': ");
        string boolInput = Console.ReadLine() ?? string.Empty;
        if (bool.TryParse(boolInput, out bool boolConvertido))
        {
            string valorBooleanoComoTexto = boolConvertido.ToString();
            Console.WriteLine($"O valor booleano como texto é: {valorBooleanoComoTexto}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite 'true' ou 'false'.");
        }
    }
    
}
