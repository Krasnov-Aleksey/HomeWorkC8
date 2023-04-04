void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10); // [0, 9]
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

void MultiplicationMatrix(int[,] matrix1,int[,]matrix2,int[,]multiplicationMatrix)//произведение матриц
{
    for(int i=0; i<matrix1.GetLength(0);i++)
    {
        for(int j=0;j<matrix1.GetLength(0);j++)
        {
            for (int k=0;k<matrix1.GetLength(0);k++)
            {
                multiplicationMatrix[i,j]=multiplicationMatrix[i,j]+matrix1[i,k]*matrix2[k,j];    
            }
        }
    }
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[size, size];
InputMatrix(matrix1);
Console.WriteLine("Матрица 1");
PrintMatrix(matrix1);
int[,] matrix2 = new int[size, size];
InputMatrix(matrix2);
Console.WriteLine("Матрица 2");
PrintMatrix(matrix2);
int[,] multiplicationMatrix =new int[size,size];
Console.WriteLine("Произведение матриц");
MultiplicationMatrix(matrix1,matrix2,multiplicationMatrix);
PrintMatrix(multiplicationMatrix);

