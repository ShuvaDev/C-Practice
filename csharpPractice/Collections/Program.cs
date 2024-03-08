using System.Collections;

List<string> names = new List<string>();
names.Add("Shuva");
names.Add("Mehadi");
names.Add("Sakib");
names.Sort();
names.RemoveAt(0);
names.Insert(0, "Raton");

foreach (var name in names)
{
    Console.WriteLine(name);
}

Dictionary<string, int> ages = new Dictionary<string, int>();
ages.Add("Shuva", 24);
// ages.Add("Shuva", 28);
ages["Mehadi"] = 23;
ages["Mehadi"] = 25;

foreach(var age in ages)
{
    Console.WriteLine(age.Value);
}

Console.WriteLine(ages.ContainsValue(24)); // True
Console.WriteLine(ages["Mehadi"]); // 25

HashSet<int> set = new HashSet<int>();
set.Add(10);
set.Add(20);
set.Add(10);
set.Add(30);
set.Remove(30);
Console.WriteLine(set.Count);

Stack<int> st =  new Stack<int>();
st.Push(1);
st.Push(2);
st.Pop();

Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Dequeue();

LinkedList<int> list = new LinkedList<int>();
list.AddFirst(10);


// Non Generic Collection
ArrayList arrayList = new ArrayList();
arrayList.Add(10);
arrayList.Add("Shuva");
Console.WriteLine(arrayList[1]);

Hashtable hashtable = new Hashtable();
hashtable["shuva"] = 29;
hashtable["shuva"] = 30;
Console.WriteLine(hashtable["shuva"]);

Stack stack = new Stack();
stack.Push(10);