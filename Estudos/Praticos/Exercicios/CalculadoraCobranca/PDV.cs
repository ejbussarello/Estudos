using System;

namespace Estudos.Praticos.Exercicios.CalculadoraCobranca;

public class PDV
{
    public static void Checkout()
    {

        decimal totalCompra = 0;
        decimal precoUnitario;
        int quantidade;

        do
        {
            Console.WriteLine("Deseja adicionar um item à compra? (S/N)");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "N")
            {
                break;
            }

            Console.WriteLine("Insira o valor do item:");
            precoUnitario = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira a quantidade:");
            quantidade = int.Parse(Console.ReadLine());

            totalCompra += precoUnitario * quantidade;
        } while (true);
        
        Console.WriteLine($"O valor total da compra é: {totalCompra:C}");

        Console.WriteLine($"Escolhida opção de pagamento: - {FormaDePagamento.Pagamento("")}");

    }

    

}
