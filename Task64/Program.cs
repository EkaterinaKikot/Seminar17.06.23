string printNumbers(int a, int b)
{
    if (a == b)
    return $"{b}";
    return $",{b}" + printNumbers(a, b - 1);
}

Console.Clear();
Console.Write("Введите 1 число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumbers(m, n));
