using System;

namespace Estudos.Praticos;

public static class DadosVariaveis
{
    public static void TiposIntegrais()
    {
        Console.WriteLine("Sinais de tipos integrais:");

        Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
        
    }

    public static void TiposIntegraisNaoAssinados()
    {
        Console.WriteLine("");
        Console.WriteLine("Tipos de Dados não Assinados:");

        Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
    }

    public static void TiposDadosPontoFlutuante()
    {
        Console.WriteLine("");
        Console.WriteLine("Tipos de Pontos Flutuantes:");
        Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
        Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
    }

    // Decifrando grandes valores de ponto flutuante
    // Como os tipos de ponto flutuante podem conter grandes números com precisão, 
    // seus valores podem ser representados usando "Notação E", que é uma forma de notação científica que significa "vezes 10 elevados ao poder de". 
    // Portanto, um valor como 5E+2 seria o valor 500 porque é o equivalente a 5 * 10^2 ou 5 x 102.

    public static void TipoReferencia()
    {
        int[] data = new int[3];
    }

    public static void TipoValorEReferencia()
    {
        int val_A = 2;
        int val_B = val_A;
        val_B = 5;

        Console.WriteLine("--Value Types--");
        Console.WriteLine($"val_A: {val_A}");
        Console.WriteLine($"val_B: {val_B}");
    }

    public static void TipoValorEReferenciaMatriz()
    {
        int[] ref_A= new int[1];
        ref_A[0] = 2;
        int[] ref_B = ref_A;
        ref_B[0] = 5;

        Console.WriteLine("--Reference Types--");
        Console.WriteLine($"ref_A[0]: {ref_A[0]}");
        Console.WriteLine($"ref_B[0]: {ref_B[0]}");

    }

    
}

/*

Escolha tipos complexos especializados para situações especiais

Não reinvente os tipos de dados se um ou mais já existirem para uma determinada finalidade. 
Os seguintes exemplos identificam quando um tipo de dados .NET específico pode ser útil:

byte: para trabalhar com dados codificados provenientes de outros sistemas de computação ou que usam diferentes conjuntos de caracteres.
double: para trabalhar com fins geométricos ou científicos. double é usado com frequência ao criar jogos que envolvem movimento.
System.DateTime para um valor de data e hora específico.
System.TimeSpan para um intervalo de anos/mês/dias/horas/minutos/segundos/milissegundos.
Recapitulação
Há considerações ao escolher tipos de dados para um código e, geralmente, mais de uma opção. 
Pense em suas escolhas e, a menos que você tenha um bom motivo, tente manter os tipos básicos, 
como int, decimal, string e bool.

*/


