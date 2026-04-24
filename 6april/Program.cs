// using System.Linq;
// using System;
// using System.Diagnostics.Metrics;

// task1
// int max = int.MinValue;
// int number1 = Convert.ToInt32(Console.ReadLine());
// while (true)
// {
//  number1 = Convert.ToInt32(Console.ReadLine());
//     if (number1 == 0)
//     {
//         break;
//     }
//     if (number1 > max)
//     {
//         max = number1;
//     }
// }
// System.Console.WriteLine(max);

// task2
// double number =double.Parse(Console.ReadLine());
// double sum = 0;
// int number2 = int.Parse(Console.ReadLine());
//     for(int j=0;j<=number2;j++)
//     {
//         sum+=Math.Pow(number,j);
//     }
// System.Console.WriteLine(sum);

// task3
// int number3;
// int counter=0;
// int sum=0;
// while (true)
// {
//     number3=int.Parse(Console.ReadLine());
//     if (number3 > 0)
//     {
//         sum+=number3;

//     }
//     if (number3 == 0)
//     {
//         counter+=1;
//         sum+=number3;
//     }
//     else
//     {
//         counter=0;

//     }
//     if (counter == 2)
//     {
//         break;
//         }
// }
// System.Console.WriteLine(sum);

// task4
// int number4 = int.Parse(Console.ReadLine());
// int[] array = new int[number4];
// int counter = 0;
// for (int i = 0; i < number4; i++)
// {
//     array[i] = int.Parse(Console.ReadLine());


// }
// for(int i = 0; i <number4-1; i++)
// {
//         if ((array[i] > 0 && array[i + 1] > 0) || (array[i] < 0 && array[i + 1] < 0))
//         {
//             counter ++;
//         }
// }
// if (counter >0)
// {
//     Console.WriteLine("YES");
// }
// else
// {
//     Console.WriteLine("NO");
// }

// task5

// int number5 = int.Parse(Console.ReadLine());
// int[] array2 = new int[number5];
// for (int i = 0; i < number5; i++)
// {
//     array2[i] = int.Parse(Console.ReadLine());
// }
// for (int i = 0; i < number5; i++)
// {
//     for (int j = i + 1; j < number5; j++)
//     {
//         if (array2[i] == array2[j])
//         {
//             Console.Write(array2[i]+" ");
//         }
//     }

// }

// task6
// int number6 = int.Parse(Console.ReadLine());
// int[] array3 = new int[number6];
// for (int i = 0; i < number6; i++)
// {
//     array3[i] = int.Parse(Console.ReadLine());
// }
// int min =int.MaxValue;
// for(int i = 0; i < number6; i++)
// {
//     if(array3[i]<min)
//     {
//         min=array3[i];
//     }
// }
// Console.WriteLine("min: "+min);

// task7
// int number7;
// int sum7 = 0;
// int counter7 = 0;
// while (true)
// {
//     Console.WriteLine("Given number: ");
//     number7 = int.Parse(Console.ReadLine());
//     if (number7 != 0)
//     {
//         sum7 += number7;
//         counter7++;
//     }
//     else
//     {
//         break;
//     }
// }
// Console.WriteLine("Sum of numbers: " + sum7);
// Console.WriteLine("Count of numbers: " + counter7);

// task8
// int number8 = Convert.ToInt32(Console.ReadLine());
// int sum8 = 0;
// int devider = 1;
// for(int i = number8; i > 0; i /= 10)
// {
//     int sec = i % 10;
//     sum8+=sec;
//     devider*=sec;
// }
// Console.WriteLine("Sum of digits: "+sum8);
// Console.WriteLine("Devide of digits: "+devider);

// task9
// Console.WriteLine("Given number: ");
// int number9 = Convert.ToInt32(Console.ReadLine());
// int rev=0;
// for(int i = number9; i > 0; i /= 10)
// {
//     int sec=i%10;
//     rev=rev*10+sec;
// }
// Console.WriteLine("Reversed number: "+rev);

// task10
// int number10 = Convert.ToInt32(Console.ReadLine());
// int[] array10 = new int[number10];
// for (int i = 0; i < number10; i++)
// {
//     array10[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < number10; i++)
// {
//     int counter10 = 0;

//     for (int j = 1; j <=array10[i]; j++)
//     {
//         if (array10[i] % j == 0)
//         {
//             counter10++;
//         }
//     }
//     if (counter10 != 2)
//     {
//         Console.Write(array10[i] + " ");
//     }
// }