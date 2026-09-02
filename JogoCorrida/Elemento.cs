using System.Data.Common;

namespace JogoCorrida
{
    public class Elemento
    {
        // ATRIBUTO DA CLASSE
        public TipoElemento Tipo { get; set; }
        public int PosicaoX;
        public int PosicaoY;
        public int Altura { get; set; }
        public int Largura { get; set; }

        public bool Pontuou { get; set; }

        public void Movimentar(int x, int y)
        {
            PosicaoX = x; 
            PosicaoY = y;
        }
    }
}
