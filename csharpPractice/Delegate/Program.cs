using Delegate;


Console.WriteLine(x(10, 20));
/*
// Annonymous function
var x = (int x, int y) => x + y;
Console.WriteLine(x(2, 3));

void Print(string name) => Console.WriteLine($"Hello {name}");
Action<string> print = Print;
print("Shuva");


int Add(int a, int b) => a + b;
Func<int, int, int> print = Add;
Console.WriteLine(print(2, 3));
*/

/*
 * আমরা সর্ট ফাংশনটি এমন ভাবে ইম্পিলেমেন্ট করেছি যেটা যেকোন টাইপের এলিমেন্ট কে সর্ট করতে পারবে।
 * তবে কিসের উপর ভিত্তি করে সর্ট করবে তা explicitly পাস করতে হবে।
 */

// sort int array
bool CompareFunction(int x, int y)
{
    if (x > y) return true;
    return false;
}

int[] arr = [1, 5, 2, 8, 3];
BubbleSort<int> bubbleSort = new BubbleSort<int>();
bubbleSort.Sort(arr, CompareFunction);
//foreach(var item in arr) Console.WriteLine(item);

// sort people object
People p1 = new() { Name = "Shuva", Age = 23 };
People p2 = new() { Name = "Shanto", Age = 13 };
People p3 = new() { Name = "Ruma", Age = 45 };

People[] peoples = [p1, p2, p3];

bool CompareFunction2(People p1, People p2)
{
    if(p1.Age > p2.Age) return true;
    return false;
}

BubbleSort<People> bubbleSort1 = new BubbleSort<People>();
bubbleSort1.Sort(peoples, CompareFunction2);
foreach(People p in peoples)
{
    Console.WriteLine($"Name : {p.Name}  Age : {p.Age}");
}