using Jogo_De_Xadrez.tabuleiro;

namespace Jogo_De_Xadrez.xadrez
{
    class Torre :Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        
        public override string ToString()
        {
            return "T";
        }

    }
}
