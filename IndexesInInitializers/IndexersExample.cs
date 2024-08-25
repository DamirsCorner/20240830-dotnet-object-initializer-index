namespace IndexesInInitializers;

public class IndexersExample
{
    public string? name;
    public double Size { get; set; }

    private readonly char[] letters = new char[4];
    public char this[int i]
    {
        get { return letters[i]; }
        set { letters[i] = value; }
    }

    public int Length => letters.Length;
}
