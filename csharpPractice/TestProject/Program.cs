using System.Reflection;
using TestProject;
using System.Text;
using System.Collections;

/*
bool IsObjectType(Type fieldType)
{
    return fieldType.IsClass && fieldType != typeof(string) && fieldType != typeof(DateTime);
}
StringBuilder MakeJson(object obj, StringBuilder jsonObject)
{
    Type objectType = obj.GetType();
    FieldInfo[] fields = objectType.GetFields();

    for(int i = 0; i < fields.Length; i++)
    {
        // if field is a list
        if (fields[i].FieldType.Name.StartsWith("List"))
        {
            jsonObject.Append(String.Concat("\"", fields[i].Name, "\" : ["));
            IList listValues = (IList)fields[i].GetValue(obj);

            // If values of the list are object of user-defined class
            if (IsObjectType(fields[i].FieldType.GetGenericArguments()[0]))
            {
                for(int j = 0; j < listValues?.Count; j++)
                {
                    var returnString = MakeJson(listValues[j], new StringBuilder("{"));
                    jsonObject.Append(returnString);
                    if(j != listValues.Count - 1) jsonObject.Append(", ");
                }
            }
            // If values of the list are primitive type
            else
            {
                for (int j = 0; j < listValues?.Count; j++)
                {
                    jsonObject.Append(listValues[j]);
                    if (j != listValues.Count - 1) jsonObject.Append(", ");
                }
            }
            jsonObject.Append("] ");
        }
        // if field is an array
        else if (fields[i].FieldType.Name.EndsWith("[]"))
        {
            jsonObject.Append(String.Concat("\"", fields[i].Name, "\" : ["));
            var arrayItems = fields[i].GetValue(obj) as IList;
            for(int j = 0; j < arrayItems?.Count; j++)
            {
                jsonObject.Append(arrayItems[j]);
                if(j != arrayItems.Count - 1) jsonObject.Append(", ");
            }
            jsonObject.Append("] ");
        }
        // if field is a object of user-defined class
        else if ((IsObjectType(fields[i].FieldType)))
        {
            jsonObject.Append(String.Concat("\"", fields[i].Name, "\" : "));
            var returnString = MakeJson(fields[i].GetValue(obj) as object, new StringBuilder("{"));
            jsonObject.Append(returnString);
        }
        else
        {
            if (fields[i].FieldType.Name == "String" || fields[i].FieldType.Name == "DateTime" || fields[i].FieldType.Name == "Boolean" || fields[i].FieldType.Name == "Char")
            {
                jsonObject.Append(String.Concat("\"", fields[i].Name, "\" : \"", fields[i].GetValue(obj), "\""));
            }
            else
            {
                jsonObject.Append(String.Concat("\"", fields[i].Name, "\" : ", fields[i].GetValue(obj)));
            }
        }

        if(i != fields.Length - 1) jsonObject.Append(", ");

    }
    jsonObject.Append("}");

    return jsonObject;
}




Student student = new Student();

Console.WriteLine(MakeJson(student, new StringBuilder("{ ")));
*/

Assembly assembly = Assembly.GetExecutingAssembly();
Type type = assembly.GetType("TestProject.Student");

//Type type = Type.GetType("TestProject.Student");
object instance = Activator.CreateInstance(type);

//MethodInfo method = type.GetMethod("Method", new Type[] {});
//method.Invoke(instance, new object[] { });

PropertyInfo propertyInfo = type.GetProperty("Name");
propertyInfo.SetValue(instance, "Shuva Dev");
Console.WriteLine(propertyInfo.GetValue(instance));

