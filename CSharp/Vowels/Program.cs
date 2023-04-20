char ch;
Console.WriteLine("enter a character");
ch = Convert.ToChar(Console.ReadLine());
if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
{
    Console.WriteLine("Character is Vowel");
}
else
{
    Console.WriteLine("Character is not Vowel");
}
