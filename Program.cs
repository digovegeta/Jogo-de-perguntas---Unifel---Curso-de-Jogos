using System.Text.Json.Serialization.Metadata;

namespace Jogos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual jogo deseja sogar?");
        Console.WriteLine("1 - Jogo da Velha");
        Console.WriteLine("2 - Jogo de Perguntas");
        int op = 0;
        string opcao = Console.ReadLine();
        if(int.TryParse(opcao, out op))
            op = int.Parse(opcao);
        
        switch(op) {
            case 1:
                new JogoDaVelha();
                break;
            case 2:
                new JogoDePerguntas();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}