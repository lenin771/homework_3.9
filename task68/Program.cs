// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.WriteLine("Функция Аккермана работает при n <= 3 и m <=11");

int AckermannFunc(int n, int m) 
{
    if (n == 0)
        return m + 1;
    if (m == 0)
        return AckermannFunc(n - 1, 1);
    return AckermannFunc(n - 1, AckermannFunc(n, m - 1));
}

Console.WriteLine(AckermannFunc(3, 11));
