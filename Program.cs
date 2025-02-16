using System.Text.Json.Serialization.Metadata;

namespace Jogos;

class Program
{
    static void Main(string[] args)
    {
        JogoDePerguntas j = new JogoDePerguntas();
        j.play();
        
    }
}