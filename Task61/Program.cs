void InputPaskal(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[i, 0] = 1;
        matrix[i, i] = 1;
    }

    for (int i = 2; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(0); j++)
        {
            matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
        }

    }
}

void PrintPaskal(int[,] matrix)
{
    int pos = matrix.GetLength(0);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(pos, i + 1);
            if (matrix[i, j] != 0)
            {
                Console.Write($"{matrix[i, j]}");
            }
            pos = pos + 2;
        }
        pos = matrix.GetLength(0) - (i + 1);
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите первые N строк треугольника Паскаля: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];
InputPaskal(matrix);
PrintPaskal(matrix);

