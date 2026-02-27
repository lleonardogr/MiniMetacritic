public class Movie : Title
{
    public int Duration { get; set; }

    public Movie(string name) : base(name) { }

    public override string ToString()
    {
        return base.ToString() + $", Duration: {Duration}";
    }
}