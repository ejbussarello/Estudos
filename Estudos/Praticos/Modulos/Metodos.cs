using System;

namespace Estudos.Praticos.Modulos;

public class Metodos
{
    public static void Executar()
    {
        void Saudacao()
        {
            Console.WriteLine("Olá, seja bem-vindo(a)!");
        }
        Saudacao();

        void Saudacao_parametro(string nome)
        {
            Console.WriteLine($"Olá, {nome}!");
        }

        Saudacao_parametro("Alex"); // Output: Olá, Alex!
        Saudacao_parametro("Sam");  // Output: Olá, Sam!

        // Separando parâmetros com vírgula
        void Saudacao_param_virgula(string name, string greeting)
        {
            Console.WriteLine($"{greeting}, {name}!");
        }

        Saudacao_param_virgula("Eduardo", "Olá"); // Output: Olá, Eduardo!

        // Parâmetros opcionais
        void Saudacao_opcional(string name, string greeting = "Olá")
        {
            Console.WriteLine($"{greeting}, {name}!");
        }

        Saudacao_opcional("Eduardo");               // Output: Olá, Eduardo!
        Saudacao_opcional("Eduardo", "Bem-vindo");  // Output: Bem-vindo, Eduardo!
    }



}
