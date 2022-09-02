﻿namespace Jogo_De_Xadrez.tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca( Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }

        public abstract bool[,] PossiveisMovimentos();
        

        
        
        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }


    }
}
