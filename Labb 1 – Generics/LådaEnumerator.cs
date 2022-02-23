public class LådaEnumerator : IEnumerator<Låda>
{
    private int _curIndex;
    private LådaCollection _lådaCollection;
    private Låda _curlåda;
    public LådaEnumerator(LådaCollection lådaCollection)
    {
        _curlåda = default(Låda);
        _curIndex = -1;
        _lådaCollection = lådaCollection;
    }
    public Låda Current => _curlåda;

    object IEnumerator.Current => _curlåda;

    public bool MoveNext()
    {
        if (++_curIndex >= _lådaCollection.Count)
        {
            return false;
        }
        else
        {
            _curlåda = _lådaCollection[_curIndex];
            return true;
        }
    }
    public void Reset() => _curIndex = -1;

    public void Dispose() { /* Nothing to do here */  }
 
    
}