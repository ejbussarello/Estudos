using System;

namespace Estudos.Praticos;

public class DoWhileRPG
{
    public static void BatalhaRPG()
    {
        int dano = 0;

        int heroiHP = 10;
        int monstroHP = 10;

        Random dado = new Random();

        void jogaDado() => dano = dado.Next(1, 10);

        while (heroiHP > 0 && monstroHP > 0)
        {
            // vez do heroi
            jogaDado();
            monstroHP -= dano;
            Console.WriteLine($"Monstro foi atingido e perdeu {dano} pontos de vida, agora ele possui {monstroHP} pontos de vida.");

            if (monstroHP <= 0) continue;
            
            // vez do monstro
            jogaDado();
            heroiHP -= dano;
            Console.WriteLine($"Herói foi atingido e perdeu {dano} pontos de vida, agora ele possui {heroiHP} pontos de vida.");
           
        };

        Console.WriteLine(heroiHP > monstroHP ? "Herói foi o vencedor!" : "Monstro foi o vencedor!");
        
    }

}
