using System;

namespace Estudos.Praticos;

public class RenovacaoAssinatura
{
    public static void Executar()
    {
        Console.WriteLine("Deseja realizar a renovação da assinatura? (S/N)");
        string resposta = Console.ReadLine();

        // Converte a resposta em booleano usando o operador ternário
        if (resposta == null)
        {
            Console.WriteLine("Resposta inválida. Por favor, insira 'S' para sim ou 'N' para não.");
            return;
        } else if (resposta.ToUpper() != "S" && resposta.ToUpper() != "N")
        {
            Console.WriteLine("Resposta inválida. Por favor, insira 'S' para sim ou 'N' para não.");
            return;
        }
        
        bool desejaRenovar = resposta?.ToUpper() == "S" ? true : false;

        if (desejaRenovar)
        {
            // Lógica para realizar a renovação da assinatura
            Console.WriteLine("Renovando a assinatura...");
            
            Console.WriteLine("Informe a quantidade de anos para renovação:");
            string anosInput = Console.ReadLine();

            int anos;
            if (!int.TryParse(anosInput, out anos) || anos <= 0)
            {
                Console.WriteLine("Quantidade de anos inválida. Por favor, insira um número inteiro positivo.");
                return;
            } 

            Console.WriteLine($"A assinatura será renovada por {anos} anos.");       

        }
        else Console.WriteLine("Cancelando a renovação da assinatura...");

    }
}
