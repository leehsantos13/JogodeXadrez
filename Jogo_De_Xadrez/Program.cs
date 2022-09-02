using System;
using Jogo_De_Xadrez.tabuleiro;
using Jogo_De_Xadrez.xadrez;
namespace Jogo_De_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
             try
             {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Digite a posição de origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).PossiveisMovimentos();
                        Console.Clear();

                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                        Console.WriteLine();
                        Console.Write("Digite a posição de destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }
                Console.Clear();
                Tela.ImprimirPartida(partida);
                 
                
             }
             catch (TabuleiroException e)
             {
                 Console.WriteLine(e.Message);
             }
            

            /*PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(  pos);
            Console.WriteLine(pos.ToPosicao());
            */
            

        }
    }
}
