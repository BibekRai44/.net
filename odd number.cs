//Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.

Console.WriteLine("the odd numbers from 1 to 99 is :");
for (int i=1; i <= 100; i++)
{
    if (i%2 != 0)
    {
        Console.WriteLine(i);
    }
    
}
Console.ReadLine();