void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 9);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void PowMatrix(int[] sortMatrix, int[,] matrix, int pow) // cтрока матрицы => массив
{
    for (int i = 0; i < sortMatrix.Length; i++)
    {
        sortMatrix[i] = matrix[pow, i];
    }
}

void SortMatrix(int[] sortMatrix, int[,] matrix) //сортировка массива по убыванию
{
    int temp = 0;
    for (int i = 0; i < sortMatrix.Length; i++)
    {
        for (int j = 0; j < sortMatrix.Length; j++)
        {
            if (sortMatrix[i] > sortMatrix[j])
            {
                temp = sortMatrix[i];
                sortMatrix[i] = sortMatrix[j];
                sortMatrix[j] = temp;
            }
        }
    }
}

void NewMatrix(int[] sortMatrix, int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        PowMatrix(sortMatrix, matrix, i);
        SortMatrix(sortMatrix, matrix);
        for (int j = 0; j < sortMatrix.Length; j++)
        {
            matrix[i, j] = sortMatrix[j];
        }


    }

}

Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] sortMatrix = new int[size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
Console.WriteLine("Новый массив:");
NewMatrix(sortMatrix, matrix);
PrintMatrix(matrix);

