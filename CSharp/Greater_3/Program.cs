int num1, num2, num3;
Console.WriteLine("Enter First number");
num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Second number");
num2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Third number");
num3 = Convert.ToInt16(Console.ReadLine());
if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("First number is Greater");
    }
    else
    {
        Console.WriteLine("Third Number is greater");

    }
}
else if (num2 > num3)
{
    Console.WriteLine("Second Number is greater");
}

else
{
    Console.WriteLine("Third number is greater");
}