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
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Digite a posição de origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Digite a posição de destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                    partida.ExecutarMovimento(origem, destino);
                }
                 
                
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
