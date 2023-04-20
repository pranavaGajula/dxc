int stuId, StuAge, Marks1, Marks2, Marks3, Total;
double Percentage;
string StuName;
Console.WriteLine("Enter studentID");
stuId = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter student Name");
StuName = Convert.ToString(Console.ReadLine());
Console.WriteLine("Enter studentAge");
StuAge = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Marks1");
Marks1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Marks2");
Marks2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Marks3");
Marks3 = Convert.ToInt16(Console.ReadLine());
StuName = Console.ReadLine();
Total = Marks1 + Marks2 + Marks3;
Percentage = (Total / 3);
Console.WriteLine("Your Total Score is: " + Total);
Console.WriteLine("Your Average is: " + Percentage);

if (Percentage >= 50)
{
    if (Percentage >= 90)
    {
        Console.WriteLine("Your Grade is A");
    }
    else if (Percentage >= 80 && Percentage < 89)
    {
        Console.WriteLine("Your Grade is B");

    }
    else if (Percentage >= 60 && Percentage < 79)
    {
        Console.WriteLine("Your Grade is C");
    }
    else if (Percentage >= 50 && Percentage < 59)
    {
        Console.WriteLine("Your Grade is D");
    }
    Console.WriteLine("your result for the exam is Pass");
}
else
{
    Console.WriteLine("Your Grade is E");
    Console.WriteLine("your result for the exam is Fail");

}
