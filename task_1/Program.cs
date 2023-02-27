Console.Clear();
Console.WriteLine("Введите число 1: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int y = int.Parse(Console.ReadLine());

int stepen(int x)
{
    int count = 1;
    for(int i =0; i < y; i++)
    count *= x;
    return count;
}
Console.WriteLine(stepen(x));