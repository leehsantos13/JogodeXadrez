using Jogo_De_Xadrez.tabuleiro;



namespace Jogo_De_Xadrez.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }

    }
}
