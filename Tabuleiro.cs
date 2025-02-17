public class Tabuleiro{
    public Tabuleiro(){
        inicializartabuleiro();
    }
    private void inicializartabuleiro(){
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                this.tabuleiro[i, j] = ' ';
            }
        }
    }
    public void jogada(char jogador){
        bool isJogadaInvalida = false;
        bool isPosicaoInvalida = false;
        int x, y;
        do{
            do{
                x = -1;
                y = -1;
                exibirTabuleiro();
                Console.WriteLine("Digite a posicao do tabuleiro para jogar com " + jogador + ":");

                string value = Console.ReadLine();
                char valueY = char.ToUpper(value[0]);
                if(int.TryParse(value, out x))
                    if(int.Parse(value) == 0)                
                        System.Environment.Exit(1);
                y = pegarIndiceY(valueY);
                Console.WriteLine(value + " " + value.Length);
                char valueX = char.ToUpper(value[1]);
                x = pegarIndiceX(valueX);

                if(x < 0 || x > 2 || y < 0 || y > 2){
                    Console.WriteLine("Posicao invalida!");
                    isJogadaInvalida = true;
                }else{
                    isJogadaInvalida = false;
                }
            }while(isJogadaInvalida);
            //verifica se a posicao ja foi preenchida
            if(this.tabuleiro[x, y]!= 'X' && this.tabuleiro[x, y]!= 'O'){
                this.colocarPeca(x, y, jogador);
                    isPosicaoInvalida = false;
            }else{
                isPosicaoInvalida = true;
                Console.WriteLine("Posicao ja preenchida!");
            }
        }while (isPosicaoInvalida);
    }
    private int pegarIndiceY(char value){
        switch(value){
            case 'A':
               return 0;
            case 'B':
                return 1;
            case 'C':
                return 2;
            default:
                return -1;
        }
    }
    private int pegarIndiceX(char value){
        switch(value){
            case '1':
               return 0;
            case '2':
                return 1;
            case '3':
                return 2;
            default:
                return -1;
        }
    }
    private void colocarPeca(int x, int y, char jogador){
        this.tabuleiro[x, y] = jogador;
    }
    public char verificarVencedor(){
        for(int i = 0; i < 3; i++){
            if(this.tabuleiro[i, 0] == this.tabuleiro[i, 1] && this.tabuleiro[i, 1] == this.tabuleiro[i, 2]){
                return this.tabuleiro[i, 0];
            }
            if(this.tabuleiro[0, i] == this.tabuleiro[1, i] && this.tabuleiro[1, i] == this.tabuleiro[2, i]){
                return this.tabuleiro[0, i];
            }
        }
        if(this.tabuleiro[0, 0] == this.tabuleiro[1, 1] && this.tabuleiro[1, 1] == this.tabuleiro[2, 2]){
            return this.tabuleiro[0, 0];
        }
        if(this.tabuleiro[0, 2] == this.tabuleiro[1, 1] && this.tabuleiro[1, 1] == this.tabuleiro[2, 0]){
            return this.tabuleiro[0, 2];
        }
        return 'N';
    }
    public bool verificarEmpate(){
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                if(this.tabuleiro[i, j] == ' '){
                    return false;
                }
            }
        }
        return true;
    }
    public void exibirTabuleiro(){
        string sb = "   A   B   C\n";
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                if(j == 0)
                    sb += (i+1) + "  ";
                sb += this.tabuleiro[i, j];
                if(j != 2)
                sb += " | ";
            }
            if(i != 2)
                sb +="\n   ---------\n";
        }
        Console.WriteLine(sb);
    }
    public bool isConcluirPartida(){
        return !(verificarVencedor() == 'O' ||verificarVencedor() == 'X' || verificarEmpate());   
    }
    private char[,] tabuleiro = new char[3,3];
}