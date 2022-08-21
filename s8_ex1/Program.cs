Console.WriteLine("Введите количество строк в матрице");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

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

void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int t = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = t;
                }
            }
        }
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
NewArray(array);
PrintArray(array);