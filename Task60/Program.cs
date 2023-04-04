void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
int[,,] matrix = new int[2,2,2];
InputMatrix(matrix);
Console.WriteLine("Новый массив");
PrintMatrix(matrix);

