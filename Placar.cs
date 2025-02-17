 public class Placar{
    #region Construtor
    public Placar(){
        this.jogadorO = 0;
        this.jogadorX = 0;
        this.empate = 0;
    }
    #endregion
    #region Metodos
    public void fimDaPartida(char vencedor){
        Console.WriteLine(vencedor);
        switch(vencedor){
            case 'O':
                this.jogadorO++;
                break;
            case 'X':
                this.jogadorX++;
                break;
            case 'N':
                this.empate++;
                break;
        }
    }
    public void exibirPlacar(){
        Console.WriteLine("\nJogador X : " + this.jogadorX + " \nEmpates : " + this.empate + " \nJogador O : " + this.jogadorO + "\n");
    }
    #endregion
    #region Variavel
    private int jogadorX;
    private int jogadorO;
    private int empate;
    #endregion
}
