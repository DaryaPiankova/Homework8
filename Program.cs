void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}


Console.Clear();
Console.WriteLine("Введите размер первой матрицы: ");
int[] size1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];
Console.WriteLine("Введите размер второй матрицы: ");
int[] size2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];

while (size1[1] != size2[0])
{
    Console.WriteLine("Неверно! Кол-во столбцов первой матрицы должно равняться кол-ву строк второй! Введите размер первой матрицы: ");
    size1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
    matrix1 = new int[size1[0], size1[1]];
    Console.WriteLine("Введите размер второй матрицы: ");
    size2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
    matrix2 = new int[size2[0], size2[1]];
}

InputMatrix(matrix1);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix1);
InputMatrix(matrix2);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrix2);


int[,] resultMatrix = new int[size1[0], size2[1]];
resultMatrix = MultiplyMatrix(matrix1, matrix2);
Console.WriteLine("Произведение двух матриц: ");
PrintMatrix(resultMatrix);