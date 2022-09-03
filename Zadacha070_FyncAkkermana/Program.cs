Console.Clear();
Console.WriteLine("Введите число m (должно быть > 0): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n (n должно быть больше m):");
int n = int.Parse(Console.ReadLine());
int Ack(int m, int n)
{
if (m == 0)
    {
    return n + 1;
    }
        else if (n == 0)
        {
        return Ack(m - 1, 1);
        }
            else
            {
            return Ack(m - 1, Ack(m, n - 1));
            }
}
Console.WriteLine("Результат:");
Console.WriteLine(Ack(m, n));