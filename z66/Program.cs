// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumRec (int numM, int numN)
// {
//     if(numM==numN) return numM;
//     else return numM+SumRec(numM-1, numN);
// }
int SumRec (int numM, int numN)
{
    if(numM<numN) return numM+SumRec(numM+1, numN);
    else return numM;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int m = GetInfo("Введите меньшее число. M: ");
int n = GetInfo("Введите большее число. N: ");

Console.WriteLine($"M = {m}, N = {n} ->  {SumRec (m,n)}");