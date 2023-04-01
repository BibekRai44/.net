//Write a C# program to check if an array contains an odd number.

int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
bool containsOdd = false;
foreach (int n in num)
{
    if (n % 2 != 0)
    {
        containsOdd = true;
        break;
    }
}
if (containsOdd)
{
    Console.WriteLine("This array contains odd numbers");
}
else
{
    Console.WriteLine("This array does not contain odd numbers");
}
Console.ReadLine();