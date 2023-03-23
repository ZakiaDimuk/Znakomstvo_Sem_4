//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//(числа берете любые)


int[] FillMass(int size)
{
int[] Result = new int[size];
for(int i=0; i<size; i++)
{
    Result[i]=new Random().Next(1000);
}
return Result;
}

System.Console.WriteLine("Введите размерность массива: ");
int A = int.Parse(System.Console.ReadLine()!);
int[] massive = FillMass(A);

Console.WriteLine($"[{String.Join("; ",massive)}]");