using AdoDotNet;

var connection = "Server=.\\SQLEXPRESS;Database=TestDB;User Id=test;Password=12345; Trust Server Certificate = True ";
AdoNetUtility adoNetUtility = new AdoNetUtility(connection);

/*
var deleteCommand = "DELETE FROM Students WHERE id = 9";
adoNetUtility.ExecuteSql(deleteCommand);
*/

/*
var name = "Raton";
var cgpa = 3.88;
var isgraduated = true;
var dob = new DateTime(2000, 5, 12);

Dictionary<string, object> parameter = new Dictionary<string, object>
{
    { "name", name },
    { "cgpa", cgpa },
    { "isgraduated", isgraduated },
    { "dob", dob }
};
var insertCommand = "INSERT INTO (name, cgpa, isgraduated, dateofbirth) VALUES(@name, @cgpa, @isgraduated, @dob)";
adoNetUtility.ExecuteSql(insertCommand, parameter);
*/

var selectCommand = "SELECT * FROM Students";
var data = adoNetUtility.ReadData(selectCommand);

foreach(var columnName in data.columnNames)
{
    Console.Write(columnName.PadLeft(22));
}
Console.WriteLine();

foreach(var row in data.values)
{
    foreach(var item in row)
    {
        Console.Write(item.ToString().PadLeft(22));
    }
    Console.WriteLine();
}


