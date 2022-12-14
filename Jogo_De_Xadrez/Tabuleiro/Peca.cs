namespace Jogo_De_Xadrez.tabuleiro
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
        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }
        public void DecrementarQteMovimentos()
        {
            QteMovimentos--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = PossiveisMovimentos();
            for(int i = 0; i<Tab.Colunas; i++)
            {
                for(int j=0;j<Tab.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Posicao pos)
        {
            return PossiveisMovimentos()[pos.Linha, pos.Coluna];
        }
        public abstract bool[,] PossiveisMovimentos();


    }
}
