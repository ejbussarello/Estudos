using System;

namespace Estudos.Praticos;

public class VerificarPermissaoAcesso
{
    public static void TelaLogin()
    {
        string[] permissoes = { "Administrador", "Gerente", "Usuário" };
        int[] nivelAcesso = { 1, 2, 3, 4, 5 };
        
        Console.WriteLine("Cadastro de usuário");
        Console.WriteLine("Digite a permissão do usuário (Administrador, Gerente, Usuário):");
        
        string permissaoInput = Console.ReadLine();
        if (!permissoes.Contains(permissaoInput)) {
            Console.WriteLine($"Permissão '{permissaoInput}' inválida. Cadastro não realizado.");
            return;
        }
        
        Console.WriteLine("Digite o nível de acesso do usuário (1 - 5):");
        
        int acessoInput = int.Parse(Console.ReadLine());

        if (!nivelAcesso.Contains(acessoInput))
        {
            Console.WriteLine("Nível de acesso inválido. Cadastro não realizado.");
            return;
        } else
        {
            CadastroUsuario(permissaoInput, acessoInput);
        }
    }

    public static void CadastroUsuario(string permissao, int acesso)
    {
        Console.WriteLine($"Usuário com permissão '{permissao}' e nível de acesso '{acesso}' cadastrado com sucesso.");

        if (permissao == "Administrador" && acesso == 5)
        {
            Console.WriteLine($"Bem-vindo, usuário super '{permissao}'");
        } else if (permissao == "Administrador" && acesso < 5)
        {
            Console.WriteLine($"Bem-vindo, usuário '{permissao}'");
        } else if (permissao == "Gerente" && acesso >= 4 )
        {
            Console.WriteLine("Contacte um Administrador para acesso.");
        } else if (permissao == "Gerente" && acesso < 4)
        {
            Console.WriteLine("Você não tem privilégios suficientes");
        } else
        {
            Console.WriteLine($"Sua permissão é de '{permissao}'. Contacte um Administrador.");
        }

    }

}
