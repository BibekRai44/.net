//Write a C# program to check if a given number present in an array of numbers.

Console.WriteLine("Enter a number:");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
bool containsarr = false;
foreach (int num in a)
{
    if (num==n)
    {
        containsarr= true;
        break;
    }
}
if (containsarr)
{
   Console.WriteLine("this number belongs in array");
}
else
{
   Console.WriteLine("this number does not belong in array");
}
Console.ReadLine();