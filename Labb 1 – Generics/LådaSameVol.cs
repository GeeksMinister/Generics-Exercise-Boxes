using System.Diagnostics.CodeAnalysis;

public class LådaSameVol : EqualityComparer<Låda>
{
    public override bool Equals(Låda? x, Låda? y)
    {
        if ((x.Längd * x.Bredd * x.Höjd) ==
            (y.Höjd * y.Längd * y.Bredd))
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