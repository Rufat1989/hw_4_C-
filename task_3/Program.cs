int[] array = result(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}


int[] result(int n)
{
    int[] res = new int [n];
    for(int i = 0; i < n; i++)
    {
        res[i] = new Random(). Next(0, 100);
    }
    return res;
}