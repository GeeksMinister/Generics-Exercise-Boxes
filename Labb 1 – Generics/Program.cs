ICollection<Låda> lådaCollection = new LådaCollection();

lådaCollection.Add(new Låda(10, 10, 10));
lådaCollection.Add(new Låda(20, 20, 20));
lådaCollection.Add(new Låda(30, 30, 30));
lådaCollection.Add(new Låda(40, 40, 40));
lådaCollection.Add(new Låda(50, 50, 50));

WriteLine($"\n\n\t [{lådaCollection.Count}] stored boxes in the collection");
// Adding an exact box again 
lådaCollection.Add(new Låda(10, 10, 10));

// Removing a box
//lådaCollection.Remove(new Låda(50, 50, 50)); ;
// Checking if a box exists in the collection
CheckIFContains(lådaCollection, new Låda(50, 50, 50));
//Printing out the stored boxes
Display(lådaCollection);

ReadLine();




static void Display(ICollection<Låda> collection)
{
    int i = 0;
    IEnumerator enumerator = collection.GetEnumerator();
    while (enumerator.MoveNext())
    {
        i++;
        Låda låda = (Låda)enumerator.Current;
        WriteLine($"\n\n   [{i}]   [ {låda.Längd}x{låda.Bredd}x{låda.Höjd} ]");
    }
}

static void CheckIFContains(ICollection<Låda> collection, Låda låda)
{
    LådaCollection? list = collection as LådaCollection;
    if (list.Contains(new LådaSameVol()  , låda))
    {
        WriteLine($"\n  A box with the following diamensions was found in" +
               $" the collection:  [ {låda.Längd}x{låda.Bredd}x{låda.Höjd} ]");
    }
    else
    {
        WriteLine("\n  There's no stored box with the diamensions:" +
            $" [ {låda.Längd}x{låda.Bredd}x{låda.Höjd} ]");
    }
}
