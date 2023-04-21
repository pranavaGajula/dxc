int n1, n2;
char op;
Console.WriteLine("Enter n1");
n1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter n2");
n2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("enter op");
op = Convert.ToChar(Console.ReadLine());
switch (op)
{
    case '+':
        {
            Console.WriteLine(n1 + n2);
            break;
        }
    case '-' :
        {
            Console.WriteLine(n1 - n2);
            break;
        }
    case '*' :
        {
            Console.WriteLine(n1 * n2);
            break;
        }
    case '/' :
        {
            Console.WriteLine(n1 / n2);
            break;
        }

    default:
        {
            Console.WriteLine("choose only one operator 1 to 4");
            break;
        }
}


