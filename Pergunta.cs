using System;
public class Pergunta(){
    #region Construtores
    public Pergunta(string pergunta, string alternativaA, string alternativaB, string alternativaC, string alternativaD) :this()
    {
        this.pergunta = pergunta;
        this.alternativaA = alternativaA;
        this.alternativaB = alternativaB;
        this.alternativaC = alternativaC;
        this.alternativaD = alternativaD;
        this.respostaCerta = this.alternativaA;
    }
    #endregion
    #region Metodos
    public bool fazerPerguta(){
        firulas();
        do{
            exibirPerguntas();
        }while(!captarResposta());
        Console.WriteLine("Resposta: " + alternativas[alternativaRespondida]);
        Console.WriteLine("Resposta correta: " + (isRespostaCorreta(alternativas[alternativaRespondida])? "Sim" : "Não"));
        if(!isRespostaCorreta(alternativas[alternativaRespondida]))
            Console.WriteLine("Resposta: " + respostaCerta);
        Thread.Sleep(4000);
        return isRespostaCorreta(alternativas[alternativaRespondida]);
    }
    private void exibirPerguntas(){
        Console.WriteLine("\n" + pergunta + "\n");
        this.alternativas = perpararOrdemRespostas();
        Console.WriteLine($"A) {alternativas[0]}");
        Console.WriteLine($"B) {alternativas[1]}");
        Console.WriteLine($"C) {alternativas[2]}");
        Console.WriteLine($"D) {alternativas[3]}");
        Console.WriteLine("\n");
    }
    private bool captarResposta(){
        Console.WriteLine("Qual a alternativa correta?\n");
        string resp = Console.ReadLine().ToUpper().ToString();
        if(resp == "A" || resp == "B" || resp == "C" || resp == "D")
        {
            switch(resp) {
                case "A":
                    alternativaRespondida = 0;
                    break;
                case "B":
                    alternativaRespondida = 1;
                    break;
                case "C":
                    alternativaRespondida = 2;
                    break;
                case "D":
                    alternativaRespondida = 3;
                    break;
            }
            return true;
        }
        limparConsole();
        Console.WriteLine("**************** Opção invalida ****************");
        return false;
    }
    public bool isRespostaCorreta(string resp){
        return respostaCerta == resp;
    }
    private string[] perpararOrdemRespostas(){
        Random rnd = new Random();
        string[] alternativas = {alternativaA, alternativaB, alternativaC, alternativaD};
        for (int i = 0; i < 4; i++)
        {
            string temp = alternativas[i];
            int j = rnd.Next(i, 4);
            alternativas[i] = alternativas[j];
            alternativas[j] = temp;
        }
        return alternativas;
    }
    public static void limparConsole(){
        try
        {
            Console.Clear();
        }
        catch (System.IO.IOException)
        {
        
        }
    }
    private void firulas(){
        limparConsole();
        Random random = new Random();
        Console.Write("Carregando pergunta");
        for (int i =0; i <random.Next(1,10); i++){
            Thread.Sleep(random.Next(100,300));
            Console.Write(".");
        }
        Thread.Sleep(random.Next(300,600));
        limparConsole();
    }
    #endregion
    #region Variaveis
    private string pergunta = "";
    private string alternativaA = "";
    private string alternativaB = "";
    private string alternativaC = "";
    private string alternativaD = "";
    private string respostaCerta = "";
    string[] alternativas;
    int alternativaRespondida;
    #endregion
}