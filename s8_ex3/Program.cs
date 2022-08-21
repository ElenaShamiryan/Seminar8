Console.WriteLine("Введите количество строк в матрицах ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрицах ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];
int[,] array2 = new int[m,n];
int[,] array3 = new int[m,n];

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

void NewArray(int[,] matr3)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            matr3[i, j] = array[i, j] * array2[i, j];
            Console.Write($"{matr3[i, j]} ");
        }
        Console.WriteLine();

    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();
NewArray(array3);