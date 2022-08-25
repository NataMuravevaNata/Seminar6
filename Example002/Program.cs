// Задать двумерный массив следующим правилом: Aₘₙ = m+n
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
            matr[i,j] = (i+j);
        }
    } 
}

int[,]matrix = new int [5,5];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

