using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

int i;
Console.WriteLine("enter a number");
i = Convert.ToInt16(Console.ReadLine());
if (i>9999 && i<100000)
{
   int Sum = 0;
    while (i != 0)
    {
        Sum += i % 10;
        i = i / 10;
    }
    Console.WriteLine($"sum of digits {Sum}");
}
else
{
    Console.WriteLine("Enter 5 digit number only");
}