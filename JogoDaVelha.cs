public class JogoDaVelha{
    public JogoDaVelha(){
        Placar placar = new Placar();
        do{
            Tabuleiro tabuleiro = new Tabuleiro();
            bool jogador = false;
            do{
                placar.exibirPlacar();
                if(jogador)
                    tabuleiro.jogada('X');
                else
                    tabuleiro.jogada('O');
                jogador = !jogador;

            }while(tabuleiro.isConcluirPartida());
            placar.exibirPlacar();        
            placar.fimDaPartida(tabuleiro.verificarVencedor());
        }while(true);
    }
}
