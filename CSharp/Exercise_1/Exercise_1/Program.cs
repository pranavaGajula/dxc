int[] arr_1 = { 7, 4, 5, 6, 8, 2, 1 };
int max = arr_1[0];
for (int i = 0; i < arr_1.Length; i++)
{
    if (arr_1[i] > max)
    {
        max = arr_1[i];
    }
}
Console.WriteLine($"Largest number in array is: {max}");
