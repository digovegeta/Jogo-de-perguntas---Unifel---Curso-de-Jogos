
public class JogoDePerguntas{
    #region  Construtor
    public JogoDePerguntas(){
        pontuacao = new Pontuacao();
        montarPerguntas();
        play();
    }
    #endregion
    #region Metodos
   public void play(){
        montarPerguntas();
        getPergunta();
        
   }
    private void montarPerguntas(){
        perguntas = new Dictionary<string, Pergunta>();
        perguntas.Add("1", new Pergunta("Qual comando utilizado para escrever no terminal?", "Console.WriteLine", "Console.ReadLine", "Console.LineWrite", "Console.LineRead"));
        perguntas.Add("2", new Pergunta("O C# é uma linguagem de qual categoria?", "Orientada a Objetos", "Estruturada", "Script", "Marcação"));
        perguntas.Add("3", new Pergunta("O C# tem como pai qual outra linguagem?", "Java", "Python", "HTML", "C"));
        perguntas.Add("4", new Pergunta("Qual comando para criar comentários no C#?", "//", "/*", "||", "!--"));
        perguntas.Add("5", new Pergunta("Dentre os tipos de variáveis abaixo, qual consome 1 bit?", "bool", " int", "char", "string"));
        perguntas.Add("6", new Pergunta("Qual operador corresponde ao resto da divisão?", "%", "# ", " $", "&"));
        perguntas.Add("7", new Pergunta("Qual comando utilizamos para converter para inteiro?", "int.Parse ", "int.Convert ", "Convert.Parse ", "Convert.Int"));
        perguntas.Add("8", new Pergunta("Qual símbolo usamos para escrever o valor da variável no terminal?","$","#", "%",  "&"));
        perguntas.Add("9", new Pergunta("Qual dos nomes de variáveis abaixo é válido?", "Variavel_123_Ex", "123var", "nome variavel", "!nome!"));
        perguntas.Add("10", new Pergunta("Qual comando para gerar números aleatórios?", "Random", "Console.Random", "Math.Random", "Random.Round"));
        getPergunta();    
    }
    private void getPergunta(){
        Random rand = new Random();
        while(perguntas.Count > 0){
            string i = perguntas.ElementAt(rand.Next(0, perguntas.Count)).Key;
            if(perguntas[i].fazerPerguta())
                pontuacao.addPontos();
            perguntas.Remove(i);
        }
        Thread.Sleep(4000);
        Pergunta.limparConsole();
        pontuacao.exibirPontuacao();
    }
    #endregion
    #region Variaveis
     private Dictionary<string, Pergunta> perguntas = null;
    private Pontuacao pontuacao = null; 
    #endregion
}