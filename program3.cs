//Write a C# program to print an array sum.

int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int sum = 0;
foreach (int n in num)
{
    sum += n;
}
Console.WriteLine("sum is " + sum);
Console.ReadLine();