﻿using Jogo_De_Xadrez.tabuleiro;

namespace Jogo_De_Xadrez.xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "C";

        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != Cor;
        }
        public override bool[,] PossiveisMovimentos()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);
            
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 2);
            if(Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna + 1);

            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 2);

            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 2);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 2);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;


        }
    }
}
