// task1
// int FindMid(int a, int b, int c)
// {
//     int max = a;
//     int min = a;
//     if (b > max)
//     {
//         max = b;
//     }
//     if (c > max)
//     {
//         max = c;
//     }
//     if (b < min)
//     {
//         min = b;
//     }
//     if (c < min)
//     {
//         min = c;
//     }
//     return a + b + c - max - min;
// }
// string[] numbers = (Console.ReadLine() ?? "").Split();
// int a = Convert.ToInt32(numbers[0]);
// int b = Convert.ToInt32(numbers[1]);
// int c = Convert.ToInt32(numbers[2]);
// Console.WriteLine(FindMid(a, b, c));

// task2
// string[] numbers = (Console.ReadLine() ?? "").Split();
// int a = Convert.ToInt32(numbers[0]);
// int b = Convert.ToInt32(numbers[1]);
// if ((a > 0 && b > 0) || (a < 0 && b < 0))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }

// task3
// int MiddleDigit(int n)
// {
//     int count = 0;
//     int copy = n;
//     while (copy > 0)
//     {
//         count++;
//         copy = copy / 10;
//     }
//     for (int i = 0; i < count / 2; i++)
//     {
//         n = n / 10;
//     }
//     return n % 10;
// }
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(MiddleDigit(number));

// task4
// bool IsPalindrome(string word, int first, int last)
// {
//     if (first >= last)
//     {
//         return true;
//     }
//     if (word[first] != word[last])
//     {
//         return false;
//     }
//     return IsPalindrome(word, first + 1, last - 1);
// }
// string word = Console.ReadLine() ?? "";
// if (IsPalindrome(word, 0, word.Length - 1))
// {
//     Console.WriteLine("The string is Palindrome.");
// }
// else
// {
//     Console.WriteLine("The string is not Palindrome.");
// }

// task5
// int SumDigits(int n)
// {
//     if (n < 10)
//     {
//         return n;
//     }
//     return n % 10 + SumDigits(n / 10);
// }
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumDigits(number));

// task6
// string ReverseString(string text)
// {
//     if (text == "")
//     {
//         return "";
//     }
//     return ReverseString(text.Substring(1)) + text[0];
// }
// string text = Console.ReadLine() ?? "";
// Console.WriteLine(ReverseString(text));

// task7
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

// task8
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
// Console.WriteLine("The Fibonacci series of " + n + " terms is :");
// for (int i = 0; i < n; i++)
// {
//     Console.Write(fib(i) + " ");
// }
