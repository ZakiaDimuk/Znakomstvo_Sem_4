//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, 
//так как задача стоит в том, чтобы написать цикл)
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В: ");
int B = int.Parse(Console.ReadLine()!);
if (GetNature(B))
{
Console.WriteLine($"A в степени B = {GetNumber(A, B)}");
}

int GetNumber(int num1, int num2)
{
    int number = 1;
    for (int i = 0; i < num2; i++)
    {
        number *= num1;
    }
return number;
}

bool GetNature(int num2)
{
    if (num2 < 0)
    {
        System.Console.WriteLine("Число должно быть >= 0");
        return false;
    } 
return true;
}