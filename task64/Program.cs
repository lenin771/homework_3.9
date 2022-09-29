// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void ShowAllNums(int num)
{
    if (num < 1)
    {
        Console.WriteLine();
        return;
    }
    Console.Write($"{num} ");
    ShowAllNums(num - 1);
}

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
ShowAllNums(num);