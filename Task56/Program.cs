void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10);
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

Console.Clear();
Console.Write("Задайте прямоугольный двумерный массив: ");
//int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int size=Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);
Console.WriteLine("Конечный массив");
PrintMatrix(matrix);


