using System;
using System.Collections.Generic;
using Jogo_De_Xadrez.tabuleiro;
using Jogo_De_Xadrez.xadrez;
namespace Jogo_De_Xadrez
{
    class Tela
    {

        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            ImprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Truno: "+partida.turno);
            Console.WriteLine("Agurdando jogada: "+partida.jogadorAtual);
            if (partida.xeque)
            {
                Console.WriteLine("XEQUE!");
            }
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Pecas Caputadas: ");
            Console.Write("Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach(Peca x in conjunto)
            {
                Console.Write(x+" ");
            }
            Console.Write("]");
        }
       
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    ImprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }
        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundooriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundooriginal;
                    }
                    ImprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundooriginal;
                }
                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundooriginal;
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {


                if (peca.Cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}


