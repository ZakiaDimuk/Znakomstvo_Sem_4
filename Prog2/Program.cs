//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine($"Сумма чисел = {GetSumma(A)}");

int GetSumma(int number)
{
    int summa = 0;
    while (number>0)
    {
        summa += number % 10;
        number = number/10;
    }
    return summa;
}