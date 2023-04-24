int[] arr = {7,7,7,7,8,8,8,5,5,5,5,6,6,6,6};
int temp_count, freq_num = 0;

for(int i = 0; i <arr.Length; i++)
{
   
    temp_count = 0;
    for(int j = i+1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            temp_count++;
        }
    }
    if (temp_count > freq_num)
    {
        freq_num = temp_count;
       
    }
}
Console.WriteLine($"Most frequently occuring number is {freq_num}");
for (int i = 0; i < arr.Length; i++)
{
    int count = 0;

    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            count++;
        }
    }

    if (count == freq_num && arr[i] != int.MinValue)
    {
        Console.Write($"{arr[i]} ");
        arr[i] = int.MinValue;
    }
}


