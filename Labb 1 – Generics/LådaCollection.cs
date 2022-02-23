public class LådaCollection : ICollection<Låda>
{
    private List<Låda> _lådaList;
    public int Count => _lådaList.Count;
    public bool IsReadOnly => false;
    //Making the collection object represent a list by setting up an indexer:
    public Låda this[int i]
    {
        set => _lådaList[i] = value;
        get => _lådaList[i];
    }

    public LådaCollection()
    {
        _lådaList = new List<Låda>();
    }
    public IEnumerator<Låda> GetEnumerator() => new LådaEnumerator(this);
    IEnumerator IEnumerable.GetEnumerator() => new LådaEnumerator(this);
    public void Clear() => _lådaList = new List<Låda>();

    public void Add(Låda item)
    {
        if (Contains(item))
        {
            WriteLine($"\n   A box with the following diamensions is already in" +
                $" the collection  [ {item.Längd}x{item.Bredd}x{item.Höjd} ]");
        }
        else
        {
            _lådaList.Add(item);
        }
    }
    public bool Contains(Låda item)
    {
        bool found = false;
        foreach (Låda låda in _lådaList)
        {
            if (låda.Equals(item))
            {
                found = true;
            }
        }
        return found;
    }

    public bool Contains(EqualityComparer<Låda> compare, Låda item)
    {
        bool found = false;
        foreach (Låda låda in _lådaList)
        {
            if (compare.Equals(låda, item))
            {
                found = true;
            }
        }
        return found;
    }

    public bool Remove(Låda item)
    {
        bool result = false;
        for (int i = 0; i < _lådaList.Count; i++)
        {
            Låda låda = _lådaList[i];
            if (new LådaSameDimensions().Equals(låda, item))
            {
                _lådaList.RemoveAt(i);
                result = true;
                break;
            }
        }
        return result;
    }

    public void CopyTo(Låda[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }
}