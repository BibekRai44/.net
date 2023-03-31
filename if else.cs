//Write a C# program to get the absolute value of the difference between two given numbers.
//Return double the absolute value of the difference if the first number is greater than second number.

Console.WriteLine("Enter first number :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("The double of absolute value of the difference is:" + (2 * (a - b)));
}
else
{
    Console.WriteLine("Nothing");
}
Console.ReadLine();