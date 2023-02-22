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

int FindSmallestRowSum(int [,] matrix){
    int sum=0;
    int minSum=0;

    for(int k=0; k<matrix.GetLength(1); k++)
    {
        minSum+=matrix[0,k];
    }

    int minIdx=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++){
             sum+=matrix[i,j];
             int x=j+1;
             if(x==matrix.GetLength(1)){ 
                if(sum<minSum){
                    minSum=sum;
                    minIdx=i;                       
                }
             }
        }
        sum=0;    
    }
    return minIdx;
}

Console.Clear();
Console.WriteLine("Введите размер прямоугольного двумерного массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

while(size[0]==size[1])
{
Console.WriteLine("Ширина не должна равняться длине! Введите размер прямоугольного двумерного массива: ");
size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
}

int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindSmallestRowSum(matrix)+1}");