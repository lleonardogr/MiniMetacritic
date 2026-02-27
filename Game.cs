using System.Reflection.Metadata.Ecma335;

public class Game : Title
{
    public string? Plataform { get; set; }

    public Game(string name) : base(name) { }

    public Game(string name, string plataform) : base(name)
    {
        if (string.IsNullOrEmpty(plataform))
            throw new Exception("A plataforma do jogo é obrigatória");


        Plataform = plataform;
    }

    public override string ToString()
    {
        return base.ToString() + $", Plataform: {Plataform}";
    }
}