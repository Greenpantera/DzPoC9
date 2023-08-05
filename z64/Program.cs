//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
string NumberRec (int num)
{
    if(1<num) return$"{num}" + "," + NumberRec(num-1);
    else return 1.ToString();
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int n = GetInfo("Введите число N: ");
Console.WriteLine($"N = {n} ->  {NumberRec (n)}");