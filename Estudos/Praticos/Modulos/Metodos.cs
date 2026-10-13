using System;

namespace Estudos.Praticos.Modulos;

public class Metodos
{
    public static void MetodoSimples()
    {
        static void Saudacao()
        {
            Console.WriteLine("Olá, seja bem-vindo(a)!");
        }

        Saudacao(); // Output: Olá, seja bem-vindo(a)!
    }

    public static void MetodoComParametros()
    {
        static void Saudacao_parametro(string nome)
        {
            Console.WriteLine($"Olá, {nome}!");
        }

        Saudacao_parametro("Eduardo"); // Output: Olá, Eduardo!
        Saudacao_parametro("Carol");  // Output: Olá, Carol!
    }

    public static void MetodoComParametrosEntreVirgulas()
    {
        static void Saudacao_param_virgula(string nome, string saudacao)
        {
            Console.WriteLine($"{saudacao}, {nome}!");
        }

        Saudacao_param_virgula("Eduardo", "Olá"); // Output: Olá, Eduardo!
        Saudacao_param_virgula("Carol", "Bem-vinda"); // Output: Bem-vinda, Carol!
    }

    public static void MetodoComParametrosNomeados()
    {
        static void Saudacao_param_nomeado(string nome, string saudacao)
        {
            Console.WriteLine($"{saudacao}, {nome}!");
        }

        Saudacao_param_nomeado(nome: "Eduardo", saudacao: "Olá"); // Output: Olá, Eduardo!
        Saudacao_param_nomeado(saudacao: "Bem-vinda", nome: "Carol"); // Output: Bem-vinda, Carol!
    }

    public static void MetodoComParametrosPadrao()
    {
        static void Saudacao_param_padrao(string nome, string saudacao = "Olá")
        {
            Console.WriteLine($"{saudacao}, {nome}!");
        }

        Saudacao_param_padrao("Eduardo"); // Output: Olá, Eduardo!
        Saudacao_param_padrao("Carol", "Bem-vinda"); // Output: Bem-vinda, Carol!
    }

    public static void MetodoComRetorno()
    {
        // Função com retorno
        int Somar(int a, int b)
        {
            return a + b;
        }

        int resultado = Somar(5, 3);
        Console.WriteLine($"Resultado da soma: {resultado}"); // Output: Resultado da soma: 8

        Console.WriteLine(Somar(10, 5) * 2); // Output: 30
    }

    public static void MetodoComRetornoComTupla()
    {
        // Função que retorna uma tupla
        (int, int) GetCoordinates()
        {
            int x = 10;
            int y = 20;
            return (x, y);
        }

        var coordinates = GetCoordinates();
        Console.WriteLine($"Coordenadas: ({coordinates.Item1}, {coordinates.Item2})"); // Output: Coordenadas: (10, 20)

        // Desconstruindo a tupla em variáveis separadas
        var (xCoord, yCoord) = GetCoordinates();
        Console.WriteLine($"Coordenadas desconstruídas: ({xCoord}, {yCoord})"); // Output: Coordenadas desconstruídas: (10, 20)
    }

    public static void MetodoVoid()
    {
        // Método void não retorna um valor utilizável
        void Add(int a, int b)
        {
            Console.WriteLine(a + b); // Mostra o resultado, mas não retorna um valor
        }

        Add(3, 4); // Output: 7

        // int x = Add(3, 4); // Erro de compilação: não é possível atribuir o resultado de um método void a uma variável
    }

    public static void MetodoArray()
    {
        int[] a = {1,2,3,4,5};

        Console.WriteLine("Contents of Array:");
        PrintArray();

        void PrintArray()
        {
            foreach (int x in a)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
    }

}
