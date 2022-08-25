// В двумерном массиве заменить элементы, 
// у которых оба индекса чётные на их квадраты

void PrintArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j <matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j =0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    } 
}

void ChengArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j =0; j < matr.GetLength(1); j++)
        {
            if (matr [i,j]%2 == 0) 
           matr [i,j]= matr [i,j]*matr [i,j];
        }
    }    
} 
int[,]matrix = new int [3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
ChengArray(matrix);
PrintArray(matrix);

