using System.Diagnostics.CodeAnalysis;

int[] arr = new int[10];
Console.WriteLine("Enter array numbers");
for (int i = 0; i < arr.Length; i++)
{

    arr[i] = Convert.ToInt16(Console.ReadLine());
}

double sum = 0;
double avg;
for(int j=0; j < arr.Length; j++)
{
    sum =sum+ arr[j];
}
Console.WriteLine($"sum:{sum}");
avg = sum / arr.Length;
Console.WriteLine($"avg:{avg}");
