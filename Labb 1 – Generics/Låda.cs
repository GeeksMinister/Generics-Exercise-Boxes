public class Låda : IEquatable<Låda>
{
    public Låda(int h, int l, int b)
    {
        Höjd = h;
        Längd = l;
        Bredd = b;
    }
    public int Höjd { get; set; }
    public int Längd { get; set; }
    public int Bredd { get; set; }

    public bool Equals(Låda other)
    {
        if (new LådaSameDimensions().Equals(this, other))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
