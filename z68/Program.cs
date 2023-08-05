// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetAkkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return GetAkkerman(m-1, 1);
else return GetAkkerman(m-1, GetAkkerman(m, n-1));
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int m = GetInfo("Введите число. M: ");
int n = GetInfo("Введите число. N: ");

Console.WriteLine($"M = {m}, N = {n} -> A(m,n) = {GetAkkerman(m,n)}");