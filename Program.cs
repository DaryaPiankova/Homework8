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


void SortedRowMatrix(int [,] matrix){
    
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k=0;k<matrix.GetLength(1)-1 ; k++)
            {
                for(int m=0; m<matrix.GetLength(1)-1; m++)
                {
                    if(matrix[i, m]<matrix[i, m+1])
                    {
                        int temp= matrix[i,m];
                        matrix[i, m]=matrix[i, m+1];
                        matrix[i, m+1]=temp;
                    }
                }
            }
        }
    }

}

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
SortedRowMatrix(matrix);
Console.WriteLine("Упорядоченный массив: ");
PrintMatrix(matrix);