// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int sum = 0;
ShowNumsBetween(2, 8);
Console.Write($"\n Сумма элементов в диапазоне {sum} ");
Console.WriteLine();

void ShowNumsBetween(int min, int max)
{
    sum = min;
    if (min == max)
    {
        Console.Write(min);
        return;
    }
    if (min > max)
    {
        Console.Write($"{min} ");
        ShowNumsBetween(min - 1, max);
    }
    else
    {
        Console.Write($"{max} ");
        ShowNumsBetween(min, max - 1);
    }
    sum = sum + max;
    
}


