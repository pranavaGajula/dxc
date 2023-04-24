using System;
using System.Globalization;

int shot, person,gap;
Console.WriteLine("Enter No. of Robbers");
person = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter The Robber with whom Sam will start shooting:");
shot = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the gap between the robbers:");
gap = Convert.ToInt16(Console.ReadLine());
for (int i =1; i<= person; i++)
{ int j=shot;
    do
    {
        Console.WriteLine($"Target = {j}, {i} shots completed");
        j = gap + 1;
    } while (j <= person);
    Console.Write("");
}