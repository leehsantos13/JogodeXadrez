﻿using Jogo_De_Xadrez.tabuleiro;



namespace Jogo_De_Xadrez.xadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez partida;
        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
        }
        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != Cor;
        }

        private bool TesteTorreParaRoque(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p != null && p is Torre && p.Cor == Cor && p.QteMovimentos == 0;
        }

        public override bool[,] PossiveisMovimentos()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);
            //Acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if(Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna+1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Direita
            pos.DefinirValores(Posicao.Linha , Posicao.Coluna +1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna +1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna -1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Esquerda
            pos.DefinirValores(Posicao.Linha , Posicao.Coluna -1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //Noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna -1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //#Jogada Roque

            if(QteMovimentos == 0 && !partida.xeque)
            {
                //Roque Pequeno
                Posicao posT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
                if (TesteTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);
                    if(Tab.peca(p1) == null && Tab.peca(p2) == null)
                    {
                        mat[Posicao.Linha, Posicao.Coluna + 2] = true;
                    }
                }
                //Roque Grande
                Posicao posT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (TesteTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna -1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);
                    if (Tab.peca(p1) == null && Tab.peca(p2) == null && Tab.peca(p3) == null)
                    {
                        mat[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }

            return mat;


        }

    }
}
