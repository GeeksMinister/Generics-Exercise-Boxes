using System.Diagnostics.CodeAnalysis;

public class LådaSameDimensions : EqualityComparer<Låda>
{
    public override bool Equals(Låda? x, Låda? y)
    {
        if (x.Längd == y.Längd && x.Bredd == y.Bredd && x.Höjd == y.Höjd)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode([DisallowNull] Låda obj)
    {
        var hashCode = obj.Bredd ^ obj.Höjd ^ obj.Längd;
        return hashCode.GetHashCode();
    }
}
