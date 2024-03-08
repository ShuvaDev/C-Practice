int? x = null;

if (!x.HasValue)
{
    x = int.Parse(Console.ReadLine());
}

// int y = x; it is not valid 
int y = x.Value;

int z = x ?? 5; // if x is null then z will be assigned with 5 otherwise x

x ??= 5;

// if x is null then p assigned with null otherwise it covert the value of x into string and assigned in p 
string? p = x?.ToString();