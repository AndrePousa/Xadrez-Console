using System;
using tabuleiro;

namespace Xadrez_console
{
    class Tela
    {
        //recebe um tabuleiro e imprime um tabuleiro na tela
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j< tab.colunas; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
