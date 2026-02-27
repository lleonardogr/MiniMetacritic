public abstract class Title
{
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int MetaScore { get; set; }
    public int UserScore { get; set; }

    public Title(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception(
                "O nome do jogo precisa ser obrigatório");

        Name = name;
    }

    public Title(string name, DateTime releaseDate,
        int metaScore, int userScore)
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception(
                "O nome do jogo precisa ser obrigatório");

        if (metaScore < 0 || metaScore > 100)
            throw new Exception(
                "A nota dos criticos deve ser entre 0 e 100");
        if (userScore < 0 || userScore > 100)
            throw new Exception(
                "A nota do publico deve ser entre 0 e 100");

        Name = name;
        ReleaseDate = releaseDate;
        MetaScore = metaScore;
        UserScore = userScore;
    }


    public override string? ToString()
    {
        return $"{this.GetType()} - Name: {Name}, ReleaseDate: {ReleaseDate}, MetaScore: {MetaScore}, UserScore: {UserScore}";
    }
}