Console.Clear();

Console.WriteLine("Введите (от 0 до 9) число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите (от 0 до 9) число n (n должно быть больше m):");
int n = int.Parse(Console.ReadLine());
void PrintNumber(int m, int n)
{
    if (n < m) return;
    PrintNumber(m, n - 1);
    Console.Write(n + " ");
}
Console.WriteLine("Результат: ");
PrintNumber(m, n);