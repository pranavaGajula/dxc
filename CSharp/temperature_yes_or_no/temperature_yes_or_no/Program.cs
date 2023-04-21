double f;
int c;
char ch;
do
{
    Console.WriteLine("Enter the temperature in Degree Celsius:");
    c = Convert.ToInt16(Console.ReadLine());
    f = (c * 1.8) + 32;
    Console.WriteLine($"Temperature(Celsius)= {c}   Temperature(Fahrenheit) = {f}");
    Console.WriteLine("Do you wish to continue(y/n)?");
    ch = Convert.ToChar(Console.ReadLine());
} while (ch == 'y');


