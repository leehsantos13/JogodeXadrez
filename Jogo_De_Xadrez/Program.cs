﻿using System;
using Jogo_De_Xadrez.tabuleiro;
using Jogo_De_Xadrez.xadrez;
namespace Jogo_De_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            /* try
             {
                 Tabuleiro tab = new Tabuleiro(8, 8);
                 tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                 tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                 tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                 Tela.imprimirTabuleiro(tab);
             }
             catch (TabuleiroException e)
             {
                 Console.WriteLine(e.Message);
             }
            */

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(  pos);
            Console.WriteLine(pos.ToPosicao());
            

        }
    }
}
