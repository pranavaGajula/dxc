int[] arr = new int[10];
int Count = 0;
Console.WriteLine("Enter array numbers");
for (int i = 0; i < arr.Length; i++)
{
    
    arr[i] = Convert.ToInt16(Console.ReadLine());
}
Console.WriteLine("Duplicate elements are");
for (int j = 0; j < 10; j++)
{
    for(int k=j+1; k < 10; k++)
    {
        if (arr[j] == arr[k])
        {


            Count++;
            break;

        }   

    }
}
Console.WriteLine(Count);