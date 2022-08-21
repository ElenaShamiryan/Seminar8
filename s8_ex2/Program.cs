//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк в матрице ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
    
int FindMinSum(int[,] matr)
{
    int row = 1;
    int minSum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        minSum = minSum + array[0, j];
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        if (minSum > sum )
        {
            minSum = sum;
            row = row+1;
      
        }
    }
    return row;
}

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
int result =FindMinSum(array);
Console.WriteLine ($"Миминальная сумма находится в строке № {result}");
