
// task1
void PrintFromOneToN(int current, int n)
{
    if (current > n)
        return;

    if (current > 1)
        Console.Write(" ");

    Console.Write(current);
    PrintFromOneToN(current + 1, n);
}

// task2
void PrintFromNToOne(int n)
{
    if (n < 1)
        return;

    Console.Write(n);

    if (n > 1)
        Console.Write(" ");

    PrintFromNToOne(n - 1);
}

// task3
int SumToN(int n)
{
    if (n <= 1)
        return n;

    return n + SumToN(n - 1);
}

// task4
void PrintDigits(int n)
{
    if (n < 10)
    {
        Console.Write(n + " ");
        return;
    }

    PrintDigits(n / 10);
    Console.Write(n % 10 + " ");
}

// task5
int CountDigits(int n)
{
    if (n < 10)
        return 1;

    return 1 + CountDigits(n / 10);
}

// task6
void PrintEven(int current, int end)
{
    if (current > end)
        return;

    if (current % 2 == 0)
        Console.Write(current + " ");

    PrintEven(current + 1, end);
}

void PrintOdd(int current, int end)
{
    if (current > end)
        return;

    if (current % 2 != 0)
        Console.Write(current + " ");

    PrintOdd(current + 1, end);
}
