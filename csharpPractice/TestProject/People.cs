// CustomList.cs
using System.Collections;
public class CustomList : IEnumerable
{
    ArrayList list = new ArrayList();
    public void Add(object item)
    {
        list.Add(item);
    }
    public IEnumerator GetEnumerator()
    {
        return list.GetEnumerator();
    }
}