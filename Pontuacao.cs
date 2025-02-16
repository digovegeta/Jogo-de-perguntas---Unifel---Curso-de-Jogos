public class Pontuacao{
    #region Metodos
    public void addPontos(){
        this.pontos++;
    }
    public int exibirPontuacao(){
        return this.pontos;
    }
    #endregion
    #region Variaveis
    private int pontos = 0;
    #endregion
}