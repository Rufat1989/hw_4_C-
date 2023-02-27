Console.Clear();

int Factorial(int n)
{
    int sum = 0;
       while(n > 0)
    {
        sum = sum + n % 10;
        n = n / 10;
        
    }
    return sum; 
    
}

Console.WriteLine ("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"{n} --> {Factorial(n)}");

