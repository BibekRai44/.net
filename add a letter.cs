string str;
Console.WriteLine("Enter first string:");
str=Console.ReadLine();
if (str.Length >= 1)
{
    var s = str.Substring(0, 1);
    Console.WriteLine(s + str + s);
}
Console.ReadLine();