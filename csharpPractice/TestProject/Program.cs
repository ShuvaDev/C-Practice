using System.Reflection;

Assembly currentProject = Assembly.GetExecutingAssembly();

Type[] dataTypes = currentProject.GetTypes();

int count = 1;

foreach (Type type in dataTypes)
{
    Type[] interfaceTypes = type.GetInterfaces();
    
    foreach(Type interfaceType in interfaceTypes)
    {
        if (interfaceType.Name == "ICar")
        {
            Console.WriteLine($"{count++}. {type.Name}");
        }
    }
}

Console.Write("Enter your choice : ");
string userChoice = Console.ReadLine();

foreach(Type type in dataTypes)
{
    if (type.Name == userChoice)
    {
        ConstructorInfo constructorInfo = type.GetConstructor(new Type[] { });
        object instance = constructorInfo.Invoke(new object[] { });

        MethodInfo startMethod = type.GetMethod("Start");
        MethodInfo stopMethod = type.GetMethod("Stop");

        startMethod.Invoke(instance, new object[] { });
        stopMethod.Invoke(instance, new object[] { });
        
    }
}