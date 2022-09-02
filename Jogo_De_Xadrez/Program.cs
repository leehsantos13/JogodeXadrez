using System;
using Jogo_De_Xadrez.tabuleiro;
namespace Jogo_De_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);
            
           
            

        }
    }
}
