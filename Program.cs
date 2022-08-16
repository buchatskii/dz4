// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
// Console.Write("Введите A: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Введите B: ");
// int number2 = int.Parse(Console.ReadLine());

// int num = Convert.ToInt32(Math.Pow(number1, number2));
// Console.WriteLine(num);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Num(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма введенных цифр = {Num(num)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// Console.Write("Введите число: ");
// int elementMassiv = int.Parse(Console.ReadLine());
// int[] myArray = new int [elementMassiv];

// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.Write($"Введите эллемент массива под индексом {i}:\t ");
//     myArray[i] = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("Вывод массива: ");

// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.WriteLine(myArray[i]);
// }
// Console.WriteLine();