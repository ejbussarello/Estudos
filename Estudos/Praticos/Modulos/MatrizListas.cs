using System;

namespace Estudos.Praticos;

public class MatrizListas
{

    public static void Lista()
    {
        // A primeira linha cria uma lista com três valores iniciais. 
        // A segunda linha cria uma lista vazia à qual você pode adicionar itens posteriormente.

        List<string> colors = new List<string> { "vermelho", "verde", "azul" };
        List<int> scores = new List<int>();

        // Operações de listas comuns:

        //list.Count	     Retorna o número de itens
        //list.Add(value)	 Adiciona um item ao final da lista
        //list.Remove(value) Remove o primeiro item correspondente
        //list[i] = value	 Sobrescreve o item no índice i
        //list.RemoveAt(i)	 Remove o item no índice i
        //list.Sort()	     Classifica a própria lista

        List<string> cores = new List<string> { "vermelho", "verde", "azul" };

        Console.WriteLine(cores.Count); // 3
        cores.Add("amarelo");           // Adiciona "amarelo" no final da lista
        Console.WriteLine(cores.Count); // 4

        cores.Remove("vermelho");       // Remove "vermelho"
        cores[0] = "roxo";              // Substitui "verde" por "roxo"

        // Iterar sobre uma lista
        List<int> pontos = new List<int> { 95, 82, 76, 91 };
        foreach (int score in pontos)
        {
            Console.WriteLine(score);
        }

    }


    public static void Matriz()
    {
        // Criando uma Matriz
        // A primeira linha cria uma matriz de três cadeias de caracteres. 
        // A segunda linha cria uma matriz que pode conter quatro inteiros, cada um começando no valor padrão de 0

        string[] colors = { "vermelho", "verde", "azul" };
        int[] scores = new int[4];

        // Acessando itens por índice
        string[] cores = { "vermelho", "verde", "azul" };
        Console.WriteLine(cores[0]); // Output: vermelho
        Console.WriteLine(cores[2]); // Output: azul

        // O tamanho fixo de uma Matriz
        string[] cores2 = { "vermelho", "verde", "azul" };
        cores2[0] = "roxo"; // Replaces "vermelho" with "roxo"
        Console.WriteLine(cores2[0]); // Output: roxo
        Console.WriteLine(cores2.Length); // Output: 3

        // Iterar em uma matriz
        int[] pontos = { 95, 82, 76, 91 };
        foreach (int score in pontos)
        {   
            Console.WriteLine(score);
        }

    }

    // Exemplo nativo
    public static void ExecutarPadrão()
    {
        // Criando uma matriz 2D
        int[,] matriz = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Matriz 2D:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Criando uma lista de listas (jagged array)
        List<List<int>> listaDeListas = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5 },
            new List<int> { 6, 7, 8, 9 }
        };

        Console.WriteLine("\nLista de Listas:");
        foreach (var lista in listaDeListas)
        {
            foreach (var item in lista)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}
