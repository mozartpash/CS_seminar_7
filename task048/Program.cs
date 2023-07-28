// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int rows = GetNum("Введите колличество строк: ");
int columns = GetNum("Введите колличество столбцов: ");

int[,] matrix = GetArray(rows,columns);
PrintArray(matrix);


int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,]  GetArray(int row, int colomn)
{
    int[,] res = new int[row,colomn];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            res[i,j]= i+j;
        }
    }
    return res;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}");
        }
        Console.WriteLine();
    }
}