Console.WriteLine("Введите количество строк, которые необходимо вывести на экран: ");

int row= Convert.ToInt32(Console.ReadLine());
int [,] triangle= new int [row,row];
const int cellWidth=3;

void FillTriangle(){
    for(int i=0 ; i<row; i++){
        triangle[i,0]=1;
        triangle[i,i]=1;
    }
    
    for(int i=2; i<row; i++){
        for(int j=1 ; j<=i; j++){
            triangle [i,j]= triangle[i-1,j-1]+triangle[i-1,j];
        }
    }

}


void Magic(){
    int col=cellWidth*row;
    for(int i=0; i<row; i++){
        for(int j=0; j<=i; j++){
            Console.SetCursorPosition(col, i+1);
            if(triangle[i,j]!=0){
                Console.Write($"{triangle[i,j],cellWidth}");
            }
            col+=cellWidth*2;
        }
        col=cellWidth*row-cellWidth*(i+1);
        Console.WriteLine();
    }
}

Console.ReadLine();
FillTriangle();
Console.ReadLine();
Magic();