
using System.Reflection;

Console.WriteLine("Please choose a car type:");

Assembly currentProject = Assembly.GetExecutingAssembly();
Type[] dataTypes = currentProject.GetTypes();

int count = 0;
foreach (Type type in dataTypes)
{
    Type[] interfaceTypes = type.GetInterfaces();

    foreach (Type interfaceType in interfaceTypes)
    {
        if (interfaceType.Name == "ICar")
        {
            Console.WriteLine($"{++count}) {type.Name}");
        }
    }
}

string userChoice = Console.ReadLine();

foreach (var type in dataTypes)
{
    if (type.Name == userChoice)
    {
        ConstructorInfo constructor = type.GetConstructor(new Type[] { });
        object instance = constructor.Invoke(new object[] { });

        MethodInfo startMethod = type.GetMethod("Start");
        MethodInfo stopMethod = type.GetMethod("Stop");

        startMethod.Invoke(instance, new object[] { });
        stopMethod.Invoke(instance, new object[] { });
    }
}

List<int> list = new List<int>();
Type listDataType = list.GetType();
MethodInfo[] listMethods = listDataType.GetMethods();
foreach (MethodInfo method in listMethods)
    Console.WriteLine(method.Name);


/* 
//Type type = Type.GetType("TestProject.Student");

 Assembly assembly = Assembly.GetExecutingAssembly();
Type type = assembly.GetType("TestProject.Student");

object instance = Activator.CreateInstance(type);

MethodInfo method = type.GetMethod("Method", new Type[] {});
method.Invoke(instance, new object[] { });


PropertyInfo propertyInfo = type.GetProperty("Name");
propertyInfo.SetValue(instance, "Shuva Dev");
Console.WriteLine(propertyInfo.GetValue(instance));
 */

