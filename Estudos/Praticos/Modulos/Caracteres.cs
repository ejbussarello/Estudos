namespace Estudos.Praticos;

public static class Caracteres
{
    public static void Executar()
    {
        // Concatenação (unindo cadeias de caracteres)
        string first = "Hello";
        string last = "World";
        string message = first + ", " + last + "!";
        Console.WriteLine(message);

        // Uma maneira melhor: interpolação de cadeia de caracteres
        string name = "Alice";
        string greeting = $"Hello, {name}! Welcome to the program.";
        Console.WriteLine(greeting);

        // Uma maneira mais limpa de combinar entrada e saída
        string nome = Console.ReadLine() ?? string.Empty;
        string saudacao = $"Hello, {nome}! Welcome to the program.";
        Console.WriteLine(saudacao);

        // Métodos comuns de cadeia de caracteres
        // ToUpper() - converte todos os caracteres para maiúsculas
        // ToLower() - converte todos os caracteres para minúsculas
        // Trim() - remove espaços em branco no início e no final da cadeia de caracteres
        // Replace() - substitui uma parte da cadeia de caracteres por outra
        // Substring() - retorna uma parte da cadeia de caracteres
        // Split() - divide a cadeia de caracteres em um array de substrings com base em um delimitador
        // Length - retorna o número de caracteres na cadeia de caracteres
        // IndexOf() - retorna o índice da primeira ocorrência de uma substring
        // LastIndexOf() - retorna o índice da última ocorrência de uma substring
        // Contains() - verifica se a cadeia de caracteres contém uma substring específica
        // StartsWith() - verifica se a cadeia de caracteres começa com uma substring específica
        // EndsWith() - verifica se a cadeia de caracteres termina com uma substring específica

        string a = Console.ReadLine() ?? string.Empty;
        string b = $"Hello, {a.ToUpper()}! Welcome to the program.";
        Console.WriteLine(b);
    }
}
