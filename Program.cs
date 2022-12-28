Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count <= n; count++)
{
    Console.WriteLine(Math.Pow(count, 3));
}