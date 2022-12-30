// Задача 68

int Rec(int m, int n)
{
if(m == 0)
    return n+1;
    if (n == 0 && m>0)
    return Rec(m-1,1);
        else
        return Rec(m-1, Rec(m, n-1));
}

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Rec(m,n);
Console.WriteLine($"Аккерман ({m},{n}) = {Rec(m, n)}");
