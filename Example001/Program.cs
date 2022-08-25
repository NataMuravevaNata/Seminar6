// Показать двумерный массив размером m×n заполненный вещественными числами

void PrintArray (double [,] matr)
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

void FillArray (double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j =0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().NextDouble();
        }
    } 
}
int m = 5;
int n = 6;
double[,]matrix = new double [m,n];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
