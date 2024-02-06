// Decimal to binary conversion
int a = 10;
Console.WriteLine(Convert.ToString(a, toBase : 2));

// Formatting a number
Console.WriteLine(a.ToString("00.000"));

Console.WriteLine(String.Format("{0:00.000}", a));

// Compare function
string str = "shuva";
Console.WriteLine(str.CompareTo("thuva")); // -1

Console.WriteLine(String.Compare(str, "phuva")); // 1 // Here true represents ignorecase

// Compare Ordinals
string s1 = "Abc", s2 = "abc";

Console.WriteLine(String.CompareOrdinal(s1, s2));// -32 // returns ascii value difference

// Concat String
Console.WriteLine(String.Concat(s1, s2)); // abccbd

// IsNullOrEmpty function
Console.WriteLine(String.IsNullOrEmpty(s1)); // False
s1 = "";
Console.WriteLine(String.IsNullOrEmpty(s1)); // True

// Contains function
Console.WriteLine(s1.Contains("bc")); // True

// EndsWith function
Console.WriteLine(s1.EndsWith("bc")); // True

// IndexOf function
s1 = "abcdbe";
Console.WriteLine(s1.IndexOf('b')); // 1
Console.WriteLine(s1.IndexOf('B')); // -1

// LastIndexOf function
Console.WriteLine(s1.LastIndexOf('b')); // 4

// IndexOfAny function
Console.WriteLine(s1.IndexOfAny(['d', 'g'])); // 3
Console.WriteLine(s1.IndexOfAny(['b', 'd'])); // 1
Console.WriteLine(s1.IndexOfAny(['g', 'c'])); // 2

// Insert function
s1 = "shuva";
Console.WriteLine(s1.Insert(5, " ").Insert(6, "dev")); // shuva dev

// PadLeft function
Console.WriteLine(s1.PadLeft(7)); // "  shuva"

// Remove function
Console.WriteLine(s1.Remove(1, 2)); // sva

// Replace function
Console.WriteLine(s1.Replace('s', 'S')); // Shuva

// ReplaceLineEndings function
s1 = "sh\n";
Console.WriteLine(s1.ReplaceLineEndings("uva")); // shuva

// Split function
s1 = "s h u v a";
string[] arr = s1.Split(' ');
Console.WriteLine(arr[1]); // h

// Substring function
s1 = "abshuvadev";
Console.WriteLine(s1.Substring(2, 5)); // shuva

// ToCharArray function
char[] arr1;
arr1 = s1.ToCharArray();
Console.WriteLine(arr1[0]); // a

// ToUpper function
Console.WriteLine(s1.ToUpper()); // "ABSHUVADEV"

// Trim function
s1 = "   shuva   ";
Console.WriteLine(s1.Trim()); // "shuva"

// TrimStart function
Console.WriteLine(s1.TrimStart()); // "shuva    "


//I have been practicing all of the math