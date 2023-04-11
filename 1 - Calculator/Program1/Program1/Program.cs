// See https://aka.ms/new-console-template for more information
while (true)
{
    int num1, num2;
    char ch;
    Console.Write("Please enter a number : ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Please enter a number : ");
    ch = Console.ReadLine()[0];
    Console.WriteLine();
    Console.Write("Please enter a number : ");
    num2 = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (ch == '+')
    {
        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
    }
    else if (ch == '-')
    {
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
    }
    else if (ch == '*' || ch == 'x')
    {
        Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
    }
    else if (ch == '/')
    {
        if (num2 == 0)
        {
            Console.WriteLine("Couldn't Divided By Zero!");
        }
        else
        {
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        }
    }
    else if (ch == '%')
    {
        if (num2 < 2)
        {
            Console.WriteLine("Please enter a bigger number!");
        }
        else
        {
            Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid process!");
    }
}