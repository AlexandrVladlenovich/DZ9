Console.Clear();

Console.WriteLine("Введите число m (должно быть > 0): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n (n должно быть больше m):");
int n = int.Parse(Console.ReadLine());
int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.WriteLine("Результат:");
Console.WriteLine(Sum(m, n));