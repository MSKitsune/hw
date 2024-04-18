//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.class Program
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или символ 'q' для выхода:");
            string input = Console.ReadLine();

            if (input == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (int.TryParse(input, out int number))
            {
                if (IsEvenDigitSum(number))
                {
                    Console.WriteLine("Сумма цифр числа четная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Неверный формат числа. Повторите ввод.");
            }
        }
    }

    static bool IsEvenDigitSum(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum % 2 == 0;
    }
}


//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

﻿using System;

partial class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] array = new int[10];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100, 1000);
        }

        Console.WriteLine("Сгенерированный массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int count = CountEvenNumbers(array);
        Console.WriteLine($"Количество четных чисел в массиве: {count}");
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num % 2 == 0) 
            {
                count++;
            }
        }
        return count;
    }
}


//Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, 
//второй – предпоследним и т.д.)

﻿using System;
class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        ReverseArray(array);

        Console.WriteLine("\nПеревернутый массив:");
        PrintArray(array);
    }

    static void ReverseArray(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;

            left++;
            right--;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}