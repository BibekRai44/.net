Console.WriteLine("Enter your age ");
int a=Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 10:
        Console.WriteLine("your age is 10");
        break;

    case 20:
        Console.WriteLine("your age is 20");
        break;

    case 30:
        Console.WriteLine("your age is 30");
        break;

    default:
        Console.WriteLine("your age is more than 30");
        break;
}
        
Console.ReadLine();