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

int SumElement(int[,] matrix,int numLine) //  Сумма элементов
{
    int sum=0;
    for(int i=0; i<matrix.GetLength(1); i++)
    {
        sum=sum+matrix[numLine,i];
    }
    return sum;
}

int MinSumElement(int[,] matrix) //минимальная строка суммы элементов
{
    int sum=0;
    int min=SumElement(matrix,0);
    int index=0;
    for(int i=1;i<matrix.GetLength(0);i++)
    {
        sum=SumElement(matrix,i);
        if(min>sum)
        {
            min=sum;
            index=i;
        }
    }
    return index+1;
}

Console.Clear();
Console.Write("Задайте прямоугольный двумерный массив: ");
int size=Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, size];
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);
int minLine;
minLine=MinSumElement(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов {minLine}");
