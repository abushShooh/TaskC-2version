

// task1
// int EvenCount(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         int last = n % 10;
//         if (last % 2 == 0 && last != 0)
//         {
//             count++;
//         }
//         n = n / 10;
//     }
//     return count;
// }
// int OddCount(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         int last = n % 10;
//         if (last % 2 != 0)
//         {
//             count++;
//         }
//         n = n / 10;
//     }
//     return count;
// }
// int ZeroCount(int n)
// {
//     int count = 0;
//     if (n == 0)
//     {
//         return 1;
//     }
//     while (n > 0)
//     {
//         int last = n % 10;
//         if (last == 0)
//         {
//             count++;
//         }
//         n = n / 10;
//     }
//     return count;
// }
// int DigitCount(int n)
// {
//     int count = 0;
//     if (n == 0)
//     {
//         return 1;
//     }
//     while (n > 0)
//     {
//         count++;
//         n = n / 10;
//     }
//     return count;
// }
// int MinDigit(int n)
// {
//     int min = 9;
//     if (n == 0)
//     {
//         return 0;
//     }
//     while (n > 0)
//     {
//         int last = n % 10;
//         if (last < min)
//         {
//             min = last;
//         }
//         n = n / 10;
//     }
//     return min;
// }
// int MaxDigit(int n)
// {
//     int max = 0;
//     if (n == 0)
//     {
//         return 0;
//     }
//     while (n > 0)
//     {
//         int last = n % 10;
//         if (last > max)
//         {
//             max = last;
//         }
//         n = n / 10;
//     }
//     return max;
// }
// int SumDigit(int n)
// {
//     int sum = 0;
//     while (n > 0)
//     {
//         sum += n % 10;
//         n = n / 10;
//     }
//     return sum;
// }
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Even : " + EvenCount(number));
// Console.WriteLine("Odd : " + OddCount(number));
// Console.WriteLine("Zeros : " + ZeroCount(number));
// Console.WriteLine("Digits : " + DigitCount(number));
// Console.WriteLine("Min : " + MinDigit(number));
// Console.WriteLine("Max : " + MaxDigit(number));
// Console.WriteLine("Sum of Digits: " + SumDigit(number));

// task2
// char CheckGrade(int grade)
// {
//     if (grade >= 90 && grade <= 100)
//     {
//         return 'A';
//     }
//     else if (grade >= 80 && grade <= 89)
//     {
//         return 'B';
//     }
//     else if (grade >= 70 && grade <= 79)
//     {
//         return 'C';
//     }
//     else if (grade >= 60 && grade <= 69)
//     {
//         return 'D';
//     }
//     else
//     {
//         return 'F';
//     }
// }
// int grade = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CheckGrade(grade));

// task3
// int n = Convert.ToInt32(Console.ReadLine());
// string[] numbers = Console.ReadLine().Split();
// int[] arr = new int[n];
// int negative = 0;
// int positive = 0;
// int zeros = 0;
// int even = 0;
// int odd = 0;
// int sum = 0;
// int max = Convert.ToInt32(numbers[0]);
// int min = Convert.ToInt32(numbers[0]);
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(numbers[i]);
//     if (arr[i] < 0)
//     {
//         negative++;
//     }
//     else if (arr[i] > 0)
//     {
//         positive++;
//     }
//     else
//     {
//         zeros++;
//     }
//     if (arr[i] % 2 == 0 && arr[i] != 0)
//     {
//         even++;
//     }
//     else if (arr[i] % 2 != 0)
//     {
//         odd++;
//     }
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }
//     sum += arr[i];
// }
// Console.WriteLine("Negative = " + negative);
// Console.WriteLine("Positive = " + positive);
// Console.WriteLine("Zeros = " + zeros);
// Console.WriteLine("Even = " + even);
// Console.WriteLine("Odd = " + odd);
// Console.WriteLine("Max = " + max);
// Console.WriteLine("Min = " + min);
// Console.WriteLine("Sum of Digits = " + sum);

// task4
// int n = Convert.ToInt32(Console.ReadLine());
// string[] numbers = Console.ReadLine().Split();
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(numbers[i]);
// }
// for (int i = 0; i < n; i += 2)
// {
//     Console.Write(arr[i] + " ");
// }

// task5
// int n = Convert.ToInt32(Console.ReadLine());
// string[] numbers = Console.ReadLine().Split();
// int[] arr = new int[n];
// int count = 0;
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(numbers[i]);
// }
// for (int i = 1; i < n; i++)
// {
//     if (arr[i] > arr[i - 1])
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);

// task6
// int n = Convert.ToInt32(Console.ReadLine());
// string[] numbers = Console.ReadLine().Split();
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(numbers[i]);
// }
// for (int i = 0; i < n; i++)
// {
//     for (int j = i + 1; j < n; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             Console.Write(arr[i] + " ");
//         }
//     }
// }

// task7
// int from = Convert.ToInt32(Console.ReadLine());
// int to = Convert.ToInt32(Console.ReadLine());
// for (int i = from; i <= to; i++)
// {
//     Console.WriteLine("-------------------------------");
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine(i + "x" + j + "= " + i * j);
//     }
// }
// Console.WriteLine("-------------------------------");

// task8
// double Sum(double a, double b)
// {
//     return a + b;
// }
// double Subtract(double a, double b)
// {
//     return a - b;
// }
// double Multiplication(double a, double b)
// {
//     return a * b;
// }
// double Division(double a, double b)
// {
//     return a / b;
// }
// double number1 = Convert.ToDouble(Console.ReadLine());
// string operation = Console.ReadLine();
// double number2 = Convert.ToDouble(Console.ReadLine());
// if (operation == "+")
// {
//     Console.WriteLine(number1 + " + " + number2 + " = " + Sum(number1, number2));
// }
// else if (operation == "-")
// {
//     Console.WriteLine(number1 + " - " + number2 + " = " + Subtract(number1, number2));
// }
// else if (operation == "*")
// {
//     Console.WriteLine(number1 + " * " + number2 + " = " + Multiplication(number1, number2));
// }
// else if (operation == "/")
// {
//     Console.WriteLine(number1 + " / " + number2 + " = " + Division(number1, number2));
// }

// task9
// int Power(int number, int degree)
// {
//     if (degree == 0)
//     {
//         return 1;
//     }
//     return number * Power(number, degree - 1);
// }
// int number = Convert.ToInt32(Console.ReadLine());
// int degree = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("The value of " + number + " to the power of " + degree + " is : " + Power(number, degree));

// task10
// int fib(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }
//     if (n == 1)
//     {
//         return 1;
//     }
//     return fib(n - 1) + fib(n - 2);
// }
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("The Fibonacci series of " + n + " terms is : ");
// for (int i = 0; i < n; i++)
// {
//     Console.Write(fib(i) + " ");
// }
