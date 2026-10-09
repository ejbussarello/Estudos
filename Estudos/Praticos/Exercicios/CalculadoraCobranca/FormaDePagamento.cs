using System;

namespace Estudos.Praticos.Exercicios.CalculadoraCobranca;

public class FormaDePagamento
{
    public static string Pagamento(string OpcaoPagamento = "")
    {
        int formaPagamento;

        Console.WriteLine("Qual é a forma de pagamento? (1-Dinheiro, 2-Cartão, 3-Pix)");
        formaPagamento = int.Parse(Console.ReadLine());

        if (formaPagamento == 1)
        {
            Console.WriteLine("Pagamento em dinheiro selecionado.");
            OpcaoPagamento = "Dinheiro";

            return OpcaoPagamento;
        }
        else if (formaPagamento == 2)
        {
            Console.WriteLine("Pagamento com cartão selecionado.");
            OpcaoPagamento = "Cartão";

            return OpcaoPagamento;
        }
        else if (formaPagamento == 3)
        {
            Console.WriteLine("Pagamento via Pix selecionado.");
            OpcaoPagamento = "Pix";
            return OpcaoPagamento;
        }
        else
        {
            Console.WriteLine("Forma de pagamento inválida.");
            return "Forma de pagamento inválida.";
        }

    }
}